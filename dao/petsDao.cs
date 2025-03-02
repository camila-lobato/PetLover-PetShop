using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testeForm.models;
using testeForm.data;
using MySql.Data.MySqlClient;

namespace testeForm.dao
{
    internal class petsDao
    {
        public void InsertPet(Pets pet)
        {
            try
            {
                string sqlSalvar = "INSERT INTO pets(nomePet, idade, especie, raca, fkIdDono) VALUES (@nomePet, @idade, @especie, @raca, @fkIdDono);";
                MySqlCommand comando = new MySqlCommand(sqlSalvar, Conexao.Conectar());
                comando.Parameters.AddWithValue("@nomePet", pet._nomePet);
                comando.Parameters.AddWithValue("@idade", pet._idade);
                comando.Parameters.AddWithValue("@especie", pet._especie);
                comando.Parameters.AddWithValue("@raca", pet._raca);
                comando.Parameters.AddWithValue("@fkIdDono", pet._dono._idDono);
                comando.ExecuteNonQuery();
                MessageBox.Show("Pet cadastrado com sucesso!", "PetLover", MessageBoxButtons.OK);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao salvar o cadastro! " + ex.Message, "PetLover", MessageBoxButtons.OK);
            }
        }

        public void DeletePet(int idPet)
        {
            try
            {
                Pets pet = new Pets();
                string sqlDeletar = "DELETE FROM pets WHERE idPet = @idPet";
                MySqlCommand comando = new MySqlCommand(sqlDeletar, Conexao.Conectar());
                comando.Parameters.AddWithValue("@idPet", idPet);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro excluído com sucesso!");
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir cadastro: {ex.Message}.");
            }

        }

        public List<Pets> ListarPets()
        {
            List<Pets> ListaPets = new List<Pets>();
            try
            {

                var sql = "SELECT Pets.idPet, Pets.nomePet, Pets.idade, Pets.especie, Pets.raca FROM Pets ORDER BY nomePet";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Pets pet = new Pets();
                    pet._idPet = reader.GetInt32("idPet");
                    pet._nomePet = reader.GetString("nomePet");
                    pet._idade = reader.GetString("idade");
                    pet._especie = reader.GetString("especie");
                    pet._raca = reader.GetString("raca"); 
                    ListaPets.Add(pet);
                }
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar cadastros!" + ex.Message);
            }
            return ListaPets;
        }

        public void UpdatePets(Pets pet)
        {
            try
            {
                string sql = "UPDATE Pets SET nomePet = @nomePet, idade = @idade, especie = @especie, raca = @raca, fkidDono = @fkIdDono WHERE idPet = @idPet";
                using (MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar()))
                {
                    comando.Parameters.AddWithValue("@idPet", pet._idPet);
                    comando.Parameters.AddWithValue("@nomePet", pet._nomePet);
                    comando.Parameters.AddWithValue("@idade", pet._idade);
                    comando.Parameters.AddWithValue("@especie", pet._especie);
                    comando.Parameters.AddWithValue("@raca", pet._raca);
                    comando.Parameters.AddWithValue("@fkIdDono", pet._dono._idDono);
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
