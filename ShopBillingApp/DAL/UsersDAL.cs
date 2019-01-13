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
    class UsersDAL
    {
        DB C = new DB();
        public DataTable GetAllUsers()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("LoadDGVUsers", C.Con)
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

        public int UpdateUsers(UsersBAL ub)
        {
            try
            {
                using (C.Con)
                {
                    MySqlCommand cmd = new MySqlCommand("UpdateUsers", C.Con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("U_ID", ub.UserID));
                    cmd.Parameters.Add(new MySqlParameter("UName", ub.Username));
                    cmd.Parameters.Add(new MySqlParameter("PWord", ub.Password));
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

        public int UserNameValidation(string UName)
        {
            try
            {
                using (C.Con)
                {
                    MySqlCommand cmd = new MySqlCommand("UserNameValidation", C.Con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("Username",UName));
                    cmd.Connection.Open();
                    int Result = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    C.Con.Close();
                    return Result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int AddUsers(UsersBAL ub)
        {
            try
            {
                using (C.Con)
                {
                    MySqlCommand cmd = new MySqlCommand("AddUsers", C.Con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("Username", ub.Username));
                    cmd.Parameters.Add(new MySqlParameter("Password", ub.Password));
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
