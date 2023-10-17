using Adicionar_Funcionario.Modelo;
using Adicionar_Funcionário.Modelo;
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

namespace Adicionar_Funcionário.Apresentacao
{
    public partial class frmEditarSenha : Form
    {
        public FrmEditarCargosadosBanc Frm { get; set; }
        public Funcionario Funcionario { get; set; }

        public frmEditarSenha()
        {
            InitializeComponent();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.ShowDialog();
            this.Close();
        }

        private void btnEditarSenha_Click(object sender, EventArgs e)
        {
            List<string> listaDadosFuncionario = new List<string>();

            listaDadosFuncionario.Add(txbID.Text);
            listaDadosFuncionario.Add(txbCriarSenha.Text);
            listaDadosFuncionario.Add(txbConfirmarSenha.Text);
            Controle controle = new Controle();

            FrmEditarFuncionario frmEditarFuncionario = Frm.Frm.Frm;
            listaDadosFuncionario.Add(frmEditarFuncionario.txbDataNascimento.Text);
            listaDadosFuncionario.Add(frmEditarFuncionario.txbGenero.Text);
            listaDadosFuncionario.Add(frmEditarFuncionario.txbEstadoCivil.Text);
            listaDadosFuncionario.Add(frmEditarFuncionario.txbNacionalidade.Text);
            listaDadosFuncionario.Add(frmEditarFuncionario.txbRG.Text);
            listaDadosFuncionario.Add(frmEditarFuncionario.txbPIS.Text);
            listaDadosFuncionario.Add(frmEditarFuncionario.txbCPF.Text);
            listaDadosFuncionario.Add(frmEditarFuncionario.txbEndereco.Text);
            listaDadosFuncionario.Add(frmEditarFuncionario.txbNumero.Text);
            listaDadosFuncionario.Add(frmEditarFuncionario.txbBairro.Text);
            listaDadosFuncionario.Add(frmEditarFuncionario.txbUF.Text);
            listaDadosFuncionario.Add(frmEditarFuncionario.txbTelefone.Text);
            listaDadosFuncionario.Add(frmEditarFuncionario.txbCEP.Text);
            listaDadosFuncionario.Add(frmEditarFuncionario.txbLogradouro.Text);
            listaDadosFuncionario.Add(frmEditarFuncionario.txbEmail.Text);

            frmEditarDependentes frmEditarDependentes = Frm.Frm;
            listaDadosFuncionario.Add(frmEditarDependentes.txbCodigoDependentes.Text);
            listaDadosFuncionario.Add(frmEditarDependentes.txbNomeCompleto.Text);
            listaDadosFuncionario.Add(frmEditarDependentes.txbEndereco.Text);
            listaDadosFuncionario.Add(frmEditarDependentes.txbNumero.Text);
            listaDadosFuncionario.Add(frmEditarDependentes.txbBairro.Text);
            listaDadosFuncionario.Add(frmEditarDependentes.txbUF.Text);
            listaDadosFuncionario.Add(frmEditarDependentes.txbGrauParentesco.Text);

            FrmEditarCargosadosBanc frmEditarCargosadosBanc = Frm;
            listaDadosFuncionario.Add(frmEditarCargosadosBanc.txbIDCargo.Text);
            listaDadosFuncionario.Add(frmEditarCargosadosBanc.txbCargo.Text);
            listaDadosFuncionario.Add(frmEditarCargosadosBanc.txbAdmissao.Text);
            listaDadosFuncionario.Add(frmEditarCargosadosBanc.txbJornada.Text);
            listaDadosFuncionario.Add(frmEditarCargosadosBanc.txbSalarioMensal.Text);
            listaDadosFuncionario.Add(frmEditarCargosadosBanc.txbSalarioDia.Text);
            listaDadosFuncionario.Add(frmEditarCargosadosBanc.txbBanco.Text);
            listaDadosFuncionario.Add(frmEditarCargosadosBanc.txbAgencia.Text);
            listaDadosFuncionario.Add(frmEditarCargosadosBanc.txbConta.Text);

        }

        private void frmEditarSenha_Load(object sender, EventArgs e)
        {

        }
    }
}
