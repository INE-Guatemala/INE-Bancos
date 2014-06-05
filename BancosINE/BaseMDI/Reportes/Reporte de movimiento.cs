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
    public partial class Reporte_de_movimiento : Form
    {
        public Reporte_de_movimiento()
        {
            InitializeComponent();
        }

        private void Reporte_de_movimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet2.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DataSet2.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
