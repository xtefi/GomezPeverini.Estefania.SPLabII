using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum eRasgosLapiz { flexibles, acuareleables, metalizados, pastel, plantable, carbonilla, ninguno }
    public enum eTamanoLapiz { chico, mediano, grande }
    internal class Lapiz : Utiles
    {
        private eRasgosLapiz rasgos;
        private eTamanoLapiz tamano;
        public Lapiz(int cantidad, string marca, float precio)
            :base(cantidad,marca, precio)
        {

        }
    }
}
