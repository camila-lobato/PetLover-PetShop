using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testeForm.models;
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
                comando.Parameters.AddWithValue("@fkIdDono", pet._dono);
                comando.ExecuteNonQuery();
                Console.WriteLine("Pet cadastrado com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro ao salvar o cadastro!" + ex.Message);
            }
        }
    }
}
