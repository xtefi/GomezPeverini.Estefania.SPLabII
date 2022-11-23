using System;
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
                Goma g2 = new Goma("test", 50);
                Goma g = new Goma("asd", 500);
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
            FormUtiles frmUtiles = new FormUtiles();
            this.Visible = false;
            frmUtiles.ShowDialog();
            this.Visible = true;
        }

        private void btnVerLogs_Click(object sender, EventArgs e)
        {
            FormLogs frmLogs = new FormLogs();
            this.Visible = false;
            frmLogs.ShowDialog();
            this.Visible = true;
        }

        private void btnAgregarUtil_Click(object sender, EventArgs e)
        {
            Cartuchera<Utiles> cartuchera = dgdCartucheras.SelectedRows[0].DataBoundItem as Cartuchera<Utiles>;
            Lapiz lapiz;
            Goma goma;
            Sacapuntas sacapuntas;
            try
            {
                if (rbtVerLapices.Checked is true)
                {
                    lapiz = dgdUtilesDisponibles.SelectedRows[0].DataBoundItem as Lapiz;
                    if(lapiz != null && cartuchera != null)
                    {
                        cartuchera += lapiz;
                        richTextBox1.Text = cartuchera.MostrarCartuchera();
                    }
                }
                else if (rbtVerGomas.Checked is true)
                {
                    goma = dgdUtilesDisponibles.SelectedRows[0].DataBoundItem as Goma;
                    if (goma != null && cartuchera != null)
                    {
                        cartuchera += goma;
                        richTextBox1.Text = cartuchera.MostrarCartuchera();
                    }
                }
                else
                {
                    sacapuntas = dgdUtilesDisponibles.SelectedRows[0].DataBoundItem as Sacapuntas;
                    if (sacapuntas != null && cartuchera != null)
                    {
                        cartuchera += sacapuntas;
                        richTextBox1.Text = cartuchera.MostrarCartuchera();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #region CARGA DE DATOS

        private void rbtVerGomas_CheckedChanged_1(object sender, EventArgs e)
        {
            dgdUtilesDisponibles.DataSource = GestorDB.LeerGomas();
        }
        private void rbtVerSacapuntas_CheckedChanged_1(object sender, EventArgs e)
        {
            dgdUtilesDisponibles.DataSource = GestorDB.LeerSacapuntas();
        }
        private void rbtVerLapices_CheckedChanged(object sender, EventArgs e)
        {
            dgdUtilesDisponibles.DataSource = GestorDB.LeerLapiz();
        }
        #endregion

    }
}
