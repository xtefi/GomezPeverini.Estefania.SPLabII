using System.Text;

namespace Entidades
{
    public abstract class Utiles
    {
        protected string marca;
        protected float precio;

        public string Marca { get { return this.marca; } set { this.marca = value; } }
        public float Precio { get { return this.precio; } set { this.precio = value; } }

        public Utiles()
        {

        }
        public Utiles(string marca, float precio)
        {
            this.marca = marca;
            this.precio = precio;  
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Precio: {this.precio}");
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }
    }
}