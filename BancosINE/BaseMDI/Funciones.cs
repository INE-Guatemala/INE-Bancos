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

        public static DBConnect dbConnect = new DBConnect("inebancos");

        public static ArrayList array = new ArrayList();
        public static int currentPage = -1;

        public static string nombreUsuario = "";
        public static int idUsuario = 0;

        public static object[] clases = new object[]{
            new string[]{
                "BancosINE.Bancos",                
                "BancosINE.Cuentas",
                "BancosINE.Conciliaciones"
            },
            new string[]{},
            new string[]{               
                "BancosINE.Cliente",
                "BancosINE.Proveedor",
                "BancosINE.Acreedor",
                "BancosINE.Cheques"
            },
            new string[]{
                "BancosINE.Transacciones.Transaccion",
                "BancosINE.TipoCuentas",
                "BancosINE.TipoCuentas",
                "BancosINE.tipoagente"
            }
        };
    }
}
