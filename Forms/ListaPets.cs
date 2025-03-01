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
        }

        private void btPesquisaPet_Click(object sender, EventArgs e)
        {
            petsDao pDao = new petsDao();
            pDao.ListarPets();
            List<Pets> listPets = pDao.ListarPets();
            dtgListPets.DataSource = null;
            dtgListPets.DataSource = listPets;
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
        }

        private void btExcluirPet_Click(object sender, EventArgs e)
        {

        }
    }
}
