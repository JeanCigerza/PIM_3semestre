using Adicionar_Funcionário.Apresentacao;
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
    public partial class frmEditarDependentes : Form
    {
        public FrmEditarFuncionario Frm { get; set; }
        public frmEditarDependentes()

        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void btnProximo_Click(object sender, EventArgs e)
        {
            FrmEditarCargosadosBanc frmEditarCargosadosBanc = new FrmEditarCargosadosBanc();
            frmEditarCargosadosBanc.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmMenu FrmMenu = new FrmMenu();
            FrmMenu.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {

                if (control is TextBox)
                {

                    ((TextBox)control).Clear();
                }
            }
        }

        private void frmEditarDependentes_Load(object sender, EventArgs e)
        {

        }
    }
}
