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
    public partial class TipoCuentas : BaseForm
    {

        private DataGridView dataCuenta, dataMoneda;
        private Boolean isNewCuenta = true, isNewMoneda = true, cuentaOp = false;
        private int selectCuenta, selectINDCuenta, selectMoneda, selectINDMoneda;           

        public TipoCuentas()
        {
            InitializeComponent();
            this.Name = "Tipos de cuentas y tipos de moneda";
            addTitle(this.Name);

            dataCuenta = customGridView1.dGrid;
            dataMoneda = customGridView2.dGrid;
            Consulta();
        }

        private void Consulta()
        {
            dataCuenta.DataSource = Funciones.dbConnect.consulta_DataGridView("select * from tipo_cuenta");
            dataMoneda.DataSource = Funciones.dbConnect.consulta_DataGridView("select * from moneda");

            dataCuenta.Columns[0].Visible = false;
            dataMoneda.Columns[0].Visible = false;

            dataCuenta.CellMouseDown += dataCuenta_CellMouseDown;
            dataMoneda.CellMouseDown += dataMoneda_CellMouseDown;
            customGridView1.cms.ItemClicked += cms_Click;
        }

        private void cms_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            string s = e.ClickedItem.ToString();
            if (cuentaOp)
            {                
                switch (s)
                {
                    case "Editar":
                        {
                            isNewCuenta = false;
                            newCuenta_Click(sender, e);
                            textBox1.Text = dataCuenta[1, selectINDCuenta].Value.ToString();
                            textBox2.Text = dataCuenta[2, selectINDCuenta].Value.ToString();
                            break;
                        }
                    case "Eliminar":
                        {
                            EliminarCuenta();
                            break;
                        }
                }
            }
            else
            {
                switch (s)
                {
                    case "Editar":
                        {
                            isNewMoneda = false;
                            newMoneda_Click(sender, e);
                            textBox3.Text = dataMoneda[1, selectINDMoneda].Value.ToString();
                            textBox4.Text = dataMoneda[2, selectINDMoneda].Value.ToString();
                            break;
                        }
                    case "Eliminar":
                        {
                            EliminarMoneda();
                            break;
                        }
                }
            }
        }

        private void newCuenta_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            textBox1.Focus();
        }

        private void newMoneda_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            textBox3.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            panel1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            panel2.Visible = false;
        }

        private void dataCuenta_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                selectINDCuenta = e.RowIndex;
                selectCuenta = Convert.ToInt32(dataCuenta.Rows[e.RowIndex].Cells[0].Value.ToString());
                cuentaOp = true;
                customGridView1.cms.Show(Cursor.Position);
                
            }
        }

        private void dataMoneda_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                selectINDMoneda = e.RowIndex;
                selectMoneda = Convert.ToInt32(dataMoneda.Rows[e.RowIndex].Cells[0].Value.ToString());
                cuentaOp = false;
                customGridView1.cms.Show(Cursor.Position);                
            }
        }

        private void EliminarCuenta()
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Funciones.dbConnect.eliminar("tipo_cuenta", "idtipo_cuenta =" + selectCuenta.ToString());
                Consulta();
            }
        }

        private void EliminarMoneda()
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Funciones.dbConnect.eliminar("moneda", "idmoneda =" + selectMoneda.ToString());
                Consulta();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("nombre", textBox1.Text);
                dict.Add("descripcion", textBox2.Text);
                
                if (isNewCuenta)
                {
                    Funciones.dbConnect.insertar("tipo_cuenta", dict);
                }
                else
                {
                    Funciones.dbConnect.actualizar("tipo_cuenta", dict, "idtipo_cuenta =" + selectCuenta.ToString());
                }
                isNewCuenta = true;
                button3_Click(sender, e);
                Consulta();
            }
            else
            {
                MessageBox.Show("No puede dejar ningún campo en blanco");
                textBox1.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox4.Text != "")
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("nombre", textBox3.Text);
                dict.Add("descripcion", textBox4.Text);

                if (isNewMoneda)
                {
                    Funciones.dbConnect.insertar("moneda", dict);
                }
                else
                {
                    Funciones.dbConnect.actualizar("moneda", dict, "idmoneda =" + selectMoneda.ToString());
                }
                isNewMoneda = true;
                button5_Click(sender, e);
                Consulta();
            }
            else
            {
                MessageBox.Show("No puede dejar ningún campo en blanco");
                textBox3.Focus();
            }
        }
    }
}
