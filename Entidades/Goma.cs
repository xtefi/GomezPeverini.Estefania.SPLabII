using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Goma : Utiles
    {
        private string forma;
        private int id;

        public int Id { get => this.id; }
        public string Forma { get => this.forma; set => this.forma = value; }

        #region CONSTRUCTORES
        public Goma(string marca, float precio)
            :base(marca, precio)
        {
            this.forma = "Rectangular";
        }
        public Goma(string marca, float precio, string forma)
            :this(marca, precio)
        {
            this.forma = forma;
        }
        public Goma(string marca, float precio, string forma, int id)
            : this(marca, precio, forma)
        {
            this.id = id;
        }
        #endregion
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Forma: {this.forma}");
            return sb.ToString();
        }
    }
}
