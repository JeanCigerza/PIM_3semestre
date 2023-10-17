
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Adicionar_Funcionário.DAL
{
    public class Conexao
    {
        private MySqlConnection connection;
        private String stringConexao = "server=localhost;" +
            "database = folhadepagamento; uid = root; password = 121027";

        public Conexao()
        {
            connection = new MySqlConnection(stringConexao);
        }

        public MySqlConnection conectar()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                return connection;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool desconectar()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


    }
}
