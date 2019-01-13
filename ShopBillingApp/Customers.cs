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
    public partial class Customers : Form
    {
        public int Customer_ID { get; set; }
        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            LoadDGVCustomers();
        }

        public void LoadDGVCustomers()
        {
            CustomerDAL CD = new CustomerDAL();
            DGVCustomers.DataSource = CD.LoadDGVCategory();
        }

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            CustomerDAL CD = new CustomerDAL();
            CustomerBAL CB = new CustomerBAL();
            if (TxtCustomerName.Text.Trim() != "")
            {
                CB.CustomerName = TxtCustomerName.Text.Trim();
                if (TxtAddress.Text.Trim() != "")
                {
                    CB.Address = TxtAddress.Text.Trim();
                    if (TxtCity.Text.Trim() != "")
                    {
                        CB.City = TxtCity.Text.Trim();
                        CB.Contact = TxtContact.Text.Trim();
                        CB.MailID = TxtMailID.Text.Trim();
                        int Result = CD.InsertCustomer(CB);
                        if (Result > 0)
                        {
                            MessageBox.Show("Customer Added Successfully");
                            LoadDGVCustomers();
                        }
                        else
                        {
                            MessageBox.Show("Oops Something Wwent Wrong");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter the City Name");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter the Address");
                }
            }
            else
            {
                MessageBox.Show("Please Enter the Customer Name");
            }
        }

        private void DGVCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVCustomers.SelectedRows.Count > 0)
            {
                Customer_ID = Convert.ToInt32(DGVCustomers.SelectedRows[0].Cells[0].Value + string.Empty);
                TxtCustomerName.Text = DGVCustomers.SelectedRows[0].Cells[1].Value + string.Empty;
                TxtAddress.Text = DGVCustomers.SelectedRows[0].Cells[2].Value + string.Empty;
                TxtCity.Text = DGVCustomers.SelectedRows[0].Cells[3].Value + string.Empty;
                TxtContact.Text = DGVCustomers.SelectedRows[0].Cells[4].Value + string.Empty;
                TxtMailID.Text = DGVCustomers.SelectedRows[0].Cells[5].Value + string.Empty;
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtCustomerName.Text ="";
            TxtAddress.Text = "";
            TxtCity.Text = "";
            TxtContact.Text = "";
            TxtMailID.Text = "";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            CustomerDAL CD = new CustomerDAL();
            CustomerBAL CB = new CustomerBAL();
            if (TxtCustomerName.Text.Trim() != "")
            {
                CB.CustomerName = TxtCustomerName.Text.Trim();
                if (TxtAddress.Text.Trim() != "")
                {
                    CB.Address = TxtAddress.Text.Trim();
                    if (TxtCity.Text.Trim() != "")
                    {
                        CB.CustomerID = Customer_ID;
                        CB.City = TxtCity.Text.Trim();
                        CB.Contact = TxtContact.Text.Trim();
                        CB.MailID = TxtMailID.Text.Trim();
                        int Result = CD.UpdateCustomer(CB);
                        if (Result > 0)
                        {
                            MessageBox.Show("Customer Updated Successfully");
                            LoadDGVCustomers();
                        }
                        else
                        {
                            MessageBox.Show("Oops Something Wwent Wrong");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter the City Name");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter the Address");
                }
            }
            else
            {
                MessageBox.Show("Please Enter the Customer Name");
            }
        }

        private void TxtFilterByName_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void TxtFilterByCity_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                BindingSource DGV = new BindingSource
                {
                    DataSource = DGVCustomers.DataSource,
                    Filter = string.Format("`City` LIKE '%{0}' OR `City` LIKE '%{0}%'", TxtFilterByCity.Text.Trim())
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtFilterByName_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                BindingSource DGV = new BindingSource
                {
                    DataSource = DGVCustomers.DataSource,
                    Filter = string.Format("`Full Name` LIKE '%{0}' OR `Full Name` LIKE '%{0}%'", TxtFilterByName.Text.Trim())
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtFilterByContact_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                BindingSource DGV = new BindingSource
                {
                    DataSource = DGVCustomers.DataSource,
                    Filter = string.Format("`Contact No` LIKE '%{0}' OR `Contact No` LIKE '%{0}%'", TxtFilterByContact.Text.Trim())
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
