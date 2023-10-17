namespace Adicionar_Funcionário
{
    partial class frmListaDependentes
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
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.lblGrauParentesco = new System.Windows.Forms.Label();
            this.lblNomeColaborador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(32, 125);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(82, 13);
            this.lblNomeCompleto.TabIndex = 0;
            this.lblNomeCompleto.Text = "Nome Completo";
            // 
            // lblGrauParentesco
            // 
            this.lblGrauParentesco.AutoSize = true;
            this.lblGrauParentesco.Location = new System.Drawing.Point(32, 79);
            this.lblGrauParentesco.Name = "lblGrauParentesco";
            this.lblGrauParentesco.Size = new System.Drawing.Size(102, 13);
            this.lblGrauParentesco.TabIndex = 1;
            this.lblGrauParentesco.Text = "Grau de Parentesco";
            // 
            // lblNomeColaborador
            // 
            this.lblNomeColaborador.AutoSize = true;
            this.lblNomeColaborador.Location = new System.Drawing.Point(32, 35);
            this.lblNomeColaborador.Name = "lblNomeColaborador";
            this.lblNomeColaborador.Size = new System.Drawing.Size(95, 13);
            this.lblNomeColaborador.TabIndex = 2;
            this.lblNomeColaborador.Text = "Nome Colaborador";
            // 
            // frmListaDependentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(497, 225);
            this.Controls.Add(this.lblNomeColaborador);
            this.Controls.Add(this.lblGrauParentesco);
            this.Controls.Add(this.lblNomeCompleto);
            this.Name = "frmListaDependentes";
            this.Text = "Lista de Dependentes";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Label lblGrauParentesco;
        private System.Windows.Forms.Label lblNomeColaborador;
    }
}