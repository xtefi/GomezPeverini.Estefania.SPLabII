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
using Entidades.Datos;

namespace UI
{
    public partial class FormNuevaCartuchera : Form
    {
        private Cartuchera<Utiles> c1;
        private Cartuchera<Utiles> c2;
        private Cartuchera<Utiles> c3;
        private Cartuchera<Utiles> c4;
        private List<Cartuchera<Utiles>> listaCartucheras;
        private List<Fibron> listaFibrones;
        private Fibron f1;
        private Fibron f2;
        private Fibron f3;

        public Action<string> sinTintaEvento = Archivador.GuardarLogErrorFibron;

        public FormNuevaCartuchera()
        {
            InitializeComponent();
            listaCartucheras = new List<Cartuchera<Utiles>>();
            c1 = new Cartuchera<Utiles>("Cartuchera de Banban", 7);
            c2 = new Cartuchera<Utiles>("Cartuchera de Mordecai", 14);
            c3 = new Cartuchera<Utiles>("Cartuchera de Ito", 15);
            c4 = new Cartuchera<Utiles>("Fibrones", 4);

            f1 = new Fibron("Mapped", 2, 10, "Verde");
            f2 = new Fibron("Mapped", 4, 7, "Rojo");
            f3 = new Fibron("Mapped", 6.25f, 2, "Azul");

            listaCartucheras.Add(c1);
            listaCartucheras.Add(c2);
            listaCartucheras.Add(c3);
            listaCartucheras.Add(c4);

            listaFibrones = new List<Fibron>();
            listaFibrones.Add(f1);
            listaFibrones.Add(f2);
            listaFibrones.Add(f3);
            c4 += f1;
            c4 += f2;
            c4 += f3;
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
        private void rbtFibron_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgdUtilesDisponibles.DataSource = this.listaFibrones;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void rbtVerGomas_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                dgdUtilesDisponibles.DataSource = GestorDB.LeerGomas();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void rbtVerSacapuntas_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                dgdUtilesDisponibles.DataSource = GestorDB.LeerSacapuntas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void rbtVerLapices_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgdUtilesDisponibles.DataSource = GestorDB.LeerLapiz();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion



        private void btnResaltar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Cartuchera<Utiles> cartuchera = c4;//dgdCartucheras.SelectedRows[0].DataBoundItem as Cartuchera<Utiles>;
            int resaltar = random.Next(1, 10);
            Fibron fibronAux=null;

            try
            {
                int fibronRandom = random.Next(0, cartuchera.Utiles.Count-1);
                if (cartuchera.Utiles[fibronRandom] is Fibron)
                {
                    fibronAux = cartuchera.Utiles[fibronRandom] as Fibron;
                    fibronAux.Resaltar(resaltar);
                }               

            }
            catch(SinTintaExcepcion ex)
            {
                sinTintaEvento.Invoke(fibronAux.MostrarSinTinta()+"Se quiso restar"+" "+resaltar.ToString());
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
//3) Al atrapar la excepcion debera lanzar el evento “SinTintaEvento”
//4) Crear un manejador de ese evento que escriba el fibron y cuanta tinta le faltó en el
//archivo “errors.log”
//En el form principal al cargarlo, crear la cartuchera con los 3 fibrones.
//Agregar un botón que llame al método Resaltar() y le pase un random entre 1 y 10
//El elemento de la cartuchera será elegido mediante un random
//Dar respuesta amigable al usuario de lo que va sucediendo
}
