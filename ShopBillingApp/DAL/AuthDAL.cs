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
    class AuthDAL
    {
        DB Con = new DB();
        public bool CheckAuth(AuthBAL A)
        {
            try
            {
                string Query = "Select * From users Where Name = '"+A.Username+"' AND Pass = '"+A.Password+"'";
                MySqlDataAdapter Sda = new MySqlDataAdapter(Query,Con.Con);
                DataTable dt = new DataTable();
                Sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Auth(AuthBAL A)
        {
            bool result;
            try
            {
                MySqlParameter[] Pms = new MySqlParameter[2];
                Pms[0] = new MySqlParameter("UName", MySqlDbType.VarChar)
                {
                    Value = A.Username
                };
                Pms[1] = new MySqlParameter("Pword", MySqlDbType.VarChar)
                {
                    Value = A.Password
                };
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Con.Con,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "Check_Auth"
                };
                cmd.Parameters.AddRange(Pms);
                Con.Con.Open();
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
                Con.Con.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
