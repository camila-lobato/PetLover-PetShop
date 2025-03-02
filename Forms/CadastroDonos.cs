using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testeForm.dao;
using testeForm.models;

namespace testeForm.Forms
{
    public partial class CadastroDonos : Form
    {
        public CadastroDonos()
        {
            InitializeComponent();
        }

        private void AtualizarListaDonos()
        {
            List<Donos>ListDonos = new List<Donos>();
            donosDao donosDao = new donosDao();
            ListDonos = donosDao.ListarDonos();
        }

        private void btSalvarDono_Click(object sender, EventArgs e)
        {
            donosDao dDao = new donosDao();
            Donos dono = new Donos();
            List<Donos> listaDonos = new List<Donos>();

            if (txtNomeDono.Text.Trim() != "" && txtTelefoneDono.Text.Trim() != "" && txtCpfDono.Text.Trim() != "")
            {

                dono._nome = txtNomeDono.Text;
                dono._telefone = txtTelefoneDono.Text;
                dono._cpf = txtCpfDono.Text;
                dDao.InsertDono(dono);
                foreach (var item in listaDonos)
                {
                    listaDonos.Add(item);
                }
                txtNomeDono.Clear();
                txtTelefoneDono.Clear();
                txtCpfDono.Clear();
                AtualizarListaDonos();
            }
            else
            {
                MessageBox.Show("Preencha todos os dados corretamente!", "PetLover", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btCancelarDono_Click(object sender, EventArgs e)
        {
            txtNomeDono.Clear();
            txtTelefoneDono.Clear();
            txtCpfDono.Clear();
            this.Close();
        }

        private void iconLista_Click(object sender, EventArgs e)
        {

        }
    }
}
