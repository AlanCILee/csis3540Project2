using DataAdministrator.EF_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

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

            dataGridViewProducts.DataSource = context.Products.Local.ToBindingList();
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.Columns["categoryId"].Visible = false;
            dataGridViewProducts.Columns["primeCost"].Visible = false;
           dataGridViewProducts.Columns["orders"].Visible = false;

            comboBoxCategory.DataSource = context.Categories.ToList();
            comboBoxCategory.ValueMember = "categoryId";
            comboBoxCategory.DisplayMember = "categoryName";
            comboBoxCategory.Invalidate();

        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = from category in context.Products
                        where comboBoxCategory.SelectedIndex = category.categoryId
                        select category;


        }
    }
}
