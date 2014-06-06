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
    public partial class conciliacion : BaseForm
    {

        private int selectRow = -1;
        private int selectIndex = -1;
        private Boolean isNew = true;

        
        public conciliacion()
        {
            InitializeComponent();
            this.Name = "Conciliaciones";
            addTitle(this.Name);
            this.llenarcombo();
            this.consultar();
        }

        public void llenarcombo()
        {
            string query = "select idcuenta, concat(numero,'-',nombre) as info from cuenta";
            cmbcuenta.DataSource = Funciones.dbConnect.consulta_ComboBox(query);
   
            cmbcuenta.DisplayMember = "info";
            cmbcuenta.ValueMember = "idcuenta";

        }

        public void consultar()
        {
           // String query = "select * from movimiento";
            String query = "select m.fecha as 'Fecha', c.nombre as 'Nombre Cuenta', m.referencia as 'Referencia', m.monto as 'Monto', m.estado as 'Estado' ";
            query += "from movimiento m, cuenta c";
            
            DataTable data = Funciones.dbConnect.consulta_DataGridView(query);
            this.datagrid.dGrid.DataSource = data;
            
        }

        public void consultar2(string query)
        {
            DataTable data = Funciones.dbConnect.consulta_DataGridView(query);
            this.datagrid.dGrid.DataSource = data;

        }
        
        

        private void newRegistro_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //para fechas
            //aqi va el si es new

            //internet
            //SELECT * FROM Tabla1 WHERE Fecha BETWEEN '2011-09-01' AND '2011-10-01'
            string fechainicial = txtfechainicial.Value.ToString("yyyy-MM-dd");
            string fechafinal = txtfechafinal.Value.ToString("yyyy-MM-dd");

            //MessageBox.Show(fechafinal.Replace("-", ""));
            string fechafinal2 = fechafinal.Replace("-","");
            string fechainicial2 = fechainicial.Replace("-", "");
            //fechafinal = fechafinal.Replace("-","");
            
            //MessageBox.Show(fechafinal.ToString());
            //primera prueba
            //String query = "SELECT  fecha FROM movimiento WHERE fecha BETWEEN " +fechainicial ;
            //query+= " AND ";

            //segunda prueba

            string query = "select m.fecha as 'Fecha', m.referencia as 'Referencia' , m.monto as 'Monto', t.nombre as 'Nombre', m.estado as 'Estado'";
query+=" FROM movimiento m";
query+=" INNER JOIN transaccion t ON m.idtransaccion=t.idtransaccion";
query+=" WHERE m.idcuenta="+cmbcuenta.SelectedValue.ToString();
query+=" AND m.fecha BETWEEN " + fechainicial2.ToString() + " AND " + fechafinal2.ToString();

//emergencia
if (chkoperado.Checked == true)
{
    query += " AND estado=1";
}
if(chkoperado.Checked==false)
{
    query+=" AND estado=0";
}          
//query += " AND estado";
            this.consultar2(query);


        }
        private void Conciliaciones_Load(object sender, EventArgs e)
        {

        }

        private void datagrid_Load(object sender, EventArgs e)
        {

        }

        private void chkoperado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Conciliaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Name = "Conciliaciones";
            this.Load += new System.EventHandler(this.Conciliaciones_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Conciliaciones_Load_1(object sender, EventArgs e)
        {

        }


    }
}
