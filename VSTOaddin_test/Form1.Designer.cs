namespace VSTOaddin_test
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.napraviBtn = new System.Windows.Forms.Button();
            this.nazivTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kategorijaTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.valueTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // napraviBtn
            // 
            this.napraviBtn.Location = new System.Drawing.Point(104, 165);
            this.napraviBtn.Name = "napraviBtn";
            this.napraviBtn.Size = new System.Drawing.Size(75, 23);
            this.napraviBtn.TabIndex = 0;
            this.napraviBtn.Text = "napravi";
            this.napraviBtn.UseVisualStyleBackColor = true;
            this.napraviBtn.Click += new System.EventHandler(this.napraviBtn_Click);
            // 
            // nazivTxt
            // 
            this.nazivTxt.Location = new System.Drawing.Point(135, 43);
            this.nazivTxt.Name = "nazivTxt";
            this.nazivTxt.Size = new System.Drawing.Size(100, 20);
            this.nazivTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "naziv";
            // 
            // kategorijaTxt
            // 
            this.kategorijaTxt.Location = new System.Drawing.Point(135, 90);
            this.kategorijaTxt.Name = "kategorijaTxt";
            this.kategorijaTxt.Size = new System.Drawing.Size(100, 20);
            this.kategorijaTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "kategorija";
            // 
            // valueTxt
            // 
            this.valueTxt.Location = new System.Drawing.Point(135, 139);
            this.valueTxt.Name = "valueTxt";
            this.valueTxt.Size = new System.Drawing.Size(100, 20);
            this.valueTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "vrednosti";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.valueTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kategorijaTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nazivTxt);
            this.Controls.Add(this.napraviBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button napraviBtn;
        private System.Windows.Forms.TextBox nazivTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kategorijaTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valueTxt;
        private System.Windows.Forms.Label label3;
    }
}