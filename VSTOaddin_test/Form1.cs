using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace VSTOaddin_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void napraviBtn_Click(object sender, EventArgs e)
        {
            Excel.Worksheet ws = Globals.ThisAddIn.Application.ActiveSheet;

            Excel.Range selektovano = Globals.ThisAddIn.Application.Selection;
            var chart = ws.ChartObjects().Add(60, 10, 300, 300).Chart;

            chart.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlColumnClustered;
            chart.HasLegend = false;

            chart.ChartWizard(Source: selektovano,
                    Title: nazivTxt.Text,
                    CategoryTitle: kategorijaTxt.Text,
                    ValueTitle: valueTxt.Text);

            this.Visible = false;
        }

    }
}
