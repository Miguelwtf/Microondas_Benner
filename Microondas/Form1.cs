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
    public partial class Form1 : Form
    {
        private string input = "";
        private int totalTimeInSeconds;
        private int indPotencia = 0;
        private bool operando = false;

        public Form1()
        {
            InitializeComponent();
            timer2.Interval = 1000;
            LoadData();

            //txtPotencia.Text = indPotencia.ToString();
            txtVisor.Text = "00:00";
        }


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
                    string formattedTime = timeSpan.ToString(@"hh\:mm\:ss");

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
            if (timer2.Enabled)
            {
                int minutos = totalTimeInSeconds / 60;
                int segundos = totalTimeInSeconds % 60;

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


        /* Counter Tick */
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (totalTimeInSeconds > 0)
            {
                totalTimeInSeconds--;
                UpdateVisor();
            }
            else
            {
                timer2.Stop();
            }
        }

        /* Botão Liga */
        private void buttonLiga_Click(object sender, EventArgs e)
        {
            string paddedInput = input.PadLeft(4, '0');
            int minutos = int.Parse(paddedInput.Substring(0, 2));
            int segundos = int.Parse(paddedInput.Substring(2, 2));
            int novoTempoEmSegundos = (minutos * 60) + segundos;

            if (operando)
            {
                totalTimeInSeconds += 30;
            }
            else
            {
                if (indPotencia == 0)
                {
                    indPotencia = 10;
                    txtPotencia.Text = indPotencia.ToString();
                } 

                totalTimeInSeconds = Math.Max(novoTempoEmSegundos, 30);
                operando = true;
                timer2.Start();
            }

            UpdateVisor();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var formCadastro = new FormCadastro();
            formCadastro.ShowDialog();
            LoadData();
        }

        /* Botão Para */
        private void buttonPara_Click(object sender, EventArgs e)
        {
            input = ""; 
            totalTimeInSeconds = 0;
            timer2.Stop(); 
            txtVisor.Text = "00:00";
            operando = false;
        }
        
        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (input.Length < 4)
            {
                input += "0";
                UpdateVisor();
            }
        }

        private void buttonUm_Click(object sender, EventArgs e)
        {
            if (input.Length < 4) 
            {
                input += "1"; 
                UpdateVisor(); 
            }
        }

        private void buttonDois_Click(object sender, EventArgs e)
        {
            if (input.Length < 4)
            {
                input += "2";
                UpdateVisor();
            }
        }
        private void buttonTres_Click(object sender, EventArgs e)
        {
            if (input.Length < 4)
            {
                input += "3";
                UpdateVisor();
            }
        }
        private void buttonQuatro_Click(object sender, EventArgs e)
        {
            if (input.Length < 4)
            {
                input += "4";
                UpdateVisor();
            }
        }
        private void buttonCinco_Click(object sender, EventArgs e)
        {
            if (input.Length < 4)
            {
                input += "5";
                UpdateVisor();
            }
        }
        private void buttonSeis_Click(object sender, EventArgs e)
        {
            if (input.Length < 4)
            {
                input += "6";
                UpdateVisor();
            }
        }
        private void buttonSete_Click(object sender, EventArgs e)
        {
            if (input.Length < 4)
            {
                input += "7";
                UpdateVisor();
            }
        }
        private void buttonOito_Click(object sender, EventArgs e)
        {
            if (input.Length < 4)
            {
                input += "8";
                UpdateVisor();
            }
        }

        private void buttonNove_Click(object sender, EventArgs e)
        {
            if (input.Length < 4)
            {
                input += "9";
                UpdateVisor();
            }
        }

        private void btnAumenta_Click(object sender, EventArgs e)
        {
            if (indPotencia < 10)
            {
                indPotencia++;
                txtPotencia.Text = indPotencia.ToString();
            }
        }

        private void btnDiminui_Click(object sender, EventArgs e)
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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
