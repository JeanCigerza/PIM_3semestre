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
    public partial class FrmPesquisarFunc : Form
    {
        public FrmPesquisarFunc()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void FrmListadeFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmMenu FrmMenu = new FrmMenu();
            FrmMenu.Show();
            this.Hide();
        }

        private void btnPróximo_Click(object sender, EventArgs e)
        {
            frmDadosFuncionario frmDadosFuncionario = new frmDadosFuncionario();
            frmDadosFuncionario.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
