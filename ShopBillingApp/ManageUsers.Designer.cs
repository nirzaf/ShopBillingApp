namespace ShopBillingApp
{
    partial class ManageUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers));
            this.DGVUsers = new System.Windows.Forms.DataGridView();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.PBoxUpdate = new System.Windows.Forms.PictureBox();
            this.TabUpdate = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LblMessage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVUserTable = new System.Windows.Forms.DataGridView();
            this.TxtConfirmPWord = new System.Windows.Forms.TextBox();
            this.TxtUName = new System.Windows.Forms.TextBox();
            this.TxtPWord = new System.Windows.Forms.TextBox();
            this.PBoxAddUsers = new System.Windows.Forms.PictureBox();
            this.Message = new System.Windows.Forms.Timer(this.components);
            this.PanelUnlock = new System.Windows.Forms.Panel();
            this.TxtUseName = new System.Windows.Forms.TextBox();
            this.TxtPasWord = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TUnlock = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxUpdate)).BeginInit();
            this.TabUpdate.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUserTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxAddUsers)).BeginInit();
            this.PanelUnlock.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVUsers
            // 
            this.DGVUsers.AllowUserToAddRows = false;
            this.DGVUsers.AllowUserToDeleteRows = false;
            this.DGVUsers.BackgroundColor = System.Drawing.Color.White;
            this.DGVUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsers.GridColor = System.Drawing.Color.White;
            this.DGVUsers.Location = new System.Drawing.Point(10, 15);
            this.DGVUsers.Name = "DGVUsers";
            this.DGVUsers.ReadOnly = true;
            this.DGVUsers.Size = new System.Drawing.Size(380, 302);
            this.DGVUsers.TabIndex = 0;
            this.DGVUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUsers_CellClick);
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(396, 15);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(214, 26);
            this.TxtUsername.TabIndex = 1;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(396, 47);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(214, 26);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            // 
            // PBoxUpdate
            // 
            this.PBoxUpdate.Image = ((System.Drawing.Image)(resources.GetObject("PBoxUpdate.Image")));
            this.PBoxUpdate.Location = new System.Drawing.Point(455, 90);
            this.PBoxUpdate.Name = "PBoxUpdate";
            this.PBoxUpdate.Size = new System.Drawing.Size(73, 68);
            this.PBoxUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxUpdate.TabIndex = 3;
            this.PBoxUpdate.TabStop = false;
            this.PBoxUpdate.Click += new System.EventHandler(this.PBoxUpdate_Click);
            // 
            // TabUpdate
            // 
            this.TabUpdate.Controls.Add(this.tabPage1);
            this.TabUpdate.Controls.Add(this.tabPage2);
            this.TabUpdate.Location = new System.Drawing.Point(12, 13);
            this.TabUpdate.Name = "TabUpdate";
            this.TabUpdate.SelectedIndex = 0;
            this.TabUpdate.Size = new System.Drawing.Size(624, 385);
            this.TabUpdate.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVUsers);
            this.tabPage1.Controls.Add(this.TxtUsername);
            this.tabPage1.Controls.Add(this.TxtPassword);
            this.tabPage1.Controls.Add(this.PBoxUpdate);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(616, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Change Paswword";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LblMessage);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.DGVUserTable);
            this.tabPage2.Controls.Add(this.TxtConfirmPWord);
            this.tabPage2.Controls.Add(this.TxtUName);
            this.tabPage2.Controls.Add(this.TxtPWord);
            this.tabPage2.Controls.Add(this.PBoxAddUsers);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(616, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create New User";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.ForeColor = System.Drawing.Color.Red;
            this.LblMessage.Location = new System.Drawing.Point(17, 306);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(0, 24);
            this.LblMessage.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Confirm Passwrord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Passwrord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usename";
            // 
            // DGVUserTable
            // 
            this.DGVUserTable.AllowUserToAddRows = false;
            this.DGVUserTable.AllowUserToDeleteRows = false;
            this.DGVUserTable.BackgroundColor = System.Drawing.Color.White;
            this.DGVUserTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVUserTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DGVUserTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUserTable.GridColor = System.Drawing.Color.White;
            this.DGVUserTable.Location = new System.Drawing.Point(237, 19);
            this.DGVUserTable.Name = "DGVUserTable";
            this.DGVUserTable.ReadOnly = true;
            this.DGVUserTable.Size = new System.Drawing.Size(373, 302);
            this.DGVUserTable.TabIndex = 8;
            // 
            // TxtConfirmPWord
            // 
            this.TxtConfirmPWord.Location = new System.Drawing.Point(17, 178);
            this.TxtConfirmPWord.Name = "TxtConfirmPWord";
            this.TxtConfirmPWord.PasswordChar = '*';
            this.TxtConfirmPWord.Size = new System.Drawing.Size(214, 26);
            this.TxtConfirmPWord.TabIndex = 7;
            this.TxtConfirmPWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtConfirmPWord_KeyPress);
            this.TxtConfirmPWord.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtConfirmPWord_KeyUp);
            // 
            // TxtUName
            // 
            this.TxtUName.Location = new System.Drawing.Point(17, 52);
            this.TxtUName.Name = "TxtUName";
            this.TxtUName.Size = new System.Drawing.Size(214, 26);
            this.TxtUName.TabIndex = 4;
            this.TxtUName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUName_KeyPress);
            this.TxtUName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtUName_KeyUp);
            // 
            // TxtPWord
            // 
            this.TxtPWord.Location = new System.Drawing.Point(17, 112);
            this.TxtPWord.Name = "TxtPWord";
            this.TxtPWord.PasswordChar = '*';
            this.TxtPWord.Size = new System.Drawing.Size(214, 26);
            this.TxtPWord.TabIndex = 5;
            // 
            // PBoxAddUsers
            // 
            this.PBoxAddUsers.Image = global::ShopBillingApp.Properties.Resources.add_icon;
            this.PBoxAddUsers.Location = new System.Drawing.Point(80, 225);
            this.PBoxAddUsers.Name = "PBoxAddUsers";
            this.PBoxAddUsers.Size = new System.Drawing.Size(73, 68);
            this.PBoxAddUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxAddUsers.TabIndex = 6;
            this.PBoxAddUsers.TabStop = false;
            this.PBoxAddUsers.Click += new System.EventHandler(this.PBoxAddUsers_Click);
            // 
            // Message
            // 
            this.Message.Enabled = true;
            this.Message.Interval = 10000;
            this.Message.Tick += new System.EventHandler(this.Message_Tick);
            // 
            // PanelUnlock
            // 
            this.PanelUnlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PanelUnlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelUnlock.Controls.Add(this.label5);
            this.PanelUnlock.Controls.Add(this.label4);
            this.PanelUnlock.Controls.Add(this.BtnLogin);
            this.PanelUnlock.Controls.Add(this.TxtPasWord);
            this.PanelUnlock.Controls.Add(this.TxtUseName);
            this.PanelUnlock.Location = new System.Drawing.Point(-9, -8);
            this.PanelUnlock.Name = "PanelUnlock";
            this.PanelUnlock.Size = new System.Drawing.Size(657, 426);
            this.PanelUnlock.TabIndex = 5;
            // 
            // TxtUseName
            // 
            this.TxtUseName.Location = new System.Drawing.Point(207, 48);
            this.TxtUseName.Name = "TxtUseName";
            this.TxtUseName.Size = new System.Drawing.Size(183, 26);
            this.TxtUseName.TabIndex = 0;
            // 
            // TxtPasWord
            // 
            this.TxtPasWord.Location = new System.Drawing.Point(207, 99);
            this.TxtPasWord.Name = "TxtPasWord";
            this.TxtPasWord.Size = new System.Drawing.Size(183, 26);
            this.TxtPasWord.TabIndex = 1;
            this.TxtPasWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPasWord_KeyPress);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackgroundImage = global::ShopBillingApp.Properties.Resources.secrecy_icon;
            this.BtnLogin.Location = new System.Drawing.Point(170, 131);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(256, 248);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TUnlock
            // 
            this.TUnlock.Interval = 1;
            this.TUnlock.Tick += new System.EventHandler(this.TUnlock_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 410);
            this.Controls.Add(this.PanelUnlock);
            this.Controls.Add(this.TabUpdate);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxUpdate)).EndInit();
            this.TabUpdate.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUserTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxAddUsers)).EndInit();
            this.PanelUnlock.ResumeLayout(false);
            this.PanelUnlock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVUsers;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.PictureBox PBoxUpdate;
        private System.Windows.Forms.TabControl TabUpdate;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TxtConfirmPWord;
        private System.Windows.Forms.TextBox TxtUName;
        private System.Windows.Forms.TextBox TxtPWord;
        private System.Windows.Forms.PictureBox PBoxAddUsers;
        private System.Windows.Forms.DataGridView DGVUserTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.Timer Message;
        private System.Windows.Forms.Panel PanelUnlock;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtPasWord;
        private System.Windows.Forms.TextBox TxtUseName;
        private System.Windows.Forms.Timer TUnlock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}