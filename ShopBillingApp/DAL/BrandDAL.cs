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
    class BrandDAL
    {
        DB C = new DB();

        public int InsertBrand(BrandBAL B)
        {
            try
            {
                using (C.Con)
                {
                    MySqlCommand cmd = new MySqlCommand("AddBrand", C.Con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("BName", B.BrandName));
                    cmd.Parameters.Add(new MySqlParameter("CID", B.Category));
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

        public DataTable LoadDGV()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("GetBrands", C.Con)
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

        public DataSet LoadCMBBrand()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("GetBrands", C.Con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                MySqlDataAdapter Sda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                Sda.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public DataTable LoadValueMemberOfBrandComboBox(string CmbBName)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("LoadValueMemberOfBrandComboBox", C.Con);
                cmd.Parameters.Add(new MySqlParameter("@B_Name", CmbBName));
                cmd.CommandType = CommandType.StoredProcedure;
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

        public int UpdateBrand(BrandBAL B)
        {
            try
            {
                using (C.Con)
                {
                    MySqlCommand cmd = new MySqlCommand("UpdateBrand", C.Con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("BrandID", B.BrandID));
                    cmd.Parameters.Add(new MySqlParameter("BName", B.BrandName));
                    cmd.Parameters.Add(new MySqlParameter("CatID", B.Category));
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
