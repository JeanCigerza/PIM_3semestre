namespace Adicionar_Funcionário.Apresentacao
{
    partial class FrmCargos
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
            this.lblID_Cargo = new System.Windows.Forms.Label();
            this.lblNome_Cargo = new System.Windows.Forms.Label();
            this.lblJornDTrab = new System.Windows.Forms.Label();
            this.lblSalarioDcargo = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID_Cargo
            // 
            this.lblID_Cargo.AutoSize = true;
            this.lblID_Cargo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_Cargo.Location = new System.Drawing.Point(28, 43);
            this.lblID_Cargo.Name = "lblID_Cargo";
            this.lblID_Cargo.Size = new System.Drawing.Size(21, 16);
            this.lblID_Cargo.TabIndex = 0;
            this.lblID_Cargo.Text = "ID ";
            // 
            // lblNome_Cargo
            // 
            this.lblNome_Cargo.AutoSize = true;
            this.lblNome_Cargo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome_Cargo.Location = new System.Drawing.Point(28, 90);
            this.lblNome_Cargo.Name = "lblNome_Cargo";
            this.lblNome_Cargo.Size = new System.Drawing.Size(90, 16);
            this.lblNome_Cargo.TabIndex = 1;
            this.lblNome_Cargo.Text = "Nome do cargo";
            // 
            // lblJornDTrab
            // 
            this.lblJornDTrab.AutoSize = true;
            this.lblJornDTrab.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJornDTrab.Location = new System.Drawing.Point(28, 141);
            this.lblJornDTrab.Name = "lblJornDTrab";
            this.lblJornDTrab.Size = new System.Drawing.Size(111, 16);
            this.lblJornDTrab.TabIndex = 2;
            this.lblJornDTrab.Text = "Jornada de trabalho";
            // 
            // lblSalarioDcargo
            // 
            this.lblSalarioDcargo.AutoSize = true;
            this.lblSalarioDcargo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioDcargo.Location = new System.Drawing.Point(28, 190);
            this.lblSalarioDcargo.Name = "lblSalarioDcargo";
            this.lblSalarioDcargo.Size = new System.Drawing.Size(92, 16);
            this.lblSalarioDcargo.TabIndex = 3;
            this.lblSalarioDcargo.Text = "Salario do cargo";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.Location = new System.Drawing.Point(270, 250);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(96, 31);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FrmCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(394, 312);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblSalarioDcargo);
            this.Controls.Add(this.lblJornDTrab);
            this.Controls.Add(this.lblNome_Cargo);
            this.Controls.Add(this.lblID_Cargo);
            this.Name = "FrmCargos";
            this.Text = "Cargo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID_Cargo;
        private System.Windows.Forms.Label lblNome_Cargo;
        private System.Windows.Forms.Label lblJornDTrab;
        private System.Windows.Forms.Label lblSalarioDcargo;
        private System.Windows.Forms.Button btnVoltar;
    }
}