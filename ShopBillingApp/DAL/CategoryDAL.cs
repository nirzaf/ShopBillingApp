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
    class CategoryDAL
    {
        DB C = new DB();
        public DataSet GetAllCategory()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("LoadCategory", C.Con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                MySqlDataAdapter Sda = new MySqlDataAdapter(cmd);
                DataSet dt = new DataSet();
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
                MySqlCommand cmd = new MySqlCommand("LoadDGVCategory", C.Con)
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

        public DataTable LoadValueMember(string CmbCatText)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("LoadValueMember", C.Con);
                cmd.Parameters.Add(new MySqlParameter("@Cat_Name",CmbCatText));
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

        public int InsertCategory(CategoryBAL B)
        {
            try
            {
                using (C.Con)
                {
                    MySqlCommand cmd = new MySqlCommand("AddCategory", C.Con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("Category", B.CategoryName));
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

        public int UpdateCategory(CategoryBAL CB)
        {
            try
            {
                using (C.Con)
                {
                    MySqlCommand cmd = new MySqlCommand("UpdateCategory", C.Con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("Cat_ID",CB.CatID));
                    cmd.Parameters.Add(new MySqlParameter("Cat_Name", CB.CategoryName));
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
