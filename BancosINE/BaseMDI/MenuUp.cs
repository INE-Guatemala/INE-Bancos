using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BancosINE
{
    public partial class MenuUp : UserControl
    {

        private ArrayList array = new ArrayList();
        private MDI mdi;

        public MenuUp()
        {
            InitializeComponent();
            prevLbl.Text = "";
            nextLbl.Text = "";
            
        }

        public void sendMDI(MDI m){
            mdi = m;
        }

        public void addPage(string nombre)
        {
            Funciones.array.Add(nombre);
            listadoPages.Items.Add(nombre);
            listadoPages.Items[listadoPages.Items.Count-1].ForeColor = Color.White;
            setPrevNextLbl();
        }

        public void removePage(string nombre)
        {

            for (int i = 0; i <= Funciones.array.Count - 1; i++)
            {
                if (nombre == Funciones.array[i].ToString())
                {
                    listadoPages.Items.RemoveAt(i);
                    Funciones.array.RemoveAt(i);
                }
            }
            setPrevNextLbl();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mdi.prevPage();
            setPrevNextLbl();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mdi.nextPage();
            setPrevNextLbl();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listadoPages.Items.Count>0) listadoPages.Show(Cursor.Position);
        }

        private void listadoPages_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (listadoPages.Items.Count > 0)
            {
                mdi.goPage(e.ClickedItem.ToString());
                setPrevNextLbl();
            }
        }

        public void setPrevNextLbl()
        {
            if (Funciones.currentPage >= 1)
            {
                prevLbl.Text = Funciones.array[Funciones.currentPage - 1].ToString();
            }
            else
            {
                prevLbl.Text = "";
            }
            if (Funciones.currentPage != (Funciones.array.Count - 1))
            {
                nextLbl.Text = Funciones.array[Funciones.currentPage + 1].ToString();
            }
            else
            {
                nextLbl.Text = "";
            }
        }
    }
}
