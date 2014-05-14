using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODBCConnect;

namespace BancosINE
{
    class Funciones
    {

        public static DBConnect dbConnect = new DBConnect("pruebaine");

        public static ArrayList array = new ArrayList();
        public static int currentPage = -1;

        public static object[] clases = new object[]{
            new string[]{
                "Bancos",
                "TipoCuentas",
                "TipoCuentas",
                "Cuentas"
            }
        };

        public static string nombreUsuario = "";
        public static int idUsuario = 0;
    }
}
