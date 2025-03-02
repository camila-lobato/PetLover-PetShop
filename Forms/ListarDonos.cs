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
    public partial class ListarDonos : Form
    {
        public ListarDonos()
        {
            InitializeComponent();
            AtualizarListaDonos();
           dtgListDonos.CellClick += new DataGridViewCellEventHandler(dtgListDonos_CellClick);
        }
        private void AtualizarListaDonos()
        {
            donosDao donosDao = new donosDao();
            List<Donos> ListDonos = donosDao.ListarDonos();
            dtgListDonos.DataSource = null;
            dtgListDonos.DataSource = ListDonos;
            dtgListDonos.Refresh();
        }

        private void DtgListDonos_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btPesquisaDono_Click(object sender, EventArgs e)
        {
            donosDao dDao = new donosDao();
            dDao.ListarDonos();
            List<Donos> listDonos = dDao.ListarDonos();
            dtgListDonos.DataSource = null;
            dtgListDonos.DataSource = listDonos;
            AtualizarListaDonos();

        }

        private void btEditarDono_Click(object sender, EventArgs e)
        {
            EditarDonos form = new EditarDonos();
            form.ShowDialog();
            AtualizarListaDonos();
        }
        private void btExcluirDono_Click(object sender, EventArgs e)
        {
            if (dtgListDonos.CurrentRow != null)
            {
                int idDonoSelecionado = Convert.ToInt32(dtgListDonos.CurrentRow.Cells[0].Value);
                DialogResult resp = MessageBox.Show("Deseja deletar o cadastro selecionado?", "PetLover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(resp == DialogResult.Yes)
                {
                    donosDao donosDao = new donosDao();
                    donosDao.DeleteDono(idDonoSelecionado);
                    AtualizarListaDonos();
                }
                else
                {
                    MessageBox.Show("Nenhum cadastro válido selecionado para exclusão", "PetLover", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            }
        }

        private void btLimparGrid_Click(object sender, EventArgs e)
        {
            dtgListDonos.DataSource = null;
            dtgListDonos.Rows.Clear();
        }

        private void dtgListDonos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgListDonos.Rows[e.RowIndex];
                int idDonoSelecionado = Convert.ToInt32(row.Cells[0].Value);
                ;
            }
        }
    }
}
