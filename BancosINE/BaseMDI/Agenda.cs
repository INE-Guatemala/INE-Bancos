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
    public partial class Agenda : BaseForm
    {

        private Boolean isNew = true, ready = false;
        private int selectRow = -1, selectIndex = -1;
        private DataGridView dataGrid;
        private int currentCount = -1;

        public Agenda()
        {
            InitializeComponent();
            this.Name = "Agenda de movimientos";
            addTitle(this.Name);

            FillCombo();
        }

        private void Consultar(int idcuenta)
        {
            currentCount = idcuenta;
            dataGrid = customGridView1.dGrid;

            string query = "select a.idagenda, concat(a.mes,'') as 'Mes', a.dia as 'Dia',a.monto as 'Monto', a.descripcion as 'Descripcion', t.nombre as 'Transaccion', concat(a.estado,'') as 'Estado', t.idtransaccion, a.mes, a.estado ";
            query += " from agenda a, transaccion t where a.idtransaccion=t.idtransaccion and a.idcuenta=" + idcuenta.ToString();
            dataGrid.DataSource = Funciones.dbConnect.consulta_DataGridView(query);
            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[7].Visible = false;
            dataGrid.Columns[8].Visible = false;
            dataGrid.Columns[9].Visible = false;

            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                string b = dataGrid[6, i].Value.ToString();
                int a = Convert.ToInt32(b);
                switch (a)
                {
                    case 1:                        
                        dataGrid[6, i].Value = "Activada";
                        break;
                    case 2:
                        dataGrid[6, i].Value = "Finalizada";
                        break;
                    case 0:
                        dataGrid[6, i].Value = "Desactivada";
                        break;
                }
                b = dataGrid[8, i].Value.ToString();
                a = Convert.ToInt32(b);
                dataGrid[1, i].Value = mesCmb.Items[a].ToString();
            }

            dataGrid.CellMouseDown += dataCuenta_CellMouseDown;
            customGridView1.cms.ItemClicked += cms_ItemClicked;
            dataGrid.CellMouseClick += dataGrid_CellMouseClick;
        }

        void dataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                dataGrid[4, e.RowIndex].ToolTipText = dataGrid[4, e.RowIndex].Value.ToString();
            }
        }

        private void cms_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string s = e.ClickedItem.ToString();
            switch (s)
            {
                case "Editar":
                    {
                        isNew = false;
                        newRegistro_Click(sender, e);

                        estadoCmb.Items.Clear();
                        estadoCmb.Items.Add("Desactivado");
                        estadoCmb.Items.Add("Activo");
                        estadoCmb.Items.Add("Finalizado");
                        estadoCmb.SelectedIndex = 0;

                        mesCmb.SelectedItem = dataGrid[1, selectRow].Value.ToString();
                        diaCmb.SelectedItem = dataGrid[2, selectRow].Value.ToString();
                        montoTbx.Text = dataGrid[3, selectRow].Value.ToString();
                        descripcionTxb.Text = dataGrid[4, selectRow].Value.ToString();
                        estadoCmb.SelectedIndex = Convert.ToInt32(dataGrid[9, selectRow].Value.ToString());
                        transaccionCmb.SelectedValue = Convert.ToInt32(dataGrid[7, selectRow].Value.ToString());
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
            if (MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Funciones.dbConnect.eliminar("agenda", "idagenda =" + selectIndex.ToString());
                Consultar(currentCount);
            }
        }

        private void dataCuenta_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                selectRow = e.RowIndex;
                selectIndex = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                customGridView1.cms.Show(Cursor.Position);
            }
        }

        private void FillCombo()
        {
            cuentaCmb.DataSource = Funciones.dbConnect.consulta_ComboBox("select c.idcuenta as 'idcuenta', concat(c.numero,' - ',c.nombre,' - ',b.nombre) as nombre from cuenta c, banco b where c.idbanco=b.idbanco");
            cuentaCmb.DisplayMember = "nombre";
            cuentaCmb.ValueMember = "idcuenta";

            transaccionCmb.DataSource = Funciones.dbConnect.consulta_ComboBox("select t.idtransaccion as 'idtransaccion', concat(t.clave,' - ',t.nombre,' - ',p.nombre) as 'nombre' from transaccion t, tipo_transaccion p where t.idtipo_transaccion=p.idtipo_transaccion");
            transaccionCmb.DisplayMember = "nombre";
            transaccionCmb.ValueMember = "idtransaccion";

            mesCmb.SelectedIndex = 0;
            diaCmb.SelectedIndex = 0;

            ready = true;
            Consultar(Convert.ToInt32(cuentaCmb.SelectedValue));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ready)
            {
                Consultar(Convert.ToInt32(cuentaCmb.SelectedValue));
            }
        }

        private void newRegistro_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            newRegistro.Visible = false;
            mesCmb.Focus();
            estadoCmb.Items.Clear();
            estadoCmb.Items.Add("Activo");
            estadoCmb.SelectedIndex = 0;
        }

        private void mesCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            diaCmb.Items.Clear();
            int index = mesCmb.SelectedIndex;
            int total = 0;
            if (index == 2) total = 28;
            else if (index == 0) total = 31;
            else
            {
                int r = index % 2;
                if (r == 0) total = 30;
                else total = 31;
            }
            for (int i = 1; i <= total; i++)
            {
                diaCmb.Items.Add(i.ToString());
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            mesCmb.SelectedIndex = 0;
            diaCmb.SelectedIndex = 0;
            montoTbx.Text = "";
            descripcionTxb.Text = "";
            transaccionCmb.SelectedIndex = 0;
            isNew = true;
            panel1.Visible = false;
            newRegistro.Visible = true;
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (montoTbx.Text != "" && descripcionTxb.Text != "")
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("idcuenta", cuentaCmb.SelectedValue.ToString());
                if (diaCmb.SelectedItem != null) dict.Add("dia", diaCmb.SelectedItem.ToString());
                else dict.Add("dia", dataGrid[2, selectRow].Value.ToString());
                dict.Add("mes", mesCmb.SelectedIndex.ToString());
                dict.Add("descripcion", descripcionTxb.Text);
                dict.Add("monto", montoTbx.Text);
                dict.Add("idtransaccion", transaccionCmb.SelectedValue.ToString());

                if (isNew)
                {
                    dict.Add("estado", "1");
                    Funciones.dbConnect.insertar("agenda", dict);
                }
                else
                {
                    dict.Add("estado", estadoCmb.SelectedIndex.ToString());
                    Funciones.dbConnect.actualizar("agenda", dict, "idagenda=" + selectIndex.ToString());
                }
                isNew = true;
                Consultar(currentCount);
                cancelBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No puede dejar ningún campo vacio");
                montoTbx.Focus();
            }
        }
    }
}
