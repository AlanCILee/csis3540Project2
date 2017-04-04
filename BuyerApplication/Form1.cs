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
    public partial class Form1 : Form
    {
        private ElectronicsMartEntities context;

        public Form1()
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
    }
}
