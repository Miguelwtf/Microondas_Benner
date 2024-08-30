namespace Microondas.Model
{
    partial class FormCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNomePrograma = new System.Windows.Forms.TextBox();
            this.txtAlimento = new System.Windows.Forms.TextBox();
            this.txtSimbolo = new System.Windows.Forms.TextBox();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInstrucoes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomePrograma
            // 
            this.txtNomePrograma.Location = new System.Drawing.Point(72, 11);
            this.txtNomePrograma.Name = "txtNomePrograma";
            this.txtNomePrograma.Size = new System.Drawing.Size(242, 20);
            this.txtNomePrograma.TabIndex = 0;
            this.txtNomePrograma.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAlimento
            // 
            this.txtAlimento.Location = new System.Drawing.Point(387, 11);
            this.txtAlimento.Name = "txtAlimento";
            this.txtAlimento.Size = new System.Drawing.Size(168, 20);
            this.txtAlimento.TabIndex = 1;
            // 
            // txtSimbolo
            // 
            this.txtSimbolo.Location = new System.Drawing.Point(72, 37);
            this.txtSimbolo.MaxLength = 1;
            this.txtSimbolo.Name = "txtSimbolo";
            this.txtSimbolo.Size = new System.Drawing.Size(31, 20);
            this.txtSimbolo.TabIndex = 2;
            this.txtSimbolo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSimbolo_KeyPress);
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(283, 41);
            this.txtPotencia.MaxLength = 2;
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(31, 20);
            this.txtPotencia.TabIndex = 3;
            this.txtPotencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPotencia_KeyPress);
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(490, 38);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(65, 20);
            this.txtTempo.TabIndex = 4;
            this.txtTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtInstrucoes
            // 
            this.txtInstrucoes.Location = new System.Drawing.Point(72, 64);
            this.txtInstrucoes.Name = "txtInstrucoes";
            this.txtInstrucoes.Size = new System.Drawing.Size(483, 20);
            this.txtInstrucoes.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Alimento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Símbolo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Potência";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tempo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Instruções";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(204, 90);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(283, 90);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 134);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInstrucoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.txtSimbolo);
            this.Controls.Add(this.txtAlimento);
            this.Controls.Add(this.txtNomePrograma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCadastro";
            this.Text = "FormCadastro";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomePrograma;
        private System.Windows.Forms.TextBox txtAlimento;
        private System.Windows.Forms.TextBox txtSimbolo;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInstrucoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
    }
}