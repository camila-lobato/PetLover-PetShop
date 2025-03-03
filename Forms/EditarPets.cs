using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testeForm.dao;
using testeForm.models;

namespace testeForm.Forms
{
    public partial class EditarPets : Form
    {
        public EditarPets()
        {
            InitializeComponent();
        }

       
        private void btCancelarEditPets_Click(object sender, EventArgs e)
        {
            txtNomePet.Clear();
            txtIdadePet.Clear();
            txtEspeciePet.Clear();
            txtRacaPet.Clear();
            txtIdadePet.Clear();
            cbDonoEditarPet.SelectedIndex = -1;
            this.Close();
        }
        public void DonosEditarCb()
        {
            donosDao dDao = new donosDao();
            List<Donos> listDonos = dDao.ListarDonos();

            if (listDonos == null || listDonos.Count == 0)
            {
                MessageBox.Show("Nenhum cadastro de dono encontrado no banco!", "PetLover", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cbDonoEditarPet.DataSource = null;
            cbDonoEditarPet.DataSource = listDonos;
            cbDonoEditarPet.DisplayMember = "_nome";
            cbDonoEditarPet.ValueMember = "_idDono";
            cbDonoEditarPet.SelectedIndex = -1;

        }



        private void btAlterarPet_Click(object sender, EventArgs e)
        {
            petsDao pDao = new petsDao();
            Pets pet = new Pets();

            if (txtIdPet.Text.Trim() != "" && txtNomePet.Text.Trim() != "" && txtIdadePet.Text.Trim() != "" && txtRacaPet.Text.Trim() != "" && txtEspeciePet.Text.Trim() != "" && cbDonoEditarPet.SelectedIndex != -1)
            {
                pet._idPet = Convert.ToInt32(txtIdPet.Text);
                int idDonoSelecionado = Convert.ToInt32(cbDonoEditarPet.SelectedValue);
                pet._nomePet = txtNomePet.Text;
                pet._idade = txtIdadePet.Text;
                pet._raca = txtRacaPet.Text;
                pet._especie = txtEspeciePet.Text;
                pet._dono = (Donos)cbDonoEditarPet.SelectedItem;
                pDao.UpdatePets(pet);
                txtNomePet.Clear();
                txtIdadePet.Clear();
                txtEspeciePet.Clear();
                txtRacaPet.Clear();
                txtIdadePet.Clear();
                txtIdPet.Clear();
                cbDonoEditarPet.SelectedIndex = -1;       
            }
            else
            {
                MessageBox.Show("Preencha todos os dados corretamente!", "PetLover", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           
            

        }

        private void EditarPets_Load(object sender, EventArgs e)
        {
            DonosEditarCb();
        }
    }
}

