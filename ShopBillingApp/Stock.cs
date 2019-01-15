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
    public partial class Stock : Form
    {
        ProductDAL pd = new ProductDAL();
        public int ProductID { get; set; }

        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadDGVStock();
        }

        public void LoadProducts()
        {
            AutoCompleteStringCollection Products = new AutoCompleteStringCollection();
            DataTable dtb = pd.LoadDGVProducts();
            foreach (DataRow drb in dtb.Rows)
            {
                Products.Add(drb[1].ToString());
            }
            TxtProductName.AutoCompleteCustomSource = Products;
        }

        private void BtnAddStock_Click(object sender, EventArgs e)
        {
            StockBAL sb = new StockBAL();
            StockDAL sd = new StockDAL();
            if (TxtProductName.Text.Trim() != "")
            {
                LoadProductID();
                sb.ProductID = ProductID;
                sb.Quantity = Convert.ToInt32(TxtQuantity.Text.Trim());
                int Result = sd.AddStockDetails(sb);
                if (Result == 1)
                {
                    MessageBox.Show("Product Added Succesfully");
                    LoadDGVStock();
                }
                else
                {
                    MessageBox.Show("Something Went Wrong");
                }
            }
            else
            {
                MessageBox.Show("Product Name Cannot be empty");
            }
        }

        public void LoadProductID()
        {
            string ProductName = TxtProductName.Text.Trim(); 
            DataTable dt = pd.LoadProductID(ProductName);
            foreach (DataRow dr in dt.Rows)
            {
                ProductID = Convert.ToInt32(dr[0].ToString());
            }
        }

        private void TxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int ZERO = 48;
            const int NINE = 57;
            //const int NOT_FOUND = -1;
            int keyvalue = (int)e.KeyChar;
            if ((keyvalue == BACKSPACE) ||
            ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;
            //Allow the first (but only the first) decimal point
            //if ((keyvalue == DECIMAL_POINT) &&
            //(TextPostCode.Text.IndexOf(".") == NOT_FOUND)) return;
            //Allow nothing else
            e.Handled = true;

            if (e.KeyChar == 13)
            {
                StockBAL sb = new StockBAL();
                StockDAL sd = new StockDAL();
                if (TxtProductName.Text.Trim() != "")
                {
                    LoadProductID();
                    sb.ProductID = ProductID;
                    sb.Quantity = Convert.ToInt32(TxtQuantity.Text.Trim());
                    int Result = sd.AddStockDetails(sb);
                    if (Result == 1)
                    {
                        MessageBox.Show("Product Added Succesfully");
                        LoadDGVStock();
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong");
                    }
                }
                else
                {
                    MessageBox.Show("Product Name Cannot be empty");
                }
            }
        }

        public void LoadDGVStock()
        {
            try
            {
                StockDAL sd = new StockDAL();
                DGVStockDetails.DataSource = sd.LoadDGVStock();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtProductName.Text = "";
            TxtQuantity.Text = "";
        }
    }
}
