using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTutorias.DAO
{
    internal static class Conexion
    {
        private static String servidor = "DESKTOP-JKKF8L6";
        private static String puerto = "1433";
        private static String baseDeDatos = "SistemaTutorias";
        private static String usuario = "SistemaTutorias";
        private static String contrasena = "Magt22081998";

        public static String cadenaDeConexion = $"Server={servidor},{puerto};Database={baseDeDatos};User Id={usuario};Password={contrasena};";

        


    }
}
