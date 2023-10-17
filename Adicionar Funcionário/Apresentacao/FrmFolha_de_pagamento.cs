using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adicionar_Funcionário.Apresentacao
{
    public partial class FrmFolha_de_pagamento : Form
    {
        public FrmFolha_de_pagamento()
        {
            InitializeComponent();
        }

        private void Folha_de_pagamento_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSalário_Base_Click(object sender, EventArgs e)
        {

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
                frmRelatorioFolhadePagamento frmRelatorioFolhadePagamento = new frmRelatorioFolhadePagamento();
                frmRelatorioFolhadePagamento.Show();
                this.Hide();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
