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
    }
}
