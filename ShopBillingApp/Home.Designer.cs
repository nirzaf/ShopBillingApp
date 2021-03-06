﻿namespace ShopBillingApp
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBrand = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuManageUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStocks = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMinimumStock = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTransactions = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSalesReport = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGVMinimumStock = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMinimumStock)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.BackgroundImage = global::ShopBillingApp.Properties.Resources.download1;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMaster,
            this.SettingsToolStripMenuItem,
            this.ProductsToolStripMenuItem1,
            this.MenuTransactions,
            this.ReportsToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuMaster
            // 
            this.MenuMaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBrand,
            this.MenuCategory,
            this.MenuProducts,
            this.MenuCustomers});
            this.MenuMaster.Name = "MenuMaster";
            this.MenuMaster.Size = new System.Drawing.Size(81, 26);
            this.MenuMaster.Text = "Master";
            // 
            // MenuBrand
            // 
            this.MenuBrand.Name = "MenuBrand";
            this.MenuBrand.Size = new System.Drawing.Size(168, 26);
            this.MenuBrand.Text = "Brand";
            this.MenuBrand.Click += new System.EventHandler(this.MenuBrand_Click);
            // 
            // MenuCategory
            // 
            this.MenuCategory.Name = "MenuCategory";
            this.MenuCategory.Size = new System.Drawing.Size(168, 26);
            this.MenuCategory.Text = "Category";
            this.MenuCategory.Click += new System.EventHandler(this.MenuCategory_Click);
            // 
            // MenuProducts
            // 
            this.MenuProducts.Name = "MenuProducts";
            this.MenuProducts.Size = new System.Drawing.Size(168, 26);
            this.MenuProducts.Text = "Products";
            this.MenuProducts.Click += new System.EventHandler(this.MenuProducts_Click);
            // 
            // MenuCustomers
            // 
            this.MenuCustomers.Name = "MenuCustomers";
            this.MenuCustomers.Size = new System.Drawing.Size(168, 26);
            this.MenuCustomers.Text = "Customers";
            this.MenuCustomers.Click += new System.EventHandler(this.MenuCustomers_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuManageUsers});
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.SettingsToolStripMenuItem.Text = "Settings";
            // 
            // MenuManageUsers
            // 
            this.MenuManageUsers.Name = "MenuManageUsers";
            this.MenuManageUsers.Size = new System.Drawing.Size(198, 26);
            this.MenuManageUsers.Text = "Manage Users";
            this.MenuManageUsers.Click += new System.EventHandler(this.MenuManageUsers_Click);
            // 
            // ProductsToolStripMenuItem1
            // 
            this.ProductsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStocks,
            this.MenuMinimumStock});
            this.ProductsToolStripMenuItem1.Name = "ProductsToolStripMenuItem1";
            this.ProductsToolStripMenuItem1.Size = new System.Drawing.Size(95, 26);
            this.ProductsToolStripMenuItem1.Text = "Products";
            this.ProductsToolStripMenuItem1.Click += new System.EventHandler(this.ProductsToolStripMenuItem1_Click);
            // 
            // MenuStocks
            // 
            this.MenuStocks.Name = "MenuStocks";
            this.MenuStocks.Size = new System.Drawing.Size(218, 26);
            this.MenuStocks.Text = "Stocks";
            this.MenuStocks.Click += new System.EventHandler(this.MenuStocks_Click);
            // 
            // MenuMinimumStock
            // 
            this.MenuMinimumStock.Name = "MenuMinimumStock";
            this.MenuMinimumStock.Size = new System.Drawing.Size(218, 26);
            this.MenuMinimumStock.Text = "Minimum Stocks";
            this.MenuMinimumStock.Click += new System.EventHandler(this.MenuMinimumStock_Click);
            // 
            // MenuTransactions
            // 
            this.MenuTransactions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemInvoice});
            this.MenuTransactions.Name = "MenuTransactions";
            this.MenuTransactions.Size = new System.Drawing.Size(128, 26);
            this.MenuTransactions.Text = "Transactions";
            // 
            // MenuItemInvoice
            // 
            this.MenuItemInvoice.Name = "MenuItemInvoice";
            this.MenuItemInvoice.Size = new System.Drawing.Size(139, 26);
            this.MenuItemInvoice.Text = "Invoice";
            this.MenuItemInvoice.Click += new System.EventHandler(this.MenuItemInvoice_Click);
            // 
            // ReportsToolStripMenuItem
            // 
            this.ReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSalesReport});
            this.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem";
            this.ReportsToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.ReportsToolStripMenuItem.Text = "Reports";
            // 
            // MenuSalesReport
            // 
            this.MenuSalesReport.Name = "MenuSalesReport";
            this.MenuSalesReport.Size = new System.Drawing.Size(185, 26);
            this.MenuSalesReport.Text = "Sales Report";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // DGVMinimumStock
            // 
            this.DGVMinimumStock.AllowUserToAddRows = false;
            this.DGVMinimumStock.AllowUserToDeleteRows = false;
            this.DGVMinimumStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMinimumStock.BackgroundColor = System.Drawing.Color.White;
            this.DGVMinimumStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVMinimumStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMinimumStock.Location = new System.Drawing.Point(0, 50);
            this.DGVMinimumStock.Name = "DGVMinimumStock";
            this.DGVMinimumStock.ReadOnly = true;
            this.DGVMinimumStock.Size = new System.Drawing.Size(228, 67);
            this.DGVMinimumStock.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minimum Stock Notification";
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ShopBillingApp.Properties.Resources.download1;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DGVMinimumStock);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMinimumStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuMaster;
        private System.Windows.Forms.ToolStripMenuItem MenuBrand;
        private System.Windows.Forms.ToolStripMenuItem MenuCategory;
        private System.Windows.Forms.ToolStripMenuItem MenuProducts;
        private System.Windows.Forms.ToolStripMenuItem MenuCustomers;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuManageUsers;
        private System.Windows.Forms.ToolStripMenuItem ProductsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuStocks;
        private System.Windows.Forms.ToolStripMenuItem MenuMinimumStock;
        private System.Windows.Forms.ToolStripMenuItem ReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuSalesReport;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.DataGridView DGVMinimumStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem MenuTransactions;
        private System.Windows.Forms.ToolStripMenuItem MenuItemInvoice;
    }
}