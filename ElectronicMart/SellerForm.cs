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

            showCategoryOption();

           
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
            gridViewStock.Columns[0].Width = 60;
            gridViewStock.Columns[1].Width = 60;
            gridViewStock.Columns[2].Width = 300;
            gridViewStock.Columns[3].Width = 60;
            gridViewStock.Columns[4].Width = 60;
            gridViewStock.Columns[5].Width = 60;

        }

        private void showCategoryOption()
        {
            var query = from category in context.Categories
                         select new
                         {
                             CategoryId = category.categoryId,
                             CategoryName = category.categoryName
                         };

            cbCategory.DataSource = query.ToList();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryId";
        }

        //search products with search condition
        private void btnSearch_Click(object sender, EventArgs e)
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
                        join category in context.Categories
                        on product.categoryId equals category.categoryId
                        where inputId == product.productId || inputId == -1
                        where inputCategoryId == product.categoryId || inputCategoryId == 0
                        where inputQty >= product.quantityAvailable || inputQty == -1
                        where product.productName.Contains(inputProductName) || inputProductName == ""
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
    }
}
