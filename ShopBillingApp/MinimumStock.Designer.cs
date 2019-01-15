namespace ShopBillingApp
{
    partial class MinimumStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinimumStock));
            this.DGVStock = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFilterByProductName = new System.Windows.Forms.TextBox();
            this.TxtMinStockQty = new System.Windows.Forms.TextBox();
            this.BtnUpdateMinStock = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVStock
            // 
            this.DGVStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVStock.BackgroundColor = System.Drawing.Color.White;
            this.DGVStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStock.Location = new System.Drawing.Point(14, 70);
            this.DGVStock.Name = "DGVStock";
            this.DGVStock.Size = new System.Drawing.Size(479, 354);
            this.DGVStock.TabIndex = 0;
            this.DGVStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStock_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtFilterByProductName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filetr By";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // TxtFilterByProductName
            // 
            this.TxtFilterByProductName.Location = new System.Drawing.Point(116, 19);
            this.TxtFilterByProductName.Name = "TxtFilterByProductName";
            this.TxtFilterByProductName.Size = new System.Drawing.Size(216, 26);
            this.TxtFilterByProductName.TabIndex = 3;
            // 
            // TxtMinStockQty
            // 
            this.TxtMinStockQty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMinStockQty.Location = new System.Drawing.Point(517, 70);
            this.TxtMinStockQty.Name = "TxtMinStockQty";
            this.TxtMinStockQty.Size = new System.Drawing.Size(146, 26);
            this.TxtMinStockQty.TabIndex = 4;
            this.TxtMinStockQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMinStockQty_KeyPress);
            // 
            // BtnUpdateMinStock
            // 
            this.BtnUpdateMinStock.BackColor = System.Drawing.Color.White;
            this.BtnUpdateMinStock.BorderColor = System.Drawing.Color.Transparent;
            this.BtnUpdateMinStock.ButtonColor = System.Drawing.Color.Black;
            this.BtnUpdateMinStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateMinStock.Font = new System.Drawing.Font("Beast Machines", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateMinStock.Location = new System.Drawing.Point(517, 102);
            this.BtnUpdateMinStock.Name = "BtnUpdateMinStock";
            this.BtnUpdateMinStock.OnHoverBorderColor = System.Drawing.Color.White;
            this.BtnUpdateMinStock.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.BtnUpdateMinStock.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BtnUpdateMinStock.Size = new System.Drawing.Size(146, 61);
            this.BtnUpdateMinStock.TabIndex = 5;
            this.BtnUpdateMinStock.Text = "Update";
            this.BtnUpdateMinStock.TextColor = System.Drawing.Color.White;
            this.BtnUpdateMinStock.UseVisualStyleBackColor = false;
            this.BtnUpdateMinStock.Click += new System.EventHandler(this.BtnUpdateMinStock_Click);
            // 
            // MinimumStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 438);
            this.Controls.Add(this.BtnUpdateMinStock);
            this.Controls.Add(this.TxtMinStockQty);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGVStock);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MinimumStock";
            this.Text = "Minimum Stock";
            this.Load += new System.EventHandler(this.MinimumStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVStock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtFilterByProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMinStockQty;
        private ePOSOne.btnProduct.Button_WOC BtnUpdateMinStock;
    }
}