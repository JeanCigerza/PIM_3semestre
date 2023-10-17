using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adicionar_Funcionario.Modelo;
using Adicionar_Funcionário.Modelo;

namespace Adicionar_Funcionário.DAL
{
    public class funcionarioDAO
    {
        Conexão con = new Conexão();
        SqlDataReader dr;
        public string mensagem;

        public void adicionarFuncionario(Funcionario funcionario)
        {
            this.mensagem = "";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"insert into pessoas (nome,data_nascimento,genero, estado_civil, nacionalidade, rg, pis, cpf, endereço,
telefone, cep, email, id_dependente, id_cargo, cargo, data_admissao, jornada_trabalho, salario_mensal, salario_dia, agencia, conta,
banco) 
                            values (@nome,@data_nascimento, @genero, @estado_civil, @nacionalidade, @rg, @pis, @cpf, @endereço,
@telefone, @cep, @email, @id_dependente, @id_cargo, @cargo, @data_admissao, @jornada_trabalho, @salario_mensal, @salario_dia, 
@agencia, @conta, @banco);)";

            cmd.Parameters.AddWithValue("@nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@data_nascimento", funcionario.data_nascimento);
            cmd.Parameters.AddWithValue("@genero", funcionario.genero);
            cmd.Parameters.AddWithValue("@estado_civil", funcionario.estado_civil);
            cmd.Parameters.AddWithValue("@nacionalidade", funcionario.nacionalidade);
            cmd.Parameters.AddWithValue("@rg", funcionario.rg);
            cmd.Parameters.AddWithValue("@pis", funcionario.pis);
            cmd.Parameters.AddWithValue("@cpf", funcionario.cpf);
            cmd.Parameters.AddWithValue("@endereco", funcionario.endereco);
            cmd.Parameters.AddWithValue("@telefone", funcionario.telefone);
            cmd.Parameters.AddWithValue("@cep", funcionario.cep);
            cmd.Parameters.AddWithValue("@email", funcionario.email);
            cmd.Parameters.AddWithValue("@id_dependente", funcionario.id_Dependente);
            cmd.Parameters.AddWithValue("@id_cargo", funcionario.id_Cargo);
            cmd.Parameters.AddWithValue("@cargo", funcionario.cargo);
            cmd.Parameters.AddWithValue("@data_admissao", funcionario.data_admissao);
            cmd.Parameters.AddWithValue("@jornada_trabalho", funcionario.jornada_trabalho);
            cmd.Parameters.AddWithValue("@salario_mensal", funcionario.salario_mensal);
            cmd.Parameters.AddWithValue("@salario_dia", funcionario.salario_dia);
            cmd.Parameters.AddWithValue("@agencia", funcionario.agencia);
            cmd.Parameters.AddWithValue("@conta", funcionario.conta);
            cmd.Parameters.AddWithValue("@banco", funcionario.banco);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Funcionário adicionado com sucesso!";
            }
            catch (Exception e)
            {
                this.mensagem = "Erro de BD";
            }
        }
    }

    internal class Conexão
    {
        public Conexão()
        {
        }

        internal MySqlConnection conectar()
        {
            throw new NotImplementedException();
        }

        internal void desconectar()
        {
            throw new NotImplementedException();
        }
    }
}
