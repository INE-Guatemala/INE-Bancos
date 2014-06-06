using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using numerosaletrascanel;
using System.Collections;

namespace BancosINE
{
    public partial class Cheques:BaseForm
    {
        numerosletras conv = new numerosletras();

        private int selectRow = -1;
        private int selectIndex = -1;
        private Boolean isNew = true;
        public Cheques()
        {
            InitializeComponent();
            this.Name = "Cheques";            
            addTitle(this.Name);            
            this.llenarcombo();
            this.consultar();
        }

        
        public void limpiartextobox()
        {
            txtconcepto.Text = string.Empty;
            //txtbeneficiario.Text =string.Empty;
            txtvalor.Text = "0";
            txtcheque.Text =string.Empty;
            
        }
       public void consultar()
        {          
            string query="select ch.idcheque No_cheque, c.nombre Nombre_Cuenta, c.numero Numero_Cuenta, ch.fecha Fecha, a.nombre Agente, ch.valor Valor, ch.concepto Concepto";
            query+=" FROM cheque ch";
            query+=" INNER JOIN agente a ON ch.idagente=a.idagente";
            query+=" INNER JOIN cuenta c ON ch.idcuenta=c.idcuenta";
           DataTable data=Funciones.dbConnect.consulta_DataGridView(query);           
           this.datagrid.dGrid.DataSource = data;
           //datagrid.dGrid.Columns[0].Visible = false;


           //dGrid.CellMouseDown += dataGridView1_CellMouseDown;
           datagrid.dGrid.CellMouseDown += dataGridView1_CellMouseDown;
           
           //customGridView1.cms.ItemClicked += cms_Click;
           this.datagrid.cms.ItemClicked += cms_Click;
        }

       public void llenarcombo()
       {
           
           cmbagente.DataSource = Funciones.dbConnect.consulta_ComboBox("select idagente, nombre from agente");
           cmbagente.DisplayMember = "nombre";
           cmbagente.ValueMember = "idagente";

           //cmbcuenta.DataSource = Funciones.dbConnect.consulta_ComboBox("select idcuenta, nombre from cuenta");
           string query = "select idcuenta, concat(numero,'-',nombre) as info from cuenta";
           cmbcuenta.DataSource = Funciones.dbConnect.consulta_ComboBox(query);
           //"SELECT IdCliente, (CONVERT(varchar, IdCliente) + ', ' + Nombre) AS DatosCombinados " + "FROM Clientes";
           //cmbcuenta.DisplayMember = "nombre"; //sentencia bien
           cmbcuenta.DisplayMember = "info";
           cmbcuenta.ValueMember = "idcuenta";
           
           cmbcuenta2.DataSource = Funciones.dbConnect.consulta_ComboBox(query);
           cmbcuenta2.DisplayMember = "info";
           cmbcuenta2.ValueMember = "idcuenta";
       }

       private void cms_Click(object sender, ToolStripItemClickedEventArgs e)
       {
           
           string s = e.ClickedItem.ToString();
           
           
           switch (s)
           {
               case "Editar":
                   {
                       isNew = false;
                       newRegistro_Click(sender, e);
                       txtcheque.Text=datagrid.dGrid[0,selectRow].Value.ToString();
                       txtnombrecuenta.Text  = datagrid.dGrid[1, selectRow].Value.ToString();
                       //agregar combocuenta Pendiente
                       txtnumerocuenta.Text  = datagrid.dGrid[2, selectRow].Value.ToString();
                       txtfecha.Text =  datagrid.dGrid[3, selectRow].Value.ToString();
                       cmbagente.Text= datagrid.dGrid[4, selectRow].Value.ToString();
                       txtvalor.Text = datagrid.dGrid[5, selectRow].Value.ToString();
                       txtconcepto.Text = datagrid.dGrid[6, selectRow].Value.ToString();
                       break;
                   }
               case "Eliminar":
                   {
                       //Eliminar();

                       DialogResult res = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminación", MessageBoxButtons.YesNo);
                       if (res == DialogResult.Yes)
                       {
                           string tabla = "cheque";
                           string condicion = "idcheque =" + selectIndex.ToString();
                           Funciones.dbConnect.eliminar(tabla, condicion);
                           consultar();
                       }
                       break;
                   }

           }
       }


       private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
       {
           if (e.Button == MouseButtons.Right)
           {
               selectRow = e.RowIndex;

               //selectIndex = Convert.ToInt32(dGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
               selectIndex = Convert.ToInt32(datagrid.dGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
               
               //customGridView1.cms.Show(Cursor.Position);
               this.datagrid.cms.Show(Cursor.Position);

           }
       }

       private void newRegistro_Click(object sender, EventArgs e)
       {
           panel1.Visible = true;
       }

       private void txtvalor_KeyUp(object sender, KeyEventArgs e)
       {
           if (string.IsNullOrEmpty(txtvalor.Text))
           {
               txtvalor.Text = "0";
               txtvalor.SelectAll();
               lblcantletras.Text = conv.ConvierteaLetras(0.00);
           }
           else
           {
               double valorcheque = Convert.ToDouble(txtvalor.Text);
               lblcantletras.Text = conv.ConvierteaLetras(valorcheque);
            
           }
       }

       private void button1_Click(object sender, EventArgs e)
       {
           panel1.Visible = false;
           newRegistro.Visible = true;
          //limpiar los textobx
           this.limpiartextobox();
           isNew = true;
       }

       private void button2_Click(object sender, EventArgs e)
       {
           //if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
           //{
               Dictionary<string, string> dict = new Dictionary<string, string>();
                //canel
               dict.Add("idcheque", txtcheque.Text);
               dict.Add("fecha", txtfecha.Value.ToString("yyyy-MM-dd HH:mm:ss"));
               dict.Add("idcuenta", cmbcuenta.SelectedValue.ToString());
               dict.Add("idagente",cmbagente.SelectedValue.ToString());
               //dict.Add("beneficiario", txtbeneficiario.Text);
               dict.Add("concepto",txtconcepto.Text);
               dict.Add("valor", txtvalor.Text);

               if (isNew)
               {
                   Funciones.dbConnect.insertar("cheque", dict);
               }
               else
               {
                   //Funciones.dbConnect.actualizar("cheque", dict, "idcheque =" + selectIndex.ToString());
                   
                   //Funciones.dbConnect.actualizar("cheque", dict, "idcheque =" + txtcheque.Text.ToString());
                   Funciones.dbConnect.actualizar("cheque", dict, "idcheque ="+txtcheque.Text);
                   
               }
               isNew = true;
               button1_Click(sender, e);
               consultar();
                
           //}
       }

       private void label3_Click(object sender, EventArgs e)
       {

       }

       

       private void cmbcuenta_SelectionChangeCommitted(object sender, EventArgs e)
       {
          // String query2 = "select *from cuenta where idcuenta=" + cmbcuenta.SelectedValue.ToString();
           String query2="select c.numero numerocuenta,c.nombre nombrecuenta, c.saldo saldocuenta,tc.nombre tipocuenta, b.nombre banco, m.nombre moneda";
            query2+=" FROM cuenta c";
            query2+=" INNER JOIN tipo_cuenta tc ON c.idtipo_cuenta = tc.idtipo_cuenta";
            query2+=" INNER JOIN banco b ON c.idbanco=b.idbanco ";
            query2+="INNER JOIN moneda m ON c.idmoneda=m.idmoneda ";
            query2 += "where c.idcuenta="+cmbcuenta.SelectedValue.ToString();


           ArrayList infocuenta = Funciones.dbConnect.consultar(query2);
           foreach (Dictionary<string, string> dict in infocuenta)
           {
               txtnombrecuenta.Text = dict["nombrecuenta"];
               txtnumerocuenta.Text = dict["numerocuenta"];
               txtsaldocuenta.Text = dict["saldocuenta"];
               txtbanco.Text= dict["banco"];
               txttipocuenta.Text= dict["tipocuenta"];
               txtmoneda.Text= dict["moneda"];

           }
           

       }

       private void cmbcuenta2_SelectionChangeCommitted(object sender, EventArgs e)
       {
           


           String query2 = "select c.numero numerocuenta,c.nombre nombrecuenta, c.saldo saldocuenta,tc.nombre tipocuenta, b.nombre banco, m.nombre moneda";
           query2 += " FROM cuenta c";
           query2 += " INNER JOIN tipo_cuenta tc ON c.idtipo_cuenta = tc.idtipo_cuenta";
           query2 += " INNER JOIN banco b ON c.idbanco=b.idbanco ";
           query2 += "INNER JOIN moneda m ON c.idmoneda=m.idmoneda ";
           query2 += "where c.idcuenta=" + cmbcuenta2.SelectedValue.ToString();

           
string query="select ch.idcheque No_cheque,";// c.nombre Nombre_Cuenta, c.numero Numero_Cuenta, 
           query+=" ch.fecha Fecha, a.nombre Agente, ch.valor Valor, ch.concepto Concepto";
query+=" FROM cheque ch";
query+=" INNER JOIN agente a ON ch.idagente=a.idagente";
//query+=" INNER JOIN cuenta c ON ch.idcuenta=c.idcuenta";
query += " WHERE ch.idcuenta= " + cmbcuenta2.SelectedValue.ToString();

           datagrid2.dGrid.DataSource = Funciones.dbConnect.consulta_DataGridView(query);
           ArrayList infocuenta = Funciones.dbConnect.consultar(query2);
           foreach (Dictionary<string, string> dict in infocuenta)
           {
               txtnombrecuenta2.Text = dict["nombrecuenta"];
               txtnumerocuenta2.Text = dict["numerocuenta"];
               txtsaldo2.Text = dict["saldocuenta"];
               txtbanco2.Text = dict["banco"];
               txttipocuenta2.Text = dict["tipocuenta"];
               txtmoneda2.Text = dict["moneda"];
           }

       }

       private void button3_Click(object sender, EventArgs e)
       {
           panel2.Visible = true;
       }

       
       



    }
}
