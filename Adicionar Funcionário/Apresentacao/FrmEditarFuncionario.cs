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
    public partial class FrmEditarFuncionario : Form
    {
        public FrmEditarFuncionario()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnProximo_Click(object sender, EventArgs e)
        {
            frmEditarDependentes frmEditarDependentes = new frmEditarDependentes() { Frm = this };
            frmEditarDependentes.Show();
            this.Hide();
        }

        private void FrmEditarFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
