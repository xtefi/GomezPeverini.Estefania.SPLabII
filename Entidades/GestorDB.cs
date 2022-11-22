using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    class GestorDB
    {
        private static string cadenaConexion;

        static GestorDB()
        {
            cadenaConexion = @"Server=.\SQLEXPRESS;Database=Libreria;Trusted_Connection=True;";
        }

        
    }
}
