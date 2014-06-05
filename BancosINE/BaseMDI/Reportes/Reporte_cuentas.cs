using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancosINE
{
    public partial class Reporte_cuentas : Form
    {
        public Reporte_cuentas()
        {
            InitializeComponent();
        }

        private void Reporte_cuentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.Fill(this.DataSet1.DataTable);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
