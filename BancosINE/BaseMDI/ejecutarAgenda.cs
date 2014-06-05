using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancosINE
{
    class ejecutarAgenda
    {
        DateTime lastDate = Properties.Settings.Default.agendaActualizada;
        System.Data.DataTable dgrid = new System.Data.DataTable();
        int lastDay, lastMonth, today, todayMonth;

        public ejecutarAgenda()
        {
            if (lastDate != DateTime.Today)
            {
                lastDay = lastDate.Day;
                lastMonth = lastDate.Month;
                today = DateTime.Today.Day;
                todayMonth = DateTime.Today.Month;

                string query = "select monto,idtransaccion,idcuenta from agenda where ((mes>= "+lastMonth+" and mes <="+todayMonth+") or mes=0) and (dia>= "+lastDay+" and dia<="+today+") and estado=1";
                dgrid = Funciones.dbConnect.consulta_DataGridView(query);

                if (dgrid.Rows.Count > 0)
                {
                    for(int i=0;i<dgrid.Rows.Count;i++){
                        Dictionary<string, string> dict = new Dictionary<string, string>();
                        dict.Add("monto", dgrid.Rows[i][0].ToString());
                        dict.Add("idtransaccion", dgrid.Rows[i][1].ToString());
                        dict.Add("idcuenta", dgrid.Rows[i][2].ToString());
                        dict.Add("fecha", DateTime.Today.ToString("yyyy-MM-dd"));

                        Console.WriteLine(dgrid.Rows[i][0].ToString());
                        //Funciones.dbConnect.insertar("movimiento", dict);
                    }                
                }

                Properties.Settings.Default.agendaActualizada = DateTime.Today;
                Properties.Settings.Default.Save();
                System.Windows.Forms.MessageBox.Show("Se ha actualizado correctamente los movimientos de la agenda");
            }
        }
    }
}
