using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancosINE
{
    public partial class MDI : Form
    {

        private int sobrante = 150;
        private login fLogin;

        public MDI()
        {
            InitializeComponent();

            fLogin = new login(this);
            fLogin.ShowDialog();

            menuUp1.sendMDI(this);
            menuLeft1.sendMDI(this);
            int w = Screen.FromControl(this).WorkingArea.Width;
            int h = Screen.FromControl(this).WorkingArea.Height;
            ReDimensionar(w, h);
            //openForm(new Cheques());
        }

        private void ReDimensionar(int w, int h)
        {
            this.Width = w;
            this.Height = h;
            menuLeft1.Height = h-sobrante;
            this.Location = new Point(0, 0);
            PanelContainer.Width = w - menuLeft1.Width;
            PanelContainer.Height = h - sobrante;
            panelMenuUp.Width = PanelContainer.Width;
            menuUp1.Location = new Point((panelMenuUp.Width/2)-(menuUp1.Width/2), 0);
            closeBtnCurrentPage.Location = new Point(panelMenuUp.Width-60, 0);
            panelPublicitario.Location = new Point(0, h -sobrante);
        }

        public void closeApplication()
        {
            Application.Exit();
        }

        private void MDI_ResizeEnd(object sender, EventArgs e)
        {
            ReDimensionar(this.Width, this.Height);
        }

        public void openForm(Form f)
        {
            addPage(f);
        }

        private void addPage(Form f)
        {
            Boolean alredy = false;
            foreach (string s in Funciones.array)
            {
                if (s == f.Name) alredy = true;
            }
            if (!alredy)
            {
                foreach (Form o in PanelContainer.Controls)
                {
                    o.Hide();
                }
                f.TopLevel = false;
                f.Size = PanelContainer.Size;
                PanelContainer.Controls.Add(f);
                f.Show();
                Funciones.currentPage = PanelContainer.Controls.Count - 1;
                menuUp1.addPage(f.Name);
                //Funciones.array.Add(Name);
            }
            else
            {
                MessageBox.Show("El módulo ya está abierto");
                Funciones.currentPage = Funciones.array.IndexOf(f.Name);
                showPage(Funciones.array[Funciones.array.IndexOf(f.Name)].ToString());
                menuUp1.setPrevNextLbl();
            }
        }

        public void nextPage()
        {
            if (Funciones.currentPage != PanelContainer.Controls.Count - 1)
            {
                Funciones.currentPage++;
                showPage(Funciones.array[Funciones.currentPage].ToString());
            }
        }

        public void prevPage()
        {
            if (Funciones.currentPage >= 1)
            {
                Funciones.currentPage--;
                showPage(Funciones.array[Funciones.currentPage].ToString());   
            }
        }

        public void goPage(string s)
        {
            for (int i = 0; i <= Funciones.array.Count - 1; i++)
            {
                if (s == Funciones.array[i].ToString())
                {
                    Funciones.currentPage = i;
                    showPage(s);
                }
            }
        }

        private void showPage(string i)
        {
            
            foreach (Form o in PanelContainer.Controls)
            {
                o.Hide();
                if (o.Name == i) o.Show();
            } 
        }

        private void closeBtnCurrentPage_Click(object sender, EventArgs e)
        {
            string t = "";
            foreach (Form f in PanelContainer.Controls)
            {
                if (f.Name == Funciones.array[Funciones.currentPage].ToString())
                {
                    t = f.Name;
                    f.Close();
                }
            }
            Funciones.currentPage--;
            if (Funciones.currentPage >=0)
            {
                showPage(Funciones.array[Funciones.currentPage].ToString());
            }
            menuUp1.removePage(t);
        }
    }
}
