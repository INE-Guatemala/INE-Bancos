/* 
 MODULO: Conciliacion Bancaria
 RESPONSABLE: Rony Alejandro Caracun Cruz
 ITERACIONES:  Concernientes a las 2 y 3
 DESCRIPCION: En base a consultas sobre movimientos contra datos bancarios (estados de cuenta) se estable una comparacion
              de los datos en sistema vrs los datos Bancarios para sus usos p

*/
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
    public partial class Conciliacion : BaseForm
    {

        private Boolean isNew = true;
        private int selectRow = -1, selectIndex = -1;
       private DataGridView dataCuenta;

        public Conciliacion()
        {
            InitializeComponent();
            this.Name = "Conciliacion";
            addTitle(this.Name);

            llenarCombos();
            Consultar();
        }

        private void llenarCombos()
        {

            bancoCmb.DataSource = Funciones.dbConnect.consulta_ComboBox("select idbanco, nombre from banco");
            bancoCmb.DisplayMember = "nombre";
            bancoCmb.ValueMember = "idbanco";

            cuentaCmb.DataSource = Funciones.dbConnect.consulta_ComboBox("select idcuenta, concat(numero,' - ',nombre) as numero from cuenta");
   
            cuentaCmb.DisplayMember = "numero";
            cuentaCmb.ValueMember = "idcuenta";           

        
        }

        private void Consultar()
        {
            dataCuenta = customGridView1.dGrid;

            //string query = "select c.idcuenta as 'Numero Cuenta',c.nombre as 'Titular' ,c.numero as 'Numero', t.nombre as 'Tipo de cuenta', m.monto as 'Valor', b.nombre as 'Banco', b.idbanco, t.idtipo_cuenta, m.idmovimiento ";
           // query += "from cuenta c, banco b, tipo_cuenta t, movimiento m where c.idtipo_cuenta=t.idtipo_cuenta and c.idcuenta=m.idcuenta ";  //and c.idbanco=b.idbanco
            
            
            string query = " select c.numero NumeroCuenta,c.nombre NombreCuenta, c.estado Estado, m.fecha Fecha, m.monto Monto, m.referencia REF FROM cuenta c INNER JOIN movimiento m ON c.idcuenta = m.idcuenta";
 
            
            dataCuenta.DataSource = Funciones.dbConnect.consulta_DataGridView(query);
          dataCuenta.Columns[0].Visible = false;
        dataCuenta.Columns[1].Visible = false;
     

            dataCuenta.CellMouseDown += dataCuenta_CellMouseDown;
            customGridView1.cms.ItemClicked += cms_ItemClicked;
        }

        void cms_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string s = e.ClickedItem.ToString();
            switch (s)
            {
                case "Editar":
                    {
                        isNew = false;
                        newRegistro_Click(sender, e);
                        ConciliacionTxt.Text = dataCuenta[1, selectRow].Value.ToString();
                        //numeroTxt.Text = dataCuenta[2, selectRow].Value.ToString();
                        bancoCmb.SelectedValue = Convert.ToInt32(dataCuenta[6, selectRow].Value.ToString());
                        cuentaCmb.SelectedValue = Convert.ToInt32(dataCuenta[7, selectRow].Value.ToString());
                      
                        break;
                    }
                case "Eliminar":
                    {
                        Eliminar();
                        break;
                    }
            }
        }

        void dataCuenta_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                selectRow = e.RowIndex;
                selectIndex = Convert.ToInt32(dataCuenta.Rows[e.RowIndex].Cells[0].Value.ToString());
                customGridView1.cms.Show(Cursor.Position);
            }
        }

        private void newRegistro_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            ConciliacionTxt.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConciliacionTxt.Text = "";
            //numeroTxt.Text = "";
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ConciliacionTxt.Text != "" && numeroTxt.Text != "")
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("nombre", ConciliacionTxt.Text);
                dict.Add("numero", numeroTxt.Text);
                dict.Add("idbanco", bancoCmb.SelectedValue.ToString());
                dict.Add("idcuenta", cuentaCmb.SelectedValue.ToString());
               // dict.Add("idtipo_moneda", monedaCmb.SelectedValue.ToString());
                if (isNew)
                {
                    Funciones.dbConnect.insertar("cuenta", dict);
                }
                else
                {
                    Funciones.dbConnect.actualizar("cuenta", dict, "idcuenta = " + selectIndex.ToString());
                }
                isNew = true;
                button1_Click(sender, e);
                Consultar();
            }
            else
            {
                MessageBox.Show("No puede dejar ningún campo vacío");
                ConciliacionTxt.Focus();
            }
        }

        private void Eliminar()
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Funciones.dbConnect.eliminar("cuenta", "idcuenta ="+selectIndex.ToString());
                Consultar();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Conciliacion_Load(object sender, EventArgs e)
        {
            FechaTxt.Text = DateTime.Now.ToLongDateString();
        }

        private void customGridView1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FechaTxt_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void bancoCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
