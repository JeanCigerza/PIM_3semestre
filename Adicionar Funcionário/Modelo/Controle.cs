using Adicionar_Funcionário.DAL;
using Adicionar_Funcionário.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adicionar_Funcionario.Modelo
{
    public class Controle
    {
        public string mensagem;

        public void adicionarFuncionario(List<String> listaDadosFuncionario)
        {
            Validacao validacao = new Validacao();
            validacao.validarDadosFuncionario(listaDadosFuncionario);
            if (validacao.mensagem.Equals(""))
            {
                Funcionario funcionario = new Funcionario ();
                funcionario.nome = listaDadosFuncionario[0];
                funcionario.rg = listaDadosFuncionario[1];
                funcionario.cpf = listaDadosFuncionario[2];
                funcionarioDAO funcionarioDAO = new funcionarioDAO();
                funcionarioDAO.adicionarFuncionario(funcionario);
                this.mensagem = funcionarioDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }

        }
    }
}
