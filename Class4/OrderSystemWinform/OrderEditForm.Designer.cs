namespace OrderSystemWinform
{
    partial class OrderEditForm
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
            this.Order_GB = new System.Windows.Forms.GroupBox();
            this.Address_TB = new System.Windows.Forms.TextBox();
            this.Address_Label = new System.Windows.Forms.Label();
            this.Customer_TB = new System.Windows.Forms.TextBox();
            this.Customer_Label = new System.Windows.Forms.Label();
            this.ID_TB = new System.Windows.Forms.TextBox();
            this.ID_Label = new System.Windows.Forms.Label();
            this.Detail_GB = new System.Windows.Forms.GroupBox();
            this.Unselected_Btn = new System.Windows.Forms.Button();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.Number_TB = new System.Windows.Forms.TextBox();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Number_Label = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Price_TB = new System.Windows.Forms.TextBox();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Price_Label = new System.Windows.Forms.Label();
            this.Order_DGV = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Finish_Btn = new System.Windows.Forms.Button();
            this.Order_GB.SuspendLayout();
            this.Detail_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_DGV)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Order_GB
            // 
            this.Order_GB.Controls.Add(this.Address_TB);
            this.Order_GB.Controls.Add(this.Address_Label);
            this.Order_GB.Controls.Add(this.Customer_TB);
            this.Order_GB.Controls.Add(this.Customer_Label);
            this.Order_GB.Controls.Add(this.ID_TB);
            this.Order_GB.Controls.Add(this.ID_Label);
            this.Order_GB.Dock = System.Windows.Forms.DockStyle.Top;
            this.Order_GB.Location = new System.Drawing.Point(0, 0);
            this.Order_GB.Name = "Order_GB";
            this.Order_GB.Size = new System.Drawing.Size(1129, 105);
            this.Order_GB.TabIndex = 0;
            this.Order_GB.TabStop = false;
            this.Order_GB.Text = "Order";
            // 
            // Address_TB
            // 
            this.Address_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Address_TB.Location = new System.Drawing.Point(645, 44);
            this.Address_TB.Name = "Address_TB";
            this.Address_TB.Size = new System.Drawing.Size(472, 35);
            this.Address_TB.TabIndex = 5;
            this.Address_TB.TextChanged += new System.EventHandler(this.Address_TB_TextChanged);
            // 
            // Address_Label
            // 
            this.Address_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Address_Label.AutoSize = true;
            this.Address_Label.Location = new System.Drawing.Point(540, 47);
            this.Address_Label.Name = "Address_Label";
            this.Address_Label.Size = new System.Drawing.Size(94, 24);
            this.Address_Label.TabIndex = 4;
            this.Address_Label.Text = "Address";
            // 
            // Customer_TB
            // 
            this.Customer_TB.Location = new System.Drawing.Point(316, 44);
            this.Customer_TB.Name = "Customer_TB";
            this.Customer_TB.Size = new System.Drawing.Size(205, 35);
            this.Customer_TB.TabIndex = 3;
            this.Customer_TB.TextChanged += new System.EventHandler(this.Customer_TB_TextChanged);
            // 
            // Customer_Label
            // 
            this.Customer_Label.AutoSize = true;
            this.Customer_Label.Location = new System.Drawing.Point(204, 47);
            this.Customer_Label.Name = "Customer_Label";
            this.Customer_Label.Size = new System.Drawing.Size(106, 24);
            this.Customer_Label.TabIndex = 2;
            this.Customer_Label.Text = "Customer";
            // 
            // ID_TB
            // 
            this.ID_TB.Location = new System.Drawing.Point(81, 44);
            this.ID_TB.Name = "ID_TB";
            this.ID_TB.ReadOnly = true;
            this.ID_TB.Size = new System.Drawing.Size(100, 35);
            this.ID_TB.TabIndex = 1;
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Location = new System.Drawing.Point(32, 47);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(34, 24);
            this.ID_Label.TabIndex = 0;
            this.ID_Label.Text = "ID";
            // 
            // Detail_GB
            // 
            this.Detail_GB.Controls.Add(this.Unselected_Btn);
            this.Detail_GB.Controls.Add(this.Delete_Btn);
            this.Detail_GB.Controls.Add(this.Number_TB);
            this.Detail_GB.Controls.Add(this.Add_Btn);
            this.Detail_GB.Controls.Add(this.Number_Label);
            this.Detail_GB.Controls.Add(this.Name_Label);
            this.Detail_GB.Controls.Add(this.Price_TB);
            this.Detail_GB.Controls.Add(this.Name_TB);
            this.Detail_GB.Controls.Add(this.Price_Label);
            this.Detail_GB.Dock = System.Windows.Forms.DockStyle.Top;
            this.Detail_GB.Location = new System.Drawing.Point(0, 105);
            this.Detail_GB.Name = "Detail_GB";
            this.Detail_GB.Size = new System.Drawing.Size(1129, 169);
            this.Detail_GB.TabIndex = 1;
            this.Detail_GB.TabStop = false;
            this.Detail_GB.Text = "Commodity";
            // 
            // Unselected_Btn
            // 
            this.Unselected_Btn.Location = new System.Drawing.Point(953, 105);
            this.Unselected_Btn.Margin = new System.Windows.Forms.Padding(10);
            this.Unselected_Btn.Name = "Unselected_Btn";
            this.Unselected_Btn.Padding = new System.Windows.Forms.Padding(6);
            this.Unselected_Btn.Size = new System.Drawing.Size(166, 51);
            this.Unselected_Btn.TabIndex = 12;
            this.Unselected_Btn.Text = "Unselected";
            this.Unselected_Btn.UseVisualStyleBackColor = true;
            this.Unselected_Btn.Click += new System.EventHandler(this.Unselected_Btn_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Location = new System.Drawing.Point(161, 105);
            this.Delete_Btn.Margin = new System.Windows.Forms.Padding(10);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Padding = new System.Windows.Forms.Padding(6);
            this.Delete_Btn.Size = new System.Drawing.Size(120, 51);
            this.Delete_Btn.TabIndex = 1;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // Number_TB
            // 
            this.Number_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Number_TB.Location = new System.Drawing.Point(779, 57);
            this.Number_TB.Name = "Number_TB";
            this.Number_TB.Size = new System.Drawing.Size(338, 35);
            this.Number_TB.TabIndex = 11;
            this.Number_TB.TextChanged += new System.EventHandler(this.Number_TB_TextChanged);
            // 
            // Add_Btn
            // 
            this.Add_Btn.Location = new System.Drawing.Point(21, 105);
            this.Add_Btn.Margin = new System.Windows.Forms.Padding(10);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Padding = new System.Windows.Forms.Padding(6);
            this.Add_Btn.Size = new System.Drawing.Size(120, 51);
            this.Add_Btn.TabIndex = 0;
            this.Add_Btn.Text = "Add";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Number_Label
            // 
            this.Number_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Number_Label.AutoSize = true;
            this.Number_Label.Location = new System.Drawing.Point(691, 60);
            this.Number_Label.Name = "Number_Label";
            this.Number_Label.Size = new System.Drawing.Size(82, 24);
            this.Number_Label.TabIndex = 10;
            this.Number_Label.Text = "Number";
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(17, 60);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(58, 24);
            this.Name_Label.TabIndex = 6;
            this.Name_Label.Text = "Name";
            // 
            // Price_TB
            // 
            this.Price_TB.Location = new System.Drawing.Point(429, 57);
            this.Price_TB.Name = "Price_TB";
            this.Price_TB.Size = new System.Drawing.Size(205, 35);
            this.Price_TB.TabIndex = 9;
            this.Price_TB.TextChanged += new System.EventHandler(this.Price_TB_TextChanged);
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(81, 57);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(229, 35);
            this.Name_TB.TabIndex = 7;
            this.Name_TB.TextChanged += new System.EventHandler(this.Name_TB_TextChanged);
            // 
            // Price_Label
            // 
            this.Price_Label.AutoSize = true;
            this.Price_Label.Location = new System.Drawing.Point(349, 60);
            this.Price_Label.Name = "Price_Label";
            this.Price_Label.Size = new System.Drawing.Size(70, 24);
            this.Price_Label.TabIndex = 8;
            this.Price_Label.Text = "Price";
            // 
            // Order_DGV
            // 
            this.Order_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.Order_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Order_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Order_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Order_DGV.Location = new System.Drawing.Point(0, 274);
            this.Order_DGV.Name = "Order_DGV";
            this.Order_DGV.RowHeadersWidth = 4;
            this.Order_DGV.RowTemplate.Height = 37;
            this.Order_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Order_DGV.Size = new System.Drawing.Size(1129, 485);
            this.Order_DGV.TabIndex = 2;
            this.Order_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Order_DGV_CellContentClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Finish_Btn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 688);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1129, 71);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Finish_Btn
            // 
            this.Finish_Btn.Location = new System.Drawing.Point(999, 10);
            this.Finish_Btn.Margin = new System.Windows.Forms.Padding(10);
            this.Finish_Btn.Name = "Finish_Btn";
            this.Finish_Btn.Padding = new System.Windows.Forms.Padding(6);
            this.Finish_Btn.Size = new System.Drawing.Size(120, 51);
            this.Finish_Btn.TabIndex = 13;
            this.Finish_Btn.Text = "Finish";
            this.Finish_Btn.UseVisualStyleBackColor = true;
            this.Finish_Btn.Click += new System.EventHandler(this.Finish_Btn_Click);
            // 
            // OrderEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 759);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Order_DGV);
            this.Controls.Add(this.Detail_GB);
            this.Controls.Add(this.Order_GB);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "OrderEditForm";
            this.Text = "OrderEditForm";
            this.Order_GB.ResumeLayout(false);
            this.Order_GB.PerformLayout();
            this.Detail_GB.ResumeLayout(false);
            this.Detail_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_DGV)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Order_GB;
        private System.Windows.Forms.TextBox Address_TB;
        private System.Windows.Forms.Label Address_Label;
        private System.Windows.Forms.TextBox Customer_TB;
        private System.Windows.Forms.Label Customer_Label;
        private System.Windows.Forms.TextBox ID_TB;
        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.GroupBox Detail_GB;
        private System.Windows.Forms.TextBox Number_TB;
        private System.Windows.Forms.Label Number_Label;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.TextBox Price_TB;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.Label Price_Label;
        private System.Windows.Forms.DataGridView Order_DGV;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Button Finish_Btn;
        private System.Windows.Forms.Button Unselected_Btn;
    }
}