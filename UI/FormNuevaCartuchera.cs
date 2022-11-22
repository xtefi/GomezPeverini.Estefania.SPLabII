﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace UI
{
    public partial class FormNuevaCartuchera : Form
    {
        private Cartuchera<Utiles> c1;
        private Cartuchera<Utiles> c2;
        private Cartuchera<Utiles> c3;
        public static FormNuevaCartuchera instancia;
        public Cartuchera<Utiles> cartucheraAuxiliar;

        private List<Cartuchera<Utiles>> listaCartucheras;
        public FormNuevaCartuchera()
        {
            InitializeComponent();
            listaCartucheras = new List<Cartuchera<Utiles>>();
            c1 = new Cartuchera<Utiles>("Cartuchera de Bryan", 7);
            c2 = new Cartuchera<Utiles>("Cartuchera de morde", 4);
            c3 = new Cartuchera<Utiles>("asd", 5);
            listaCartucheras.Add(c1);
            listaCartucheras.Add(c2);
            listaCartucheras.Add(c3);
            CargarDataGrid();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Cartuchera<Utiles> c;
            if (tbxNombreCartuchera.Text != string.Empty)
            {
                c = new Cartuchera<Utiles>(tbxNombreCartuchera.Text, (int)numCapacidadCartuchera.Value);
                this.listaCartucheras.Add(c);
                dgdCartucheras.DataSource = listaCartucheras;
            }
            else
            {
                MessageBox.Show("Revise datos ingresados");
            }
            CargarDataGrid();
        }

        private void btnMostrarCartuchera_Click(object sender, EventArgs e)
        {
            try
            {                
                Cartuchera<Utiles> selected = (Cartuchera<Utiles>)dgdCartucheras.CurrentRow.DataBoundItem;
                //dgdCartucheras.SelectedRows[0].DataBoundItem as Cartuchera<Utiles>;
                MessageBox.Show(selected.MostrarCartuchera());
            }
            catch
            {
                MessageBox.Show("Seleccione una cartuchera");
            }
        }
        private void btnEditarCartuchera_Click(object sender, EventArgs e)
        {
            try
            {
                Goma g2 = new Goma(1, "test", 50);
                Goma g = new Goma(1, "asd", 500);
                c1+=g2;
                c1+=g;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarDataGrid()
        {
            dgdCartucheras.DataSource = null;
            dgdCartucheras.DataSource = listaCartucheras;
        }

        private void btnAgregarUtiles_Click(object sender, EventArgs e)
        {
            try
            {
                cartucheraAuxiliar = (Cartuchera<Utiles>)dgdCartucheras.CurrentRow.DataBoundItem;
                if(cartucheraAuxiliar != null)
                {
                    FormUtiles frmUtiles = new FormUtiles();
                    this.Visible = false;
                    frmUtiles.ShowDialog();
                    this.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Seleccione una cartuchera");
            }
        }

        private void btnVerLogs_Click(object sender, EventArgs e)
        {
            FormLogs frmLogs = new FormLogs();
            this.Visible = false;
            frmLogs.ShowDialog();
            this.Visible = true;
        }
    }
}
