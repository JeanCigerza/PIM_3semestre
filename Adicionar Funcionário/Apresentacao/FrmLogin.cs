using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Adicionar_Funcionário.DAL;

namespace DesktopPim
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btNAvançar_Click(object sender, EventArgs e)
        {
            String User = "admin";
            String Password = "1234";
            Conexao cnx = new Conexao();
            cnx.conectar();
            if (txtUsuario.Text == User & txtSenha.Text == Password)
            {
                MessageBox.Show("Acesso Liberado");
                FrmMenu FrmMenu = new FrmMenu();
                FrmMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario/Senha Incorrenta!");
            }
        }
    }
}
