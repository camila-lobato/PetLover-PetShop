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
                comando.Parameters.AddWithValue("@fkIdDono", pet._dono);
                comando.ExecuteNonQuery();
                MessageBox.Show("Pet cadastrado com sucesso!", "PetLover", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao salvar o cadastro! " + ex.Message, "PetLover", MessageBoxButtons.OK);
            }
        }
    }
}
