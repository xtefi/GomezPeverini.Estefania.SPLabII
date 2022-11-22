using System;
using Entidades;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            Cartuchera<Utiles> c1 = new Cartuchera<Utiles>("Verde", 2);

            Lapiz l1 = new Lapiz(1, "Faber", 2.5f);
            Lapiz l2 = new Lapiz(1, "Faber", 45.5f, "verde", "grande");
            Goma g1 = new Goma(2, "Faber", 4.5f);



            try
            {
                Console.WriteLine("Enter para agregar un producto");
                Console.ReadKey();
                c1 += l1;
                Console.WriteLine(c1.MostrarCartuchera());
                Console.ReadKey();

                Console.WriteLine("\n Enter para agregar dos productos");
                Console.Clear();

                c1 += g1;                
                Console.WriteLine(c1.MostrarCartuchera());
                Console.ReadKey();

                Console.WriteLine("Agrego tres productos");
                Console.Clear();
                c1 += l1;
                Console.WriteLine(c1.MostrarCartuchera());
                Console.ReadKey();
                c1 += l2;

                // c1 += l2;
                // Console.WriteLine(c1.MostrarCartuchera());
                // c1 += l1;
                //Console.WriteLine(c1.MostrarCartuchera());
            }
             catch (CartucheraLlenaException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

            Console.WriteLine("Enter para testear el XML del lapiz");
            Console.ReadKey();
            Console.Clear();
            
            l1.GuardarXml(l1);
            Lapiz l3 = l1.LeerXml();
            Console.WriteLine(l3.Mostrar());
           
        }
    }
}
