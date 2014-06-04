using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancosINE.Movimientos
{
    public partial class Movimientos_bancarios : BaseForm
    {
        private DataGridView dGrid;
        private int selectRow = -1;
        private int selectIndex = -1;
        private Boolean isNew = true;
        static double temp=0;
        
        
        
        public Movimientos_bancarios()
        {
            InitializeComponent();
            this.Name = "Movimientos Bancarios";
            addTitle(this.Name);
            dGrid = customGridView1.dGrid;
            llenarCombo();
            llenarCuenta();
            Consultar();
            saldo();
        }

        private void Consultar()
        {
            string query ="select m.idtransaccion as 'No. Transaccion', c.nombre as 'NOMBRE DE CUENTA', tp.nombre as 'TIPO', ";
            query += " t.nombre as 'DETALLE MOVIEMIENTO', m.fecha as 'FECHA', m.referencia as 'NO. REFERENCIA', ";
            query+= "m.monto as 'MONTO' from movimiento m, cuenta c, transaccion t, tipo_transaccion tp ";
            query += " where m.idcuenta = c.idcuenta and c.idcuenta =" + comboBox2.SelectedValue.ToString() + " and m.idtransaccion = t.idtransaccion and t.idtipo_transaccion = tp.idtipo_transaccion";
            DataTable dt = Funciones.dbConnect.consulta_DataGridView(query);
            dGrid.DataSource = dt;
            dGrid.Columns[0].Visible = false;
                //Llenado label 9
            string query2 = "select m.nombre moneda from cuenta c";
            query2 += " INNER JOIN moneda m ON c.idmoneda";
            query2 += " where c.idcuenta=" + comboBox2.SelectedValue.ToString();
            
            Dictionary<string, string> res = Funciones.dbConnect.consultar_un_registro(query2);
            label9.Text = res["moneda"];   

            dGrid.CellMouseDown += dataGridView1_CellMouseDown;
            customGridView1.cms.ItemClicked += cms_Click;

            this.dGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dGrid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
           
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
                        comboBox1.Text = dGrid[3, selectRow].Value.ToString();
                        textBox1.Text = dGrid[5, selectRow].Value.ToString();
                        dateTimePicker1.Text = dGrid[4, selectRow].Value.ToString();
                        textBox3.Text = dGrid[6, selectRow].Value.ToString();
                        temp = Convert.ToDouble(textBox3.Text);
                        break;
                        
                        
                    }
                case "Eliminar":
                    {
                        Eliminar();
                        break;

                    }
            }
        }
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                selectRow = e.RowIndex;
                selectIndex = Convert.ToInt32(dGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                customGridView1.cms.Show(Cursor.Position);

            }
        }

        private void newRegistro_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            textBox1.Focus();
            newRegistro.Visible = false;
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            newRegistro.Visible = true;
            textBox1.Text = "";
            textBox3.Text = "";
            isNew = true;
        }
        private void Eliminar()
        {
            DialogResult res = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminación", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string tabla = "movimiento";
                string condicion = "idmovimiento =" + selectIndex.ToString()+ " and idcuenta = "+ comboBox2.SelectedValue.ToString() ;
                Funciones.dbConnect.eliminar(tabla, condicion);
                Consultar();
                saldo();
            }
        }

        private void Movimientos_bancarios_Load(object sender, EventArgs e)
        {

        }

        private void newRegistro_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            newRegistro.Visible = true;
            textBox1.Text = "";
            textBox3.Text = "";
            isNew = true;
        }
        private void llenarCombo()
        {       // Llena combobox tipo de transaccion
            comboBox1.DataSource = Funciones.dbConnect.consulta_ComboBox("select idtransaccion, nombre from transaccion");
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "idtransaccion";
        }

        private void llenarCuenta()
        {   // Llena combobox de cuentas
            comboBox2.DataSource = Funciones.dbConnect.consulta_ComboBox("select idcuenta, nombre from cuenta");
            comboBox2.DisplayMember = "nombre";
            comboBox2.ValueMember = "idcuenta";
        }
        private void button1_Click_1(object sender, EventArgs e)
        {           //Boton Eliminar
            Eliminar();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "")
            {               // Boton editar
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("referencia", textBox1.Text);
                dict.Add("fecha", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                dict.Add("monto", textBox3.Text);
                dict.Add("idtransaccion", comboBox1.SelectedValue.ToString()) ;

                
                

                if (isNew)
                {
                                                                // Insercion nuevo registro
                    dict.Add("idcuenta", comboBox2.SelectedValue.ToString());
                    Funciones.dbConnect.insertar("movimiento", dict);

                                                                    ///Funcion de calculo de saldo
                    double aoc = Convert.ToDouble(textBox3.Text);
                    string op = "select idtipo_transaccion from transaccion where idtransaccion ="+ comboBox1.SelectedValue.ToString();
                    Dictionary<string, string> res = Funciones.dbConnect.consultar_un_registro(op);
                    string query4 = "select c.saldo from cuenta  c where c.idcuenta =" + comboBox2.SelectedValue;
                    Dictionary<string, string> res2 = Funciones.dbConnect.consultar_un_registro(query4);
                    double saldotemp = Convert.ToDouble(res2["saldo"]);
                    double abono = 0;
                    double cargo = 0;

                    if (res["idtipo_transaccion"] == "1")
                    {
                        abono += aoc;
                        saldotemp += abono;
                    }
                    else
                    {
                        cargo += aoc;
                        saldotemp -= cargo;
                    }

                    
                    dict = new Dictionary<string,string>();
                    dict.Add("saldo", saldotemp.ToString());
                    Funciones.dbConnect.actualizar("cuenta",dict, "idcuenta ="+comboBox2.SelectedValue.ToString());
                                       
                }
                else
                {
                    Funciones.dbConnect.actualizar("movimiento", dict, "idmovimiento =" + selectIndex.ToString() );
                    
                                // Calculo de Saldo 'cuenta' si se edita un registro
                    string op = "select idtipo_transaccion from transaccion where idtransaccion =" + comboBox1.SelectedValue.ToString();
                    Dictionary<string, string> res = Funciones.dbConnect.consultar_un_registro(op);
                    string query4 = "select c.saldo from cuenta  c where c.idcuenta =" + comboBox2.SelectedValue;
                    Dictionary<string, string> res2 = Funciones.dbConnect.consultar_un_registro(query4);
                    double saldotemp = Convert.ToDouble(res2["saldo"]);
                    double cambio = Convert.ToDouble(textBox3.Text);
                    
                    if (res["idtipo_transaccion"] == "1")
                    {
                        saldotemp -= temp;
                        saldotemp += cambio;
                        
                    }
                    else
                    {
                        saldotemp += temp;
                        saldotemp -= cambio;
                    }
                    

                    dict = new Dictionary<string, string>();
                    dict.Add("saldo", saldotemp.ToString());
                    Funciones.dbConnect.actualizar("cuenta", dict, "idcuenta =" + comboBox2.SelectedValue.ToString());


                }
                isNew = true;
                button1_Click(sender, e);
                Consultar();
                saldo();
            }
            else
            {

            }

        }
        private void saldo()
        {
            label6.Text = "Saldo :";
            string query = "select saldo from cuenta where idcuenta =" + comboBox2.SelectedValue;
            Dictionary<string,string> res = Funciones.dbConnect.consultar_un_registro(query);
       
            label7.Text =res["saldo"];
            

        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";

            Consultar();
            saldo();
        }
        
    }
}
