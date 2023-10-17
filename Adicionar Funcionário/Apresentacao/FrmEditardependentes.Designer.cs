namespace Adicionar_Funcionário
{
    partial class frmEditarDependentes
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
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txbGrauParentesco = new System.Windows.Forms.TextBox();
            this.lblGrauParentesco = new System.Windows.Forms.Label();
            this.txbUF = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txbNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.txbCodigoDependentes = new System.Windows.Forms.TextBox();
            this.lblCodigoDependentes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(442, 352);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 82;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(176, 352);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 79;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txbGrauParentesco
            // 
            this.txbGrauParentesco.Location = new System.Drawing.Point(135, 244);
            this.txbGrauParentesco.Name = "txbGrauParentesco";
            this.txbGrauParentesco.Size = new System.Drawing.Size(269, 20);
            this.txbGrauParentesco.TabIndex = 78;
            // 
            // lblGrauParentesco
            // 
            this.lblGrauParentesco.AutoSize = true;
            this.lblGrauParentesco.Location = new System.Drawing.Point(31, 247);
            this.lblGrauParentesco.Name = "lblGrauParentesco";
            this.lblGrauParentesco.Size = new System.Drawing.Size(102, 13);
            this.lblGrauParentesco.TabIndex = 77;
            this.lblGrauParentesco.Text = "Grau de Parentesco";
            // 
            // txbUF
            // 
            this.txbUF.Location = new System.Drawing.Point(697, 155);
            this.txbUF.Name = "txbUF";
            this.txbUF.Size = new System.Drawing.Size(47, 20);
            this.txbUF.TabIndex = 76;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(670, 159);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(21, 13);
            this.lblUF.TabIndex = 75;
            this.lblUF.Text = "UF";
            // 
            // txbBairro
            // 
            this.txbBairro.ForeColor = System.Drawing.Color.Gray;
            this.txbBairro.Location = new System.Drawing.Point(553, 156);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(100, 20);
            this.txbBairro.TabIndex = 74;
            this.txbBairro.Text = "Bairro";
            // 
            // txbNumero
            // 
            this.txbNumero.ForeColor = System.Drawing.Color.Gray;
            this.txbNumero.Location = new System.Drawing.Point(456, 156);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(71, 20);
            this.txbNumero.TabIndex = 73;
            this.txbNumero.Text = "Numero";
            // 
            // txbEndereco
            // 
            this.txbEndereco.ForeColor = System.Drawing.Color.Gray;
            this.txbEndereco.Location = new System.Drawing.Point(78, 156);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(351, 20);
            this.txbEndereco.TabIndex = 72;
            this.txbEndereco.Text = "Rua";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(24, 159);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 71;
            this.lblEndereco.Text = "Endereço";
            // 
            // txbNomeCompleto
            // 
            this.txbNomeCompleto.Location = new System.Drawing.Point(409, 59);
            this.txbNomeCompleto.Name = "txbNomeCompleto";
            this.txbNomeCompleto.Size = new System.Drawing.Size(269, 20);
            this.txbNomeCompleto.TabIndex = 70;
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(325, 62);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(82, 13);
            this.lblNomeCompleto.TabIndex = 69;
            this.lblNomeCompleto.Text = "Nome Completo";
            // 
            // txbCodigoDependentes
            // 
            this.txbCodigoDependentes.Location = new System.Drawing.Point(150, 62);
            this.txbCodigoDependentes.Name = "txbCodigoDependentes";
            this.txbCodigoDependentes.Size = new System.Drawing.Size(101, 20);
            this.txbCodigoDependentes.TabIndex = 68;
            // 
            // lblCodigoDependentes
            // 
            this.lblCodigoDependentes.AutoSize = true;
            this.lblCodigoDependentes.Location = new System.Drawing.Point(26, 65);
            this.lblCodigoDependentes.Name = "lblCodigoDependentes";
            this.lblCodigoDependentes.Size = new System.Drawing.Size(122, 13);
            this.lblCodigoDependentes.TabIndex = 67;
            this.lblCodigoDependentes.Text = "Código de Dependentes";
            // 
            // frmEditarDependentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txbGrauParentesco);
            this.Controls.Add(this.lblGrauParentesco);
            this.Controls.Add(this.txbUF);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.txbBairro);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txbNomeCompleto);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.txbCodigoDependentes);
            this.Controls.Add(this.lblCodigoDependentes);
            this.Name = "frmEditarDependentes";
            this.Text = "Editar Dependentes";
            this.Load += new System.EventHandler(this.frmEditarDependentes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblGrauParentesco;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Label lblCodigoDependentes;
        public System.Windows.Forms.TextBox txbGrauParentesco;
        public System.Windows.Forms.TextBox txbUF;
        public System.Windows.Forms.TextBox txbBairro;
        public System.Windows.Forms.TextBox txbNumero;
        public System.Windows.Forms.TextBox txbEndereco;
        public System.Windows.Forms.TextBox txbNomeCompleto;
        public System.Windows.Forms.TextBox txbCodigoDependentes;
    }
}