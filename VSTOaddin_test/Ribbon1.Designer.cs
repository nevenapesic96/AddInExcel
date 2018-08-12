namespace VSTOaddin_test
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.button1 = this.Factory.CreateRibbonButton();
            this.btnStart = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.ucitajExcel = this.Factory.CreateRibbonButton();
            this.prikaziAP = this.Factory.CreateRibbonToggleButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.izmeniBtn = this.Factory.CreateRibbonToggleButton();
            this.napraviListBtn = this.Factory.CreateRibbonButton();
            this.ubaciSlikuBtn = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.button1);
            this.group1.Items.Add(this.btnStart);
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // button1
            // 
            this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button1.Image = global::VSTOaddin_test.Properties.Resources.arrow_filled1600;
            this.button1.Label = "spoji";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // btnStart
            // 
            this.btnStart.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnStart.Image = global::VSTOaddin_test.Properties.Resources.a18;
            this.btnStart.Label = "Get value";
            this.btnStart.Name = "btnStart";
            this.btnStart.ShowImage = true;
            this.btnStart.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnStart_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.ucitajExcel);
            this.group2.Items.Add(this.prikaziAP);
            this.group2.Items.Add(this.button2);
            this.group2.Label = "group2";
            this.group2.Name = "group2";
            // 
            // ucitajExcel
            // 
            this.ucitajExcel.Label = "Ucitaj";
            this.ucitajExcel.Name = "ucitajExcel";
            this.ucitajExcel.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ucitajExcel_Click);
            // 
            // prikaziAP
            // 
            this.prikaziAP.Label = "prikazi task pane";
            this.prikaziAP.Name = "prikaziAP";
            this.prikaziAP.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.prikaziAP_Click);
            // 
            // button2
            // 
            this.button2.Label = "napravi chart";
            this.button2.Name = "button2";
            this.button2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button2_Click);
            // 
            // group3
            // 
            this.group3.Items.Add(this.ubaciSlikuBtn);
            this.group3.Items.Add(this.izmeniBtn);
            this.group3.Items.Add(this.napraviListBtn);
            this.group3.Label = "group3";
            this.group3.Name = "group3";
            // 
            // izmeniBtn
            // 
            this.izmeniBtn.Label = "izmeni";
            this.izmeniBtn.Name = "izmeniBtn";
            this.izmeniBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.izmeniBtn_Click_1);
            // 
            // napraviListBtn
            // 
            this.napraviListBtn.Label = "napravi listu";
            this.napraviListBtn.Name = "napraviListBtn";
            this.napraviListBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.napraviListBtn_Click);
            // 
            // ubaciSlikuBtn
            // 
            this.ubaciSlikuBtn.Label = "ubaciSliku";
            this.ubaciSlikuBtn.Name = "ubaciSlikuBtn";
            this.ubaciSlikuBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ubaciSlikuBtn_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnStart;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton prikaziAP;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ucitajExcel;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton napraviListBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton izmeniBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ubaciSlikuBtn;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
