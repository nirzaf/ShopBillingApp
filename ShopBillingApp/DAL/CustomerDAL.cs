using MySql.Data.MySqlClient;
using ShopBillingApp.BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopBillingApp.DAL
{
    class CustomerDAL
    {
        DB C = new DB();

        public int InsertCustomer(CustomerBAL B)
        {
            try
            {
                using (C.Con)
                {
                    MySqlCommand cmd = new MySqlCommand("AddCustomer", C.Con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("C_Name", B.CustomerName));
                    cmd.Parameters.Add(new MySqlParameter("C_Address", B.Address));
                    cmd.Parameters.Add(new MySqlParameter("City_Name", B.City));
                    cmd.Parameters.Add(new MySqlParameter("Contact_No", B.Contact));
                    cmd.Parameters.Add(new MySqlParameter("MailID", B.MailID));
                    cmd.Connection.Open();
                    int Result = cmd.ExecuteNonQuery();
                    C.Con.Close();
                    return Result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public DataTable LoadDGVCategory()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("LoadDGVCustomers", C.Con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                MySqlDataAdapter Sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                Sda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public int UpdateCustomer(CustomerBAL CB)
        {
            try
            {
                using (C.Con)
                {
                    MySqlCommand cmd = new MySqlCommand("UpdateCustomers", C.Con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("CU_ID", CB.CustomerID));
                    cmd.Parameters.Add(new MySqlParameter("C_Name", CB.CustomerName));
                    cmd.Parameters.Add(new MySqlParameter("C_Address", CB.Address));
                    cmd.Parameters.Add(new MySqlParameter("C_City", CB.City));
                    cmd.Parameters.Add(new MySqlParameter("C_Contact", CB.Contact));
                    cmd.Parameters.Add(new MySqlParameter("C_Mail", CB.MailID));
                    cmd.Connection.Open();
                    int Result = cmd.ExecuteNonQuery();
                    C.Con.Close();
                    return Result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
