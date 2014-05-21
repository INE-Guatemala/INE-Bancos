using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancosINE.Transacciones
{
    public partial class Transaccion : BaseForm
    {

        private DataGridView dGrid;
        private int selectRow = -1;
        private int selectIndex = -1;
        private Boolean isNew = true;

        public Transaccion()
        {
            InitializeComponent();
            this.Name = "Transacciones";
            addTitle(this.Name);
            dGrid = customGridView1.dGrid;
            Consultar();
            FillCombo();
        }

        private void FillCombo()
        {
            comboBox1.DataSource = Funciones.dbConnect.consulta_ComboBox("select idtipo_transaccion, nombre from tipo_transaccion");
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "idtipo_transaccion";
        }

        private void Consultar()
        {
            string query = "select t.idtransaccion, t.nombre as 'Nombre' ,t.clave as 'Clave',t.descripcion as 'Descripción', i.nombre as 'Tipo', i.idtipo_transaccion from transaccion t, tipo_transaccion i where t.idtipo_transaccion=i.idtipo_transaccion";
            dGrid.DataSource = Funciones.dbConnect.consulta_DataGridView(query);
            dGrid.Columns[0].Visible = false;
            dGrid.Columns[5].Visible = false;

            dGrid.CellMouseDown += dataGridView1_CellMouseDown;
            customGridView1.cms.ItemClicked += cms_Click;
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
                        textBox1.Text = dGrid[1, selectRow].Value.ToString();
                        textBox2.Text = dGrid[2, selectRow].Value.ToString();
                        richTextBox1.Text = dGrid[3, selectRow].Value.ToString();
                        comboBox1.SelectedValue = Convert.ToInt32(dGrid[5, selectRow].Value.ToString());                        
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && richTextBox1.Text != "")
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("nombre", textBox1.Text);
                dict.Add("clave", textBox2.Text);
                dict.Add("descripcion", richTextBox1.Text);
                dict.Add("idtipo_transaccion", comboBox1.SelectedValue.ToString());

                if (isNew)
                {
                    Funciones.dbConnect.insertar("transaccion", dict);
                }
                else
                {
                    Funciones.dbConnect.actualizar("transaccion", dict, "idtransaccion =" + selectIndex.ToString());
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
            richTextBox1.Text = "";
            comboBox1.SelectedIndex = 0;
            isNew = true;
        }

        private void Eliminar()
        {
            DialogResult res = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminación", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string tabla = "transaccion";
                string condicion = "idtransaccion =" + selectIndex.ToString();
                Funciones.dbConnect.eliminar(tabla, condicion);
                Consultar();
            }
        }
    }
}
