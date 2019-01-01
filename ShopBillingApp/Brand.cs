using ShopBillingApp.BAL;
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
    public partial class Brand : Form
    {
        public int BrandID { get; set; }
        public Brand()
        {
            InitializeComponent();
        }

        private void Brand_Load(object sender, EventArgs e)
        {
            LoadCMBCat();
            LoadDGVBrands();
        }

        public void LoadCMBCat()
        {
            CategoryDAL cd = new CategoryDAL();
            DataSet ds = cd.GetAllCategory();
            CMBCategory.DataSource = ds.Tables[0];
            CMBCategory.ValueMember = "CatID";
            CMBCategory.DisplayMember = "CategoryName";
        }

        public void LoadDGVBrands()
        {
            BrandDAL BB = new BrandDAL();
            DGVBrand.DataSource = BB.LoadDGV();
        }

        private void CMBCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ValueMember = CMBCategory.Text.ToString();
            CategoryDAL cd = new CategoryDAL();
            DataTable ds = cd.LoadValueMember(ValueMember);
            foreach(DataRow dr in ds.Rows)
            {
                Label.Text = dr[0].ToString();
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtBrandName.Text = "";
        }

        private void BtnAddBrand_Click(object sender, EventArgs e)
        {
            BrandBAL BB = new BrandBAL
            {
                BrandName = TxtBrandName.Text.Trim(),
                Category = Convert.ToInt32(Label.Text.Trim())
            };
            BrandDAL BD = new BrandDAL();
            int Result = BD.InsertBrand(BB);
            if (Result > 0)
            {
                MessageBox.Show("Brand Added Successfully");
                LoadDGVBrands();
            }
            else
            {
                MessageBox.Show("Oops Something Went Wrong");
                LoadDGVBrands();
            }
        }

        private void DGVBrand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGVBrand.SelectedRows.Count > 0)
                {
                    TxtBrandName.Text = DGVBrand.SelectedRows[0].Cells[1].Value + string.Empty;
                    CMBCategory.Text = DGVBrand.SelectedRows[0].Cells[2].Value + string.Empty;
                    BrandID = Convert.ToInt32(DGVBrand.SelectedRows[0].Cells[0].Value + string.Empty);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void DGVBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                BrandBAL BB = new BrandBAL
                {
                    BrandID = BrandID,
                    BrandName = TxtBrandName.Text.Trim(),
                    Category = Convert.ToInt32(Label.Text)
                };
                BrandDAL BD = new BrandDAL();
                int Result = BD.UpdateBrand(BB);
                if (Result > 0)
                {
                    MessageBox.Show("Brand Successfully Updated");
                    LoadDGVBrands();
                }
                else
                {
                    MessageBox.Show("Something Went Wrong");
                }
            }
            catch (Exception)
            {
                throw;
            }           
        }

        private void BtnAddBrand_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(BtnAddBrand, "Click this Button to Add Brand");
        }

        private void BtnReset_MouseMove(object sender, MouseEventArgs e)
        {
             toolTip2.SetToolTip(BtnReset, "Reset the Brand Name Text Field");
        }

        private void BtnUpdate_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip3.SetToolTip(BtnUpdate, "Update the Brand Details");
        }
    }
}
