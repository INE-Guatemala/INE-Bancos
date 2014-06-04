using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ODBCConnect;

namespace BancosINE
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pressButton1();            
        }

        public virtual void pressButton1()
        {
            //MessageBox.Show("Desde el original");
        }

        public void addTitle(string n)
        {
            label1.Text = n;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

    }
}
