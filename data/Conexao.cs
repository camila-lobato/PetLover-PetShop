using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeForm.data
{
    internal static class Conexao
    {
        static MySqlConnection conexao;
        static string strconexao = "server=localhost;uid=root;pwd=root;database=petLover";
        public static MySqlConnection Conectar()
        {
            try
            {
                conexao = new MySqlConnection(strconexao);
                conexao.Open();
                Console.WriteLine("Conectado com sucesso!");
                return conexao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao realizar conexão com a base de dados!" + ex.Message);
            }

        }
        public static void FecharConexao()
        {
            conexao.Close();
        }
    }
}
