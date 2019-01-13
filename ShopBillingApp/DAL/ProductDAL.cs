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
    class ProductDAL
    {
        DB C = new DB();

        public int InsertProduct(ProductBAL B)
        {
            try
            {
                DataTable dt = CheckProductByName(B.Product_Name);
                int Res=0;
                foreach (DataRow dr in dt.Rows)
                {
                    Res = Convert.ToInt32(dr[0].ToString());
                }
                if (Res == 0)
                {
                    using (C.Con)
                    {
                        MySqlCommand cmd = new MySqlCommand("AddProduct", C.Con)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmd.Parameters.Add(new MySqlParameter("P_Name", B.Product_Name));
                        cmd.Parameters.Add(new MySqlParameter("Brand_ID", B.Brand_ID));
                        cmd.Parameters.Add(new MySqlParameter("B_Rate", B.Selling_Rate));
                        cmd.Parameters.Add(new MySqlParameter("S_Rate", B.Product_Cost));
                        cmd.Parameters.Add(new MySqlParameter("Description", B.Description));
                        cmd.Connection.Open();
                        int Result = cmd.ExecuteNonQuery();
                        C.Con.Close();
                        return Result;
                    }
                }
                else
                {
                    MessageBox.Show("Entered Product "+ B.Product_Name + " Exist Already! Please Use a Unique Name for Each Product");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public DataTable CheckProductByName(string PName)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("CheckExistingProductByName", C.Con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new MySqlParameter("P_Name", PName));
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

        public DataTable LoadDGVProducts()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("LoadDGVProducts", C.Con)
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

        public DataTable LoadProductID(string PName)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("GetProductID", C.Con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new MySqlParameter("Pro_Name", PName));
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

        public int UpdateProduct(ProductBAL B)
        {
            try
            {
                using (C.Con)
                {
                    MySqlCommand cmd = new MySqlCommand("UpdateProduct", C.Con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("P_ID", B.Product_ID));
                    cmd.Parameters.Add(new MySqlParameter("P_Name", B.Product_Name));
                    cmd.Parameters.Add(new MySqlParameter("B_ID", B.Brand_ID));
                    cmd.Parameters.Add(new MySqlParameter("B_Rate", B.Product_Cost));
                    cmd.Parameters.Add(new MySqlParameter("S_Rate", B.Selling_Rate));
                    cmd.Parameters.Add(new MySqlParameter("Description", B.Description));
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
