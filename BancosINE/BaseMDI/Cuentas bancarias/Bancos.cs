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
    public partial class Bancos : BaseForm
    {

        private DataGridView dGrid;
        private int selectRow = -1;
        private int selectIndex = -1;
        private Boolean isNew = true;

        public Bancos()
        {
            InitializeComponent();
            this.Name = "Bancos";         
            addTitle(this.Name);
            dGrid = customGridView1.dGrid;
            Consultar();            
        }

        private void Consultar()
        {
            DataTable dt = Funciones.dbConnect.consulta_DataGridView("select * from banco");
            dGrid.DataSource = dt;
            dGrid.Columns[0].Visible = false;

            dGrid.CellMouseDown += dataGridView1_CellMouseDown;
            customGridView1.cms.ItemClicked += cms_Click;
        }

        private void cms_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            string s = e.ClickedItem.ToString();
            switch (s){
                case "Editar":
                    {
                        isNew = false;
                        newRegistro_Click(sender, e);
                        textBox1.Text = dGrid[1, selectRow].Value.ToString();
                        textBox2.Text = dGrid[2, selectRow].Value.ToString();
                        textBox3.Text = dGrid[3, selectRow].Value.ToString();
                        break;
                    }
                case "Eliminar":
                    {
                        Eliminar();
                        break;
                    }
            }
        }

        public override void pressButton1()
        {
            base.pressButton1();
            MessageBox.Show("Hola desde Override");
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "") { 
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("nombre", textBox1.Text);
                dict.Add("telefono", textBox2.Text);
                dict.Add("direccion", textBox3.Text);

                if (isNew)
                {
                    Funciones.dbConnect.insertar("banco", dict);    
                }
                else
                {
                    Funciones.dbConnect.actualizar("banco", dict, "idbanco ="+selectIndex.ToString());
                }
                isNew = true;
                button1_Click(sender, e);
                Consultar();
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            newRegistro.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            isNew = true;
        }

        private void Eliminar()
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                string tabla = "banco";
                string condicion = "idbanco =" + selectIndex.ToString();
                Funciones.dbConnect.eliminar(tabla,condicion );
                Consultar();
            }
        }
    }
}
