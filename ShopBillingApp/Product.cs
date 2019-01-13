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
    public partial class Product : Form
    {
        public int CMBBrandValueMember { get; set; }
        public int ProductID { get; set; }
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            LoadBrandComboBox();
            LoadDGVProducts();
        }

        public void LoadBrandComboBox()
        {
            BrandDAL BD = new BrandDAL();
            DataSet ds = BD.LoadCMBBrand();
            CMBBrand.ValueMember = "Brand ID";
            CMBBrand.DisplayMember = "Brand Name";
            CMBBrand.DataSource = ds.Tables[0];
        }

        public void LoadDGVProducts()
        {
            ProductDAL PB = new ProductDAL();
            DataTable dt = PB.LoadDGVProducts();
            DGVProduct.DataSource = dt;
        }

        private void CMBBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CmbBrandText = CMBBrand.Text.ToString();
            BrandDAL BD = new BrandDAL();
            DataTable ds = BD.LoadValueMemberOfBrandComboBox(CmbBrandText);
            foreach (DataRow dr in ds.Rows)
            {
                CMBBrandValueMember = Convert.ToInt32(dr[0].ToString());
            }
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            ProductBAL PB = new ProductBAL();
            if (TxtProductName.Text.Trim() != "")
            {
                PB.Product_Name = TxtProductName.Text.Trim();
                if (CMBBrandValueMember != 0)
                {
                    PB.Brand_ID = CMBBrandValueMember;
                    if (TxtCost.Text.Trim() != "")
                    {
                        PB.Product_Cost = Convert.ToDecimal(TxtCost.Text.Trim());
                        if (TxtSellingRate.Text.Trim() != "")
                        {
                            PB.Selling_Rate = Convert.ToDecimal(TxtSellingRate.Text.Trim());
                            PB.Description = TxtDescription.Text.Trim();
                            ProductDAL PD = new ProductDAL();
                            int result = PD.InsertProduct(PB);
                            if (result > 0)
                            {
                                MessageBox.Show("Product Added Successfully");
                                LoadDGVProducts();
                            }
                            else
                            {
                                MessageBox.Show("Something Went Wrong");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter the selling price of the product");
                            TxtSellingRate.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter the Product Cost");
                        TxtCost.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please Select the Brand Name");
                }
            }
            else
            {
                MessageBox.Show("Product Name cannot be blank");
                TxtProductName.Focus();
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtProductName.Text = "";
            TxtCost.Text = "";
            TxtDescription.Text = "";
            TxtSellingRate.Text = "";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ProductBAL PB = new ProductBAL();
            if (TxtProductName.Text.Trim() != "")
            {
                PB.Product_Name = TxtProductName.Text.Trim();
                if (CMBBrandValueMember != 0)
                {
                    PB.Brand_ID = CMBBrandValueMember;
                    if (TxtCost.Text.Trim() != "")
                    {
                        PB.Product_Cost = Convert.ToDecimal(TxtCost.Text.Trim());
                        if (TxtSellingRate.Text.Trim() != "")
                        {
                            PB.Selling_Rate = Convert.ToDecimal(TxtSellingRate.Text.Trim());
                            PB.Description = TxtDescription.Text.Trim();
                            PB.Product_ID = ProductID;
                            ProductDAL PD = new ProductDAL();
                            int result = PD.UpdateProduct(PB);
                            if (result > 0)
                            {
                                MessageBox.Show("Product Updated Successfully");
                                LoadDGVProducts();
                            }
                            else
                            {
                                MessageBox.Show("Something Went Wrong");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter the selling price of the product");
                            TxtSellingRate.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter the Product Cost");
                        TxtCost.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please Select the Brand Name");
                }
            }
            else
            {
                MessageBox.Show("Product Name cannot be blank");
                TxtProductName.Focus();
            }
        }

        private void DGVProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVProduct.SelectedRows.Count > 0)
            {
                ProductID = Convert.ToInt32(DGVProduct.SelectedRows[0].Cells[0].Value + string.Empty);
                TxtProductName.Text = DGVProduct.SelectedRows[0].Cells[1].Value + string.Empty;
                CMBBrand.Text = DGVProduct.SelectedRows[0].Cells[2].Value + string.Empty;
                TxtCost.Text = DGVProduct.SelectedRows[0].Cells[3].Value + string.Empty;
                TxtSellingRate.Text = DGVProduct.SelectedRows[0].Cells[4].Value + string.Empty;
                TxtDescription.Text = DGVProduct.SelectedRows[0].Cells[5].Value + string.Empty;
            }
        }

        private void TxtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtSellingRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtFilterByProductName_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                BindingSource DGV = new BindingSource
                {
                    DataSource = DGVProduct.DataSource,
                    Filter = string.Format("`Product Name` LIKE '%{0}' OR `Product Name` LIKE '%{0}%'", TxtFilterByProductName.Text.Trim())
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtFilterByBrand_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                BindingSource DGV = new BindingSource
                {
                    DataSource = DGVProduct.DataSource,
                    Filter = string.Format("`Brand Name` LIKE '%{0}' OR `Brand Name` LIKE '%{0}%'", TxtFilterByBrand.Text.Trim())
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtFilterByCategory_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                BindingSource DGV = new BindingSource
                {
                    DataSource = DGVProduct.DataSource,
                    Filter = string.Format("`Category` LIKE '%{0}' OR `Category` LIKE '%{0}%'", TxtFilterByCategory.Text.Trim())
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
