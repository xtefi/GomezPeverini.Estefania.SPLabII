using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace UI
{
    public partial class FormUtiles : Form
    {
        private Lapiz lapizAux;
        delegate void MiDelegado(int i);
        public FormUtiles()
        {
            InitializeComponent();
            LimpiarGroupBoxes();
        }

        #region CARGA DE DATOS
        private void rbtLapices_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgdUtilesDisponibles.DataSource = GestorDB.LeerLapiz();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbtSacapuntas_CheckedChanged(object sender, EventArgs e)
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

        private void rbtGomas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgdUtilesDisponibles.DataSource = GestorDB.LeerGomas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region ELIMINAR UTIL
        private void btnEliminaUtil_Click(object sender, EventArgs e)
        {
            Task.Run(MostrarMensajeProductoBorrado);
            try 
            {             
                if (rbtGomas.Checked == true)
                {
                    Goma selected = (Goma)dgdUtilesDisponibles.CurrentRow.DataBoundItem;
                    GestorDB.Delete(selected, selected.Id);
                    dgdUtilesDisponibles.DataSource = GestorDB.LeerGomas();
                }
                else if(rbtLapices.Checked == true)
                {
                    Lapiz selected = (Lapiz)dgdUtilesDisponibles.CurrentRow.DataBoundItem;
                    GestorDB.Delete(selected, selected.Id);
                    dgdUtilesDisponibles.DataSource = GestorDB.LeerLapiz();
                }
                else
                {
                    Sacapuntas selected = (Sacapuntas)dgdUtilesDisponibles.CurrentRow.DataBoundItem;
                    GestorDB.Delete(selected, selected.Id);
                    dgdUtilesDisponibles.DataSource = GestorDB.LeerSacapuntas();               
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region AGREGAR NUEVO UTIL
        private void btnNuevoUtil_Click(object sender, EventArgs e)
        {
            LimpiarGroupBoxes();
            gbxUtiles.Visible = true;
            if (rbtGomas.Checked is true)
            {
                gbxGoma.Visible = true;
            }
            else if (rbtSacapuntas.Checked is true)
            {
                gbxSacapuntas.Visible = true;
            }
            else if (rbtLapices.Visible is true)
            {
                gbxLapiz.Visible = true;
            }
            else
                MessageBox.Show("Seleccione un útil para operar");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Lapiz lapiz;
            Goma goma;
            Sacapuntas sacapuntas;
            try
            {
                if (rbtGomas.Checked is true)
                {
                    goma = new Goma(tbxMarca.Text, (float)Convert.ToDouble(tbxPrecio.Text), tbxFormaGoma.Text);
                    GestorDB.AltaGoma(goma);
                    dgdUtilesDisponibles.DataSource = GestorDB.LeerGomas();
                }
                else if (rbtSacapuntas.Checked is true)
                {
                    sacapuntas = new Sacapuntas(tbxMarca.Text, (float)Convert.ToDouble(tbxPrecio.Text), tbxFormaSacapuntas.Text, chbxDeposito.Checked, tbxMaterialSacapuntas.Text);
                    GestorDB.AltaSacapuntas(sacapuntas);
                    dgdUtilesDisponibles.DataSource = GestorDB.LeerSacapuntas();
                }
                else
                {
                    lapiz = new Lapiz(tbxMarca.Text, (float)Convert.ToDouble(tbxPrecio.Text), tbxColorLapiz.Text, tbxTamanoLapiz.Text);
                    GestorDB.AltaLapiz(lapiz);
                    dgdUtilesDisponibles.DataSource = GestorDB.LeerLapiz();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LimpiarGroupBoxes();
        }

        #endregion

        #region EDITAR UTIL
        private void btnEditarUtilSeleccionado_Click(object sender, EventArgs e)
        {
            LimpiarGroupBoxes();
            gbxUtiles.Visible = true;
            Lapiz lapiz;
            Goma goma;
            Sacapuntas sacapuntas;
            try
            {
                if (rbtGomas.Checked is true)
                {
                    gbxGoma.Visible = true;
                    goma = (Goma)dgdUtilesDisponibles.CurrentRow.DataBoundItem;
                    tbxMarca.Text = goma.Marca;
                    tbxPrecio.Text = goma.Precio.ToString();
                    tbxFormaGoma.Text = goma.Forma;
                }
                else if (rbtSacapuntas.Checked is true)
                {
                    gbxSacapuntas.Visible = true;
                    sacapuntas = (Sacapuntas)dgdUtilesDisponibles.CurrentRow.DataBoundItem;
                    tbxMarca.Text = sacapuntas.Marca;
                    tbxPrecio.Text = sacapuntas.Precio.ToString();
                    tbxMaterialSacapuntas.Text = sacapuntas.Material;
                    tbxFormaSacapuntas.Text = sacapuntas.Forma;
                    chbxDeposito.Checked = sacapuntas.ConDeposito;
                }
                else if (rbtLapices.Visible is true)
                {
                    gbxLapiz.Visible = true;
                    lapiz = (Lapiz)dgdUtilesDisponibles.CurrentRow.DataBoundItem;
                    tbxMarca.Text = lapiz.Marca;
                    tbxPrecio.Text = lapiz.Precio.ToString();
                    tbxColorLapiz.Text = lapiz.Color;
                    tbxTamanoLapiz.Text = lapiz.Tamano;

                }
                else
                    MessageBox.Show("Seleccione un útil para operar");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnConfirmaModificacion_Click(object sender, EventArgs e)
        {
            Lapiz lapiz;
            Goma goma;
            Sacapuntas sacapuntas;
            try
            {
                if (rbtGomas.Checked is true)
                {
                    goma = (Goma)dgdUtilesDisponibles.CurrentRow.DataBoundItem;
                    goma.Marca = tbxMarca.Text;
                    goma.Precio = (float)Convert.ToDouble(tbxPrecio.Text);
                    goma.Forma = tbxFormaGoma.Text;
                    GestorDB.ActualizarGomas(goma, goma.Id);
                    dgdUtilesDisponibles.DataSource = GestorDB.LeerGomas();
                }
                else if (rbtSacapuntas.Checked is true)
                {
                    sacapuntas = (Sacapuntas)dgdUtilesDisponibles.CurrentRow.DataBoundItem;
                    sacapuntas.Marca = tbxMarca.Text;
                    sacapuntas.Precio = (float)Convert.ToDouble(tbxPrecio.Text);
                    sacapuntas.Material = tbxMaterialSacapuntas.Text;
                    sacapuntas.ConDeposito = chbxDeposito.Checked;
                    sacapuntas.Forma = tbxFormaSacapuntas.Text;
                    GestorDB.ActualizarSacapuntas(sacapuntas, sacapuntas.Id);
                    dgdUtilesDisponibles.DataSource = GestorDB.LeerSacapuntas();
                }
                else
                {
                    lapiz = (Lapiz)dgdUtilesDisponibles.CurrentRow.DataBoundItem;
                    lapiz.Marca = tbxMarca.Text;
                    lapiz.Precio = (float)Convert.ToDouble(tbxPrecio.Text);
                    lapiz.Color = tbxColorLapiz.Text;
                    lapiz.Tamano = tbxTamanoLapiz.Text;
                    GestorDB.ActualizarLapiz(lapiz, lapiz.Id);
                    dgdUtilesDisponibles.DataSource = GestorDB.LeerLapiz();
                }
                LimpiarGroupBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region SERIALIZANDO LAPIZ
        private void btnSerializaXml_Click(object sender, EventArgs e)
        {
            try
            {
                CargarLapiz();
                lapizAux.GuardarXml(lapizAux);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeserealizaXml_Click(object sender, EventArgs e)
        {
            try
            {
                lapizAux = lapizAux.LeerXml();
                MessageBox.Show($"Lapiz deseralizado *** \n {lapizAux.Mostrar()}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSerializaJson_Click(object sender, EventArgs e)
        {
            try
            {
                CargarLapiz();
                lapizAux.GuardarJson(lapizAux);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeseralizaJson_Click(object sender, EventArgs e)
        {
            try
            {
                lapizAux = lapizAux.LeerJson();
                MessageBox.Show($"Lapiz deseralizado *** \n {lapizAux.Mostrar()}");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Carga el lapiz seleccionado desde la grilla para luego serializarse
        /// </summary>
        private void CargarLapiz()
        {
            try
            {
                if (rbtLapices.Checked == true)
                    lapizAux = dgdUtilesDisponibles.SelectedRows[0].DataBoundItem as Lapiz;
            }
            catch
            {
                MessageBox.Show("Error al cargar el lápiz");
            }
           
        }
        #endregion
        /// <summary>
        /// Esconde y limpia los campos utilizados para agregar/editar útiles
        /// </summary>
        private void LimpiarGroupBoxes()
        {
            gbxUtiles.Visible = false;
            gbxLapiz.Visible = false;
            gbxSacapuntas.Visible = false;
            gbxGoma.Visible = false;
            tbxMarca.Text = string.Empty;
            tbxPrecio.Text = string.Empty;
            tbxColorLapiz.Text = string.Empty;
            tbxTamanoLapiz.Text = string.Empty;
            tbxFormaGoma.Text = string.Empty;
            tbxMaterialSacapuntas.Text = string.Empty;
        }

        /// <summary>
        /// Muestra un mensaje con un contador
        /// </summary>
        /// <param name="i"></param>
        private void MensajeProductoBorrado(int i)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    MiDelegado llamador = new MiDelegado(MensajeProductoBorrado);
                    object[] args = { i };
                    this.BeginInvoke(llamador, args);
                }
                else
                {
                    this.lblHora.Text = $"El producto se borrará en {i}";
                    if (i == 0)
                    {
                        this.lblHora.Text = "No hay marcha atrás.";
                    }
                    if(i < 0)
                    {
                        this.lblHora.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MostrarMensajeProductoBorrado()
        {
            for (int i = 3; i > -2; i--)
            {
                MensajeProductoBorrado(i);
                Thread.Sleep(1000);
            }

        }
        /// <summary>
        /// Valido que solo se ingresen números
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
