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
using Microondas.Models;

namespace Microondas.Model
{
    public partial class MicroondasCadastro : Form
    {
        private bool isUpdating = false;
        private int tempoConvertido = 0;
        private bool IsEditMode { get; set; }
        private int RecordId { get; set; }

        public MicroondasCadastro(int recordId = 0)
        {
            InitializeComponent();

            if (recordId > 0)
            {
                IsEditMode = true;

                RecordId = recordId;
                CarregarDados();
            }
        }

        private void CarregarDados()
        {
            var dbProgramas = new DBProgramas();
            var programa = dbProgramas.GetById(RecordId);

            if (programa != null)
            {
                txtNomePrograma.Text = programa.Nome;
                txtAlimento.Text = programa.Alimento;
                txtPotencia.Text = programa.Potencia.ToString();
                txtSimbolo.Text = programa.Simbolo;
                txtInstrucoes.Text = programa.Instrucoes;

                TimeSpan timeSpan = TimeSpan.FromSeconds(programa.Tempo);
                txtTempo.Text = timeSpan.ToString(@"mm\:ss");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomePrograma.Text) ||
                string.IsNullOrWhiteSpace(txtAlimento.Text) ||
                string.IsNullOrWhiteSpace(txtSimbolo.Text) ||
                !int.TryParse(txtPotencia.Text, out int potencia) ||
                tempoConvertido <= 0)
            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preenchidos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var programa = new ProgramaAquecimento
            {
                Nome = txtNomePrograma.Text,
                Alimento = txtAlimento.Text,
                Potencia = potencia,
                Tempo = tempoConvertido,
                Simbolo = txtSimbolo.Text,
                Instrucoes = txtInstrucoes.Text
            };

            var dbProgramas = new DBProgramas();

            if (IsEditMode)
            {
                programa.Id = RecordId;

                if (programa.Nome == "Aquecimento" || programa.Nome == "Aquecimento Rápido")
                {
                    if (!int.TryParse(txtTempo.Text, out int tempoEmSegundos))
                    {
                        MessageBox.Show("Tempo inválido. Por favor, insira um valor numérico válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (tempoEmSegundos < 1 || tempoEmSegundos > 120)
                    {
                        MessageBox.Show("O tempo deve estar entre 1 segundo e 2 minutos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    programa.Tempo = tempoEmSegundos;
                }

                if (dbProgramas.Update(programa))
                {
                    MessageBox.Show("Programa de aquecimento atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar o programa de aquecimento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var todosProgramas = dbProgramas.GetAll();
                foreach (var p in todosProgramas)
                {
                    if (p.Simbolo == programa.Simbolo)
                    {
                        MessageBox.Show("Símbolo já utilizado. Por favor, escolha outro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (dbProgramas.Add(programa))
                {
                    MessageBox.Show("Programa de aquecimento cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o programa de aquecimento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.Close();
        }

        private void txtTempo_TextChanged(object sender, EventArgs e)
    
        {
            if (isUpdating)
                return;

            isUpdating = true;

            string digits = new string(txtTempo.Text.Where(char.IsDigit).ToArray());

            if (digits.Length > 4)
            {
                digits = digits.Substring(digits.Length - 4);
            }

            digits = digits.PadLeft(4, '0');
            string minutos = digits.Substring(0, 2);
            string segundos = digits.Substring(2, 2);

            if (int.TryParse(segundos, out int segundosInt))
            {
                if (segundosInt > 59)
                {
                    segundos = "59";
                }
            }

            string formatted = $"{minutos}:{segundos}";

            if (txtTempo.Text != formatted)
            {
                txtTempo.Text = formatted;
            }

            txtTempo.SelectionStart = txtTempo.Text.Length;
            isUpdating = false;

            ConverterParaSegundos(minutos, segundos);
        }

        private void ConverterParaSegundos(string minutos, string segundos)
        {
            if (int.TryParse(minutos, out int minutosInt) && int.TryParse(segundos, out int segundosInt))
            {
                tempoConvertido = (minutosInt * 60) + segundosInt;
            }
            else
            {
                tempoConvertido = 0;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTempo.Text = "";
            txtSimbolo.Text = "";
            txtPotencia.Text = "";
            txtAlimento.Text = "";
            txtInstrucoes.Text = "";
            txtNomePrograma.Text = "";
        }

        private void txtPotencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                int parsedValue;
                if (int.TryParse(textBox.Text + e.KeyChar, out parsedValue))
                {
                    if (parsedValue > 10)
                    {
                        textBox.Text = "10";
                        e.Handled = true; 
                        textBox.SelectionStart = textBox.Text.Length; 
                    }
                }
            }
        }

        private void txtSimbolo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length >= 1 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
        }


        private void MicroondasCadastro_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
