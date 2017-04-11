namespace BuyerApplication
{
    partial class BuyerForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSelectCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelEnterQuantity = new System.Windows.Forms.Label();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonClearCart = new System.Windows.Forms.Button();
            this.labelCartTotal = new System.Windows.Forms.Label();
            this.labelOrderTotal = new System.Windows.Forms.Label();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.groupBoxCart = new System.Windows.Forms.GroupBox();
            this.labelMyCart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.groupBoxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.groupBoxCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(461, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(174, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "The Electronics Mart";
            // 
            // labelSelectCategory
            // 
            this.labelSelectCategory.AutoSize = true;
            this.labelSelectCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectCategory.Location = new System.Drawing.Point(25, 39);
            this.labelSelectCategory.Name = "labelSelectCategory";
            this.labelSelectCategory.Size = new System.Drawing.Size(85, 13);
            this.labelSelectCategory.TabIndex = 2;
            this.labelSelectCategory.Text = "Select Category:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(133, 36);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(211, 23);
            this.comboBoxCategory.TabIndex = 3;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToCart.Location = new System.Drawing.Point(352, 453);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(153, 38);
            this.buttonAddToCart.TabIndex = 5;
            this.buttonAddToCart.Text = "Add To Cart";
            this.buttonAddToCart.UseVisualStyleBackColor = true;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(184, 460);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(94, 24);
            this.textBoxQuantity.TabIndex = 6;
            // 
            // labelEnterQuantity
            // 
            this.labelEnterQuantity.AutoSize = true;
            this.labelEnterQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterQuantity.Location = new System.Drawing.Point(69, 463);
            this.labelEnterQuantity.Name = "labelEnterQuantity";
            this.labelEnterQuantity.Size = new System.Drawing.Size(101, 15);
            this.labelEnterQuantity.TabIndex = 7;
            this.labelEnterQuantity.Text = "Enter Quantity:";
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.AllowUserToAddRows = false;
            this.dataGridViewCart.AllowUserToDeleteRows = false;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Location = new System.Drawing.Point(653, 104);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.ReadOnly = true;
            this.dataGridViewCart.Size = new System.Drawing.Size(351, 184);
            this.dataGridViewCart.TabIndex = 8;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrder.Location = new System.Drawing.Point(98, 295);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(162, 42);
            this.buttonOrder.TabIndex = 10;
            this.buttonOrder.Text = "Order";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonClearCart
            // 
            this.buttonClearCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearCart.Location = new System.Drawing.Point(116, 343);
            this.buttonClearCart.Name = "buttonClearCart";
            this.buttonClearCart.Size = new System.Drawing.Size(129, 42);
            this.buttonClearCart.TabIndex = 11;
            this.buttonClearCart.Text = "Clear Cart";
            this.buttonClearCart.UseVisualStyleBackColor = true;
            this.buttonClearCart.Click += new System.EventHandler(this.buttonClearCart_Click);
            // 
            // labelCartTotal
            // 
            this.labelCartTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCartTotal.Location = new System.Drawing.Point(178, 254);
            this.labelCartTotal.Name = "labelCartTotal";
            this.labelCartTotal.Size = new System.Drawing.Size(150, 23);
            this.labelCartTotal.TabIndex = 12;
            // 
            // labelOrderTotal
            // 
            this.labelOrderTotal.AutoSize = true;
            this.labelOrderTotal.Location = new System.Drawing.Point(71, 254);
            this.labelOrderTotal.Name = "labelOrderTotal";
            this.labelOrderTotal.Size = new System.Drawing.Size(91, 16);
            this.labelOrderTotal.TabIndex = 13;
            this.labelOrderTotal.Text = "Order Total:";
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxMenu.Controls.Add(this.dataGridViewProducts);
            this.groupBoxMenu.Controls.Add(this.labelSelectCategory);
            this.groupBoxMenu.Controls.Add(this.comboBoxCategory);
            this.groupBoxMenu.Controls.Add(this.buttonAddToCart);
            this.groupBoxMenu.Controls.Add(this.textBoxQuantity);
            this.groupBoxMenu.Controls.Add(this.labelEnterQuantity);
            this.groupBoxMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMenu.Location = new System.Drawing.Point(25, 65);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(583, 522);
            this.groupBoxMenu.TabIndex = 14;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Menu";
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(28, 87);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(530, 346);
            this.dataGridViewProducts.TabIndex = 8;
            // 
            // groupBoxCart
            // 
            this.groupBoxCart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxCart.Controls.Add(this.buttonClearCart);
            this.groupBoxCart.Controls.Add(this.labelCartTotal);
            this.groupBoxCart.Controls.Add(this.buttonOrder);
            this.groupBoxCart.Controls.Add(this.labelOrderTotal);
            this.groupBoxCart.Controls.Add(this.labelMyCart);
            this.groupBoxCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCart.Location = new System.Drawing.Point(643, 65);
            this.groupBoxCart.Name = "groupBoxCart";
            this.groupBoxCart.Size = new System.Drawing.Size(367, 410);
            this.groupBoxCart.TabIndex = 8;
            this.groupBoxCart.TabStop = false;
            this.groupBoxCart.Text = "Cart";
            // 
            // labelMyCart
            // 
            this.labelMyCart.AutoSize = true;
            this.labelMyCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyCart.Location = new System.Drawing.Point(138, 16);
            this.labelMyCart.Name = "labelMyCart";
            this.labelMyCart.Size = new System.Drawing.Size(53, 16);
            this.labelMyCart.TabIndex = 9;
            this.labelMyCart.Text = "My Cart";
            // 
            // BuyerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 606);
            this.Controls.Add(this.dataGridViewCart);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.groupBoxCart);
            this.Name = "BuyerForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BuyerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.groupBoxCart.ResumeLayout(false);
            this.groupBoxCart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSelectCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelEnterQuantity;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonClearCart;
        private System.Windows.Forms.Label labelCartTotal;
        private System.Windows.Forms.Label labelOrderTotal;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.GroupBox groupBoxCart;
        private System.Windows.Forms.Label labelMyCart;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
    }
}

