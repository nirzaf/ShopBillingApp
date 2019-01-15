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
    public partial class MinimumStock : Form
    {
        public int ProductID { get; set; }
        public MinimumStock()
        {
            InitializeComponent();
        }

        private void MinimumStock_Load(object sender, EventArgs e)
        {
            LoadDGVStock();
        }

        public void LoadDGVStock()
        {
            try
            {
                StockDAL sd = new StockDAL();
                DGVStock.DataSource = sd.LoadDGVStockWithMinStock();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void DGVStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVStock.SelectedRows.Count > 0)
            {
                TxtMinStockQty.Text = DGVStock.SelectedRows[0].Cells[3].Value + string.Empty; 
                ProductID = Convert.ToInt32(DGVStock.SelectedRows[0].Cells[0].Value + string.Empty); 
            }
        }

        private void TxtMinStockQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void BtnUpdateMinStock_Click(object sender, EventArgs e)
        {
            StockBAL sb = new StockBAL();
            StockDAL sd = new StockDAL();
            if (TxtMinStockQty.Text.Trim() != "")
            {
                sb.ProductID = ProductID;
                sb.Quantity = Convert.ToInt32(TxtMinStockQty.Text.Trim());
                int Result = sd.UpdateMinimumStock(sb);
                if (Result == 1)
                {
                    MessageBox.Show("Minimum Stock Updated Succesfully");
                    LoadDGVStock();
                }
                else
                {
                    MessageBox.Show("Something Went Wrong");
                }
            }
            else
            {
                MessageBox.Show("Minimum Stock Cannot be empty");
            }
        }
    }
}
