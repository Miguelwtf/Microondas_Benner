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
            this.btnUm = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnPara = new System.Windows.Forms.Button();
            this.btnLiga = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.txtTeste = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.padrao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrucoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDiminui = new System.Windows.Forms.Button();
            this.btnAumenta = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExclui = new System.Windows.Forms.Button();
            this.btnEdita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVisor
            // 
            this.txtVisor.Enabled = false;
            this.txtVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisor.Location = new System.Drawing.Point(418, 289);
            this.txtVisor.Margin = new System.Windows.Forms.Padding(2);
            this.txtVisor.MaxLength = 4;
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.Size = new System.Drawing.Size(242, 80);
            this.txtVisor.TabIndex = 0;
            this.txtVisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // buttonZero
            // 
            this.buttonZero.Location = new System.Drawing.Point(746, 471);
            this.buttonZero.Margin = new System.Windows.Forms.Padding(2);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(78, 48);
            this.buttonZero.TabIndex = 1;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // btnUm
            // 
            this.btnUm.Location = new System.Drawing.Point(664, 418);
            this.btnUm.Margin = new System.Windows.Forms.Padding(2);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(78, 48);
            this.btnUm.TabIndex = 2;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = true;
            this.btnUm.Click += new System.EventHandler(this.buttonUm_Click);
            // 
            // btnDois
            // 
            this.btnDois.Location = new System.Drawing.Point(746, 419);
            this.btnDois.Margin = new System.Windows.Forms.Padding(2);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(78, 48);
            this.btnDois.TabIndex = 3;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = true;
            this.btnDois.Click += new System.EventHandler(this.buttonDois_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(746, 366);
            this.btnCinco.Margin = new System.Windows.Forms.Padding(2);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(78, 48);
            this.btnCinco.TabIndex = 6;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.buttonCinco_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.Location = new System.Drawing.Point(664, 365);
            this.btnQuatro.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(78, 48);
            this.btnQuatro.TabIndex = 5;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = true;
            this.btnQuatro.Click += new System.EventHandler(this.buttonQuatro_Click);
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(828, 418);
            this.btnTres.Margin = new System.Windows.Forms.Padding(2);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(78, 48);
            this.btnTres.TabIndex = 4;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.buttonTres_Click);
            // 
            // btnOito
            // 
            this.btnOito.Location = new System.Drawing.Point(746, 314);
            this.btnOito.Margin = new System.Windows.Forms.Padding(2);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(78, 48);
            this.btnOito.TabIndex = 9;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = true;
            this.btnOito.Click += new System.EventHandler(this.buttonOito_Click);
            // 
            // btnSete
            // 
            this.btnSete.Location = new System.Drawing.Point(664, 313);
            this.btnSete.Margin = new System.Windows.Forms.Padding(2);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(78, 48);
            this.btnSete.TabIndex = 8;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = true;
            this.btnSete.Click += new System.EventHandler(this.buttonSete_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Location = new System.Drawing.Point(828, 366);
            this.btnSeis.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(78, 48);
            this.btnSeis.TabIndex = 7;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.buttonSeis_Click);
            // 
            // btnPara
            // 
            this.btnPara.Location = new System.Drawing.Point(664, 471);
            this.btnPara.Margin = new System.Windows.Forms.Padding(2);
            this.btnPara.Name = "btnPara";
            this.btnPara.Size = new System.Drawing.Size(78, 48);
            this.btnPara.TabIndex = 12;
            this.btnPara.Text = "Pausa/Canc";
            this.btnPara.UseVisualStyleBackColor = true;
            this.btnPara.Click += new System.EventHandler(this.buttonPara_Click);
            // 
            // btnLiga
            // 
            this.btnLiga.Location = new System.Drawing.Point(828, 471);
            this.btnLiga.Margin = new System.Windows.Forms.Padding(2);
            this.btnLiga.Name = "btnLiga";
            this.btnLiga.Size = new System.Drawing.Size(78, 48);
            this.btnLiga.TabIndex = 11;
            this.btnLiga.Text = "Aquecimento";
            this.btnLiga.UseVisualStyleBackColor = true;
            this.btnLiga.Click += new System.EventHandler(this.buttonLiga_Click);
            // 
            // btnNove
            // 
            this.btnNove.Location = new System.Drawing.Point(828, 313);
            this.btnNove.Margin = new System.Windows.Forms.Padding(2);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(78, 48);
            this.btnNove.TabIndex = 10;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = true;
            this.btnNove.Click += new System.EventHandler(this.buttonNove_Click);
            // 
            // txtTeste
            // 
            this.txtTeste.Enabled = false;
            this.txtTeste.Location = new System.Drawing.Point(664, 289);
            this.txtTeste.Margin = new System.Windows.Forms.Padding(2);
            this.txtTeste.Name = "txtTeste";
            this.txtTeste.Size = new System.Drawing.Size(242, 20);
            this.txtTeste.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Potência";
            // 
            // txtPotencia
            // 
            this.txtPotencia.Enabled = false;
            this.txtPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPotencia.Location = new System.Drawing.Point(561, 436);
            this.txtPotencia.MaxLength = 10;
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(78, 31);
            this.txtPotencia.TabIndex = 15;
            this.txtPotencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.alimento,
            this.tempo,
            this.potencia,
            this.simbolo,
            this.padrao,
            this.instrucoes});
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(894, 272);
            this.dataGrid.TabIndex = 16;
            this.dataGrid.Click += new System.EventHandler(this.dataGrid_Click);
            this.dataGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGrid_MouseDown);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id.HeaderText = "Cód.";
            this.id.Name = "id";
            this.id.Width = 54;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 60;
            // 
            // alimento
            // 
            this.alimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.alimento.HeaderText = "Alimento";
            this.alimento.Name = "alimento";
            this.alimento.Width = 72;
            // 
            // tempo
            // 
            this.tempo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tempo.HeaderText = "Tempo";
            this.tempo.Name = "tempo";
            this.tempo.Width = 65;
            // 
            // potencia
            // 
            this.potencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.potencia.HeaderText = "Potência";
            this.potencia.Name = "potencia";
            this.potencia.Width = 74;
            // 
            // simbolo
            // 
            this.simbolo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.simbolo.HeaderText = "Símbolo";
            this.simbolo.Name = "simbolo";
            this.simbolo.Width = 71;
            // 
            // padrao
            // 
            this.padrao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.padrao.HeaderText = "Padrão";
            this.padrao.Name = "padrao";
            this.padrao.ReadOnly = true;
            this.padrao.Width = 66;
            // 
            // instrucoes
            // 
            this.instrucoes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.instrucoes.HeaderText = "Instruções";
            this.instrucoes.Name = "instrucoes";
            this.instrucoes.Width = 81;
            // 
            // btnDiminui
            // 
            this.btnDiminui.Location = new System.Drawing.Point(418, 470);
            this.btnDiminui.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiminui.Name = "btnDiminui";
            this.btnDiminui.Size = new System.Drawing.Size(78, 48);
            this.btnDiminui.TabIndex = 17;
            this.btnDiminui.Text = "Diminui";
            this.btnDiminui.UseVisualStyleBackColor = true;
            this.btnDiminui.Click += new System.EventHandler(this.btnDiminui_Click);
            // 
            // btnAumenta
            // 
            this.btnAumenta.Location = new System.Drawing.Point(418, 418);
            this.btnAumenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnAumenta.Name = "btnAumenta";
            this.btnAumenta.Size = new System.Drawing.Size(78, 48);
            this.btnAumenta.TabIndex = 18;
            this.btnAumenta.Text = "Aumenta";
            this.btnAumenta.UseVisualStyleBackColor = true;
            this.btnAumenta.Click += new System.EventHandler(this.btnAumenta_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 290);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 19;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExclui
            // 
            this.btnExclui.Location = new System.Drawing.Point(174, 290);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(75, 23);
            this.btnExclui.TabIndex = 21;
            this.btnExclui.Text = "Exclui";
            this.btnExclui.UseVisualStyleBackColor = true;
            this.btnExclui.Click += new System.EventHandler(this.btnExclui_Click);
            // 
            // btnEdita
            // 
            this.btnEdita.Location = new System.Drawing.Point(93, 290);
            this.btnEdita.Name = "btnEdita";
            this.btnEdita.Size = new System.Drawing.Size(75, 23);
            this.btnEdita.TabIndex = 22;
            this.btnEdita.Text = "Edita";
            this.btnEdita.UseVisualStyleBackColor = true;
            this.btnEdita.Click += new System.EventHandler(this.btnEdita_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 529);
            this.Controls.Add(this.btnEdita);
            this.Controls.Add(this.btnExclui);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAumenta);
            this.Controls.Add(this.btnDiminui);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTeste);
            this.Controls.Add(this.btnPara);
            this.Controls.Add(this.btnLiga);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.txtVisor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnPara;
        private System.Windows.Forms.Button btnLiga;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.TextBox txtTeste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnDiminui;
        private System.Windows.Forms.Button btnAumenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn alimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn potencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn simbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn padrao;
        private System.Windows.Forms.DataGridViewTextBoxColumn instrucoes;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExclui;
        private System.Windows.Forms.Button btnEdita;
    }
}

