using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Entidades
{

    public class Lapiz : Utiles, IDeserializa, ISerializa
    {
        private string tipoColor;
        private string tamano;

        public string TipoColor { get { return this.tipoColor; } }
        public string Tamano { get { return this.tamano; } }


        public Lapiz()
        {

        }
        public Lapiz(int cantidad, string marca, float precio)
            :base(cantidad,marca, precio)
        {
            this.tipoColor = "Color normal";
            this.tamano = "Tamaño normal";
        }
        public Lapiz(int cantidad, string marca, float precio, string tipoColor, string tamano)
            :this(cantidad, marca, precio)
        {
            this.tipoColor = tipoColor;
            this.tamano = tamano;
        }


        private string archivo = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"/lapiz.xml";
        public void GuardarXml<T>(T objeto) where T : Lapiz
        {
            using (XmlTextWriter xmlTextW = new XmlTextWriter(archivo, Encoding.UTF8))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                xmlTextW.Formatting = Formatting.Indented;
                serializer.Serialize(xmlTextW, objeto);
            }
        }
        public Lapiz LeerXml()
        {
            using (XmlTextReader xmlReader = new XmlTextReader(archivo))
            {
                Lapiz lapiz;
                XmlSerializer serializer = new XmlSerializer(typeof(Lapiz));
                lapiz = serializer.Deserialize(xmlReader) as Lapiz;
                return lapiz;
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Tipo de color: {this.tipoColor}");
            sb.AppendLine($"Tamaño: {this.tamano}");
            return sb.ToString();
        }
    }
}
