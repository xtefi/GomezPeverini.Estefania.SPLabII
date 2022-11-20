using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{

    internal class Lapiz : Utiles, IDeserializa, ISerializa
    {
        private string tipoColor;
        private string tamano;

        string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Lapiz(int cantidad, string marca, float precio, string tipoColor, string tamano)
            :base(cantidad,marca, precio)
        {
            this.tipoColor= tipoColor;
            this.tamano= tamano;
        }

        public void GuardarXml(object dato, string myDocumentsPath)
        {
            using (XmlTextWriter xmlTextW = new XmlTextWriter(myDocumentsPath, Encoding.UTF8))
            {
                XmlSerializer serializer = new XmlSerializer(dato.GetType());
                xmlTextW.Formatting = Formatting.Indented;
                serializer.Serialize(xmlTextW, dato);
            }
        }
        public List<Lapiz> LeerXml(string myDocumentsPath)
        {
            using (XmlTextReader xmlReader = new XmlTextReader(myDocumentsPath))
            {
                List<Lapiz> listaLapices;
                XmlSerializer serializer = new XmlSerializer(typeof(Lapiz));
                listaLapices = (List<Lapiz>)serializer.Deserialize(xmlReader);
                return listaLapices;
            }
        }
    }
}
