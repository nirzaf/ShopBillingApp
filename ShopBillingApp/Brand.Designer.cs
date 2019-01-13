namespace ShopBillingApp
{
    partial class Brand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Brand));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnUpdate = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.CMBCategory = new System.Windows.Forms.ComboBox();
            this.BtnReset = new System.Windows.Forms.PictureBox();
            this.BtnAddBrand = new System.Windows.Forms.PictureBox();
            this.TxtBrandName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVBrand = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox1.Controls.Add(this.BtnUpdate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Label);
            this.groupBox1.Controls.Add(this.CMBCategory);
            this.groupBox1.Controls.Add(this.BtnReset);
            this.groupBox1.Controls.Add(this.BtnAddBrand);
            this.groupBox1.Controls.Add(this.TxtBrandName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 147);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Brand";
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
            this.BtnUpdate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnUpdate_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Category";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(53, 74);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(20, 22);
            this.Label.TabIndex = 4;
            this.Label.Text = "0";
            this.Label.Visible = false;
            // 
            // CMBCategory
            // 
            this.CMBCategory.FormattingEnabled = true;
            this.CMBCategory.Location = new System.Drawing.Point(139, 74);
            this.CMBCategory.Name = "CMBCategory";
            this.CMBCategory.Size = new System.Drawing.Size(257, 30);
            this.CMBCategory.TabIndex = 8;
            this.CMBCategory.SelectedIndexChanged += new System.EventHandler(this.CMBCategory_SelectedIndexChanged);
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
            this.BtnReset.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnReset_MouseMove);
            // 
            // BtnAddBrand
            // 
            this.BtnAddBrand.Image = global::ShopBillingApp.Properties.Resources.add_icon;
            this.BtnAddBrand.Location = new System.Drawing.Point(402, 32);
            this.BtnAddBrand.Name = "BtnAddBrand";
            this.BtnAddBrand.Size = new System.Drawing.Size(48, 48);
            this.BtnAddBrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnAddBrand.TabIndex = 5;
            this.BtnAddBrand.TabStop = false;
            this.BtnAddBrand.Click += new System.EventHandler(this.BtnAddBrand_Click);
            this.BtnAddBrand.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnAddBrand_MouseMove);
            // 
            // TxtBrandName
            // 
            this.TxtBrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBrandName.Location = new System.Drawing.Point(139, 32);
            this.TxtBrandName.Name = "TxtBrandName";
            this.TxtBrandName.Size = new System.Drawing.Size(257, 26);
            this.TxtBrandName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand Name";
            // 
            // DGVBrand
            // 
            this.DGVBrand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBrand.BackgroundColor = System.Drawing.Color.White;
            this.DGVBrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBrand.Location = new System.Drawing.Point(25, 194);
            this.DGVBrand.Name = "DGVBrand";
            this.DGVBrand.Size = new System.Drawing.Size(593, 260);
            this.DGVBrand.TabIndex = 4;
            this.DGVBrand.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVBrand_CellClick);
            this.DGVBrand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVBrand_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 301);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brand Details";
            // 
            // Brand
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 466);
            this.Controls.Add(this.DGVBrand);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Brand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brand";
            this.Load += new System.EventHandler(this.Brand_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBrand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox BtnAddBrand;
        private System.Windows.Forms.TextBox TxtBrandName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox BtnReset;
        private System.Windows.Forms.ComboBox CMBCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.DataGridView DGVBrand;
        private System.Windows.Forms.PictureBox BtnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}