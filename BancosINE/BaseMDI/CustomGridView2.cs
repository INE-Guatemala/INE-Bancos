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
    public partial class CustomGridView : UserControl
    {

        public DataGridView dGrid;
        public ContextMenuStrip cms;

        public CustomGridView()
        {
            InitializeComponent();
            dGrid = mainGrid;
            cms = contextMenuStrip1;
            mainGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 35, 38);
            mainGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            mainGrid.EnableHeadersVisualStyles = false;
        }

        private void CustomGridView_Resize(object sender, EventArgs e)
        {
            mainGrid.Size = this.Size;
        }

        private void mainGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.ForeColor = Color.White;
            e.CellStyle.BackColor = Color.FromArgb(58, 60, 68);
        }

        private void mainGrid_SelectionChanged(object sender, EventArgs e)
        {
            mainGrid.ClearSelection();
        }

    }
}
