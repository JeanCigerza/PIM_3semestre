namespace Adicionar_Funcionário.Apresentacao
{
    partial class FrmFolha_de_pagamento
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNome_Completo = new System.Windows.Forms.Label();
            this.lblSalário_Bruto = new System.Windows.Forms.Label();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblFGTS = new System.Windows.Forms.Label();
            this.lblImpostoDeRenda = new System.Windows.Forms.Label();
            this.lblSalario_Liquido = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblData_Admissão = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtSal_Liq = new System.Windows.Forms.TextBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(79, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Arvore da sorte";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 62);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // lblNome_Completo
            // 
            this.lblNome_Completo.AutoSize = true;
            this.lblNome_Completo.Location = new System.Drawing.Point(12, 101);
            this.lblNome_Completo.Name = "lblNome_Completo";
            this.lblNome_Completo.Size = new System.Drawing.Size(82, 13);
            this.lblNome_Completo.TabIndex = 2;
            this.lblNome_Completo.Text = "Nome Completo";
            // 
            // lblSalário_Bruto
            // 
            this.lblSalário_Bruto.AutoSize = true;
            this.lblSalário_Bruto.Location = new System.Drawing.Point(12, 154);
            this.lblSalário_Bruto.Name = "lblSalário_Bruto";
            this.lblSalário_Bruto.Size = new System.Drawing.Size(67, 13);
            this.lblSalário_Bruto.TabIndex = 3;
            this.lblSalário_Bruto.Text = "Salario Bruto";
            this.lblSalário_Bruto.Click += new System.EventHandler(this.lblSalário_Base_Click);
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Location = new System.Drawing.Point(12, 202);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(32, 13);
            this.lblINSS.TabIndex = 5;
            this.lblINSS.Text = "INSS";
            // 
            // lblFGTS
            // 
            this.lblFGTS.AutoSize = true;
            this.lblFGTS.Location = new System.Drawing.Point(12, 258);
            this.lblFGTS.Name = "lblFGTS";
            this.lblFGTS.Size = new System.Drawing.Size(35, 13);
            this.lblFGTS.TabIndex = 6;
            this.lblFGTS.Text = "FGTS";
            // 
            // lblImpostoDeRenda
            // 
            this.lblImpostoDeRenda.AutoSize = true;
            this.lblImpostoDeRenda.Location = new System.Drawing.Point(12, 295);
            this.lblImpostoDeRenda.Name = "lblImpostoDeRenda";
            this.lblImpostoDeRenda.Size = new System.Drawing.Size(89, 13);
            this.lblImpostoDeRenda.TabIndex = 7;
            this.lblImpostoDeRenda.Text = "Imposto de renda";
            // 
            // lblSalario_Liquido
            // 
            this.lblSalario_Liquido.AutoSize = true;
            this.lblSalario_Liquido.Location = new System.Drawing.Point(517, 340);
            this.lblSalario_Liquido.Name = "lblSalario_Liquido";
            this.lblSalario_Liquido.Size = new System.Drawing.Size(76, 13);
            this.lblSalario_Liquido.TabIndex = 8;
            this.lblSalario_Liquido.Text = "Salário Liquido";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(274, 62);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 9;
            this.lblCargo.Text = "Cargo";
            // 
            // lblData_Admissão
            // 
            this.lblData_Admissão.AutoSize = true;
            this.lblData_Admissão.Location = new System.Drawing.Point(515, 62);
            this.lblData_Admissão.Name = "lblData_Admissão";
            this.lblData_Admissão.Size = new System.Drawing.Size(78, 13);
            this.lblData_Admissão.TabIndex = 10;
            this.lblData_Admissão.Text = "Data Admissão";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(515, 21);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 11;
            this.lblData.Text = "Data";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(592, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(592, 56);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // txtSal_Liq
            // 
            this.txtSal_Liq.Location = new System.Drawing.Point(608, 333);
            this.txtSal_Liq.Name = "txtSal_Liq";
            this.txtSal_Liq.Size = new System.Drawing.Size(182, 20);
            this.txtSal_Liq.TabIndex = 14;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRelatorio.Location = new System.Drawing.Point(662, 404);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(110, 26);
            this.btnRelatorio.TabIndex = 15;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(79, 406);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmFolha_de_pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.txtSal_Liq);
            this.Controls.Add(this.dateTimePicker2);
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
            this.Name = "FrmFolha_de_pagamento";
            this.Text = "Gerador de folha de pagamento";
            this.Load += new System.EventHandler(this.Folha_de_pagamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNome_Completo;
        private System.Windows.Forms.Label lblSalário_Bruto;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lblFGTS;
        private System.Windows.Forms.Label lblImpostoDeRenda;
        private System.Windows.Forms.Label lblSalario_Liquido;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblData_Admissão;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtSal_Liq;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnVoltar;
    }
}