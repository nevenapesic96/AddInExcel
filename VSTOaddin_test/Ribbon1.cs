using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Office.Tools.Ribbon;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using Excel = Microsoft.Office.Interop.Excel;


namespace VSTOaddin_test
{
    public partial class Ribbon1
    {
        
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Worksheet ws = Globals.ThisAddIn.Application.ActiveSheet;
            Excel.Range aktCelija = Globals.ThisAddIn.Application.ActiveCell;

            if (aktCelija.Value != null)
            {
                string tekst = aktCelija.Text;
                System.Windows.Forms.MessageBox.Show(tekst);
            }
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Worksheet ws = Globals.ThisAddIn.Application.ActiveSheet;
            Excel.Range selektovano = Globals.ThisAddIn.Application.Selection;
            selektovano.Merge();
        }

        private void button2_Click(object sender, RibbonControlEventArgs e)
        {
            /*
            Excel.Worksheet ws = Globals.ThisAddIn.Application.ActiveSheet;

            Excel.Range selektovano = Globals.ThisAddIn.Application.Selection;
            var chart = ws.ChartObjects().Add(60, 10, 300, 300).Chart;

            chart.SetSourceData(selektovano);

            // Set chart properties.
            chart.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlLine;
            chart.ChartWizard(Source: selektovano,
                Title: ws.Cells[2, 1].text,
                CategoryTitle: ws.Cells[2, 2],
                ValueTitle: ws.Cells[2, 3]);
             */
            Form1 forma = new Form1();
            forma.Visible = true;

        }

        private void izbrisiBtn_Click(object sender, RibbonControlEventArgs e)
        {
                      

        }

        private void prikaziAP_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.TaskPane.Visible = ((RibbonToggleButton)sender).Checked;
        }

        private void ucitajExcel_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Application excel=new Excel.Application();

            Excel.Workbook wbDest = Globals.ThisAddIn.Application.ActiveWorkbook;
            Excel.Worksheet wsDest = wbDest.ActiveSheet;
            wsDest.UsedRange.ClearContents();

            string pathFileDest = "C:\\Users\\NEVEN\\Desktop\\krajnjiExcel";
            Excel.Workbook wbSour = excel.Workbooks.Open(pathFileDest);
            Excel.Worksheet wsSour = wbSour.Worksheets["podaci"];
            wsSour.UsedRange.Copy();
            
            wsDest.UsedRange.PasteSpecial(Excel.XlPasteType.xlPasteValues, Excel.XlPasteSpecialOperation.xlPasteSpecialOperationAdd);

            excel.CutCopyMode = 0;
            wbSour.Close();

            wsDest.Columns.AutoFit();
        }

        private void upisiUSheet2(LinkedList<String> lista)
        {
            Excel.Worksheet ws = Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets["Sheet2"];
            ws.Select();
            int i = 1;

            foreach (String podatak in lista)
            {
                ws.Cells[i,1].Value = podatak;
                i++;
            }
            ws.Columns.AutoFit();
        }

        private void napraviListBtn_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Worksheet ws = Globals.ThisAddIn.Application.ActiveSheet;
            Excel.Range oblast = Globals.ThisAddIn.Application.Selection;

            LinkedList<String> jedinstvenaLista = new LinkedList<String>();
            foreach (Excel.Range cell in oblast.Cells)
            {
                String vrednost = cell.Text;
                if (!jedinstvenaLista.Contains(vrednost))
                {
                    jedinstvenaLista.AddLast(vrednost);
                }
            }
            upisiUSheet2(jedinstvenaLista);
        }        
        private void izmeniBtn_Click_1(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.TaskPane2.Visible = ((RibbonToggleButton)sender).Checked;
        }

        private void ubaciSlikuBtn_Click(object sender, RibbonControlEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.FileName = "*";
            dlg.DefaultExt = "bmp";
            dlg.ValidateNames = true;

            dlg.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Bitmap dImg = new Bitmap(dlg.FileName);  
                  Excel.Shape IamgeAdd = Globals.ThisAddIn.Application.ActiveSheet.Shapes.AddPicture(dlg.FileName,  
      Microsoft.Office.Core.MsoTriState.msoFalse,Microsoft.Office.Core.MsoTriState.msoCTrue, 20, 30, dImg.Width, dImg.Height);  
            } 
            
            Clipboard.Clear(); 
            }
        }

}
