using Microondas.Model;
using Microondas.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microondas
{
    public partial class Microondas : Form
    {
        private string input = "";
        private string progresso = "";
        private int totalTempoSegundos;
        private int indPotencia = 0;
        private bool operando = false;
        private bool preenchAutomatico = false;
        private bool pausado = false;

        public Microondas()
        {
            InitializeComponent();
            timer.Interval = 1000;
            LoadData();
            txtVisor.Text = "00:00";
        }

        /* Carrega dados na dataGrid */
        private void LoadData()
        {
            try
            {
                var dbProgramas = new DBProgramas();
                var receitas = dbProgramas.GetAll();

                dataGrid.Rows.Clear();

                foreach (var receita in receitas)
                {
                    TimeSpan timeSpan = TimeSpan.FromSeconds(receita.Tempo);
                    string formattedTime = timeSpan.ToString(@"mm\:ss");

                    int rowIndex = dataGrid.Rows.Add(receita.Id, receita.Nome, receita.Alimento, formattedTime, receita.Potencia, receita.Simbolo, receita.Padrao, receita.Instrucoes);

                    DataGridViewRow row = dataGrid.Rows[rowIndex];

                    if (!receita.Padrao)
                    {
                        row.DefaultCellStyle.Font = new Font(dataGrid.Font, FontStyle.Italic);
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* Atualiza o Visor */
        private void UpdateVisor()
        {
            if (timer.Enabled)
            {
                int minutos = totalTempoSegundos / 60;
                int segundos = totalTempoSegundos % 60;
                txtVisor.Text = $"{minutos:D2}:{segundos:D2}";
            }
            else
            {
                if (input.Length > 0)
                {
                    string paddedInput = input.PadLeft(4, '0');

                    int minutos = int.Parse(paddedInput.Substring(0, 2));
                    int segundos = int.Parse(paddedInput.Substring(2, 2));
                    txtVisor.Text = $"{minutos:D2}:{segundos:D2}";
                }
                else
                {
                    txtVisor.Text = "00:00"; 
                }
            }
        }

        /* Timer */
        private void timer_Tick(object sender, EventArgs e)
        {
            string simbolo;
            int potencia;

            if (totalTempoSegundos > 0)
            {
                totalTempoSegundos--;
                UpdateVisor();

                if (dataGrid.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGrid.SelectedRows[0];
                    simbolo = selectedRow.Cells["Simbolo"].Value?.ToString() ?? ".";
                    potencia = int.Parse(selectedRow.Cells["Potencia"].Value.ToString());
                }
                else
                {
                    simbolo = ".";
                    potencia = indPotencia;
                }

                StringBuilder progresso = new StringBuilder(txtProgresso.Text);

                for (int j = 0; j < potencia; j++)
                {
                    progresso.Append(simbolo);
                }
                progresso.Append(" ");
                txtProgresso.Text = progresso.ToString();
            }
            else
            {
                timer.Stop();
                txtProgresso.Text = "Aquecimento concluído";
            }
        }

        /* Botão Liga */
        private void buttonLiga_Click(object sender, EventArgs e)
        {
            if (pausado)
            {
                timer.Start();
                pausado = false;
            }
            else
            {
                if (dataGrid.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGrid.SelectedRows[0];
                    var tempoCellValue = selectedRow.Cells["Tempo"].Value?.ToString();
                    var potenciaCellValue = selectedRow.Cells["Potencia"].Value?.ToString();
                    int selectedId = Convert.ToInt32(dataGrid.SelectedRows[0].Cells["Id"].Value);
                    bool isPadrao = Convert.ToBoolean(dataGrid.SelectedRows[0].Cells["Padrao"].Value);

                    if (tempoCellValue != null)
                    {
                        int minutos = int.Parse(tempoCellValue.Substring(0, 2));
                        int segundos = int.Parse(tempoCellValue.Substring(3, 2));
                        totalTempoSegundos = (minutos * 60) + segundos;

                        if (int.TryParse(potenciaCellValue, out int potencia))
                        {
                            indPotencia = potencia;
                            txtPotencia.Text = indPotencia.ToString();
                        }
                    }

                    if (operando && !isPadrao)
                    {
                        totalTempoSegundos += 30;
                    }
                }
                else
                {
                    string paddedInput = input.PadLeft(4, '0');
                    int minutos = int.Parse(paddedInput.Substring(0, 2));
                    int segundos = int.Parse(paddedInput.Substring(2, 2));
                    int novoTempoEmSegundos = (minutos * 60) + segundos;

                    if (operando)
                    {
                        totalTempoSegundos += 30;
                    }
                    else
                    {
                        if (indPotencia == 0)
                        {
                            indPotencia = 10;
                            txtPotencia.Text = indPotencia.ToString();
                        }

                        totalTempoSegundos = Math.Max(novoTempoEmSegundos, 30);
                    }
                }

                pausado = false;
                operando = true;
                timer.Start();
                UpdateVisor();
            }
        }

        private void dataGrid_MouseDown(object sender, MouseEventArgs e)
        {
            var hitTestInfo = dataGrid.HitTest(e.X, e.Y);

            if (hitTestInfo.Type != DataGridViewHitTestType.Cell)
            {
                dataGrid.ClearSelection();
                input = "";
                totalTempoSegundos = 0;
                txtVisor.Text = "00:00";
                indPotencia = 10;
                txtPotencia.Text = indPotencia.ToString();
                preenchAutomatico = false;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var MicroondasCadastro = new MicroondasCadastro();
            MicroondasCadastro.ShowDialog();
            LoadData();
        }

        /* Botão Para */
        private void buttonPara_Click(object sender, EventArgs e)
        {
            if (operando)
            {
                if (!pausado)
                {
                    timer.Stop();
                    pausado = true;
                }
                else 
                {
                    input = "";
                    totalTempoSegundos = 0;
                    txtVisor.Text = "00:00";
                    operando = false;
                    pausado = false;
                    indPotencia = 10;
                    txtPotencia.Text = indPotencia.ToString();
                    preenchAutomatico = false;
                    txtProgresso.Text = "";
                }
            }
            else
            {
                input = "";
                totalTempoSegundos = 0;
                txtVisor.Text = "00:00";
                indPotencia = 10;
                txtPotencia.Text = indPotencia.ToString();
                pausado = false;
                preenchAutomatico = false;
                txtProgresso.Text = "";
            }
        }

        private void dataGrid_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                var selectedRow = dataGrid.SelectedRows[0];
                var potenciaCellValue = selectedRow.Cells["Potencia"].Value;
                int potencia;

                if (int.TryParse(potenciaCellValue?.ToString(), out potencia))
                {
                    indPotencia = potencia;
                    txtPotencia.Text = potencia.ToString();
                }
                else
                {
                    indPotencia = 10;
                    txtPotencia.Text = "Potência inválida";
                }

                var tempoCellValue = selectedRow.Cells["Tempo"].Value?.ToString();

                txtVisor.Text = tempoCellValue ?? "Tempo inválido";

                preenchAutomatico = true;
            }
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (input.Length < 4 && !preenchAutomatico)
            {
                input += "0";
                UpdateVisor();
            }
        }

        private void buttonUm_Click(object sender, EventArgs e)
        {
            if (input.Length < 4 && !preenchAutomatico) 
            {
                input += "1"; 
                UpdateVisor(); 
            }
        }

        private void buttonDois_Click(object sender, EventArgs e)
        {
            if (input.Length < 4 && !preenchAutomatico)
            {
                input += "2";
                UpdateVisor();
            }
        }

        private void buttonTres_Click(object sender, EventArgs e)
        {
            if (input.Length < 4 && !preenchAutomatico)
            {
                input += "3";
                UpdateVisor();
            }
        }

        private void buttonQuatro_Click(object sender, EventArgs e)
        {
            if (input.Length < 4 && !preenchAutomatico)
            {
                input += "4";
                UpdateVisor();
            }
        }
        
        private void buttonCinco_Click(object sender, EventArgs e)
        {
            if (input.Length < 4 && !preenchAutomatico)
            {
                input += "5";
                UpdateVisor();
            }
        }

        private void buttonSeis_Click(object sender, EventArgs e)
        {
            if (input.Length < 4 && !preenchAutomatico)
            {
                input += "6";
                UpdateVisor();
            }
        }

        private void buttonSete_Click(object sender, EventArgs e)
        {
            if (input.Length < 4 && !preenchAutomatico)
            {
                input += "7";
                UpdateVisor();
            }
        }

        private void buttonOito_Click(object sender, EventArgs e)
        {
            if (input.Length < 4 && !preenchAutomatico)
            {
                input += "8";
                UpdateVisor();
            }
        }

        private void buttonNove_Click(object sender, EventArgs e)
        {
            if (input.Length < 4 && !preenchAutomatico)
            {
                input += "9";
                UpdateVisor();
            }
        }

        private void btnAumenta_Click(object sender, EventArgs e)
        {
            if (!preenchAutomatico)
            {
                if (indPotencia < 10)
                {
                    indPotencia++;
                    txtPotencia.Text = indPotencia.ToString();
                }
            }
        }

        private void btnDiminui_Click(object sender, EventArgs e)
        {
            if (!preenchAutomatico)
            { 
                if (indPotencia > 1)
                {
                    indPotencia--;
                    txtPotencia.Text = indPotencia.ToString();
                }
                else if (indPotencia == 0)
                {
                    indPotencia = 1;
                    txtPotencia.Text = indPotencia.ToString();
                }
            }
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGrid.SelectedRows[0].Cells["Id"].Value);

                bool isPadrao = Convert.ToBoolean(dataGrid.SelectedRows[0].Cells["Padrao"].Value);

                if (isPadrao)
                {
                    MessageBox.Show("Este item é um padrão e não pode ser excluído.", "Exclusão Não Permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                var result = MessageBox.Show("Tem certeza de que deseja excluir este item?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var dbProgramas = new DBProgramas();

                    bool isDeleted = dbProgramas.Delete(selectedId);

                    if (isDeleted)
                    {
                        dataGrid.Rows.RemoveAt(dataGrid.SelectedRows[0].Index);
                        MessageBox.Show("Item excluído com sucesso.", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir o item.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado para exclusão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Microondas_Load(object sender, EventArgs e)
        {

        }

        private void btnEdita_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGrid.SelectedRows[0].Cells["Id"].Value);

                bool isPadrao = Convert.ToBoolean(dataGrid.SelectedRows[0].Cells["Padrao"].Value);

                if (isPadrao)
                {
                    MessageBox.Show("Este item é um padrão e não pode ser editado.", "Exclusão Não Permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MicroondasCadastro MicroondasCadastro = new MicroondasCadastro(selectedId);
                    MicroondasCadastro.ShowDialog();
                }
                LoadData();
            }
        }
    }
}
