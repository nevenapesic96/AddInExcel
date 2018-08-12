namespace VSTOaddin_test
{
    partial class taskPaneControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.kriterijumTxt = new System.Windows.Forms.TextBox();
            this.izbrisiBtn = new System.Windows.Forms.Button();
            this.pronadjiBtn = new System.Windows.Forms.Button();
            this.pronadjiTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kriterijumTxt
            // 
            this.kriterijumTxt.Location = new System.Drawing.Point(22, 30);
            this.kriterijumTxt.Name = "kriterijumTxt";
            this.kriterijumTxt.Size = new System.Drawing.Size(100, 20);
            this.kriterijumTxt.TabIndex = 0;
            // 
            // izbrisiBtn
            // 
            this.izbrisiBtn.Location = new System.Drawing.Point(33, 56);
            this.izbrisiBtn.Name = "izbrisiBtn";
            this.izbrisiBtn.Size = new System.Drawing.Size(75, 23);
            this.izbrisiBtn.TabIndex = 1;
            this.izbrisiBtn.Text = "izbrisi";
            this.izbrisiBtn.UseVisualStyleBackColor = true;
            this.izbrisiBtn.Click += new System.EventHandler(this.izbrisiBtn_Click);
            // 
            // pronadjiBtn
            // 
            this.pronadjiBtn.Location = new System.Drawing.Point(33, 140);
            this.pronadjiBtn.Name = "pronadjiBtn";
            this.pronadjiBtn.Size = new System.Drawing.Size(75, 23);
            this.pronadjiBtn.TabIndex = 2;
            this.pronadjiBtn.Text = "pronadji";
            this.pronadjiBtn.UseVisualStyleBackColor = true;
            this.pronadjiBtn.Click += new System.EventHandler(this.pronadjiBtn_Click);
            // 
            // pronadjiTxt
            // 
            this.pronadjiTxt.Location = new System.Drawing.Point(22, 114);
            this.pronadjiTxt.Name = "pronadjiTxt";
            this.pronadjiTxt.Size = new System.Drawing.Size(100, 20);
            this.pronadjiTxt.TabIndex = 3;
           // this.pronadjiTxt.TextChanged += new System.EventHandler(this.pronadjiTxt_TextChanged);
            // 
            // taskPaneControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pronadjiTxt);
            this.Controls.Add(this.pronadjiBtn);
            this.Controls.Add(this.izbrisiBtn);
            this.Controls.Add(this.kriterijumTxt);
            this.Name = "taskPaneControl";
            this.Size = new System.Drawing.Size(150, 212);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kriterijumTxt;
        private System.Windows.Forms.Button izbrisiBtn;
        private System.Windows.Forms.Button pronadjiBtn;
        private System.Windows.Forms.TextBox pronadjiTxt;
    }
}
