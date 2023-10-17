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
    public partial class FrmPesquisarApagar : Form
    {
        public FrmPesquisarApagar()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            frmApagarFuncionario frmApagarFuncionario = new frmApagarFuncionario();
            frmApagarFuncionario.ShowDialog();
        }

        private void btnPróximo_Click(object sender, EventArgs e)
        {
            frmApagarFuncionario frmApagarFuncionario = new frmApagarFuncionario();
            frmApagarFuncionario.ShowDialog();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void lblCPF_Click(object sender, EventArgs e)
        {

        }

        private void lblNomeCompleto_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
