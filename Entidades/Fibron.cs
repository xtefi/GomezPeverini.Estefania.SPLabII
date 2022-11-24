using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fibron : Utiles
    {
        private int cantidadTinta;
        private string color;
        private int auxiliarTintaFaltante;

        public int CantidadTinta { get => this.cantidadTinta; }
        public string Color { get => this.color; }

        public Fibron(string marca, float precio, int cantidadTinta, string color)
            :base(marca, precio)
        {
            this.cantidadTinta = cantidadTinta;
            this.color = color;
        }


        public void Resaltar(int cantidad)
        {
            if(cantidad < this.cantidadTinta)
            {
                this.cantidadTinta -= cantidad;
            }
            else
            {
                auxiliarTintaFaltante = cantidad - this.cantidadTinta;
                throw new SinTintaExcepcion("El fibrón no tiene tinta suficiente");
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Cantidad de tinta: {this.cantidadTinta}");
            sb.AppendLine($"Color: {this.color}");
            return sb.ToString();
        }
        public string MostrarSinTinta()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Cantidad de tinta: {this.cantidadTinta}");
            sb.AppendLine($"Color: {this.color}");
            sb.AppendLine($"Le faltó: {this.auxiliarTintaFaltante} tinta para resaltar");

            return sb.ToString();
        }

    }
}
