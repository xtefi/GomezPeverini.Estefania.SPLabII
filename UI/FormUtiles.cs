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
    public partial class FormUtiles : Form
    {
        GestorDB db = new GestorDB();
        public FormUtiles()
        {
            InitializeComponent();
            LimpiarGroupBoxes();
        }

        private void rbtLapices_CheckedChanged(object sender, EventArgs e)
        {
            dgdUtilesDisponibles.DataSource = GestorDB.LeerLapiz();
        }

        private void rbtSacapuntas_CheckedChanged(object sender, EventArgs e)
        {
            dgdUtilesDisponibles.DataSource = GestorDB.LeerSacapuntas();
        }

        private void rbtGomas_CheckedChanged(object sender, EventArgs e)
        {
            dgdUtilesDisponibles.DataSource = GestorDB.LeerGomas();
        }

        private void btnEliminaUtil_Click(object sender, EventArgs e)
        {
            //DataGridViewRow selectedRow = dgdUtilesDisponibles.Rows[0];
            //string cellValue = Convert.ToString(selectedRow.Cells["Id"].Value);
            if(rbtGomas.Checked == true)
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
            if (rbtGomas.Checked is true)
            {
                goma = new Goma(tbxMarca.Text, (float)Convert.ToDouble(tbxPrecio.Text), tbxFormaGoma.Text);
                GestorDB.AltaGoma(goma);
                dgdUtilesDisponibles.DataSource = GestorDB.LeerGomas();
            }
            else if (rbtSacapuntas.Checked is true)
            {
                sacapuntas = new Sacapuntas(tbxMarca.Text, (float)Convert.ToDouble(tbxPrecio.Text), tbxFormaSacapuntas.Text, chbxDeposito.Checked ,tbxMaterialSacapuntas.Text );
                GestorDB.AltaSacapuntas(sacapuntas);
                dgdUtilesDisponibles.DataSource = GestorDB.LeerSacapuntas();
            }
            else
            {
                lapiz = new Lapiz(tbxMarca.Text, (float)Convert.ToDouble(tbxPrecio.Text), tbxColorLapiz.Text, tbxTamanoLapiz.Text);
                GestorDB.AltaLapiz(lapiz);
                dgdUtilesDisponibles.DataSource = GestorDB.LeerLapiz();
            }
            LimpiarGroupBoxes();
        }
        private void btnEditarUtilSeleccionado_Click(object sender, EventArgs e)
        {
            LimpiarGroupBoxes();
            gbxUtiles.Visible = true;
            Lapiz lapiz;
            Goma goma;
            Sacapuntas sacapuntas;
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


    }
}
