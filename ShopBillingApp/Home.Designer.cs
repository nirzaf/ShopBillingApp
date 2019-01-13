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
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBrand = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.StocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimumStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.ProductsToolStripMenuItem1,
            this.ReportsToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBrand,
            this.MenuCategory,
            this.MenuProducts,
            this.MenuCustomers});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.masterToolStripMenuItem.Text = "Master";
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
            this.ChangePasswordToolStripMenuItem});
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.SettingsToolStripMenuItem.Text = "Settings";
            // 
            // ChangePasswordToolStripMenuItem
            // 
            this.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem";
            this.ChangePasswordToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.ChangePasswordToolStripMenuItem.Text = "Manage Users";
            this.ChangePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem_Click_1);
            // 
            // ProductsToolStripMenuItem1
            // 
            this.ProductsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StocksToolStripMenuItem,
            this.minimumStocksToolStripMenuItem});
            this.ProductsToolStripMenuItem1.Name = "ProductsToolStripMenuItem1";
            this.ProductsToolStripMenuItem1.Size = new System.Drawing.Size(95, 26);
            this.ProductsToolStripMenuItem1.Text = "Products";
            // 
            // StocksToolStripMenuItem
            // 
            this.StocksToolStripMenuItem.Name = "StocksToolStripMenuItem";
            this.StocksToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.StocksToolStripMenuItem.Text = "Stocks";
            this.StocksToolStripMenuItem.Click += new System.EventHandler(this.StocksToolStripMenuItem_Click);
            // 
            // minimumStocksToolStripMenuItem
            // 
            this.minimumStocksToolStripMenuItem.Name = "minimumStocksToolStripMenuItem";
            this.minimumStocksToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.minimumStocksToolStripMenuItem.Text = "Minimum Stocks";
            // 
            // ReportsToolStripMenuItem
            // 
            this.ReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesReportToolStripMenuItem});
            this.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem";
            this.ReportsToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.ReportsToolStripMenuItem.Text = "Reports";
            // 
            // salesReportToolStripMenuItem
            // 
            this.salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
            this.salesReportToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.salesReportToolStripMenuItem.Text = "Sales Report";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ShopBillingApp.Properties.Resources.download1;
            this.ClientSize = new System.Drawing.Size(864, 482);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuBrand;
        private System.Windows.Forms.ToolStripMenuItem MenuCategory;
        private System.Windows.Forms.ToolStripMenuItem MenuProducts;
        private System.Windows.Forms.ToolStripMenuItem MenuCustomers;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem StocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimumStocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}