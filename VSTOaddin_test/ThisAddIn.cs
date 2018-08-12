using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace VSTOaddin_test
{
    public partial class ThisAddIn
    {
        private taskPaneControl taskPaneControl1;
        private taskPaneControl2 taskPaneControl2;
        
        private Microsoft.Office.Tools.CustomTaskPane taskPaneValue;
        private Microsoft.Office.Tools.CustomTaskPane taskPaneValue2;

        public Microsoft.Office.Tools.CustomTaskPane TaskPane
        {
            get
            {
                return taskPaneValue;
            }
        }

        public Microsoft.Office.Tools.CustomTaskPane TaskPane2
        {
            get
            {
                return taskPaneValue2;
            }
        }

        private void taskPaneValue_VisibleChanged(object sender, System.EventArgs e)
        {
            Globals.Ribbons.Ribbon1.prikaziAP.Checked = taskPaneValue.Visible;
        }
        private void taskPaneValue2_VisibleChanged(object sender, System.EventArgs e)
        {
            Globals.Ribbons.Ribbon1.izmeniBtn.Checked = taskPaneValue.Visible;
        }

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            taskPaneControl1 = new taskPaneControl();
            taskPaneControl2 = new taskPaneControl2();

            taskPaneValue = this.CustomTaskPanes.Add(
                taskPaneControl1, "taskPane1");
            taskPaneValue2 = this.CustomTaskPanes.Add(
                taskPaneControl2,"taskPane2");

            taskPaneValue.VisibleChanged +=
                new EventHandler(taskPaneValue_VisibleChanged);

            taskPaneValue2.VisibleChanged +=
                new EventHandler(taskPaneValue2_VisibleChanged);

        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
