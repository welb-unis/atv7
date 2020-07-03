namespace PadraoDeProjetoEmCamadas
{
    partial class frmEleicao
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
            this.textBox_IDUrna = new System.Windows.Forms.TextBox();
            this.textBox_IDEmpresa = new System.Windows.Forms.TextBox();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.textBox_Descricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker_Inicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Fim = new System.Windows.Forms.DateTimePicker();
            this.comboBox_TipoVoto = new System.Windows.Forms.ComboBox();
            this.painel_campos.SuspendLayout();
            this.Painel_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_campos
            // 
            this.painel_campos.Controls.Add(this.label1);
            this.painel_campos.Controls.Add(this.textBox_IDUrna);
            this.painel_campos.Controls.Add(this.comboBox_TipoVoto);
            this.painel_campos.Controls.Add(this.textBox_IDEmpresa);
            this.painel_campos.Controls.Add(this.dateTimePicker_Fim);
            this.painel_campos.Controls.Add(this.textBox_Nome);
            this.painel_campos.Controls.Add(this.dateTimePicker_Inicio);
            this.painel_campos.Controls.Add(this.textBox_Descricao);
            this.painel_campos.Controls.Add(this.label7);
            this.painel_campos.Controls.Add(this.label2);
            this.painel_campos.Controls.Add(this.label6);
            this.painel_campos.Controls.Add(this.label3);
            this.painel_campos.Controls.Add(this.label5);
            this.painel_campos.Controls.Add(this.label4);
            this.painel_campos.Location = new System.Drawing.Point(33, 13);
            this.painel_campos.Size = new System.Drawing.Size(656, 365);
            // 
            // Painel_botoes
            // 
            this.Painel_botoes.Location = new System.Drawing.Point(62, 386);
            this.Painel_botoes.Size = new System.Drawing.Size(595, 66);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // textBox_IDUrna
            // 
            this.textBox_IDUrna.Enabled = false;
            this.textBox_IDUrna.Location = new System.Drawing.Point(121, 15);
            this.textBox_IDUrna.Name = "textBox_IDUrna";
            this.textBox_IDUrna.Size = new System.Drawing.Size(100, 22);
            this.textBox_IDUrna.TabIndex = 0;
            // 
            // textBox_IDEmpresa
            // 
            this.textBox_IDEmpresa.Location = new System.Drawing.Point(121, 58);
            this.textBox_IDEmpresa.Name = "textBox_IDEmpresa";
            this.textBox_IDEmpresa.Size = new System.Drawing.Size(100, 22);
            this.textBox_IDEmpresa.TabIndex = 1;
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(121, 101);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(200, 22);
            this.textBox_Nome.TabIndex = 2;
            // 
            // textBox_Descricao
            // 
            this.textBox_Descricao.Location = new System.Drawing.Point(121, 189);
            this.textBox_Descricao.Multiline = true;
            this.textBox_Descricao.Name = "textBox_Descricao";
            this.textBox_Descricao.Size = new System.Drawing.Size(200, 73);
            this.textBox_Descricao.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID da Urna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID da Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo do Voto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descrição";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data Início";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Data Fim";
            // 
            // dateTimePicker_Inicio
            // 
            this.dateTimePicker_Inicio.Location = new System.Drawing.Point(121, 283);
            this.dateTimePicker_Inicio.Name = "dateTimePicker_Inicio";
            this.dateTimePicker_Inicio.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_Inicio.TabIndex = 13;
            // 
            // dateTimePicker_Fim
            // 
            this.dateTimePicker_Fim.Location = new System.Drawing.Point(121, 326);
            this.dateTimePicker_Fim.Name = "dateTimePicker_Fim";
            this.dateTimePicker_Fim.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_Fim.TabIndex = 14;
            // 
            // comboBox_TipoVoto
            // 
            this.comboBox_TipoVoto.FormattingEnabled = true;
            this.comboBox_TipoVoto.Items.AddRange(new object[] {
            "Secreto",
            "Público"});
            this.comboBox_TipoVoto.Location = new System.Drawing.Point(121, 144);
            this.comboBox_TipoVoto.Name = "comboBox_TipoVoto";
            this.comboBox_TipoVoto.Size = new System.Drawing.Size(121, 24);
            this.comboBox_TipoVoto.TabIndex = 15;
            // 
            // frmEleicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 472);
            this.Name = "frmEleicao";
            this.Text = "frmEleicao";
            this.painel_campos.ResumeLayout(false);
            this.painel_campos.PerformLayout();
            this.Painel_botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_IDUrna;
        private System.Windows.Forms.TextBox textBox_IDEmpresa;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.TextBox textBox_Descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Inicio;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Fim;
        private System.Windows.Forms.ComboBox comboBox_TipoVoto;
    }
}