using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using testeForm.dao;
using testeForm.models;

namespace testeForm.Forms
{
    public partial class CadastroPets : Form
    {
        public CadastroPets()
        {
            InitializeComponent();
        }

        private void btSalvarPet_Click(object sender, EventArgs e)
        {
            if (txtDonoPet != null && txtIdadePet!=null && txtRacaPet!=null && txtEspeciePet!=null && txtDonoPet!= null) 
            {
                petsDao pDao = new petsDao();
                Pets pet = new Pets();
                pet._nomePet = txtNomePet.Text;
                pet._idade = txtIdadePet.Text;
                pet._raca = txtRacaPet.Text;
                pet._especie = txtEspeciePet.Text;
                pet._dono._nome = txtDonoPet.Text;
                pDao.InsertPet(pet);

                txtNomePet.Clear();
                txtIdadePet.Clear();
                txtRacaPet.Clear();
                txtEspeciePet.Clear();
                txtDonoPet.Clear();
                txtNomePet.Select();

            }
            else
            {
                Console.WriteLine("Preencha todos os dados corretamente!");
            }
           

        }

        private void btCancelarPet_Click(object sender, EventArgs e)
        {
            txtNomePet.Clear();
            txtIdadePet.Clear();
            txtRacaPet.Clear();
            txtEspeciePet.Clear();
            txtDonoPet.Clear();
            this.Close();
        }
    }
}
