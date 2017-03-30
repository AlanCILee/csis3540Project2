namespace ElectronicMart
{
    partial class SellerForm
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
            this.lbStock = new System.Windows.Forms.Label();
            this.gridViewStock = new System.Windows.Forms.DataGridView();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Location = new System.Drawing.Point(13, 22);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(54, 13);
            this.lbStock.TabIndex = 0;
            this.lbStock.Text = "Stock List";
            // 
            // gridViewStock
            // 
            this.gridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewStock.Location = new System.Drawing.Point(16, 47);
            this.gridViewStock.Name = "gridViewStock";
            this.gridViewStock.Size = new System.Drawing.Size(660, 264);
            this.gridViewStock.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(152, 319);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(88, 21);
            this.cbCategory.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(594, 319);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(528, 320);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(60, 20);
            this.tbQuantity.TabIndex = 4;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(444, 322);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(78, 13);
            this.lbQuantity.TabIndex = 5;
            this.lbQuantity.Text = "Quantity Under";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(13, 323);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(58, 13);
            this.lbId.TabIndex = 7;
            this.lbId.Text = "Product ID";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(77, 319);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(60, 20);
            this.tbId.TabIndex = 6;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(273, 322);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(73, 13);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "Name Include";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(352, 320);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(86, 20);
            this.tbName.TabIndex = 8;
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 693);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.gridViewStock);
            this.Controls.Add(this.lbStock);
            this.Name = "SellerForm";
            this.Text = "Seller Application";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.DataGridView gridViewStock;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
    }
}

