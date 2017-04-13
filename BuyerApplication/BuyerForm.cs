using DataAdministrator.EF_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyerApplication
{
    public partial class BuyerForm : Form
    {
        private ElectronicsMartEntities context;
        
        //List to add orders in order table
        List<orderedProduct> productsToAdd = new List<orderedProduct>();


        public BuyerForm()
        {
            InitializeComponent();
            context = new ElectronicsMartEntities();

        }

        private void BuyerForm_Load(object sender, EventArgs e)
        {
            context.Categories.Load();
            context.Customers.Load();
            context.Orders.Load();
            context.Products.Load();

            orderedProduct.totalOrder = context.Orders.ToList().Count;

            //ComboBox allows user to choose products from different categories 
            comboBoxCategory.DataSource = context.Categories.ToList();
            comboBoxCategory.ValueMember = "categoryId";
            comboBoxCategory.DisplayMember = "categoryName";
            comboBoxCategory.Invalidate();
        }
        
        //Function to load products in dataGridViewProducts when user chooses a category from comboBoxCategory
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCategory = comboBoxCategory.SelectedIndex;


            var query = from category in context.Products
                        where category.categoryId == selectedCategory || selectedCategory == 0
                        select new
                        {
                            ProductID = category.productId,
                            Category = category.Category.categoryName,
                            ProductName = category.productName,
                            Price = category.unitPrice,
                            QTY = category.quantityAvailable
                        };
            dataGridViewProducts.DataSource = query.ToList();
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            int quantity;
            if (textBoxQuantity.Text == "")
            {
                MessageBox.Show("Please enter quantity");
                return;
            }
            else
                quantity = int.Parse(textBoxQuantity.Text);

            if (dataGridViewProducts.SelectedRows.Count == 0)
                return;

            //gets the product information selected from dataGridViewProduct and adds it to the list
            foreach (DataGridViewRow row in dataGridViewProducts.SelectedRows)
            {
                orderedProduct oProduct = new orderedProduct();
                orderedProduct.totalOrder++;        //counter variable to generate orderId
                oProduct.product = context.Products.Find(row.Cells[0].Value);
                oProduct.qty = quantity;
                oProduct.orderId = orderedProduct.totalOrder;
                productsToAdd.Add(oProduct);

            }

            //Query to display the products selected in Cart datagridview 
            var query = from orders in productsToAdd
                        select new
                        {
                            ProductId = orders.product.productId,
                            UnitPrice = orders.product.unitPrice,
                            Quantity = orders.qty,
                            TotalPrice = (orders.qty * (orders.product.unitPrice))
                        };

            dataGridViewCart.DataSource = query.ToList();
            dataGridViewCart.Refresh();
            dataGridViewCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var cartTotal = query.Sum(P => P.TotalPrice);
            labelCartTotal.Text = "$ " + cartTotal.ToString();
        }

        //Function to add a new order from cart
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (productsToAdd.Count == 0)
            {
                MessageBox.Show("Please Add items to the cart first");
                return;
            }

            foreach (orderedProduct x in productsToAdd)
            {
                context.Orders.Add(new Order
                {
                    orderId = x.orderId,
                    productId = x.product.productId,
                    quantity = x.qty,
                    delivered = 0,
                    orderDate = DateTime.Today.ToString()
                });
               
            }
            context.SaveChanges();

             MessageBox.Show("Order Placed Successfuly");
             productsToAdd.Clear();
             dataGridViewCart.DataSource = productsToAdd.ToList();
        }

        private void buttonClearCart_Click(object sender, EventArgs e)
        {
           

            productsToAdd.Clear();
            dataGridViewCart.DataSource = productsToAdd.ToList();
        }
    }

    public class orderedProduct
    {
        public static int totalOrder=0;
        public Product product { get; set; }
        public int qty { get; set; }
        public int orderId;
    }
}
