using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopBillingApp.DAL
{
    public class DB
    {
        public MySqlConnection Con;
        public DB()
        {
            try
            {
                string ConnectionString = "server=localhost; User Id = root; pwd =; database=shop;";
                Con = new MySqlConnection(ConnectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
