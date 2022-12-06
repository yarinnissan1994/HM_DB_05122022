namespace HM_DB05122022_2
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
            this.refreshBtn = new System.Windows.Forms.Button();
            this.empBtn = new System.Windows.Forms.Button();
            this.empNumBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(12, 12);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(234, 81);
            this.refreshBtn.TabIndex = 0;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // empBtn
            // 
            this.empBtn.Location = new System.Drawing.Point(12, 99);
            this.empBtn.Name = "empBtn";
            this.empBtn.Size = new System.Drawing.Size(234, 81);
            this.empBtn.TabIndex = 1;
            this.empBtn.Text = "Search Employee";
            this.empBtn.UseVisualStyleBackColor = true;
            this.empBtn.Click += new System.EventHandler(this.empBtn_Click);
            // 
            // empNumBox
            // 
            this.empNumBox.Location = new System.Drawing.Point(252, 126);
            this.empNumBox.Name = "empNumBox";
            this.empNumBox.Size = new System.Drawing.Size(100, 26);
            this.empNumBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.empNumBox);
            this.Controls.Add(this.empBtn);
            this.Controls.Add(this.refreshBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button empBtn;
        private System.Windows.Forms.TextBox empNumBox;
    }
}

