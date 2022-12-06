namespace HM_DB_05122022_3
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
            this.itemNumBox = new System.Windows.Forms.TextBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.pullBtn = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.OPBtn = new System.Windows.Forms.Button();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // itemNumBox
            // 
            this.itemNumBox.Location = new System.Drawing.Point(141, 80);
            this.itemNumBox.Name = "itemNumBox";
            this.itemNumBox.Size = new System.Drawing.Size(100, 26);
            this.itemNumBox.TabIndex = 0;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(12, 12);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(123, 50);
            this.refreshBtn.TabIndex = 1;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // pullBtn
            // 
            this.pullBtn.Location = new System.Drawing.Point(12, 68);
            this.pullBtn.Name = "pullBtn";
            this.pullBtn.Size = new System.Drawing.Size(123, 50);
            this.pullBtn.TabIndex = 2;
            this.pullBtn.Text = "Pull Item";
            this.pullBtn.UseVisualStyleBackColor = true;
            this.pullBtn.Click += new System.EventHandler(this.pullBtn_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(141, 42);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(52, 20);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price :";
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Location = new System.Drawing.Point(141, 12);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(82, 20);
            this.InventoryLabel.TabIndex = 4;
            this.InventoryLabel.Text = "Inventory :";
            // 
            // OPBtn
            // 
            this.OPBtn.Location = new System.Drawing.Point(13, 125);
            this.OPBtn.Name = "OPBtn";
            this.OPBtn.Size = new System.Drawing.Size(122, 49);
            this.OPBtn.TabIndex = 5;
            this.OPBtn.Text = "Over Price";
            this.OPBtn.UseVisualStyleBackColor = true;
            this.OPBtn.Click += new System.EventHandler(this.OPBtn_Click);
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(141, 136);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(100, 26);
            this.PriceBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 244);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.OPBtn);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.pullBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.itemNumBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemNumBox;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button pullBtn;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.Button OPBtn;
        private System.Windows.Forms.TextBox PriceBox;
    }
}

