﻿using System;
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
        }

        private void btPesquisaDono_Click(object sender, EventArgs e)
        {
            Donos donos = new Donos();
            donosDao dDao = new donosDao();
            dDao.ListarDonos();
        }

        private void btEditarDono_Click(object sender, EventArgs e)
        {
            Donos dono = new Donos();
            donosDao dDao = new donosDao();
            int linha = dtgListDonos.CurrentRow.Index;
            int qtdLinhas = dtgListDonos.RowCount;
            if (qtdLinhas > 1)
            {
                DialogResult resp = MessageBox.Show("Deseja deletar o editar selecionado? ", "PetLover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {

                    dono._idDono = Convert.ToInt32(Console.ReadLine());
                    dDao.UpdateDono(dono);
                }
            }
        }
        private void btExcluirDono_Click(object sender, EventArgs e)
        {

            Donos donos = new Donos();
            donosDao dDao = new donosDao();
            int linha = dtgListDonos.CurrentRow.Index;
            int qtdLinhas = dtgListDonos.RowCount;
            if (qtdLinhas > 1)
            {
                DialogResult resp = MessageBox.Show("Deseja deletar o cadastro selecionado? ", "PetLover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(resp == DialogResult.Yes)
                {
                    dtgListDonos.Rows.RemoveAt(linha);
                    donos._idDono = Convert.ToInt32(Console.ReadLine());
                    dDao.DeleteDono(donos._idDono);
                }
            }
            
        }
    }
}
