using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adicionar_Funcionário.Modelo
{

    public class Validacao
    {
        public string mensagem;

        public void validarDadosFuncionario(List<String> listaDadosFuncionario)
        {
            frmAdicionarFuncionario frmAdicionarFuncionario = new frmAdicionarFuncionario();

            this.mensagem = "";

            if (
                listaDadosFuncionario[0].Length < 3) _= frmAdicionarFuncionario.txbNomeCompleto.Text;


            if (listaDadosFuncionario[0].Length < 3)
                this.mensagem += "Nome deve ter mais que 3 caracteres\n";
            if (listaDadosFuncionario[0].Length > 50)
                this.mensagem += "Nome deve ter menos que 50 caracteres\n";
            if (listaDadosFuncionario[1].Length > 10)
                this.mensagem += "Data de nascimento deve ter menos que 10 caracteres\n";
            if (listaDadosFuncionario[7].Length > 13)
                this.mensagem += "CPF deve ter menos que 13 caracteres\n";
            if (listaDadosFuncionario[5].Length > 11)
                this.mensagem += "RG listaDadosPessoadeve ter menos que 11 caracteres\n";
            if (listaDadosFuncionario[6].Length > 12)
                this.mensagem += "PIS deve ter menos 12 caracteres\n";
        }
    }

}
















