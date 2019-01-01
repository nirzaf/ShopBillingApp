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
    public partial class LoginForm : Form
    {
        AuthDAL Ad = new AuthDAL();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            AuthBAL Auth = new AuthBAL();
            if (TxtUsername.Text.Trim() != "" && TxtPassword.Text.Trim() != "")
            {
                Auth.Username = TxtUsername.Text.Trim();
                Auth.Password = TxtPassword.Text.Trim();
                bool result = Ad.Auth(Auth);
                if (result == true)
                {
                    Home main = new Home();
                    main.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username and Password");
                }
            }
            else if (TxtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Username Cannot be Empty");
                TxtUsername.Focus();
            }
            else if (TxtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Password Cannot be Empty");
                TxtPassword.Focus();
            }
            else
            {
                MessageBox.Show("Username and Password Invalid");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AuthBAL Auth = new AuthBAL();
                if (TxtUsername.Text.Trim() != "" && TxtPassword.Text.Trim() != "")
                {
                    Auth.Username = TxtUsername.Text.Trim();
                    Auth.Password = TxtPassword.Text.Trim();
                    bool result = Ad.Auth(Auth);
                    if (result == true)
                    {
                        Home main = new Home();
                        main.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username and Password");
                    }
                }
                else if (TxtUsername.Text.Trim() == "")
                {
                    MessageBox.Show("Username Cannot be Empty");
                    TxtUsername.Focus();
                }
                else if (TxtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Password Cannot be Empty");
                    TxtPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Username and Password Invalid");
                }
            }
        }
    }
}
