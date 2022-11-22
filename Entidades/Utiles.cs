using System.Text;

namespace Entidades
{
    public abstract class Utiles
    {
        protected int unidades;
        protected string marca;
        protected float precio;

        public int Unidades { get { return this.unidades; } set { this.unidades = value; } }
        public string Marca { get { return this.marca; } set { this.marca = value; } }
        public float Precio { get { return this.precio; } set { this.precio = value; } }

        public Utiles()
        {

        }
        public Utiles(int unidades, string marca, float precio)
        {
            this.unidades = unidades;
            this.marca = marca;
            this.precio = precio;  
        }

        public virtual string MostrarUtiles()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Unidades: {this.unidades}");
            sb.AppendLine($"Precio: {this.precio}");
            return sb.ToString();
        }
    }
}