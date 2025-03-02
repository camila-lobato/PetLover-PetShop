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
    public partial class EditarDonos : Form
    {
        public EditarDonos()
        {
            InitializeComponent();
        }


        private void btCancelarDono_Click(object sender, EventArgs e)
        {
            txtNomeDono.Clear();
            txtTelefoneDono.Clear();
            txtCpfDono.Clear();
            txtIdDono.Clear();
            this.Close();
        }

        private void btAlterarDono_Click(object sender, EventArgs e)
        {
            donosDao dDao = new donosDao();
            Donos dono = new Donos();

            if (txtIdDono.Text.Trim() != "" && txtNomeDono.Text.Trim() != "" && txtTelefoneDono.Text.Trim() != "" && txtCpfDono.Text.Trim() != "")
            {
                dono._idDono = Convert.ToInt32(txtIdDono.Text);
                dono._nome = txtNomeDono.Text;
                dono._telefone = txtTelefoneDono.Text;
                dono._cpf = txtCpfDono.Text;
                txtNomeDono.Clear();
                txtTelefoneDono.Clear();
                txtCpfDono.Clear();
                dDao.UpdateDono(dono);
                txtNomeDono.Clear();
                txtTelefoneDono.Clear();
                txtCpfDono.Clear();
                txtIdDono.Clear();
            }
            else
            {
                MessageBox.Show("Preencha todos os dados corretamente!", "PetLover", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void iconLista_Click(object sender, EventArgs e)
        {

        }
    }
}
