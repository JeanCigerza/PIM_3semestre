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

namespace Adicionar_Funcionário
{
    public partial class frmCadSenha : Form
    {
        public FrmCadCargo Frm { get; set; }
        public Funcionario Funcionario { get; set; }
        public frmCadSenha()
        {
            InitializeComponent();
        }

        private void lblCadastrarSenha_Load(object sender, EventArgs e)
        {
 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmMenu FrmMenu = new FrmMenu();
            FrmMenu.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            List<string> listaDadosFuncionario = new List<string>();
            
            listaDadosFuncionario.Add(txbID.Text);
            listaDadosFuncionario.Add(txbCriarSenha.Text);
            listaDadosFuncionario.Add(txbConfirmarSenha.Text);
            Controle controle = new Controle();
            
            frmAdicionarFuncionario frmAdicionarFuncionario =Frm.Frm.Frm;
            listaDadosFuncionario.Add(frmAdicionarFuncionario.txbNomeCompleto.Text);
            listaDadosFuncionario.Add(frmAdicionarFuncionario.txbDataNascimento.Text);
            listaDadosFuncionario.Add(frmAdicionarFuncionario.txbGenero.Text);
            listaDadosFuncionario.Add(frmAdicionarFuncionario.txbEstadoCivil.Text);
            listaDadosFuncionario.Add(frmAdicionarFuncionario.txbNacionalidade.Text);
            listaDadosFuncionario.Add(frmAdicionarFuncionario.txbRG.Text);
            listaDadosFuncionario.Add(frmAdicionarFuncionario.txbPIS.Text);
            listaDadosFuncionario.Add(frmAdicionarFuncionario.txbCPF.Text);
            listaDadosFuncionario.Add(frmAdicionarFuncionario.txbEndereco.Text);
            listaDadosFuncionario.Add(frmAdicionarFuncionario.txbNumero.Text);
            listaDadosFuncionario.Add(frmAdicionarFuncionario.txbBairro.Text);
            listaDadosFuncionario.Add(frmAdicionarFuncionario.txbUF.Text);
            listaDadosFuncionario.Add(frmAdicionarFuncionario.txbTelefone.Text);
            listaDadosFuncionario.Add(frmAdicionarFuncionario.txbCEP.Text);
            listaDadosFuncionario.Add(frmAdicionarFuncionario.txbLogradouro.Text);
            listaDadosFuncionario.Add(frmAdicionarFuncionario.txbEmail.Text);

            frmCadastroDependentes frmCadastroDependentes = Frm.Frm;
            listaDadosFuncionario.Add(frmCadastroDependentes.txbCodigoDependentes.Text);
            listaDadosFuncionario.Add(frmCadastroDependentes.txbNomeCompleto.Text);
            listaDadosFuncionario.Add(frmCadastroDependentes.txbEndereco.Text);
            listaDadosFuncionario.Add(frmCadastroDependentes.txbNumero.Text);
            listaDadosFuncionario.Add(frmCadastroDependentes.txbBairro.Text);
            listaDadosFuncionario.Add(frmCadastroDependentes.txbUF.Text);
            listaDadosFuncionario.Add(frmCadastroDependentes.txbGrauParentesco.Text);

            FrmCadCargo frmCadCargo = Frm;
            listaDadosFuncionario.Add(frmCadCargo.txbIDCargo.Text);
            listaDadosFuncionario.Add(frmCadCargo.txbCargo.Text);
            listaDadosFuncionario.Add(frmCadCargo.txbAdmissao.Text);
            listaDadosFuncionario.Add(frmCadCargo.txbJornada.Text);
            listaDadosFuncionario.Add(frmCadCargo.txbSalarioMensal.Text);
            listaDadosFuncionario.Add(frmCadCargo.txbSalarioDia.Text);
            listaDadosFuncionario.Add(frmCadCargo.txbBanco.Text);
            listaDadosFuncionario.Add(frmCadCargo.txbAgencia.Text);
            listaDadosFuncionario.Add(frmCadCargo.txbConta.Text);

            controle.adicionarFuncionario(listaDadosFuncionario);
            MessageBox.Show(controle.mensagem);
        }
    }
   }
