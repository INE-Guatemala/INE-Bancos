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
        
        public Movimientos_bancarios()
        {
            InitializeComponent();
            this.Name = "Movimientos Bancarios";
            addTitle(this.Name);
            dGrid = customGridView1.dGrid;
            Consultar();
            saldo();
            llenarCombo();
            
        }

        private void Consultar()
        {
            DataTable dt = Funciones.dbConnect.consulta_DataGridView("select m.idtransaccion as 'No. Transaccion', c.nombre as 'NOMBRE DE CUENTA', tp.nombre as 'TIPO', t.nombre as 'DETALLE MOVIEMIENTO', m.fecha as 'FECHA', m.referencia as 'NO. REFERENCIA', m.monto as 'MONTO' from movimiento m, cuenta c, transaccion t, tipo_transaccion tp where m.idcuenta = c.idcuenta and m.idtransaccion = t.idtransaccion and t.idtipo_transaccion = tp.idtipo_transaccion");
            dGrid.DataSource = dt;
            dGrid.Columns[0].Visible = false;

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

     /*   private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("referencia", textBox1.Text);
                dict.Add("fecha", textBox2.Text);
                dict.Add("monto", textBox3.Text);
                dict.Add("idtransaccion", comboBox1.Text);
                dict.Add("idcuenta", "0");

                if (isNew)
                {
                    Funciones.dbConnect.insertar("movimiento", dict);
                }
                else
                {
                    Funciones.dbConnect.actualizar("movimiento", dict, "idmovimiento =" + selectIndex.ToString());
                }
                isNew = true;
                button1_Click(sender, e);
                Consultar();
            }
            else
            {

            }
        }  */
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
                string condicion = "idmovimiento =" + selectIndex.ToString();
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
        {
            comboBox1.DataSource = Funciones.dbConnect.consulta_ComboBox("select idtransaccion, nombre from transaccion");
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "idtransaccion";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "")
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("referencia", textBox1.Text);
                dict.Add("fecha", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                dict.Add("monto", textBox3.Text);
                dict.Add("idtransaccion", comboBox1.SelectedValue.ToString()) ;
                dict.Add("idcuenta", "1");

                if (isNew)
                {
                    Funciones.dbConnect.insertar("movimiento", dict);
                }
                else
                {
                    Funciones.dbConnect.actualizar("movimiento", dict, "idmovimiento =" + selectIndex.ToString());
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
            int n;
            double abono=0;
            double cargo=0;
            double saldo=0;
            string op;
            double aoc=0;
            int i = 0;
            n = dGrid.Rows.Count-1;
                       
            for (i = 0; i<=n; i++)  
            {
                aoc = Convert.ToDouble(dGrid[6, i].Value.ToString());
                op = (dGrid[2,i].Value.ToString());
                if (op == "Abono")
                {
                    abono += aoc;
                }
                else
                {
                    cargo += aoc;
                }
                                                
              }
            saldo = abono - cargo;
            label7.Text =Convert.ToString("Q. "+saldo);
            

        }
            
        
    }
}
