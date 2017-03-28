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

namespace DataAdministrator
{
    public partial class DataAdmin : Form
    {
        ElectronicsMartEntities context;

        public DataAdmin()
        {
            InitializeComponent();
            context = new ElectronicsMartEntities();
        }

        // Clear all tables' rows and put initial mock data
        private void btnInit_Click(object sender, EventArgs e)
        {
            context.Orders.Load();
            context.Categories.Load();
            context.Customers.Load();
            context.Products.Load();

            context.Orders.Local.Clear();
            context.Categories.Local.Clear();
            context.Customers.Local.Clear();
            context.Products.Local.Clear();

            context.Customers.AddRange((new CutomerMockData()).getMockData());
            context.SaveChanges();
            context.Categories.AddRange((new CategoryMockData()).getMockData());
            context.SaveChanges();
            context.Products.AddRange((new ProductMockData()).getMockData());

            context.SaveChanges();



        }
    }
}
