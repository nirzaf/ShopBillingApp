using ShopBillingApp.BAL;
using ShopBillingApp.DAL;
using System;
using System.Windows.Forms;

namespace ShopBillingApp
{
    public partial class ManageUsers : Form
    {
        UsersDAL ud = new UsersDAL();
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            LoadDGVUsers();
        }

        public void LoadDGVUsers()
        {
            UsersDAL ud = new UsersDAL();
            DGVUsers.DataSource = ud.GetAllUsers();
            DGVUserTable.DataSource = ud.GetAllUsers();
        }

        private void DGUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVUsers.SelectedRows.Count > 0)
            {
                TxtUsername.Text = DGVUsers.SelectedRows[0].Cells[1].Value + string.Empty;
                TxtPassword.Text = DGVUsers.SelectedRows[0].Cells[2].Value + string.Empty;
            }
        }

        private void PBoxUpdate_Click(object sender, EventArgs e)
        {
            UsersBAL ub = new UsersBAL();
            UsersDAL ud = new UsersDAL();
            if (DGVUsers.SelectedRows.Count > 0)
            {
                ub.UserID = Convert.ToInt32(DGVUsers.SelectedRows[0].Cells[0].Value + string.Empty);
                ub.Username = TxtUsername.Text.Trim();
                ub.Password = TxtPassword.Text.Trim();
                int Result = ud.UpdateUsers(ub);
                if (Result == 1)
                {
                    MessageBox.Show("Updated Successfully");
                    LoadDGVUsers();
                }
                else
                {
                    MessageBox.Show("Oops Something went wrong");
                }
            }
        }

        private void TxtUName_KeyPress(object sender, KeyPressEventArgs e)
        {
            UsersDAL ud = new UsersDAL();
            string UName = TxtUName.Text.Trim();
            int Result = ud.UserNameValidation(UName);
            if (Result > 0)
            {
                LblMessage.Text = "Warning! This Username is Not Available";
            }
            else
            {
                LblMessage.Text = "Username Available";
            }
        }

        private void Message_Tick(object sender, EventArgs e)
        {
            LblMessage.Text = "";
        }

        private void TxtUName_KeyUp(object sender, KeyEventArgs e)
        {
            UsersDAL ud = new UsersDAL();
            string UName = TxtUName.Text.Trim();
            int Result = ud.UserNameValidation(UName);
            if (Result == 1)
            {
                LblMessage.Text = "Warning! This Username is Not Available";
            }
            else
            {
                LblMessage.Text = "Username Available";
            }
        }

        private void PBoxAddUsers_Click(object sender, EventArgs e)
        {
            UsersDAL ud = new UsersDAL();
            UsersBAL ub = new UsersBAL();
            string UName = TxtUName.Text.Trim();
            int Result = ud.UserNameValidation(UName);

            if (TxtUName.Text.Trim() != "")
            {
                if (Result == 1)
                {
                    LblMessage.Text = "Warning! This Username is Not Available";
                }
                else
                {
                    if (TxtPWord.Text.Trim() != "")
                    {
                        if (TxtPWord.Text.Trim() == TxtConfirmPWord.Text.Trim())
                        {
                            ub.Username = TxtUName.Text.Trim();
                            ub.Password = TxtPWord.Text.Trim();
                            int Re = ud.AddUsers(ub);
                            if (Re > 0)
                            {
                                MessageBox.Show("User Added Successfully");
                                LoadDGVUsers();
                            }
                            else
                            {
                                MessageBox.Show("Something went wrong");
                                LoadDGVUsers();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Both Password Should be Same");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password cannot be blank");
                    }
                }
            }
            else
            {
                MessageBox.Show("Username cannot be blank");
            }
        }

        private void TxtConfirmPWord_KeyUp(object sender, KeyEventArgs e)
        {
            if (TxtPWord.Text.Trim() != TxtConfirmPWord.Text.Trim())
            {
                LblMessage.Text = "Passwords Not Matching Yet";
            }
            else
            {
                LblMessage.Text = "XXX:::  Passwords are Matching :::XXX";
            }
        }

        private void TxtConfirmPWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                UsersDAL ud = new UsersDAL();
                UsersBAL ub = new UsersBAL();
                string UName = TxtUName.Text.Trim();
                int Result = ud.UserNameValidation(UName);

                if (TxtUName.Text.Trim() != "")
                {
                    if (Result == 1)
                    {
                        LblMessage.Text = "Warning! This Username is Not Available";
                    }
                    else
                    {
                        if (TxtPWord.Text.Trim() != "")
                        {
                            if (TxtPWord.Text.Trim() == TxtConfirmPWord.Text.Trim())
                            {
                                ub.Username = TxtUName.Text.Trim();
                                ub.Password = TxtPWord.Text.Trim();
                                int Re = ud.AddUsers(ub);
                                if (Re > 0)
                                {
                                    MessageBox.Show("User Added Successfully");
                                    LoadDGVUsers();
                                }
                                else
                                {
                                    MessageBox.Show("Something went wrong");
                                    LoadDGVUsers();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Both Password Should be Same");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password cannot be blank");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Username cannot be blank");
                }
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                UsersBAL ub = new UsersBAL();
                UsersDAL ud = new UsersDAL();
                if (DGVUsers.SelectedRows.Count > 0)
                {
                    ub.UserID = Convert.ToInt32(DGVUsers.SelectedRows[0].Cells[0].Value + string.Empty);
                    ub.Username = TxtUsername.Text.Trim();
                    ub.Password = TxtPassword.Text.Trim();
                    int Result = ud.UpdateUsers(ub);
                    if (Result == 1)
                    {
                        MessageBox.Show("Updated Successfully");
                        LoadDGVUsers();
                    }
                    else
                    {
                        MessageBox.Show("Oops Something went wrong");
                    }
                }
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            AuthBAL Auth = new AuthBAL();
            AuthDAL Ad = new AuthDAL();
            if (TxtUseName.Text.Trim() != "" && TxtPasWord.Text.Trim() != "")
            {
                Auth.Username = TxtUseName.Text.Trim();
                Auth.Password = TxtPasWord.Text.Trim();
                bool result = Ad.Auth(Auth);
                if (result == true)
                {
                    TUnlock.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Invalid Username and Password");
                }
            }
            else if (TxtUseName.Text.Trim() == "")
            {
                MessageBox.Show("Username Cannot be Empty");
                TxtUsername.Focus();
            }
            else if (TxtPasWord.Text.Trim() == "")
            {
                MessageBox.Show("Password Cannot be Empty");
                TxtPassword.Focus();
            }
            else
            {
                MessageBox.Show("Username and Password cannot be empty");
            }
        }

        private void TUnlock_Tick(object sender, EventArgs e)
        {
            if (PanelUnlock.Height >= 0)
            {
                if (PanelUnlock.Width >= 0)
                {
                    PanelUnlock.Height -= 15;
                    PanelUnlock.Width -= 15;
                }
            }
        }

        private void TxtPasWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AuthBAL Auth = new AuthBAL();
                AuthDAL Ad = new AuthDAL();
                if (TxtUseName.Text.Trim() != "" && TxtPasWord.Text.Trim() != "")
                {
                    Auth.Username = TxtUseName.Text.Trim();
                    Auth.Password = TxtPasWord.Text.Trim();
                    bool result = Ad.Auth(Auth);
                    if (result == true)
                    {
                        TUnlock.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username and Password");
                    }
                }
                else if (TxtUseName.Text.Trim() == "")
                {
                    MessageBox.Show("Username Cannot be Empty");
                    TxtUsername.Focus();
                }
                else if (TxtPasWord.Text.Trim() == "")
                {
                    MessageBox.Show("Password Cannot be Empty");
                    TxtPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Username and Password cannot be empty");
                }
            }
        }
    }
}
