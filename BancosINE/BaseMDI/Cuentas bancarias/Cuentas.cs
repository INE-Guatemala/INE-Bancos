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
    public partial class Cuentas : BaseForm
    {

        private Boolean isNew = true;
        private int selectRow = -1, selectIndex = -1;
        private DataGridView dataCuenta;

        public Cuentas()
        {
            InitializeComponent();
            this.Name = "Cuentas Bancarias";
            addTitle(this.Name);

            llenarCombos();
            Consultar();
        }

        private void llenarCombos()
        {

            bancoCmb.DataSource = Funciones.dbConnect.consulta_ComboBox("select idbanco, nombre from banco");
            bancoCmb.DisplayMember = "nombre";
            bancoCmb.ValueMember = "idbanco";

            cuentaCmb.DataSource = Funciones.dbConnect.consulta_ComboBox("select idtipo_cuenta, concat(nombre,' - ',descripcion) as nombre from tipo_cuenta");
            cuentaCmb.DisplayMember = "nombre";
            cuentaCmb.ValueMember = "idtipo_cuenta";           

            monedaCmb.DataSource = Funciones.dbConnect.consulta_ComboBox("select idmoneda, concat(nombre,' - ',descripcion) as nombre from moneda");
            monedaCmb.DisplayMember = "nombre";
            monedaCmb.ValueMember = "idmoneda";
        }

        private void Consultar()
        {
            dataCuenta = customGridView1.dGrid;

            string query = "select c.idcuenta as 'id',c.nombre as 'Nombre' ,c.numero as 'Número', t.nombre as 'Tipo de cuenta', m.nombre as 'Moneda', b.nombre as 'Banco', b.idbanco, t.idtipo_cuenta, m.idmoneda ";
            query += "from cuenta c, banco b, tipo_cuenta t, moneda m where c.idtipo_cuenta=t.idtipo_cuenta and c.idmoneda=m.idmoneda and c.idbanco=b.idbanco";
            dataCuenta.DataSource = Funciones.dbConnect.consulta_DataGridView(query);
            dataCuenta.Columns[0].Visible = false;
            dataCuenta.Columns[6].Visible = false;
            dataCuenta.Columns[7].Visible = false;
            dataCuenta.Columns[8].Visible = false;

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
                        nombreTxt.Text = dataCuenta[1, selectRow].Value.ToString();
                        numeroTxt.Text = dataCuenta[2, selectRow].Value.ToString();
                        bancoCmb.SelectedValue = Convert.ToInt32(dataCuenta[6, selectRow].Value.ToString());
                        cuentaCmb.SelectedValue = Convert.ToInt32(dataCuenta[7, selectRow].Value.ToString());
                        monedaCmb.SelectedValue = Convert.ToInt32(dataCuenta[8, selectRow].Value.ToString());
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
            nombreTxt.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombreTxt.Text = "";
            numeroTxt.Text = "";
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nombreTxt.Text != "" && numeroTxt.Text != "")
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("nombre", nombreTxt.Text);
                dict.Add("numero", numeroTxt.Text);
                dict.Add("idbanco", bancoCmb.SelectedValue.ToString());
                dict.Add("idtipo_cuenta", cuentaCmb.SelectedValue.ToString());
                dict.Add("idmoneda", monedaCmb.SelectedValue.ToString());
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
                nombreTxt.Focus();
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
    }
}
