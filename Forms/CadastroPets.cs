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

        public void AtualizarListaPets()
        {
            List<Pets> listPets = new List<Pets>();
            petsDao petsDao = new petsDao();
            listPets = petsDao.ListarPets();
        }
        private void btSalvarPet_Click(object sender, EventArgs e)
        {
            if (txtNomePet.Text.Trim() != "" && txtIdadePet.Text.Trim() != "" && txtRacaPet.Text.Trim() != "" && txtEspeciePet.Text.Trim() != "" && cbDonos.SelectedIndex != -1)
            {
                petsDao pDao = new petsDao();
                Pets pet = new Pets();
                int idDonoSelecionado = Convert.ToInt32(cbDonos.SelectedValue);
                pet._nomePet = txtNomePet.Text;
                pet._idade = txtIdadePet.Text;
                pet._raca = txtRacaPet.Text;
                pet._especie = txtEspeciePet.Text;
                pet._dono = (Donos)cbDonos.SelectedItem;
                pDao.InsertPet(pet);
                txtNomePet.Clear();
                txtIdadePet.Clear();
                txtRacaPet.Clear();
                txtEspeciePet.Clear();
                cbDonos.SelectedIndex = -1;
                AtualizarListaPets();

            }
            else
            {
                MessageBox.Show("Preencha todos os dados corretamente!", "PetLover", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancelarPet_Click(object sender, EventArgs e)
        {
            txtNomePet.Clear();
            txtIdadePet.Clear();
            txtRacaPet.Clear();
            txtEspeciePet.Clear();
            cbDonos.SelectedIndex = -1;
            this.Close();
        }

        private void cbDonos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void DonosCb()
        {
            donosDao dDao = new donosDao();
            List<Donos> listDonos = dDao.ListarDonos();
            Donos dono = new Donos();
            cbDonos.DataSource = null;
            cbDonos.DataSource = listDonos;
            cbDonos.DisplayMember = "_nome";
            cbDonos.ValueMember = "_idDono";
            cbDonos.SelectedIndex = -1;

        }

        private void CadastroPets_Load(object sender, EventArgs e)
        {
            DonosCb();
        }
    }
}
