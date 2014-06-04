using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BancosINE.Cheque
{
    public partial class formcheque :Form
    {
        public formcheque()
        {
            InitializeComponent();
        }

        public formcheque(string direccion,Dictionary<string,string> diccionario)
        {
            InitializeComponent();
            CrystalDecisions.CrystalReports.Engine.ReportDocument cryRpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();            
            cryRpt.Load(direccion);
            foreach (KeyValuePair<string,string> dic in diccionario)
            {
                cryRpt.SetParameterValue(dic.Key, dic.Value);
            }            
            crystalReportViewer1.ReportSource = cryRpt;
            //viewer.Zoom = new Zoom(ZoomMode.Scale, 1.0);
            crystalReportViewer1.Zoom(200);
            
        }

       

       
    }
}
