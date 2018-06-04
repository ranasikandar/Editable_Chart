using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace EditableChart
{
    public partial class ReportViwer : Form
    {
        public ReportViwer()
        {
            InitializeComponent();
        }

        public ReportDocument rptRD1 { get; set; }
        public String rptTitle { get; set; }
        public bool isDirectPrint { get; set; }

        private void ReportViwer_Load(object sender, EventArgs e)
        {
            if (isDirectPrint)
            {
                rptRD1.PrintToPrinter(1, false, 0, 0);
                this.Close();
            }
            else
            {
                this.Text = rptTitle;
                this.crystalReportViewer1.ReportSource = rptRD1;
                
                this.Refresh();
            }
            //this.reportViewer1.RefreshReport();
        }
    }
}
