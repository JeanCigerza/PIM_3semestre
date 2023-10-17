namespace DesktopPim
{
    partial class FrmMenu
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
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.btnAdcFunc = new System.Windows.Forms.Button();
            this.btnListFunc = new System.Windows.Forms.Button();
            this.btnEditarFunc = new System.Windows.Forms.Button();
            this.btnApagarFunc = new System.Windows.Forms.Button();
            this.btnFolha_de_Pagamento = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPrincipal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMenuPrincipal.Location = new System.Drawing.Point(174, 44);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(123, 39);
            this.lblMenuPrincipal.TabIndex = 0;
            this.lblMenuPrincipal.Text = "MENU";
            this.lblMenuPrincipal.UseWaitCursor = true;
            // 
            // btnAdcFunc
            // 
            this.btnAdcFunc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdcFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdcFunc.Location = new System.Drawing.Point(66, 130);
            this.btnAdcFunc.Name = "btnAdcFunc";
            this.btnAdcFunc.Size = new System.Drawing.Size(90, 61);
            this.btnAdcFunc.TabIndex = 1;
            this.btnAdcFunc.Text = "Adicionar funcionario";
            this.btnAdcFunc.UseVisualStyleBackColor = false;
            this.btnAdcFunc.UseWaitCursor = true;
            this.btnAdcFunc.Click += new System.EventHandler(this.btnAdcFunc_Click);
            // 
            // btnListFunc
            // 
            this.btnListFunc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListFunc.Location = new System.Drawing.Point(66, 280);
            this.btnListFunc.Name = "btnListFunc";
            this.btnListFunc.Size = new System.Drawing.Size(90, 55);
            this.btnListFunc.TabIndex = 4;
            this.btnListFunc.Text = "Pesquisar Funcionario";
            this.btnListFunc.UseVisualStyleBackColor = false;
            this.btnListFunc.UseWaitCursor = true;
            this.btnListFunc.Click += new System.EventHandler(this.btnListFunc_Click);
            // 
            // btnEditarFunc
            // 
            this.btnEditarFunc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarFunc.Location = new System.Drawing.Point(312, 130);
            this.btnEditarFunc.Name = "btnEditarFunc";
            this.btnEditarFunc.Size = new System.Drawing.Size(95, 61);
            this.btnEditarFunc.TabIndex = 8;
            this.btnEditarFunc.Text = "Editar Funcionarios";
            this.btnEditarFunc.UseVisualStyleBackColor = false;
            this.btnEditarFunc.UseWaitCursor = true;
            this.btnEditarFunc.Click += new System.EventHandler(this.btnEditarFunc_Click);
            // 
            // btnApagarFunc
            // 
            this.btnApagarFunc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnApagarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarFunc.Location = new System.Drawing.Point(309, 212);
            this.btnApagarFunc.Name = "btnApagarFunc";
            this.btnApagarFunc.Size = new System.Drawing.Size(95, 54);
            this.btnApagarFunc.TabIndex = 12;
            this.btnApagarFunc.Text = "Apagar Funcionário";
            this.btnApagarFunc.UseVisualStyleBackColor = false;
            this.btnApagarFunc.UseWaitCursor = true;
            this.btnApagarFunc.Click += new System.EventHandler(this.btnApagarFunc_Click);
            // 
            // btnFolha_de_Pagamento
            // 
            this.btnFolha_de_Pagamento.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFolha_de_Pagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnFolha_de_Pagamento.Location = new System.Drawing.Point(312, 280);
            this.btnFolha_de_Pagamento.Name = "btnFolha_de_Pagamento";
            this.btnFolha_de_Pagamento.Size = new System.Drawing.Size(92, 55);
            this.btnFolha_de_Pagamento.TabIndex = 13;
            this.btnFolha_de_Pagamento.Text = "Gerar folha de pagamento";
            this.btnFolha_de_Pagamento.UseVisualStyleBackColor = false;
            this.btnFolha_de_Pagamento.UseWaitCursor = true;
            this.btnFolha_de_Pagamento.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(66, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 55);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cargos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(387, 433);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(88, 24);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair do Menu";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.UseWaitCursor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(488, 475);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnFolha_de_Pagamento);
            this.Controls.Add(this.btnApagarFunc);
            this.Controls.Add(this.btnEditarFunc);
            this.Controls.Add(this.btnListFunc);
            this.Controls.Add(this.btnAdcFunc);
            this.Controls.Add(this.lblMenuPrincipal);
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.UseWaitCursor = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenu_FormClosed);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.Button btnAdcFunc;
        private System.Windows.Forms.Button btnListFunc;
        private System.Windows.Forms.Button btnEditarFunc;
        private System.Windows.Forms.Button btnApagarFunc;
        private System.Windows.Forms.Button btnFolha_de_Pagamento;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSair;
    }
}

