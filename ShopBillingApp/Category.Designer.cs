namespace ShopBillingApp.DAL
{
    partial class Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnUpdate = new System.Windows.Forms.PictureBox();
            this.BtnReset = new System.Windows.Forms.PictureBox();
            this.BtnAddCategory = new System.Windows.Forms.PictureBox();
            this.TxtCategoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGVCategory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFilterByCatName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddCategory)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox1.Controls.Add(this.BtnUpdate);
            this.groupBox1.Controls.Add(this.BtnReset);
            this.groupBox1.Controls.Add(this.BtnAddCategory);
            this.groupBox1.Controls.Add(this.TxtCategoryName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 103);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Category";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Image = global::ShopBillingApp.Properties.Resources.Apps_system_software_update_icon;
            this.BtnUpdate.Location = new System.Drawing.Point(510, 32);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(48, 48);
            this.BtnUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnUpdate.TabIndex = 9;
            this.BtnUpdate.TabStop = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Image = global::ShopBillingApp.Properties.Resources.Clear_icon;
            this.BtnReset.Location = new System.Drawing.Point(456, 32);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(48, 48);
            this.BtnReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnReset.TabIndex = 6;
            this.BtnReset.TabStop = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnAddCategory
            // 
            this.BtnAddCategory.Image = global::ShopBillingApp.Properties.Resources.add_icon;
            this.BtnAddCategory.Location = new System.Drawing.Point(402, 32);
            this.BtnAddCategory.Name = "BtnAddCategory";
            this.BtnAddCategory.Size = new System.Drawing.Size(48, 48);
            this.BtnAddCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnAddCategory.TabIndex = 5;
            this.BtnAddCategory.TabStop = false;
            this.BtnAddCategory.Click += new System.EventHandler(this.BtnAddCategory_Click);
            // 
            // TxtCategoryName
            // 
            this.TxtCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCategoryName.Location = new System.Drawing.Point(146, 32);
            this.TxtCategoryName.Name = "TxtCategoryName";
            this.TxtCategoryName.Size = new System.Drawing.Size(250, 26);
            this.TxtCategoryName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGVCategory);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 284);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Category Details";
            // 
            // DGVCategory
            // 
            this.DGVCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCategory.BackgroundColor = System.Drawing.Color.White;
            this.DGVCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCategory.Location = new System.Drawing.Point(6, 28);
            this.DGVCategory.Name = "DGVCategory";
            this.DGVCategory.Size = new System.Drawing.Size(593, 238);
            this.DGVCategory.TabIndex = 5;
            this.DGVCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCategory_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filter By Category Name";
            // 
            // TxtFilterByCatName
            // 
            this.TxtFilterByCatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFilterByCatName.Location = new System.Drawing.Point(252, 130);
            this.TxtFilterByCatName.Name = "TxtFilterByCatName";
            this.TxtFilterByCatName.Size = new System.Drawing.Size(250, 26);
            this.TxtFilterByCatName.TabIndex = 10;
            this.TxtFilterByCatName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtFilterByCatName_KeyUp);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 466);
            this.Controls.Add(this.TxtFilterByCatName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddCategory)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox BtnUpdate;
        private System.Windows.Forms.PictureBox BtnReset;
        private System.Windows.Forms.PictureBox BtnAddCategory;
        private System.Windows.Forms.TextBox TxtCategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGVCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFilterByCatName;
    }
}