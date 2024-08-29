namespace Microondas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonUm = new System.Windows.Forms.Button();
            this.buttonDois = new System.Windows.Forms.Button();
            this.buttonCinco = new System.Windows.Forms.Button();
            this.buttonQuatro = new System.Windows.Forms.Button();
            this.buttonTres = new System.Windows.Forms.Button();
            this.buttonOito = new System.Windows.Forms.Button();
            this.buttonSete = new System.Windows.Forms.Button();
            this.buttonSeis = new System.Windows.Forms.Button();
            this.buttonPara = new System.Windows.Forms.Button();
            this.buttonLiga = new System.Windows.Forms.Button();
            this.buttonNove = new System.Windows.Forms.Button();
            this.txtTeste = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtVisor
            // 
            this.txtVisor.Enabled = false;
            this.txtVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisor.Location = new System.Drawing.Point(102, 143);
            this.txtVisor.MaxLength = 4;
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.Size = new System.Drawing.Size(355, 98);
            this.txtVisor.TabIndex = 0;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // buttonZero
            // 
            this.buttonZero.Location = new System.Drawing.Point(624, 297);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(84, 59);
            this.buttonZero.TabIndex = 1;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // buttonUm
            // 
            this.buttonUm.Location = new System.Drawing.Point(534, 232);
            this.buttonUm.Name = "buttonUm";
            this.buttonUm.Size = new System.Drawing.Size(84, 59);
            this.buttonUm.TabIndex = 2;
            this.buttonUm.Text = "1";
            this.buttonUm.UseVisualStyleBackColor = true;
            this.buttonUm.Click += new System.EventHandler(this.buttonUm_Click);
            // 
            // buttonDois
            // 
            this.buttonDois.Location = new System.Drawing.Point(624, 232);
            this.buttonDois.Name = "buttonDois";
            this.buttonDois.Size = new System.Drawing.Size(84, 59);
            this.buttonDois.TabIndex = 3;
            this.buttonDois.Text = "2";
            this.buttonDois.UseVisualStyleBackColor = true;
            this.buttonDois.Click += new System.EventHandler(this.buttonDois_Click);
            // 
            // buttonCinco
            // 
            this.buttonCinco.Location = new System.Drawing.Point(624, 167);
            this.buttonCinco.Name = "buttonCinco";
            this.buttonCinco.Size = new System.Drawing.Size(84, 59);
            this.buttonCinco.TabIndex = 6;
            this.buttonCinco.Text = "5";
            this.buttonCinco.UseVisualStyleBackColor = true;
            this.buttonCinco.Click += new System.EventHandler(this.buttonCinco_Click);
            // 
            // buttonQuatro
            // 
            this.buttonQuatro.Location = new System.Drawing.Point(534, 167);
            this.buttonQuatro.Name = "buttonQuatro";
            this.buttonQuatro.Size = new System.Drawing.Size(84, 59);
            this.buttonQuatro.TabIndex = 5;
            this.buttonQuatro.Text = "4";
            this.buttonQuatro.UseVisualStyleBackColor = true;
            this.buttonQuatro.Click += new System.EventHandler(this.buttonQuatro_Click);
            // 
            // buttonTres
            // 
            this.buttonTres.Location = new System.Drawing.Point(714, 232);
            this.buttonTres.Name = "buttonTres";
            this.buttonTres.Size = new System.Drawing.Size(84, 59);
            this.buttonTres.TabIndex = 4;
            this.buttonTres.Text = "3";
            this.buttonTres.UseVisualStyleBackColor = true;
            this.buttonTres.Click += new System.EventHandler(this.buttonTres_Click);
            // 
            // buttonOito
            // 
            this.buttonOito.Location = new System.Drawing.Point(624, 102);
            this.buttonOito.Name = "buttonOito";
            this.buttonOito.Size = new System.Drawing.Size(84, 59);
            this.buttonOito.TabIndex = 9;
            this.buttonOito.Text = "8";
            this.buttonOito.UseVisualStyleBackColor = true;
            this.buttonOito.Click += new System.EventHandler(this.buttonOito_Click);
            // 
            // buttonSete
            // 
            this.buttonSete.Location = new System.Drawing.Point(534, 102);
            this.buttonSete.Name = "buttonSete";
            this.buttonSete.Size = new System.Drawing.Size(84, 59);
            this.buttonSete.TabIndex = 8;
            this.buttonSete.Text = "7";
            this.buttonSete.UseVisualStyleBackColor = true;
            this.buttonSete.Click += new System.EventHandler(this.buttonSete_Click);
            // 
            // buttonSeis
            // 
            this.buttonSeis.Location = new System.Drawing.Point(714, 167);
            this.buttonSeis.Name = "buttonSeis";
            this.buttonSeis.Size = new System.Drawing.Size(84, 59);
            this.buttonSeis.TabIndex = 7;
            this.buttonSeis.Text = "6";
            this.buttonSeis.UseVisualStyleBackColor = true;
            this.buttonSeis.Click += new System.EventHandler(this.buttonSeis_Click);
            // 
            // buttonPara
            // 
            this.buttonPara.Location = new System.Drawing.Point(534, 297);
            this.buttonPara.Name = "buttonPara";
            this.buttonPara.Size = new System.Drawing.Size(84, 59);
            this.buttonPara.TabIndex = 12;
            this.buttonPara.Text = "buttonPara";
            this.buttonPara.UseVisualStyleBackColor = true;
            this.buttonPara.Click += new System.EventHandler(this.buttonPara_Click);
            // 
            // buttonLiga
            // 
            this.buttonLiga.Location = new System.Drawing.Point(714, 297);
            this.buttonLiga.Name = "buttonLiga";
            this.buttonLiga.Size = new System.Drawing.Size(84, 59);
            this.buttonLiga.TabIndex = 11;
            this.buttonLiga.Text = "buttonLiga";
            this.buttonLiga.UseVisualStyleBackColor = true;
            this.buttonLiga.Click += new System.EventHandler(this.buttonLiga_Click);
            // 
            // buttonNove
            // 
            this.buttonNove.Location = new System.Drawing.Point(714, 102);
            this.buttonNove.Name = "buttonNove";
            this.buttonNove.Size = new System.Drawing.Size(84, 59);
            this.buttonNove.TabIndex = 10;
            this.buttonNove.Text = "9";
            this.buttonNove.UseVisualStyleBackColor = true;
            this.buttonNove.Click += new System.EventHandler(this.buttonNove_Click);
            // 
            // txtTeste
            // 
            this.txtTeste.Enabled = false;
            this.txtTeste.Location = new System.Drawing.Point(104, 361);
            this.txtTeste.Name = "txtTeste";
            this.txtTeste.Size = new System.Drawing.Size(340, 22);
            this.txtTeste.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTeste);
            this.Controls.Add(this.buttonPara);
            this.Controls.Add(this.buttonLiga);
            this.Controls.Add(this.buttonNove);
            this.Controls.Add(this.buttonOito);
            this.Controls.Add(this.buttonSete);
            this.Controls.Add(this.buttonSeis);
            this.Controls.Add(this.buttonCinco);
            this.Controls.Add(this.buttonQuatro);
            this.Controls.Add(this.buttonTres);
            this.Controls.Add(this.buttonDois);
            this.Controls.Add(this.buttonUm);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.txtVisor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonUm;
        private System.Windows.Forms.Button buttonDois;
        private System.Windows.Forms.Button buttonCinco;
        private System.Windows.Forms.Button buttonQuatro;
        private System.Windows.Forms.Button buttonTres;
        private System.Windows.Forms.Button buttonOito;
        private System.Windows.Forms.Button buttonSete;
        private System.Windows.Forms.Button buttonSeis;
        private System.Windows.Forms.Button buttonPara;
        private System.Windows.Forms.Button buttonLiga;
        private System.Windows.Forms.Button buttonNove;
        private System.Windows.Forms.TextBox txtTeste;
    }
}

