namespace VSTOaddin_test
{
    partial class taskPaneControl2
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
            this.promenljivTxt = new System.Windows.Forms.TextBox();
            this.zameniBtn = new System.Windows.Forms.Button();
            this.zamenjenTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // promenljivTxt
            // 
            this.promenljivTxt.Location = new System.Drawing.Point(44, 49);
            this.promenljivTxt.Name = "promenljivTxt";
            this.promenljivTxt.Size = new System.Drawing.Size(100, 20);
            this.promenljivTxt.TabIndex = 0;
            this.promenljivTxt.TextChanged += new System.EventHandler(this.promenljivTxt_TextChanged);
            // 
            // zameniBtn
            // 
            this.zameniBtn.Location = new System.Drawing.Point(55, 90);
            this.zameniBtn.Name = "zameniBtn";
            this.zameniBtn.Size = new System.Drawing.Size(75, 23);
            this.zameniBtn.TabIndex = 1;
            this.zameniBtn.Text = "zameni";
            this.zameniBtn.UseVisualStyleBackColor = true;
            this.zameniBtn.Click += new System.EventHandler(this.zameniBtn_Click);
            // 
            // zamenjenTxt
            // 
            this.zamenjenTxt.Location = new System.Drawing.Point(44, 182);
            this.zamenjenTxt.Name = "zamenjenTxt";
            this.zamenjenTxt.Size = new System.Drawing.Size(100, 20);
            this.zamenjenTxt.TabIndex = 2;
            // 
            // taskPaneControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.zamenjenTxt);
            this.Controls.Add(this.zameniBtn);
            this.Controls.Add(this.promenljivTxt);
            this.Name = "taskPaneControl2";
            this.Size = new System.Drawing.Size(198, 259);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox promenljivTxt;
        private System.Windows.Forms.Button zameniBtn;
        private System.Windows.Forms.TextBox zamenjenTxt;
    }
}
