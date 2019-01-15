using ShopBillingApp.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopBillingApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuBrand_Click(object sender, EventArgs e)
        {
            Brand ChildForm = new Brand
            {
                MdiParent = this
            };
            ChildForm.Show();
        }

        private void MenuCategory_Click(object sender, EventArgs e)
        {
            Category ChildForm = new Category
            {
                MdiParent = this
            };
            ChildForm.Show();
        }

        private void MenuProducts_Click(object sender, EventArgs e)
        {
            Product ChildForm = new Product
            {
                MdiParent = this
            };
            ChildForm.Show();
        }

        private void MenuCustomers_Click(object sender, EventArgs e)
        {
            Customers ChildForm = new Customers
            {
                MdiParent = this
            };
            ChildForm.Show();
        }

        private void MenuStocks_Click(object sender, EventArgs e)
        {
            Stock ChildForm = new Stock
            {
                MdiParent = this
            };
            ChildForm.Show();
        }

        private void MenuManageUsers_Click(object sender, EventArgs e)
        {
            ManageUsers ChildForm = new ManageUsers
            {
                MdiParent = this
            };
            ChildForm.Show();
        }

        private void MenuMinimumStock_Click(object sender, EventArgs e)
        {
            MinimumStock ChildForm = new MinimumStock
            {
                MdiParent = this
            };
            ChildForm.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadDGVMinimumStockNotification();
        }

        public void LoadDGVMinimumStockNotification()
        {
            try
            {
                StockDAL sd = new StockDAL();
                DGVMinimumStock.DataSource = sd.LoadDGVMinimumStockNotification();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
