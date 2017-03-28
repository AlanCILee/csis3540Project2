using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAdministrator.EF_Classes;
using System.Data.Entity; 

namespace ElectronicMart
{ 
    public partial class SellerForm : Form
    {
        private ElectronicsMartEntities context;

        public SellerForm()
        {
            InitializeComponent();
            context = new ElectronicsMartEntities();
        }

        

        private void SellerForm_Load(object sender, EventArgs e)
        {
            context.Products.Load();
            context.Categories.Load();

            var query = from product in context.Products
                        join category in context.Categories
                        on product.categoryId equals category.categoryId
                        select new
                        {
                            ProductID = product.productId,
                            Category = category.categoryName,
                            ProductName = product.productName,
                            Price = product.unitPrice,
                            QTY = product.quantityAvailable,
                            Cost = product.primeCost
                        };


            gridViewStock.DataSource = query.ToList();
            gridViewStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //gridViewStock.Columns[2].Width = 10;
            //gridViewStock.Columns[3].Width = 40;
            //gridViewStock.Columns[4].Width = 40;
            //gridViewStock.Columns[5].Width = 40;
        }
    }
}
