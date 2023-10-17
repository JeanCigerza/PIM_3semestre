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
    public partial class FrmEditarCargosadosBanc : Form
    {
        public frmEditarDependentes Frm { get; set; }
        public FrmEditarCargosadosBanc() 
        {
            InitializeComponent();
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

        private void btnProximo_Click(object sender, EventArgs e)
        {

            frmEditarSenha frmEditarSenha = new frmEditarSenha() {Frm = this};
            frmEditarSenha.Show();
            this.Hide();
        }

        private void btnPróximo_Click(object sender, EventArgs e)
        {
            frmEditarSenha frmEditarSenha = new frmEditarSenha();
            frmEditarSenha.Show();
            this.Hide();
        }

        private void frmEditarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

        }

        private void lblDatAdmis_Click(object sender, EventArgs e)
        {

        }

        private void txbAdmissao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
