using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancosINE
{
    public partial class MenuLeft : UserControl
    {

        private MDI mdi;

        public MenuLeft()
        {
            InitializeComponent();
            treeView1.ExpandAll();
        }

        public void sendMDI(MDI m){
            mdi = m;
        }

        private void MenuLeft_Resize(object sender, EventArgs e)
        {
            treeView1.Location = new Point(0, 0);
            treeView1.Size = new Size(this.Width, this.Height);
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode tn = treeView1.SelectedNode;            
            if (tn.Level > 0)
            {
                int r = tn.Parent.Index;
                int i = tn.Index;
                string[] o = (string[])Funciones.clases[r];
                string clase = o[i];                
                Type t = Type.GetType(clase);                
                if (t != null)
                {
                    mdi.openForm((Form)Activator.CreateInstance(t));
                }
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            /*
            if (treeView1.SelectedNode.Level == 0)
            {
                if (treeView1.SelectedNode.IsExpanded) treeView1.SelectedNode.Collapse();
                else treeView1.SelectedNode.Expand();
            }
             * */
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
