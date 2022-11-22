using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Datos
{
    public class Archivador
    {
        private string ruta;
        public Archivador(string ruta)
        {
            this.ruta = ruta;
        }

        /// <summary>
        /// Escribe datos del tipo string en un archivo de logs. En caso de no existir el archivo, lo crea.
        /// </summary>
        /// <param name="datos">Datos del tipo string que se quiere guardar en el archivo.txt</param>
        public void Guardar(string datos)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(ruta, true))
                {
                    writer.WriteLine($"Logs del dia: {DateTime.Now.ToString()}--------------------------------------------");
                    writer.WriteLine(datos);
                }
            }
            catch
            {
                throw;
            }
        }
        #region ARCHIVOS
        /// <summary>
        /// Valida que exista un archivo de texto y retorna todo su contenido. 
        /// En caso de no existir el archivo arroja una Excepcion.
        /// </summary>
        /// <param name="datos">Datos del tipo string que fueron obtenidos del archivo de logs</param>
        public void Leer(out string datos)
        {
            datos = string.Empty;
            if (File.Exists(ruta))
            {
                using (StreamReader reader = new StreamReader(ruta))
                {
                    datos = reader.ReadToEnd();
                }
            }
            else
            {
                throw new FileNotFoundException("No se encontró ningun archivo de logs para leer");
            }
        }
        #endregion
    }
}
