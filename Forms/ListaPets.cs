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
    public partial class ListaPets : Form
    {
        public ListaPets()
        {
            InitializeComponent();
            petsDao pDao = new petsDao();
            pDao.ListarPets();
            List<Pets> listPets = pDao.ListarPets();
            dtgListPets.DataSource = null;
            dtgListPets.DataSource = listPets;

        }
        private void AtualizarListaPets()
        {
            petsDao petsDao = new petsDao();
            List<Pets> ListPets = petsDao.ListarPets();
            dtgListPets.DataSource = null;
            dtgListPets.DataSource = ListPets;
            dtgListPets.Refresh();
        }

        private void btPesquisaPet_Click(object sender, EventArgs e)
        {
            petsDao pDao = new petsDao();
            pDao.ListarPets();
            List<Pets> listPets = pDao.ListarPets();
            dtgListPets.DataSource = null;
            dtgListPets.DataSource = listPets;
            AtualizarListaPets();
          
        }

        private void btLimparGridPet_Click(object sender, EventArgs e)
        {
            dtgListPets.DataSource = null;
            dtgListPets.Rows.Clear();
        }

        private void btEditarPet_Click(object sender, EventArgs e)
        {
            EditarPets form = new EditarPets();
            form.ShowDialog();
            AtualizarListaPets();
        }

        private void btExcluirPet_Click(object sender, EventArgs e)
        {
            if (dtgListPets.CurrentRow != null)
            {
                int idPetSelecionado = Convert.ToInt32(dtgListPets.CurrentRow.Cells[0].Value);
                DialogResult resp = MessageBox.Show("Deseja deletar o cadastro selecionado?", "PetLover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    petsDao petsDao = new petsDao();
                    petsDao.DeletePet(idPetSelecionado);
                    AtualizarListaPets();
                }
                else
                {
                    MessageBox.Show("Nenhum cadastro válido selecionado para exclusão", "PetLover", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            }
        }
    }
    
}
