using ShopBillingApp.BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopBillingApp.DAL
{
    public partial class Category : Form
    {
        public int Cat_ID { get; set; }
        public Category()
        {
            InitializeComponent();
        }

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            CategoryBAL CB = new CategoryBAL();
            CategoryDAL CD = new CategoryDAL();
            if (TxtCategoryName.Text == "")
            {
                MessageBox.Show("Category Field Cannot be blank");
            }
            else
            {
                CB.CategoryName = TxtCategoryName.Text.Trim();
                int Result = CD.InsertCategory(CB);
                if (Result > 0)
                {
                    MessageBox.Show("Category Added Successfully");
                    LoadDGVCategory();
                }
                else
                {
                    MessageBox.Show("Something Went Wrong");
                    LoadDGVCategory();
                }
            }
        }

        private void Category_Load(object sender, EventArgs e)
        {
            LoadDGVCategory();
        }

        public void LoadDGVCategory()
        {
            CategoryDAL CD = new CategoryDAL();
            DGVCategory.DataSource = CD.LoadDGVCategory();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            CategoryBAL CB = new CategoryBAL();
            CategoryDAL CD = new CategoryDAL();
            if (TxtCategoryName.Text != "")
            {
                CB.CatID = Cat_ID;
                CB.CategoryName = TxtCategoryName.Text.Trim();
                int Result = CD.UpdateCategory(CB);
                if (Result > 0)
                {
                    MessageBox.Show("Category Updated with Category ID Number " + Cat_ID + " Successfully");
                    LoadDGVCategory();
                }
                else
                {
                    MessageBox.Show("Something Went Wrong");
                    LoadDGVCategory();
                }
            }
        }

        private void DGVCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGVCategory.SelectedRows.Count > 0)
                {
                    Cat_ID = Convert.ToInt32(DGVCategory.SelectedRows[0].Cells[0].Value + string.Empty);
                    TxtCategoryName.Text = DGVCategory.SelectedRows[0].Cells[1].Value + string.Empty;
                }
            }
            catch (Exception)
            {
                throw;
            }
          
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtCategoryName.Text = "";
        }
    }
}
