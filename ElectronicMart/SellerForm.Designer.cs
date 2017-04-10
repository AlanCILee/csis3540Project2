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
            this.gridViewOrder = new System.Windows.Forms.DataGridView();
            this.lbOrders = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.tbPurchaseCnt = new System.Windows.Forms.TextBox();
            this.lbProductId = new System.Windows.Forms.Label();
            this.tbRegisterId = new System.Windows.Forms.TextBox();
            this.tbRegisterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRegisterPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRegisterCost = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRegisterCategory = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrder)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // gridViewOrder
            // 
            this.gridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewOrder.Location = new System.Drawing.Point(682, 47);
            this.gridViewOrder.Name = "gridViewOrder";
            this.gridViewOrder.Size = new System.Drawing.Size(467, 264);
            this.gridViewOrder.TabIndex = 10;
            // 
            // lbOrders
            // 
            this.lbOrders.AutoSize = true;
            this.lbOrders.Location = new System.Drawing.Point(679, 22);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(66, 13);
            this.lbOrders.TabIndex = 11;
            this.lbOrders.Text = "Order Status";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1074, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(522, 13);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(93, 23);
            this.btnPurchase.TabIndex = 14;
            this.btnPurchase.Text = "Purchase Item";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // tbPurchaseCnt
            // 
            this.tbPurchaseCnt.Location = new System.Drawing.Point(416, 15);
            this.tbPurchaseCnt.Name = "tbPurchaseCnt";
            this.tbPurchaseCnt.Size = new System.Drawing.Size(100, 20);
            this.tbPurchaseCnt.TabIndex = 15;
            // 
            // lbProductId
            // 
            this.lbProductId.AutoSize = true;
            this.lbProductId.Location = new System.Drawing.Point(339, 18);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(0, 13);
            this.lbProductId.TabIndex = 16;
            this.lbProductId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbRegisterId
            // 
            this.tbRegisterId.Location = new System.Drawing.Point(105, 38);
            this.tbRegisterId.Name = "tbRegisterId";
            this.tbRegisterId.Size = new System.Drawing.Size(100, 20);
            this.tbRegisterId.TabIndex = 18;
            // 
            // tbRegisterName
            // 
            this.tbRegisterName.Location = new System.Drawing.Point(105, 64);
            this.tbRegisterName.Name = "tbRegisterName";
            this.tbRegisterName.Size = new System.Drawing.Size(424, 20);
            this.tbRegisterName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Selling Price";
            // 
            // tbRegisterPrice
            // 
            this.tbRegisterPrice.Location = new System.Drawing.Point(105, 89);
            this.tbRegisterPrice.Name = "tbRegisterPrice";
            this.tbRegisterPrice.Size = new System.Drawing.Size(100, 20);
            this.tbRegisterPrice.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Prime Cost";
            // 
            // tbRegisterCost
            // 
            this.tbRegisterCost.Location = new System.Drawing.Point(105, 140);
            this.tbRegisterCost.Name = "tbRegisterCost";
            this.tbRegisterCost.Size = new System.Drawing.Size(100, 20);
            this.tbRegisterCost.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.cbRegisterCategory);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbRegisterCost);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbRegisterPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbRegisterName);
            this.groupBox1.Controls.Add(this.tbRegisterId);
            this.groupBox1.Location = new System.Drawing.Point(12, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 210);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register New Product";
            // 
            // cbRegisterCategory
            // 
            this.cbRegisterCategory.FormattingEnabled = true;
            this.cbRegisterCategory.Location = new System.Drawing.Point(105, 115);
            this.cbRegisterCategory.Name = "cbRegisterCategory";
            this.cbRegisterCategory.Size = new System.Drawing.Size(88, 21);
            this.cbRegisterCategory.TabIndex = 30;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(241, 171);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 31;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 693);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbProductId);
            this.Controls.Add(this.tbPurchaseCnt);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lbOrders);
            this.Controls.Add(this.gridViewOrder);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DataGridView gridViewOrder;
        private System.Windows.Forms.Label lbOrders;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.TextBox tbPurchaseCnt;
        private System.Windows.Forms.Label lbProductId;
        private System.Windows.Forms.TextBox tbRegisterId;
        private System.Windows.Forms.TextBox tbRegisterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRegisterPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbRegisterCost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cbRegisterCategory;
    }
}

