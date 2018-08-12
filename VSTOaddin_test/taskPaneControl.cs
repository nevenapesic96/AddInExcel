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
    public partial class taskPaneControl : UserControl
    {
        public taskPaneControl()
        {
            InitializeComponent();
        }

        private void izbrisiBtn_Click(object sender, EventArgs e)
        {
            if (!kriterijumTxt.Text.Equals(""))
            {
                Excel.Workbook wb = Globals.ThisAddIn.Application.ActiveWorkbook;
                Excel.Worksheet ws = Globals.ThisAddIn.Application.ActiveSheet;
                var aktCelija = Globals.ThisAddIn.Application.ActiveCell;

                int kolona = aktCelija.Column;
                string kriterijum = kriterijumTxt.Text;

                Excel.Range usedRange = ws.UsedRange;

                Excel.Range last = ws.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
                int red = last.Row;
                int i = 1;
                while (i <= red)
                {
                    Excel.Range celija = ws.Cells[i, kolona];
                    if (celija.Text == kriterijum)
                    {
                        celija.EntireRow.Delete(Excel.XlDeleteShiftDirection.xlShiftUp);
                    }
                    i++;
                }
            }
        }

        private void pronadjiBtn_Click(object sender, EventArgs e)
        {
            if (!pronadjiTxt.Text.Equals(""))
            {
                Excel.Workbook wb = Globals.ThisAddIn.Application.ActiveWorkbook;
                Excel.Worksheet ws = Globals.ThisAddIn.Application.ActiveSheet;
                var aktCelija = Globals.ThisAddIn.Application.ActiveCell;

                ColorDialog dlg = new ColorDialog();

                var str = dlg.Color;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    str = dlg.Color;
                }

                int kolona = aktCelija.Column;
                Excel.Range last = ws.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);

                string kriterijum = pronadjiTxt.Text;
                int red = last.Row;
                int i = 1;

                while (i <= red)
                {
                    Excel.Range celija = ws.Cells[i, kolona];
                    string tekst = celija.Text;
                    if (tekst.Contains(kriterijum))
                    {
                        celija.Interior.Color = str;
                    }
                    i++;
                }
            }
        }
        
    }
}
