namespace OrderSystemWinform
{
    partial class OrderSystemForm
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
            this.Search_GB = new System.Windows.Forms.GroupBox();
            this.Search_Btn = new System.Windows.Forms.Button();
            this.SearchCtx_TB = new System.Windows.Forms.TextBox();
            this.Address_RBtn = new System.Windows.Forms.RadioButton();
            this.Customer_RBtn = new System.Windows.Forms.RadioButton();
            this.ID_RBtn = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Create_Btn = new System.Windows.Forms.Button();
            this.Edit_Btn = new System.Windows.Forms.Button();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Order_DGV = new System.Windows.Forms.DataGridView();
            this.Detail_DGV = new System.Windows.Forms.DataGridView();
            this.Search_GB.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detail_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_GB
            // 
            this.Search_GB.Controls.Add(this.Search_Btn);
            this.Search_GB.Controls.Add(this.SearchCtx_TB);
            this.Search_GB.Controls.Add(this.Address_RBtn);
            this.Search_GB.Controls.Add(this.Customer_RBtn);
            this.Search_GB.Controls.Add(this.ID_RBtn);
            this.Search_GB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Search_GB.Dock = System.Windows.Forms.DockStyle.Top;
            this.Search_GB.Location = new System.Drawing.Point(0, 0);
            this.Search_GB.Name = "Search_GB";
            this.Search_GB.Size = new System.Drawing.Size(1642, 79);
            this.Search_GB.TabIndex = 0;
            this.Search_GB.TabStop = false;
            this.Search_GB.Text = "Search";
            // 
            // Search_Btn
            // 
            this.Search_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_Btn.Location = new System.Drawing.Point(1512, 24);
            this.Search_Btn.Name = "Search_Btn";
            this.Search_Btn.Size = new System.Drawing.Size(118, 44);
            this.Search_Btn.TabIndex = 4;
            this.Search_Btn.Text = "Search";
            this.Search_Btn.UseVisualStyleBackColor = true;
            this.Search_Btn.Click += new System.EventHandler(this.Search_Btn_Click);
            // 
            // SearchCtx_TB
            // 
            this.SearchCtx_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchCtx_TB.Location = new System.Drawing.Point(373, 31);
            this.SearchCtx_TB.Margin = new System.Windows.Forms.Padding(10);
            this.SearchCtx_TB.Name = "SearchCtx_TB";
            this.SearchCtx_TB.Size = new System.Drawing.Size(1126, 35);
            this.SearchCtx_TB.TabIndex = 3;
            // 
            // Address_RBtn
            // 
            this.Address_RBtn.AutoSize = true;
            this.Address_RBtn.Location = new System.Drawing.Point(235, 34);
            this.Address_RBtn.Name = "Address_RBtn";
            this.Address_RBtn.Size = new System.Drawing.Size(125, 28);
            this.Address_RBtn.TabIndex = 2;
            this.Address_RBtn.TabStop = true;
            this.Address_RBtn.Text = "Address";
            this.Address_RBtn.UseVisualStyleBackColor = true;
            // 
            // Customer_RBtn
            // 
            this.Customer_RBtn.AutoSize = true;
            this.Customer_RBtn.Location = new System.Drawing.Point(92, 34);
            this.Customer_RBtn.Name = "Customer_RBtn";
            this.Customer_RBtn.Size = new System.Drawing.Size(137, 28);
            this.Customer_RBtn.TabIndex = 1;
            this.Customer_RBtn.TabStop = true;
            this.Customer_RBtn.Text = "Customer";
            this.Customer_RBtn.UseVisualStyleBackColor = true;
            // 
            // ID_RBtn
            // 
            this.ID_RBtn.AutoSize = true;
            this.ID_RBtn.Location = new System.Drawing.Point(6, 34);
            this.ID_RBtn.Name = "ID_RBtn";
            this.ID_RBtn.Size = new System.Drawing.Size(65, 28);
            this.ID_RBtn.TabIndex = 0;
            this.ID_RBtn.TabStop = true;
            this.ID_RBtn.Text = "ID";
            this.ID_RBtn.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Create_Btn);
            this.flowLayoutPanel1.Controls.Add(this.Edit_Btn);
            this.flowLayoutPanel1.Controls.Add(this.Delete_Btn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 662);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1642, 68);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // Create_Btn
            // 
            this.Create_Btn.Location = new System.Drawing.Point(6, 6);
            this.Create_Btn.Name = "Create_Btn";
            this.Create_Btn.Size = new System.Drawing.Size(131, 50);
            this.Create_Btn.TabIndex = 0;
            this.Create_Btn.Text = "Create";
            this.Create_Btn.UseVisualStyleBackColor = true;
            this.Create_Btn.Click += new System.EventHandler(this.Create_Btn_Click);
            // 
            // Edit_Btn
            // 
            this.Edit_Btn.Location = new System.Drawing.Point(143, 6);
            this.Edit_Btn.Name = "Edit_Btn";
            this.Edit_Btn.Size = new System.Drawing.Size(131, 50);
            this.Edit_Btn.TabIndex = 1;
            this.Edit_Btn.Text = "Edit";
            this.Edit_Btn.UseVisualStyleBackColor = true;
            this.Edit_Btn.Click += new System.EventHandler(this.Edit_Btn_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Location = new System.Drawing.Point(280, 6);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(131, 50);
            this.Delete_Btn.TabIndex = 2;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 79);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Order_DGV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Detail_DGV);
            this.splitContainer1.Size = new System.Drawing.Size(1642, 583);
            this.splitContainer1.SplitterDistance = 659;
            this.splitContainer1.TabIndex = 5;
            // 
            // Order_DGV
            // 
            this.Order_DGV.AllowUserToAddRows = false;
            this.Order_DGV.AllowUserToDeleteRows = false;
            this.Order_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.Order_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Order_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Order_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Order_DGV.Location = new System.Drawing.Point(0, 0);
            this.Order_DGV.MultiSelect = false;
            this.Order_DGV.Name = "Order_DGV";
            this.Order_DGV.ReadOnly = true;
            this.Order_DGV.RowHeadersWidth = 4;
            this.Order_DGV.RowTemplate.Height = 37;
            this.Order_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Order_DGV.Size = new System.Drawing.Size(659, 583);
            this.Order_DGV.TabIndex = 0;
            this.Order_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Order_DGV_CellContentClick);
            // 
            // Detail_DGV
            // 
            this.Detail_DGV.AllowUserToAddRows = false;
            this.Detail_DGV.AllowUserToDeleteRows = false;
            this.Detail_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.Detail_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Detail_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Detail_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Detail_DGV.Location = new System.Drawing.Point(0, 0);
            this.Detail_DGV.MultiSelect = false;
            this.Detail_DGV.Name = "Detail_DGV";
            this.Detail_DGV.RowHeadersWidth = 4;
            this.Detail_DGV.RowTemplate.Height = 37;
            this.Detail_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Detail_DGV.Size = new System.Drawing.Size(979, 583);
            this.Detail_DGV.TabIndex = 0;
            // 
            // OrderSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1642, 730);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Search_GB);
            this.Name = "OrderSystemForm";
            this.Text = "OrderSystemForm";
            this.Search_GB.ResumeLayout(false);
            this.Search_GB.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Order_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detail_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Search_GB;
        private System.Windows.Forms.RadioButton Customer_RBtn;
        private System.Windows.Forms.RadioButton ID_RBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox SearchCtx_TB;
        private System.Windows.Forms.RadioButton Address_RBtn;
        private System.Windows.Forms.Button Create_Btn;
        private System.Windows.Forms.Button Edit_Btn;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.DataGridView Order_DGV;
        private System.Windows.Forms.DataGridView Detail_DGV;
        private System.Windows.Forms.Button Search_Btn;
    }
}