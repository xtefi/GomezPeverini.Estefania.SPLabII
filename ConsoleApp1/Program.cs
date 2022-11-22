using System;
using Entidades;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            Cartuchera<Utiles> c1 = new Cartuchera<Utiles>("Verde");

            Lapiz l1 = new Lapiz(1, "Faber", 2.5f);
            Utiles l2 = new Lapiz(1, "Faber", 47.5f, "verde", "grande");


            try
            {
                c1 += l1;
                Console.WriteLine(c1.MostrarCartuchera());
               // c1 += l2;
               // Console.WriteLine(c1.MostrarCartuchera());
               // c1 += l1;
               //Console.WriteLine(c1.MostrarCartuchera());
            }
             catch (CartucheraLlenaException ex)
            {
                Console.WriteLine(ex.Message);
            }

            l1.GuardarXml(l1);

            Console.ReadKey();

            Lapiz l3 = l1.LeerXml();

            Console.WriteLine(l3.MostrarLapices());
           
        }
    }
}
