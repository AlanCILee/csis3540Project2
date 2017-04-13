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
            this.btnStockSearch = new System.Windows.Forms.Button();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gridViewOrder = new System.Windows.Forms.DataGridView();
            this.lbOrders = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.tbPurchaseCnt = new System.Windows.Forms.TextBox();
            this.lbProductId = new System.Windows.Forms.Label();
            this.tbRegisterId = new System.Windows.Forms.TextBox();
            this.tbRegisterName = new System.Windows.Forms.TextBox();
            this.lbRegisterProductId = new System.Windows.Forms.Label();
            this.lbRegisterName = new System.Windows.Forms.Label();
            this.lbRegisterCategory = new System.Windows.Forms.Label();
            this.lbRegisterSellingPrice = new System.Windows.Forms.Label();
            this.tbRegisterPrice = new System.Windows.Forms.TextBox();
            this.lbRegisterPrimeCost = new System.Windows.Forms.Label();
            this.tbRegisterCost = new System.Windows.Forms.TextBox();
            this.gbRegisterNewProduct = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cbRegisterCategory = new System.Windows.Forms.ComboBox();
            this.btnDeliver = new System.Windows.Forms.Button();
            this.gbRevenueInfo = new System.Windows.Forms.GroupBox();
            this.lbSalesIncome = new System.Windows.Forms.Label();
            this.lbSalesCost = new System.Windows.Forms.Label();
            this.lbSales = new System.Windows.Forms.Label();
            this.lbSalesCount = new System.Windows.Forms.Label();
            this.lbRevenueIncome = new System.Windows.Forms.Label();
            this.lbRevenueCost = new System.Windows.Forms.Label();
            this.lbRevenueGrossSales = new System.Windows.Forms.Label();
            this.lbRevenuSales = new System.Windows.Forms.Label();
            this.btnOrderSearch = new System.Windows.Forms.Button();
            this.gbRadioButtons = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbNotDelivred = new System.Windows.Forms.RadioButton();
            this.rbDelivered = new System.Windows.Forms.RadioButton();
            this.lbOrderId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrder)).BeginInit();
            this.gbRegisterNewProduct.SuspendLayout();
            this.gbRevenueInfo.SuspendLayout();
            this.gbRadioButtons.SuspendLayout();
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
            // btnStockSearch
            // 
            this.btnStockSearch.Location = new System.Drawing.Point(594, 319);
            this.btnStockSearch.Name = "btnStockSearch";
            this.btnStockSearch.Size = new System.Drawing.Size(75, 23);
            this.btnStockSearch.TabIndex = 3;
            this.btnStockSearch.Text = "Search";
            this.btnStockSearch.UseVisualStyleBackColor = true;
            this.btnStockSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.gridViewOrder.Size = new System.Drawing.Size(535, 264);
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
            // lbRegisterProductId
            // 
            this.lbRegisterProductId.AutoSize = true;
            this.lbRegisterProductId.Location = new System.Drawing.Point(13, 41);
            this.lbRegisterProductId.Name = "lbRegisterProductId";
            this.lbRegisterProductId.Size = new System.Drawing.Size(58, 13);
            this.lbRegisterProductId.TabIndex = 20;
            this.lbRegisterProductId.Text = "Product ID";
            // 
            // lbRegisterName
            // 
            this.lbRegisterName.AutoSize = true;
            this.lbRegisterName.Location = new System.Drawing.Point(13, 67);
            this.lbRegisterName.Name = "lbRegisterName";
            this.lbRegisterName.Size = new System.Drawing.Size(35, 13);
            this.lbRegisterName.TabIndex = 21;
            this.lbRegisterName.Text = "Name";
            // 
            // lbRegisterCategory
            // 
            this.lbRegisterCategory.AutoSize = true;
            this.lbRegisterCategory.Location = new System.Drawing.Point(13, 118);
            this.lbRegisterCategory.Name = "lbRegisterCategory";
            this.lbRegisterCategory.Size = new System.Drawing.Size(49, 13);
            this.lbRegisterCategory.TabIndex = 25;
            this.lbRegisterCategory.Text = "Category";
            // 
            // lbRegisterSellingPrice
            // 
            this.lbRegisterSellingPrice.AutoSize = true;
            this.lbRegisterSellingPrice.Location = new System.Drawing.Point(13, 92);
            this.lbRegisterSellingPrice.Name = "lbRegisterSellingPrice";
            this.lbRegisterSellingPrice.Size = new System.Drawing.Size(65, 13);
            this.lbRegisterSellingPrice.TabIndex = 24;
            this.lbRegisterSellingPrice.Text = "Selling Price";
            // 
            // tbRegisterPrice
            // 
            this.tbRegisterPrice.Location = new System.Drawing.Point(105, 89);
            this.tbRegisterPrice.Name = "tbRegisterPrice";
            this.tbRegisterPrice.Size = new System.Drawing.Size(100, 20);
            this.tbRegisterPrice.TabIndex = 22;
            // 
            // lbRegisterPrimeCost
            // 
            this.lbRegisterPrimeCost.AutoSize = true;
            this.lbRegisterPrimeCost.Location = new System.Drawing.Point(13, 143);
            this.lbRegisterPrimeCost.Name = "lbRegisterPrimeCost";
            this.lbRegisterPrimeCost.Size = new System.Drawing.Size(57, 13);
            this.lbRegisterPrimeCost.TabIndex = 28;
            this.lbRegisterPrimeCost.Text = "Prime Cost";
            // 
            // tbRegisterCost
            // 
            this.tbRegisterCost.Location = new System.Drawing.Point(105, 140);
            this.tbRegisterCost.Name = "tbRegisterCost";
            this.tbRegisterCost.Size = new System.Drawing.Size(100, 20);
            this.tbRegisterCost.TabIndex = 26;
            // 
            // gbRegisterNewProduct
            // 
            this.gbRegisterNewProduct.Controls.Add(this.btnRegister);
            this.gbRegisterNewProduct.Controls.Add(this.cbRegisterCategory);
            this.gbRegisterNewProduct.Controls.Add(this.lbRegisterPrimeCost);
            this.gbRegisterNewProduct.Controls.Add(this.tbRegisterCost);
            this.gbRegisterNewProduct.Controls.Add(this.lbRegisterCategory);
            this.gbRegisterNewProduct.Controls.Add(this.lbRegisterSellingPrice);
            this.gbRegisterNewProduct.Controls.Add(this.tbRegisterPrice);
            this.gbRegisterNewProduct.Controls.Add(this.lbRegisterName);
            this.gbRegisterNewProduct.Controls.Add(this.lbRegisterProductId);
            this.gbRegisterNewProduct.Controls.Add(this.tbRegisterName);
            this.gbRegisterNewProduct.Controls.Add(this.tbRegisterId);
            this.gbRegisterNewProduct.Location = new System.Drawing.Point(12, 360);
            this.gbRegisterNewProduct.Name = "gbRegisterNewProduct";
            this.gbRegisterNewProduct.Size = new System.Drawing.Size(541, 210);
            this.gbRegisterNewProduct.TabIndex = 29;
            this.gbRegisterNewProduct.TabStop = false;
            this.gbRegisterNewProduct.Text = "Register New Product";
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
            // cbRegisterCategory
            // 
            this.cbRegisterCategory.FormattingEnabled = true;
            this.cbRegisterCategory.Location = new System.Drawing.Point(105, 115);
            this.cbRegisterCategory.Name = "cbRegisterCategory";
            this.cbRegisterCategory.Size = new System.Drawing.Size(88, 21);
            this.cbRegisterCategory.TabIndex = 30;
            // 
            // btnDeliver
            // 
            this.btnDeliver.Location = new System.Drawing.Point(1142, 18);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(75, 23);
            this.btnDeliver.TabIndex = 30;
            this.btnDeliver.Text = "Deliver Item";
            this.btnDeliver.UseVisualStyleBackColor = true;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // gbRevenueInfo
            // 
            this.gbRevenueInfo.Controls.Add(this.lbSalesIncome);
            this.gbRevenueInfo.Controls.Add(this.lbSalesCost);
            this.gbRevenueInfo.Controls.Add(this.lbSales);
            this.gbRevenueInfo.Controls.Add(this.lbSalesCount);
            this.gbRevenueInfo.Controls.Add(this.lbRevenueIncome);
            this.gbRevenueInfo.Controls.Add(this.lbRevenueCost);
            this.gbRevenueInfo.Controls.Add(this.lbRevenueGrossSales);
            this.gbRevenueInfo.Controls.Add(this.lbRevenuSales);
            this.gbRevenueInfo.Location = new System.Drawing.Point(682, 369);
            this.gbRevenueInfo.Name = "gbRevenueInfo";
            this.gbRevenueInfo.Size = new System.Drawing.Size(467, 201);
            this.gbRevenueInfo.TabIndex = 31;
            this.gbRevenueInfo.TabStop = false;
            this.gbRevenueInfo.Text = "Revenue Info";
            // 
            // lbSalesIncome
            // 
            this.lbSalesIncome.AutoSize = true;
            this.lbSalesIncome.Location = new System.Drawing.Point(96, 114);
            this.lbSalesIncome.Name = "lbSalesIncome";
            this.lbSalesIncome.Size = new System.Drawing.Size(0, 13);
            this.lbSalesIncome.TabIndex = 7;
            // 
            // lbSalesCost
            // 
            this.lbSalesCost.AutoSize = true;
            this.lbSalesCost.Location = new System.Drawing.Point(93, 87);
            this.lbSalesCost.Name = "lbSalesCost";
            this.lbSalesCost.Size = new System.Drawing.Size(0, 13);
            this.lbSalesCost.TabIndex = 6;
            // 
            // lbSales
            // 
            this.lbSales.AutoSize = true;
            this.lbSales.Location = new System.Drawing.Point(118, 62);
            this.lbSales.Name = "lbSales";
            this.lbSales.Size = new System.Drawing.Size(0, 13);
            this.lbSales.TabIndex = 5;
            // 
            // lbSalesCount
            // 
            this.lbSalesCount.AutoSize = true;
            this.lbSalesCount.Location = new System.Drawing.Point(118, 35);
            this.lbSalesCount.Name = "lbSalesCount";
            this.lbSalesCount.Size = new System.Drawing.Size(0, 13);
            this.lbSalesCount.TabIndex = 4;
            // 
            // lbRevenueIncome
            // 
            this.lbRevenueIncome.AutoSize = true;
            this.lbRevenueIncome.Location = new System.Drawing.Point(21, 114);
            this.lbRevenueIncome.Name = "lbRevenueIncome";
            this.lbRevenueIncome.Size = new System.Drawing.Size(69, 13);
            this.lbRevenueIncome.TabIndex = 3;
            this.lbRevenueIncome.Text = "Total Income";
            // 
            // lbRevenueCost
            // 
            this.lbRevenueCost.AutoSize = true;
            this.lbRevenueCost.Location = new System.Drawing.Point(21, 87);
            this.lbRevenueCost.Name = "lbRevenueCost";
            this.lbRevenueCost.Size = new System.Drawing.Size(55, 13);
            this.lbRevenueCost.TabIndex = 2;
            this.lbRevenueCost.Text = "Total Cost";
            // 
            // lbRevenueGrossSales
            // 
            this.lbRevenueGrossSales.AutoSize = true;
            this.lbRevenueGrossSales.Location = new System.Drawing.Point(21, 62);
            this.lbRevenueGrossSales.Name = "lbRevenueGrossSales";
            this.lbRevenueGrossSales.Size = new System.Drawing.Size(90, 13);
            this.lbRevenueGrossSales.TabIndex = 1;
            this.lbRevenueGrossSales.Text = "Total Gross Sales";
            // 
            // lbRevenuSales
            // 
            this.lbRevenuSales.AutoSize = true;
            this.lbRevenuSales.Location = new System.Drawing.Point(21, 35);
            this.lbRevenuSales.Name = "lbRevenuSales";
            this.lbRevenuSales.Size = new System.Drawing.Size(91, 13);
            this.lbRevenuSales.TabIndex = 0;
            this.lbRevenuSales.Text = "Total Sales Count";
            // 
            // btnOrderSearch
            // 
            this.btnOrderSearch.Location = new System.Drawing.Point(1142, 318);
            this.btnOrderSearch.Name = "btnOrderSearch";
            this.btnOrderSearch.Size = new System.Drawing.Size(75, 23);
            this.btnOrderSearch.TabIndex = 32;
            this.btnOrderSearch.Text = "Search";
            this.btnOrderSearch.UseVisualStyleBackColor = true;
            this.btnOrderSearch.Click += new System.EventHandler(this.btnOrderSearch_Click);
            // 
            // gbRadioButtons
            // 
            this.gbRadioButtons.Controls.Add(this.rbAll);
            this.gbRadioButtons.Controls.Add(this.rbNotDelivred);
            this.gbRadioButtons.Controls.Add(this.rbDelivered);
            this.gbRadioButtons.Location = new System.Drawing.Point(694, 311);
            this.gbRadioButtons.Name = "gbRadioButtons";
            this.gbRadioButtons.Size = new System.Drawing.Size(225, 31);
            this.gbRadioButtons.TabIndex = 33;
            this.gbRadioButtons.TabStop = false;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(180, 11);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(36, 17);
            this.rbAll.TabIndex = 2;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbNotDelivred
            // 
            this.rbNotDelivred.AutoSize = true;
            this.rbNotDelivred.Location = new System.Drawing.Point(84, 11);
            this.rbNotDelivred.Name = "rbNotDelivred";
            this.rbNotDelivred.Size = new System.Drawing.Size(90, 17);
            this.rbNotDelivred.TabIndex = 1;
            this.rbNotDelivred.Text = "Not Delivered";
            this.rbNotDelivred.UseVisualStyleBackColor = true;
            // 
            // rbDelivered
            // 
            this.rbDelivered.AutoSize = true;
            this.rbDelivered.Location = new System.Drawing.Point(7, 11);
            this.rbDelivered.Name = "rbDelivered";
            this.rbDelivered.Size = new System.Drawing.Size(70, 17);
            this.rbDelivered.TabIndex = 0;
            this.rbDelivered.Text = "Delivered";
            this.rbDelivered.UseVisualStyleBackColor = true;
            // 
            // lbOrderId
            // 
            this.lbOrderId.AutoSize = true;
            this.lbOrderId.Location = new System.Drawing.Point(1077, 22);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(0, 13);
            this.lbOrderId.TabIndex = 34;
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 693);
            this.Controls.Add(this.lbOrderId);
            this.Controls.Add(this.gbRadioButtons);
            this.Controls.Add(this.btnOrderSearch);
            this.Controls.Add(this.gbRevenueInfo);
            this.Controls.Add(this.btnDeliver);
            this.Controls.Add(this.gbRegisterNewProduct);
            this.Controls.Add(this.lbProductId);
            this.Controls.Add(this.tbPurchaseCnt);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.lbOrders);
            this.Controls.Add(this.gridViewOrder);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.btnStockSearch);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.gridViewStock);
            this.Controls.Add(this.lbStock);
            this.Name = "SellerForm";
            this.Text = "Seller Application";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrder)).EndInit();
            this.gbRegisterNewProduct.ResumeLayout(false);
            this.gbRegisterNewProduct.PerformLayout();
            this.gbRevenueInfo.ResumeLayout(false);
            this.gbRevenueInfo.PerformLayout();
            this.gbRadioButtons.ResumeLayout(false);
            this.gbRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.DataGridView gridViewStock;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnStockSearch;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DataGridView gridViewOrder;
        private System.Windows.Forms.Label lbOrders;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.TextBox tbPurchaseCnt;
        private System.Windows.Forms.Label lbProductId;
        private System.Windows.Forms.TextBox tbRegisterId;
        private System.Windows.Forms.TextBox tbRegisterName;
        private System.Windows.Forms.Label lbRegisterProductId;
        private System.Windows.Forms.Label lbRegisterName;
        private System.Windows.Forms.Label lbRegisterCategory;
        private System.Windows.Forms.Label lbRegisterSellingPrice;
        private System.Windows.Forms.TextBox tbRegisterPrice;
        private System.Windows.Forms.Label lbRegisterPrimeCost;
        private System.Windows.Forms.TextBox tbRegisterCost;
        private System.Windows.Forms.GroupBox gbRegisterNewProduct;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cbRegisterCategory;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.GroupBox gbRevenueInfo;
        private System.Windows.Forms.Label lbRevenueCost;
        private System.Windows.Forms.Label lbRevenueGrossSales;
        private System.Windows.Forms.Label lbRevenuSales;
        private System.Windows.Forms.Label lbRevenueIncome;
        private System.Windows.Forms.Button btnOrderSearch;
        private System.Windows.Forms.GroupBox gbRadioButtons;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbNotDelivred;
        private System.Windows.Forms.RadioButton rbDelivered;
        private System.Windows.Forms.Label lbSalesIncome;
        private System.Windows.Forms.Label lbSalesCost;
        private System.Windows.Forms.Label lbSales;
        private System.Windows.Forms.Label lbSalesCount;
        private System.Windows.Forms.Label lbOrderId;
    }
}

