using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Text.Json;
using Entidades.Datos;

namespace Entidades
{

    public class Lapiz : Utiles, IDeserializa, ISerializa
    {
        private string color;
        private string tamano;
        private int id;
        private Archivador archivador;
        private static string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/lapiz.xml";

        public int Id { get => this.id; }
        public string Color { get => this.color; set => this.color = value; }
        public string Tamano { get => this.tamano; set => this.tamano = value; }      

        public Lapiz()
        {
            
        }
        public Lapiz(string marca, float precio, string color, string tamano)
            :base(marca, precio)
        {
            this.color = color;
            this.tamano = tamano;
        }

        public Lapiz(string marca, float precio, string color, string tamano, int id)
            : this(marca, precio, color, tamano)
        {
            this.id = id;
        }

    
        public void GuardarXml<T>(T objeto) where T : Lapiz
        {
            try
            {
                using (XmlTextWriter xmlTextW = new XmlTextWriter(ruta, Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    xmlTextW.Formatting = Formatting.Indented;
                    serializer.Serialize(xmlTextW, objeto);
                }
            }
            catch
            {
                throw;
            }
        }
        public Lapiz LeerXml()
        {
            try
            {
                using (XmlTextReader xmlReader = new XmlTextReader(ruta))
                {
                    Lapiz lapiz;
                    XmlSerializer serializer = new XmlSerializer(typeof(Lapiz));
                    lapiz = serializer.Deserialize(xmlReader) as Lapiz;
                    return lapiz;
                }
            }
            catch
            {
                throw;
            }
        }
        public void GuardarJson<T>(T objeto) where T : Lapiz
        {
            archivador = new Archivador($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\lapiz.json");
            try
            {
                archivador.Guardar(JsonSerializer.Serialize(objeto, typeof(T)));
            }
            catch
            {
                throw;
            }
        }
        /// <summary>
        /// Lee archivos en formato JSON
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public Lapiz LeerJson()
        {
            string json = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\lapiz.json"))
                {
                    while (!sr.EndOfStream) // mientras no sea el fin del archivo
                    {
                        json += $"{sr.ReadLine()}\n"; // leo y lo concateno
                    }
                    return JsonSerializer.Deserialize<Lapiz>(json);
                }
            }
            catch
            {
                throw;
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Tipo de color: {this.color}");
            sb.AppendLine($"Tamaño: {this.tamano}");
            return sb.ToString();
        }
    }
}
