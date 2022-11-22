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
    }
}
