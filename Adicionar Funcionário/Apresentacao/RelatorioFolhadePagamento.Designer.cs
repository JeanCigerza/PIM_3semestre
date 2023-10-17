namespace Adicionar_Funcionário.Apresentacao
{
    partial class frmRelatorioFolhadePagamento
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
            this.btnGerarPDF = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.lblData_Admissão = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblSalario_Liquido = new System.Windows.Forms.Label();
            this.lblImpostoDeRenda = new System.Windows.Forms.Label();
            this.lblFGTS = new System.Windows.Forms.Label();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblSalário_Bruto = new System.Windows.Forms.Label();
            this.lblNome_Completo = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnVoltaraoMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerarPDF
            // 
            this.btnGerarPDF.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGerarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGerarPDF.Location = new System.Drawing.Point(661, 407);
            this.btnGerarPDF.Name = "btnGerarPDF";
            this.btnGerarPDF.Size = new System.Drawing.Size(110, 26);
            this.btnGerarPDF.TabIndex = 30;
            this.btnGerarPDF.Text = "Gerar PDF";
            this.btnGerarPDF.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(591, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(543, 24);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 26;
            this.lblData.Text = "Data";
            // 
            // lblData_Admissão
            // 
            this.lblData_Admissão.Location = new System.Drawing.Point(0, 0);
            this.lblData_Admissão.Name = "lblData_Admissão";
            this.lblData_Admissão.Size = new System.Drawing.Size(100, 23);
            this.lblData_Admissão.TabIndex = 32;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(162, 82);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 24;
            this.lblCargo.Text = "Cargo";
            // 
            // lblSalario_Liquido
            // 
            this.lblSalario_Liquido.AutoSize = true;
            this.lblSalario_Liquido.Location = new System.Drawing.Point(615, 82);
            this.lblSalario_Liquido.Name = "lblSalario_Liquido";
            this.lblSalario_Liquido.Size = new System.Drawing.Size(76, 13);
            this.lblSalario_Liquido.TabIndex = 23;
            this.lblSalario_Liquido.Text = "Salário Liquido";
            // 
            // lblImpostoDeRenda
            // 
            this.lblImpostoDeRenda.AutoSize = true;
            this.lblImpostoDeRenda.Location = new System.Drawing.Point(468, 82);
            this.lblImpostoDeRenda.Name = "lblImpostoDeRenda";
            this.lblImpostoDeRenda.Size = new System.Drawing.Size(89, 13);
            this.lblImpostoDeRenda.TabIndex = 22;
            this.lblImpostoDeRenda.Text = "Imposto de renda";
            // 
            // lblFGTS
            // 
            this.lblFGTS.AutoSize = true;
            this.lblFGTS.Location = new System.Drawing.Point(388, 82);
            this.lblFGTS.Name = "lblFGTS";
            this.lblFGTS.Size = new System.Drawing.Size(35, 13);
            this.lblFGTS.TabIndex = 21;
            this.lblFGTS.Text = "FGTS";
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Location = new System.Drawing.Point(324, 82);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(32, 13);
            this.lblINSS.TabIndex = 20;
            this.lblINSS.Text = "INSS";
            // 
            // lblSalário_Bruto
            // 
            this.lblSalário_Bruto.AutoSize = true;
            this.lblSalário_Bruto.Location = new System.Drawing.Point(228, 82);
            this.lblSalário_Bruto.Name = "lblSalário_Bruto";
            this.lblSalário_Bruto.Size = new System.Drawing.Size(67, 13);
            this.lblSalário_Bruto.TabIndex = 19;
            this.lblSalário_Bruto.Text = "Salario Bruto";
            // 
            // lblNome_Completo
            // 
            this.lblNome_Completo.AutoSize = true;
            this.lblNome_Completo.Location = new System.Drawing.Point(47, 82);
            this.lblNome_Completo.Name = "lblNome_Completo";
            this.lblNome_Completo.Size = new System.Drawing.Size(82, 13);
            this.lblNome_Completo.TabIndex = 18;
            this.lblNome_Completo.Text = "Nome Completo";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(11, 82);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 17;
            this.lblID.Text = "ID";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(11, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(79, 13);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Arvore da sorte";
            // 
            // btnVoltaraoMenu
            // 
            this.btnVoltaraoMenu.Location = new System.Drawing.Point(96, 409);
            this.btnVoltaraoMenu.Name = "btnVoltaraoMenu";
            this.btnVoltaraoMenu.Size = new System.Drawing.Size(140, 23);
            this.btnVoltaraoMenu.TabIndex = 33;
            this.btnVoltaraoMenu.Text = "Voltar ao Menu";
            this.btnVoltaraoMenu.UseVisualStyleBackColor = true;
            this.btnVoltaraoMenu.Click += new System.EventHandler(this.btnVoltaraoMenu_Click);
            // 
            // frmRelatorioFolhadePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltaraoMenu);
            this.Controls.Add(this.btnGerarPDF);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblData_Admissão);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblSalario_Liquido);
            this.Controls.Add(this.lblImpostoDeRenda);
            this.Controls.Add(this.lblFGTS);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.lblSalário_Bruto);
            this.Controls.Add(this.lblNome_Completo);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblNome);
            this.Name = "frmRelatorioFolhadePagamento";
            this.Text = "Relatorio Folha de Pagamento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarPDF;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblData_Admissão;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblSalario_Liquido;
        private System.Windows.Forms.Label lblImpostoDeRenda;
        private System.Windows.Forms.Label lblFGTS;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lblSalário_Bruto;
        private System.Windows.Forms.Label lblNome_Completo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnVoltaraoMenu;
    }
}