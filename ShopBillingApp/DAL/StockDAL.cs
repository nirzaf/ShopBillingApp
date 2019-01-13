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
    class StockDAL
    {
        DB C = new DB();

        public int InsertCategory(StockBAL S)
        {
            try
            {
                DataTable dt = CheckProductByID(S.ProductID);
                int Res = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    Res = Convert.ToInt32(dr[0].ToString());
                }
                if (Res == 0)
                {
                    using (C.Con)
                    {
                        MySqlCommand cmd = new MySqlCommand("AddStock", C.Con)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmd.Parameters.Add(new MySqlParameter("P_ID", S.ProductID));
                        cmd.Parameters.Add(new MySqlParameter("Quantity", S.Quantity));
                        cmd.Connection.Open();
                        int Result = cmd.ExecuteNonQuery();
                        C.Con.Close();
                        return Result;
                    }
                }
                else
                {
                    using (C.Con)
                    {
                        MySqlCommand cmd = new MySqlCommand("UpdateStock", C.Con)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmd.Parameters.Add(new MySqlParameter("Pro_ID", S.ProductID));
                        cmd.Parameters.Add(new MySqlParameter("Quantity", S.Quantity));
                        cmd.Connection.Open();
                        int Result = cmd.ExecuteNonQuery();
                        C.Con.Close();
                        return Result;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public DataTable CheckProductByID(int ProductID)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("CheckProductInStock", C.Con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new MySqlParameter("Pro_ID", ProductID));
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

        public DataTable LoadDGVCategory()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("LoadStockDetails", C.Con)
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

    }
}
