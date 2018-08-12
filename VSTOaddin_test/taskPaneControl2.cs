using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace VSTOaddin_test
{
    public partial class taskPaneControl2 : UserControl
    {
        static LinkedList<Excel.Range> celije = new LinkedList<Excel.Range>();

        public Excel.Workbook wb = Globals.ThisAddIn.Application.ActiveWorkbook;
        public Excel.Worksheet ws = Globals.ThisAddIn.Application.ActiveSheet;

        public Excel.Range usedRange;

        public taskPaneControl2()
        {
            InitializeComponent();
        }

        private void zameniBtn_Click(object sender, EventArgs e)
        {
            foreach (Excel.Range cell in celije)
            {
                cell.Value = zamenjenTxt.Text;
            }
        }

        private void promenljivTxt_TextChanged(object sender, EventArgs e)
        {
            celije.Clear();
            Excel.Range used = Globals.ThisAddIn.Application.Selection;
            used.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White); 
            if (!promenljivTxt.Text.Equals(""))
            {
                foreach (Excel.Range cell in used.Cells)
                {
                    if (cell.Text.Contains(promenljivTxt.Text))
                    {
                        cell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);

                        if (!celije.Contains(cell))
                            celije.AddLast(cell);

                    }
                    else
                    {
                        if (celije.Contains(cell))
                        {
                            cell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                            celije.Remove(cell);
                        }

                    }
                }
            }
        }
        }
}
