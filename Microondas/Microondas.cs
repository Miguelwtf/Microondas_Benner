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
using Microondas.DataAccess;
using Microondas.Utils;
using Microondas.Util;
using System.Security.Cryptography;

namespace Microondas
{
    public partial class Microondas : Form
    {
        private int tempoInt = 0;

        private string input = "";
        private string progresso = "";
        
        private int totalTempoSegundos;
        private int indPotencia = 0;
        
        private bool isOperando = false;
        private bool preenchAutomatico = false;
        private bool isPausado = false;
        
        private const int defaultPotencia = 10;
        private const string defaultVisor = "00:00";
        private const string defaultSimbolo = ".";

        private UpdateVisor updateVisor = new UpdateVisor(); 
        private TimeConverter timeConverter = new TimeConverter(); 
        
        public Microondas()
        {
            InitializeComponent();
            timer.Interval = 1000;
            LoadData();
            txtVisor.Text = defaultVisor;
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
                    int tempoInt = receita.Tempo;

                    int rowIndex = dataGrid.Rows.Add(receita.Id, receita.Nome, receita.Alimento, formattedTime, receita.Potencia, receita.Simbolo, receita.Padrao, receita.Instrucoes, receita.Tempo);

                    DataGridViewRow row = dataGrid.Rows[rowIndex];

                    if (!receita.Padrao)
                    {
                        row.DefaultCellStyle.Font = new Font(dataGrid.Font, FontStyle.Italic);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                TimeSpan time = TimeSpan.FromSeconds(totalTempoSegundos);
                txtVisor.Text = time.ToString(@"mm\:ss"); 

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

                var carregaProgresso = new CarregaProgresso(potencia, simbolo);
                txtProgresso.Text = carregaProgresso.GerarProgresso(txtProgresso.Text);
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
            if (isPausado)
            {
                timer.Start();
                isPausado = false;
            }
            else
            {
                if (dataGrid.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGrid.SelectedRows[0];
                    var potenciaCellValue = selectedRow.Cells["Potencia"].Value?.ToString();
                    int tempo = tempoInt;
                    int selectedId = Convert.ToInt32(dataGrid.SelectedRows[0].Cells["Id"].Value);
                    bool isPadrao = Convert.ToBoolean(dataGrid.SelectedRows[0].Cells["Padrao"].Value);

                    if (tempo < 0)
                    {
                        int novoTempoEmSegundos = timeConverter.ConverteTempo(tempo);

                        if (int.TryParse(potenciaCellValue, out int potencia))
                        {
                            indPotencia = potencia;
                            txtPotencia.Text = indPotencia.ToString();
                        }
                    }

                    if (isOperando && !isPadrao)
                    {
                        totalTempoSegundos += 30;
                    }
                }
                else
                {
                    if (isOperando)
                    {
                        totalTempoSegundos += 30;
                    }
                    else
                    {
                        if (indPotencia == 0)
                        {
                            indPotencia = defaultPotencia;
                            txtPotencia.Text = indPotencia.ToString();
                        }

                        int novoTempoEmSegundos = timeConverter.ConverteTempo(totalTempoSegundos);
                        totalTempoSegundos = Math.Max(novoTempoEmSegundos, 30);
                    }
                }

                isPausado = false;
                isOperando = true;
                timer.Start();
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
                txtVisor.Text = defaultVisor;
                indPotencia = defaultPotencia;
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
            if (isOperando)
            {
                if (!isPausado)
                {
                    timer.Stop();
                    isPausado = true;
                }
                else 
                {
                    input = "";
                    totalTempoSegundos = 0;
                    txtVisor.Text = defaultVisor;
                    isOperando = false;
                    isPausado = false;
                    indPotencia = defaultPotencia;
                    txtPotencia.Text = indPotencia.ToString();
                    preenchAutomatico = false;
                    txtProgresso.Text = "";
                }
            }
            else
            {
                input = "";
                totalTempoSegundos = 0;
                txtVisor.Text = defaultVisor;
                indPotencia = defaultPotencia;
                txtPotencia.Text = indPotencia.ToString();
                isPausado = false;
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

                var textTempoCellValue = selectedRow.Cells["Tempo"].Value;

                if (int.TryParse(potenciaCellValue?.ToString(), out potencia))
                {
                    indPotencia = potencia;
                    txtPotencia.Text = potencia.ToString();
                }
                else
                {
                    indPotencia = defaultPotencia;
                    txtPotencia.Text = "Potência inválida";
                }

                string nomeColunaTempo = "TempoI"; 
                if (selectedRow.Cells[nomeColunaTempo] != null)
                {
                    totalTempoSegundos = Convert.ToInt32(selectedRow.Cells[nomeColunaTempo].Value);
                }

                txtVisor.Text = updateVisor.Atualiza(textTempoCellValue.ToString());
                preenchAutomatico = true;
            }
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (input.Length < 4 && !preenchAutomatico)
            {
                input += (sender as Button).Text;
                txtVisor.Text = updateVisor.Atualiza(input);
            }
        }

        private void buttonUm_Click(object sender, EventArgs e)
        {
            if (input.Length < 4 && !preenchAutomatico) 
            {
                input += (sender as Button).Text;
                txtVisor.Text = updateVisor.Atualiza(input);
            }
        }

        private void buttonDois_Click(object sender, EventArgs e)
        {
            if (input.Length < 4 && !preenchAutomatico)
            {
                input += (sender as Button).Text;
                txtVisor.Text = updateVisor.Atualiza(input);
            }
        }

        private void buttonTres_Click(object sender, EventArgs e)
        {
            if (input.Length < 4 && !preenchAutomatico)
            {
                input += (sender as Button).Text;
                txtVisor.Text = updateVisor.Atualiza(input);
            }
        }

        private void buttonQuatro_Click(object sender, EventArgs e)
        {
            if (input.Length < 4 && !preenchAutomatico)
            {
                input += (sender as Button).Text;
                txtVisor.Text = updateVisor.Atualiza(input);
            }
        }
        
        private void buttonCinco_Click(object sender, EventArgs e)
        {
            if (input.Length < 4 && !preenchAutomatico)
            {
                input += (sender as Button).Text;
                txtVisor.Text = updateVisor.Atualiza(input);
            }
        }

        private void buttonSeis_Click(object sender, EventArgs e)
        {
            if (input.Length < 4 && !preenchAutomatico)
            {
                input += (sender as Button).Text;
                txtVisor.Text = updateVisor.Atualiza(input);
            }
        }

        private void buttonSete_Click(object sender, EventArgs e)
        {
            if (input.Length < 4 && !preenchAutomatico)
            {
                input += (sender as Button).Text;
                txtVisor.Text = updateVisor.Atualiza(input);
            }
        }

        private void buttonOito_Click(object sender, EventArgs e)
        {
            if (input.Length < 4 && !preenchAutomatico)
            {
                input += (sender as Button).Text;
                txtVisor.Text = updateVisor.Atualiza(input);
            }
        }

        private void buttonNove_Click(object sender, EventArgs e)
        {
            if (input.Length < 4 && !preenchAutomatico)
            {
                input += (sender as Button).Text;
                txtVisor.Text = updateVisor.Atualiza(input);
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
