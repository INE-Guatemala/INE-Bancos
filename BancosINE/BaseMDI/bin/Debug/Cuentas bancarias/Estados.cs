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
    public partial class Estados : BaseForm
    {

        private bool isLoad = false;
        private DataGridView dGrid;

        public Estados()
        {
            InitializeComponent();
            this.Name ="Estados de cuenta";
            this.addTitle(this.Name);
            dGrid = customGridView1.dGrid;

            fillCombo();
            consultarSaldo(1);   
        }

        private void fillCombo()
        {
            comboBox1.DataSource = Funciones.dbConnect.consulta_ComboBox("select idcuenta,nombre from cuenta");
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "idcuenta";

            cuentaEstado.DataSource = comboBox1.DataSource;
            cuentaEstado.DisplayMember = comboBox1.DisplayMember;
            cuentaEstado.ValueMember = comboBox1.ValueMember;
            isLoad = true;
        }

        private void consultarSaldo(int idcuenta)
        {
            if (isLoad)
            {
                string query = "select nombre as 'Nombre de cuenta',numero as 'Numero de cuenta',concat('Q.',saldo) as 'Saldo' from cuenta where idcuenta = " + idcuenta.ToString();
                dGrid.DataSource = Funciones.dbConnect.consulta_DataGridView(query);
                //dGrid.Columns[0].Visible = false;
            }
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(isLoad) consultarSaldo(Convert.ToInt32(comboBox1.SelectedValue.ToString()));
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            string fechaInicio = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string fechaFin = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string idcuenta = cuentaEstado.SelectedValue.ToString();

            string query = "select m.fecha as 'Fecha', m.referencia as 'Referencia', t.nombre as 'Tipo de transaccion', m.monto as 'Monto' ";
            query += " from movimiento m, transaccion t where m.idtransaccion=t.idtransaccion and m.idcuenta = " + idcuenta;
            query += " and m.fecha <=" + fechaFin + " and m.fecha >=" + fechaInicio;

            DataGridView dGrid = customGridView2.dGrid;
            dGrid.DataSource = Funciones.dbConnect.consulta_DataGridView(query);
        }

        private void cuentaEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
