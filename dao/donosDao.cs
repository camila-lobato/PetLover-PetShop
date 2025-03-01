using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testeForm.data;
using testeForm.models;

namespace testeForm.dao
{
    internal class donosDao
    {
        public void InsertDono(Donos dono)
        {
            try
            {
                string sqlSalvar = "INSERT INTO donos(nome, telefone, cpf) VALUES (@nome, @telefone, @cpf);";
                MySqlCommand comando = new MySqlCommand(sqlSalvar, Conexao.Conectar());
                comando.Parameters.AddWithValue("@nome", dono._nome);
                comando.Parameters.AddWithValue("@telefone", dono._telefone);
                comando.Parameters.AddWithValue("@cpf", dono._cpf);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dono cadastrado com sucesso!", "PetLover", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o cadastro! " + ex.Message, "PetLover", MessageBoxButtons.OK);
            }
        }

        public void DeleteDono(int idDono)
        {
            try
            {
                Donos dono = new Donos();
                string sqlDeletar = "DELETE FROM donos WHERE idDono = @idDono";
                MySqlCommand comando = new MySqlCommand(sqlDeletar, Conexao.Conectar());
                comando.Parameters.AddWithValue("@idDono", dono._idDono);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro excluído com sucesso!");
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir cadastro: {ex.Message}.");
            }
           
        }

        public List <Donos> ListarDonos()
        {
        List<Donos> Listadonos = new List<Donos>();
            try
            {
                var sql = "SELECT * FROM Donos ORDER BY nome";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                MySqlDataReader reader = comando.ExecuteReader();
                
                while (reader.Read())
                {
                    Donos dono = new Donos();
                    dono._idDono = reader.GetInt32("idDono");
                    dono._nome = reader.GetString("nome");
                    dono._telefone = reader.GetString("telefone");
                    dono._cpf = reader.GetString("cpf");
                    Listadonos.Add(dono);
                }
                
                Conexao.FecharConexao();
            }catch (Exception ex) 
            {
                throw new Exception("Erro ao listar cadastros!" + ex.Message);
            }
            return Listadonos;
        }

        public void UpdateDono(Donos dono)
        {
            try
            {
                string sql = "UPDATE Donos SET idDono = @idDono, nome = @nomeDono, telefone = @telefoneDono, cpf = @cpfDono WHERE idDono = @idDono";
                using MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                {
                    comando.Parameters.AddWithValue("@idDono", dono._idDono);
                    comando.Parameters.AddWithValue("@nomeDono", dono._nome);
                    comando.Parameters.AddWithValue("@telefoneDono", dono._telefone);
                    comando.Parameters.AddWithValue("@cpfDono", dono._cpf);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro atualizado com sucesso!", "PetLover", MessageBoxButtons.OK);
                }
               
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar cadastro" + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }
    }
}
