using DataAdministrator.EF_Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ElectronicMart
{
    public partial class SellerForm : Form
    {
        private ElectronicsMartEntities context;
        private int selectedProductId = -1;
        private int selectedOrderId = -1;

        public SellerForm()
        {
            InitializeComponent();
            context = new ElectronicsMartEntities();
        }


        private void SellerForm_Load(object sender, EventArgs e)
        {
            // Load data 
            context.Products.Load();
            context.Categories.Load();
            context.Orders.Load();
            context.Categories.Load();

            // Setup Combo Box contents in form
            showCategoryOption(cbCategory);
            showCategoryOption(cbRegisterCategory);

            // Show initial products list & format of GridView
            var query = from product in context.Products
                        select new
                        {
                            ProductID = product.productId,
                            Category = product.Category.categoryName,
                            ProductName = product.productName,
                            Price = product.unitPrice,
                            QTY = product.quantityAvailable,
                            Cost = product.primeCost
                        };

            gridViewStock.DataSource = query.ToList();
            gridViewStock.Columns[0].Width = 60;
            gridViewStock.Columns[1].Width = 60;
            gridViewStock.Columns[2].Width = 300;
            gridViewStock.Columns[3].Width = 60;
            gridViewStock.Columns[4].Width = 60;
            gridViewStock.Columns[5].Width = 60;

            // Show Order Grid View
            showOrders();

            // Show initial Revenue Status 
            calculateRevenue();

            // Register Gridview click event to find the id of clicked item
            gridViewStock.CellMouseClick += this.gridViewStock_CellMouseClick;
            gridViewOrder.CellMouseClick += this.gridViewOrder_CellMouseClick;

        }

        // Register a Combo box's data with categories data
        private void showCategoryOption(ComboBox cb)
        {
            cb.DataSource = context.Categories.Local.ToArray();
            cb.DisplayMember = "CategoryName";
            cb.ValueMember = "CategoryId";
        }

        // search products with search condition
        private void btnSearch_Click(object sender, EventArgs e)
        {
            showStocks();
        }

        // Fills in stock gridview by search conditions
        private void showStocks()
        {

            int inputId;
            int inputCategoryId;
            int inputQty;
            string inputProductName;

            //check productId. empty & wrong input means search all id products
            try
            {
                inputId = int.Parse(tbId.Text);
            }
            catch (Exception ex)
            {
                inputId = -1;
            }

            // check stock quantity. empty & wrong input means search all quantity products 
            try
            {
                inputQty = int.Parse(tbQuantity.Text);
            }
            catch (Exception ex)
            {
                inputQty = -1;
            }

            inputCategoryId = cbCategory.SelectedIndex;
            inputProductName = tbName.Text;

            // use LINQ query with search conditions
            var query = from product in context.Products
                        where inputId == product.productId || inputId == -1
                        where inputCategoryId == product.categoryId || inputCategoryId == 0
                        where inputQty >= product.quantityAvailable || inputQty == -1
                        where product.productName.Contains(inputProductName) || inputProductName == ""
                        select new
                        {
                            ProductID = product.productId,
                            Category = product.Category.categoryName,
                            ProductName = product.productName,
                            Price = product.unitPrice,
                            QTY = product.quantityAvailable,
                            Cost = product.primeCost
                        };

            gridViewStock.DataSource = query.ToList();
        }

        // Stock grid view cell click event to store clicked item's id
        private void gridViewStock_CellMouseClick(Object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                selectedProductId = (int)gridViewStock.Rows[e.RowIndex].Cells[0].Value;
                lbProductId.Text = "Product ID: " + selectedProductId;
            }
            catch(Exception ex)
            {
                //In case of clicking title cell : Do nothing
            }          
        }

        // Order grid view cell click event to store clicked item's id
        private void gridViewOrder_CellMouseClick(Object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                selectedOrderId = (int)gridViewOrder.Rows[e.RowIndex].Cells[0].Value;
                lbOrderId.Text = "Order ID: " + selectedOrderId;
            }
            catch (Exception ex)
            {
                //In case of clicking title cell : Do nothing
            }
        }

        // Purchase Stock Processing Button Event
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                int purchaseCnt = int.Parse(tbPurchaseCnt.Text);
                if (selectedProductId >= 0)
                {
                    context.Products.Load(); 
                    
                    // Find product instance which was clicked 
                    var result = context.Products.SingleOrDefault(p => p.productId == selectedProductId);
                    if (result != null)
                    {
                        result.quantityAvailable += purchaseCnt;    // Add number of purchasing
                        context.SaveChanges();
                        showStocks();

                        tbPurchaseCnt.Text = "";
                        lbProductId.Text = "";
                        selectedProductId = -1;
                        MessageBox.Show("Purchasing " + purchaseCnt + " of " + result.productName + " processed successfully");
                    }
                }else
                {
                    MessageBox.Show("Please click product to purchase on the list");
                }

            }catch (Exception ex)
            {
                MessageBox.Show("Please input correct purchase count: " + ex.Message);
            }
        }

        // Register New Product Button Click Event
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {                    
                int rProductId = int.Parse(tbRegisterId.Text);
                string rProductName = tbRegisterName.Text;
                int rProductPrice = int.Parse(tbRegisterPrice.Text);           
                int rProductCost = int.Parse(tbRegisterCost.Text);
                int rProductCategory = cbRegisterCategory.SelectedIndex;
                if (rProductCategory == 0)
                {
                    MessageBox.Show("Please select product category");
                    return;
                }

                // Create object and Add to the database
                context.Products.Add(new Product
                {
                    productId = rProductId,
                    productName = rProductName,
                    unitPrice = rProductPrice,
                    categoryId = rProductCategory,
                    quantityAvailable = 0,
                    primeCost = rProductCost
                });

                context.SaveChanges();
                showStocks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input correct value: " + ex.Message);
            }            
        }

        // Order Deliver click event
        private void btnDeliver_Click(object sender, EventArgs e)
        {
            if (selectedOrderId >= 0)
            {
                context.Orders.Load();

                var result = context.Orders.SingleOrDefault(o => o.orderId == selectedOrderId);

                if (result != null)
                {
                    if(result.delivered == 0)
                    {
                        result.delivered = 1;
                        context.SaveChanges();
                        showOrders();

                        lbOrderId.Text = "";
                        selectedOrderId = -1;
                        MessageBox.Show("Order " + result.orderId + " delivered successfully");

                        calculateRevenue();
                    }
                    else
                    {
                        lbOrderId.Text = "";
                        selectedOrderId = -1;
                        MessageBox.Show("You already sent this order");
                    }

                }
            }
            else
            {
                MessageBox.Show("Please click order to deliver on the list");
            }
        }

        // Show Order List with Radio Button Condition
        private void showOrders()
        {
            context.Orders.Load();

            var query = context.Orders.ToList().Where(order => checkDeliveredStatus((int)order.delivered));
            var query2 = from order in query.ToList()
                        select new
                        {
                            OrderID = order.orderId,                            
                            ProductName = order.Product.productName,
                            Price = order.Product.unitPrice,
                            QTY = order.quantity,
                            Delivered = returnDeliveredString((int)order.delivered)
                        };

            gridViewOrder.DataSource = query2.ToList();
        }

        // Return boolean for query, depends on delivered status
        bool checkDeliveredStatus(int delivered)
        {
            if (rbAll.Checked)
                return true;
            else if (rbDelivered.Checked)
                return delivered == 1;
            else 
                return delivered == 0;
        }

        // Return delivery status string 
        string returnDeliveredString(int delivered)
        {
            if (delivered == 1)
                return "Delivered";
            else
                return "Waiting";
        }

        // Order Search button click event
        private void btnOrderSearch_Click(object sender, EventArgs e)
        {
            showOrders();
        }

        // Revenu generate and display method
        private void calculateRevenue()
        {
            // Find delivered items only
            var query = from order in context.Orders.ToList()
                        where order.delivered == 1
                        select new
                         {
                             OrderId = order.orderId,                            
                             Price = order.Product.unitPrice,
                             QTY = order.quantity,
                             Cost = order.Product.primeCost
                         };

            // Caculate total coast and revenue
            int totalCost = query.Sum(s => (int)s.Cost);
            int grossSales = query.Sum(s => (int)s.Price);

            lbSalesCount.Text = string.Format("{0}", query.Count());
            lbSales.Text = string.Format("$ {0}", grossSales);
            lbSalesCost.Text = string.Format("$ {0}", totalCost);
            lbSalesIncome.Text = string.Format("$ {0}", grossSales - totalCost);
        }
    }
}
