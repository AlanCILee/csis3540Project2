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
        List<Product> productsToAdd = new List<Product>();

        public BuyerForm()
        {
            InitializeComponent();

            context = new ElectronicsMartEntities();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context.Categories.Load();
            context.Customers.Load();
            context.Orders.Load();
            context.Products.Load();

            comboBoxCategory.DataSource = context.Categories.ToList();
            comboBoxCategory.ValueMember = "categoryId";
            comboBoxCategory.DisplayMember = "categoryName";
            comboBoxCategory.Invalidate();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           int selectedCategory =comboBoxCategory.SelectedIndex;


            var query = from category in context.Products
                        where category.categoryId == selectedCategory || selectedCategory==0 
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



            

            foreach (DataGridViewRow row in dataGridViewProducts.SelectedRows)
                //productsToAdd.Add(context.Products.Find(row.Cells[0].Value));
                productsToAdd.Add(context.Products.Find(row.Cells[0].Value));

            //var query = from orders in productsToAdd
            //             select new
            //             {
            //                 ProductId = productsToAdd.ElementAt(0).productId,
            //                 UnitPrice = productsToAdd.ElementAt(0).unitPrice,
            //                 Quantity = quantity,
            //                 TotalPrice = (quantity * (productsToAdd.ElementAt(0).unitPrice))

            //             };

            //dataGridViewCart.DataSource = query.ToList();
            dataGridViewCart.DataSource = productsToAdd.ToList();
            dataGridViewCart.Refresh();
            dataGridViewCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            


            
           // updateCart();






        }

        private void updateCart()
        {
            throw new NotImplementedException();
        }

    
    }
}
