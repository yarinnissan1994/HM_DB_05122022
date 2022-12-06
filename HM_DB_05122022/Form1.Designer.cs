namespace HM_DB_05122022
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
            this.orderBtn = new System.Windows.Forms.Button();
            this.custBtn = new System.Windows.Forms.Button();
            this.orderBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(12, 12);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(198, 59);
            this.orderBtn.TabIndex = 0;
            this.orderBtn.Text = "Number of orders";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // custBtn
            // 
            this.custBtn.Location = new System.Drawing.Point(12, 77);
            this.custBtn.Name = "custBtn";
            this.custBtn.Size = new System.Drawing.Size(198, 59);
            this.custBtn.TabIndex = 1;
            this.custBtn.Text = "Number of custumers";
            this.custBtn.UseVisualStyleBackColor = true;
            this.custBtn.Click += new System.EventHandler(this.custBtn_Click);
            // 
            // orderBox
            // 
            this.orderBox.Location = new System.Drawing.Point(216, 28);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(94, 26);
            this.orderBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.custBtn);
            this.Controls.Add(this.orderBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button custBtn;
        private System.Windows.Forms.TextBox orderBox;
    }
}

