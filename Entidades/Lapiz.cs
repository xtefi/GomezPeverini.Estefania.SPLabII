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

        public int Id { get => this.id; }
        public string Color { get => this.color; }
        public string Tamano { get => this.tamano; }      

        public Lapiz()
        {
            
        }
        public Lapiz(string marca, float precio)
            :base(marca, precio)
        {
            this.color = "Color negro";
            this.tamano = "Tamaño 2B";
        }
        public Lapiz(string marca, float precio, string color, string tamano)
            :this(marca, precio)
        {
            this.color = color;
            this.tamano = tamano;
        }

        public Lapiz(string marca, float precio, string color, string tamano, int id)
            : this(marca, precio, color, tamano)
        {
            this.id = id;
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
    ///// <summary>
    ///// Lee archivos en formato JSON
    ///// </summary>
    ///// <param name="path"></param>
    ///// <returns></returns>
    //public T Leer(string path)
    //{
    //    string json = Archivador.Leer(path);
    //    return JsonSerializer.Deserialize<T>(json);
    //}

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
