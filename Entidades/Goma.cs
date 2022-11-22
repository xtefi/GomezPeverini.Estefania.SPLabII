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

        public Goma(int unidades, string marca, float precio)
            :base(unidades, marca, precio)
        {
            this.forma = "Rectangular";
        }
        public Goma(int unidades, string marca, float precio, string forma)
            :base(unidades, marca, precio)
        {
            this.forma = forma;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Forma: {this.forma}");
            return sb.ToString();
        }
    }
}
