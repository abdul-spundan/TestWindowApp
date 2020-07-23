using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using ProjectBLL;

namespace ReportingUtility
{
    public partial class PrintUserInformation : Form
    {
        public PrintUserInformation()
        {
            InitializeComponent();
        }

        private void brnSecurityInfo_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtdata = new DataTable();
                dtdata = BLLSecurity.GetSecurityData();
                if (dtdata.Rows.Count > 0)
                {
                    string rtppath = Application.StartupPath + System.Configuration.ConfigurationSettings.AppSettings["ReportsSecurity"].Trim() + @"\rptPrintSecurity.rpt";                    
                    ReportDocument reportdocument = new ReportDocument();                   
                    reportdocument.Load(rtppath);
                    reportdocument.SetDataSource(dtdata);                    
                    SecurityReportViewer.ReportSource = reportdocument;                    
                    reportdocument = null;
                }
                else
                {
                    //MessageBox.Show( "No Element to Process", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "TestWindowApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
