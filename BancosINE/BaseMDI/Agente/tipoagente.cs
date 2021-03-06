﻿using System;
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
    public partial class tipoagente : BaseForm
    {

        private DataGridView dataGrid;
        private Boolean isNew = true;
        private int selectIndex = -1, selectRow = -1;

        public tipoagente()
        {
            InitializeComponent();
            this.Name = "Tipos de agente";         
            addTitle(this.Name);
            dataGrid = customGridView1.dGrid;
            Consultar();
        }

        private void Consultar(){
            dataGrid.DataSource = Funciones.dbConnect.consulta_DataGridView("select * from tipo_agente");
            dataGrid.Columns[0].Visible = false;

            dataGrid.CellMouseDown += dataGridView1_CellMouseDown;
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
                        textBox1.Text = dataGrid[1, selectRow].Value.ToString();
                        richTextBox1.Text = dataGrid[2, selectRow].Value.ToString();
                        break;
                    }
                case "Eliminar":
                    {
                        Eliminar();
                        break;
                    }
            }
        }

        private void Eliminar()
        {
            DialogResult res = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminación", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string tabla = "tipo_agente";
                string condicion = "idtipo_agente =" + selectIndex.ToString();
                Funciones.dbConnect.eliminar(tabla, condicion);
                Consultar();
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                selectRow = e.RowIndex;
                selectIndex = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                customGridView1.cms.Show(Cursor.Position);

            }
        }

        private void newRegistro_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isNew = true;
            panel1.Visible = false;
            textBox1.Text = "";
            richTextBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && richTextBox1.Text != "") { 
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("nombre", textBox1.Text);
                dict.Add("descripcion", richTextBox1.Text);
                if (isNew)
                {
                    Funciones.dbConnect.insertar("tipo_agente", dict);
                }
                else
                {
                    Funciones.dbConnect.actualizar("tipo_agente", dict, "idtipo_agente=" + selectIndex);
                }
                
                button1_Click(sender, e);
                Consultar();
            }
        }
    }
}
