using DesktopPim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adicionar_Funcionário
{
    public partial class frmAdicionarFuncionario : Form
    {
        public frmAdicionarFuncionario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmMenu FrmMenu = new FrmMenu();
            FrmMenu.Show();
            this.Hide();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            frmCadastroDependentes frmCadastroDependentes= new frmCadastroDependentes() { Frm = this };
            frmCadastroDependentes.Show();
            this.Hide();
        }

        private void txbNomeCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbCPF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
