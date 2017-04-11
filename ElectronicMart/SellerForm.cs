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
            context.Products.Load();
            context.Categories.Load();

            showCategoryOption(cbCategory);
            showCategoryOption(cbRegisterCategory);

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

            gridViewStock.CellMouseClick += this.gridViewStock_CellMouseClick;
            gridViewOrder.CellMouseClick += this.gridViewOrder_CellMouseClick;
        }

        private void showCategoryOption(ComboBox cb)
        {
            cb.DataSource = context.Categories.Local.ToArray();
            cb.DisplayMember = "CategoryName";
            cb.ValueMember = "CategoryId";
        }

        //search products with search condition
        private void btnSearch_Click(object sender, EventArgs e)
        {
            showStocks();
        }

        private void showStocks()
        {

            int inputId;
            int inputCategoryId;
            int inputQty;
            string inputProductName;

            //check productId. empty & wrong input means search all ids' products
            try
            {
                inputId = int.Parse(tbId.Text);
            }
            catch (Exception ex)
            {
                inputId = -1;
            }

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

            //join product and category to show category name
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

        private bool checkId(int productId)
        {
            try
            {
                int inputId = int.Parse(tbId.Text);
                return inputId == productId;
            }
            catch (Exception e)
            {
                return true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            context.Orders.Load();
            gridViewOrder.DataSource = context.Orders.Local.ToBindingList();
            gridViewOrder.Columns["delivered"].Visible = false;
            gridViewOrder.Columns["email"].Visible = false;
            gridViewOrder.Columns["Customer"].Visible = false;
            gridViewOrder.Columns["Product"].Visible = false;

        }

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

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                int purchaseCnt = int.Parse(tbPurchaseCnt.Text);
                if (selectedProductId >= 0)
                {
                    context.Products.Load(); 
                    
                    var result = context.Products.SingleOrDefault(p => p.productId == selectedProductId);
                    if (result != null)
                    {
                        result.quantityAvailable += purchaseCnt;
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

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedOrderId >= 0)
                {
                    context.Products.Load();

                    var result = context.Orders.SingleOrDefault(o => o.orderId == selectedOrderId);
                    if (result != null)
                    {
                        result.delivered = 1;
                        context.SaveChanges();
                        showOrders();

                        lbOrderId.Text = "";
                        selectedOrderId = -1;
                        MessageBox.Show("Order " + result.orderId + " delivered successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Please click product to purchase on the list");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input correct purchase count: " + ex.Message);
            }

        }

        private void showOrders()
        {
            var query = context.Orders.ToList().Where(order => checkDeliveredStatus((int)order.delivered));
            var query2 = from order in context.Orders                      
                        select new
                        {
                            OrderID = order.productId,                            
                            ProductName = order.Product.productName,
                            Price = order.Product.unitPrice,
                            QTY = order.quantity,
                            Delivered = (int)order.delivered
                        };

            gridViewOrder.DataSource = query2.ToList();
        }

        bool checkDeliveredStatus(int delivered)
        {
            if (rbAll.Checked)
                return true;
            else if (rbDelivered.Checked)
                return delivered == 0;
            else 
                return delivered == 1;
        }

        string returnDeliveredString(int delivered)
        {
            if (delivered == 1)
                return "Delivered";
            else
                return "Waiting";
        }

        private void btnOrderSearch_Click(object sender, EventArgs e)
        {
            showOrders();
        }
    }
}
