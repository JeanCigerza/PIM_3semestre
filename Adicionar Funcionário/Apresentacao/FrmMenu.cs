using Adicionar_Funcionário;
using Adicionar_Funcionário.Apresentacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopPim
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnAdcFunc_Click(object sender, EventArgs e)
        {
            frmAdicionarFuncionario frmAdicionarFuncionario = new frmAdicionarFuncionario();
            frmAdicionarFuncionario.Show();
            this.Hide();
        }

        private void btnCadDependente_Click(object sender, EventArgs e)
        {
            frmCadastroDependentes frmCadastroDependentes = new frmCadastroDependentes();
            frmCadastroDependentes.Show();
            this.Hide();
        }

        private void btnCadCargo_Click(object sender, EventArgs e)
        {
            FrmCadCargo frmCadCargo = new FrmCadCargo();
            frmCadCargo.Show();
            this.Hide();
        }

        private void btnListFunc_Click(object sender, EventArgs e)
        {
            FrmPesquisarFunc frmListadeFuncionarios = new FrmPesquisarFunc();
            frmListadeFuncionarios.Show();
            this.Hide();
        }

        private void btnListEdnderco_Click(object sender, EventArgs e)
        {
            FrmLista_de_Endereço frmLista_De_Endereço = new FrmLista_de_Endereço();
            frmLista_De_Endereço.Show();
            this.Hide();
        }

        private void btnListDependente_Click(object sender, EventArgs e)
        {
            frmListaDependentes frmListaDependentes = new frmListaDependentes();
            frmListaDependentes.Show();
            this.Hide();
        }


        private void btnApagarFunc_Click(object sender, EventArgs e)
        {
            FrmPesquisarApagar frmPesquisarApagar = new FrmPesquisarApagar();
            frmPesquisarApagar.Show();
        }

        private void btnEditarFunc_Click(object sender, EventArgs e)
        {
            FrmEditarFuncionario frmEditarFuncionario = new FrmEditarFuncionario();
            frmEditarFuncionario.Show();
            this.Hide();
        }

        private void btnEditDependentes_Click(object sender, EventArgs e)
        {
            frmEditarDependentes frmEditarDependentes = new frmEditarDependentes();
            frmEditarDependentes.Show();
        }

        private void btnCadSenha_Click(object sender, EventArgs e)
        {
            frmCadSenha frmCadSenha = new frmCadSenha();
            frmCadSenha.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFolha_de_pagamento frmFolha_De_Pagamento = new FrmFolha_de_pagamento();
            frmFolha_De_Pagamento.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCargos frmCargos = new FrmCargos();
            frmCargos.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Até Logo!");
            Application.Exit();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
