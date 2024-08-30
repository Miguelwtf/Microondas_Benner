using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microondas.Model
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomePrograma.Text) ||
                string.IsNullOrWhiteSpace(txtAlimento.Text) ||
                string.IsNullOrWhiteSpace(txtSimbolo.Text) ||
                !int.TryParse(txtPotencia.Text, out int potencia) ||
                !int.TryParse(txtTempo.Text, out int tempo))
            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preenchidos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var programa = new ProgramaAquecimento
            {
                Nome = txtNomePrograma.Text,
                Alimento = txtAlimento.Text,
                Potencia = potencia,
                Tempo = tempo,
                Simbolo = txtSimbolo.Text,
                Instrucoes = txtInstrucoes.Text 
            };

            var dbProgramas = new DBProgramas();
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
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o programa de aquecimento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void FormCadastro_Load(object sender, EventArgs e)
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
