namespace ProjetoAtendimento
{
    partial class Form1
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
            this.listsenha = new System.Windows.Forms.ListBox();
            this.btn_gerar = new System.Windows.Forms.Button();
            this.btn_listarsenhas = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_listaratendimentos = new System.Windows.Forms.Button();
            this.btn_chamar = new System.Windows.Forms.Button();
            this.listchamar = new System.Windows.Forms.ListBox();
            this.txtchamar = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listsenha
            // 
            this.listsenha.FormattingEnabled = true;
            this.listsenha.Location = new System.Drawing.Point(21, 49);
            this.listsenha.Margin = new System.Windows.Forms.Padding(2);
            this.listsenha.Name = "listsenha";
            this.listsenha.Size = new System.Drawing.Size(190, 95);
            this.listsenha.TabIndex = 0;
            // 
            // btn_gerar
            // 
            this.btn_gerar.Location = new System.Drawing.Point(82, 18);
            this.btn_gerar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_gerar.Name = "btn_gerar";
            this.btn_gerar.Size = new System.Drawing.Size(56, 19);
            this.btn_gerar.TabIndex = 1;
            this.btn_gerar.Text = "Gerar";
            this.btn_gerar.UseVisualStyleBackColor = true;
            this.btn_gerar.Click += new System.EventHandler(this.btn_gerar_Click);
            // 
            // btn_listarsenhas
            // 
            this.btn_listarsenhas.Location = new System.Drawing.Point(53, 157);
            this.btn_listarsenhas.Margin = new System.Windows.Forms.Padding(2);
            this.btn_listarsenhas.Name = "btn_listarsenhas";
            this.btn_listarsenhas.Size = new System.Drawing.Size(120, 19);
            this.btn_listarsenhas.TabIndex = 2;
            this.btn_listarsenhas.Text = "Listar Senhas";
            this.btn_listarsenhas.UseVisualStyleBackColor = true;
            this.btn_listarsenhas.Click += new System.EventHandler(this.btn_listarsenhas_Click);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(237, 112);
            this.btn_Adicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(56, 19);
            this.btn_Adicionar.TabIndex = 3;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_listaratendimentos
            // 
            this.btn_listaratendimentos.Location = new System.Drawing.Point(368, 157);
            this.btn_listaratendimentos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_listaratendimentos.Name = "btn_listaratendimentos";
            this.btn_listaratendimentos.Size = new System.Drawing.Size(117, 19);
            this.btn_listaratendimentos.TabIndex = 4;
            this.btn_listaratendimentos.Text = "Listar Atendimentos";
            this.btn_listaratendimentos.UseVisualStyleBackColor = true;
            this.btn_listaratendimentos.Click += new System.EventHandler(this.btn_listaratendimentos_Click);
            // 
            // btn_chamar
            // 
            this.btn_chamar.Location = new System.Drawing.Point(467, 18);
            this.btn_chamar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_chamar.Name = "btn_chamar";
            this.btn_chamar.Size = new System.Drawing.Size(56, 19);
            this.btn_chamar.TabIndex = 5;
            this.btn_chamar.Text = "Chamar";
            this.btn_chamar.UseVisualStyleBackColor = true;
            this.btn_chamar.Click += new System.EventHandler(this.btn_chamar_Click);
            // 
            // listchamar
            // 
            this.listchamar.FormattingEnabled = true;
            this.listchamar.Location = new System.Drawing.Point(323, 49);
            this.listchamar.Margin = new System.Windows.Forms.Padding(2);
            this.listchamar.Name = "listchamar";
            this.listchamar.Size = new System.Drawing.Size(328, 95);
            this.listchamar.TabIndex = 6;
            this.listchamar.SelectedIndexChanged += new System.EventHandler(this.listchamar_SelectedIndexChanged);
            // 
            // txtchamar
            // 
            this.txtchamar.Location = new System.Drawing.Point(343, 17);
            this.txtchamar.Name = "txtchamar";
            this.txtchamar.Size = new System.Drawing.Size(119, 20);
            this.txtchamar.TabIndex = 7;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(248, 74);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(13, 13);
            this.lblQtd.TabIndex = 8;
            this.lblQtd.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Guiche";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 207);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.txtchamar);
            this.Controls.Add(this.listchamar);
            this.Controls.Add(this.btn_chamar);
            this.Controls.Add(this.btn_listaratendimentos);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.btn_listarsenhas);
            this.Controls.Add(this.btn_gerar);
            this.Controls.Add(this.listsenha);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listsenha;
        private System.Windows.Forms.Button btn_gerar;
        private System.Windows.Forms.Button btn_listarsenhas;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_listaratendimentos;
        private System.Windows.Forms.Button btn_chamar;
        private System.Windows.Forms.ListBox listchamar;
        private System.Windows.Forms.TextBox txtchamar;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label label1;
    }
}

