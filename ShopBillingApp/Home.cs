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
            Brand Child = new Brand
            {
                MdiParent = this
            };
            Child.Show();
        }

        private void MenuCategory_Click(object sender, EventArgs e)
        {
            Category Child = new Category
            {
                MdiParent = this
            };
            Child.Show();
        }

        private void MenuProducts_Click(object sender, EventArgs e)
        {
            Product Child = new Product
            {
                MdiParent = this
            };
            Child.Show();
        }

        private void MenuCustomers_Click(object sender, EventArgs e)
        {
            Customers Child = new Customers
            {
                MdiParent = this
            };
            Child.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUsers Child = new ManageUsers
            {
                MdiParent = this
            };
            Child.Show();
        }

        private void ChangePasswordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ManageUsers Child = new ManageUsers
            {
                MdiParent = this
            };
            Child.Show();
        }

        private void StocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock Child = new Stock
            {
                MdiParent = this
            };
            Child.Show();
        }
    }
}
