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
    public partial class Reporte_Clientes : Form
    {
        public Reporte_Clientes()
        {
            InitializeComponent();
        }

        private void Reporte_Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet3.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.Fill(this.DataSet3.DataTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
