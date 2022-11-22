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
    public partial class FormLogs : Form
    {
        Archivador archivador = new Archivador($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\tickets.log");
        private string datos;
        public FormLogs()
        {
            InitializeComponent();
            MostrarLogs();
        }

        private void MostrarLogs()
        {
            try
            {
                archivador.Leer(out datos);
                rtbxLogs.Text = datos;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
