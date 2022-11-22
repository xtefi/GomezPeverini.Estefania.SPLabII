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
    public partial class FormLogs : Form
    {
        Cartuchera<Utiles> cartuchera;
        private string datos;
        public FormLogs()
        {
            InitializeComponent();
            cartuchera = new Cartuchera<Utiles>("a",1);
            MostrarLogs();
        }

        private void MostrarLogs()
        {
            try
            {
                cartuchera.Leer(out datos);
                rtbxLogs.Text = datos;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
