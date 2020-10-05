namespace Class5
{
    partial class CrawlerForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.Url_TB = new System.Windows.Forms.TextBox();
            this.Crawl_Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Url_DVG = new System.Windows.Forms.DataGridView();
            this.InvalidUrl_DGV = new System.Windows.Forms.DataGridView();
            this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crawlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.indexDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crawlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Url_DVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvalidUrl_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crawlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crawlerBindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Url_DVG);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.InvalidUrl_DGV);
            this.splitContainer1.Size = new System.Drawing.Size(1167, 564);
            this.splitContainer1.SplitterDistance = 561;
            this.splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL:";
            // 
            // Url_TB
            // 
            this.Url_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Url_TB.Location = new System.Drawing.Point(119, 42);
            this.Url_TB.Name = "Url_TB";
            this.Url_TB.Size = new System.Drawing.Size(870, 35);
            this.Url_TB.TabIndex = 1;
            this.Url_TB.Text = "https://www.cnblogs.com";
            // 
            // Crawl_Btn
            // 
            this.Crawl_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Crawl_Btn.Location = new System.Drawing.Point(1009, 42);
            this.Crawl_Btn.Name = "Crawl_Btn";
            this.Crawl_Btn.Size = new System.Drawing.Size(136, 39);
            this.Crawl_Btn.TabIndex = 2;
            this.Crawl_Btn.Text = "Start";
            this.Crawl_Btn.UseVisualStyleBackColor = true;
            this.Crawl_Btn.Click += new System.EventHandler(this.Crawl_Btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Crawl_Btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Url_TB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 114);
            this.panel1.TabIndex = 0;
            // 
            // Url_DVG
            // 
            this.Url_DVG.AutoGenerateColumns = false;
            this.Url_DVG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Url_DVG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Url_DVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Url_DVG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn});
            this.Url_DVG.DataMember = "ValidUrlList";
            this.Url_DVG.DataSource = this.crawlerBindingSource;
            this.Url_DVG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Url_DVG.Location = new System.Drawing.Point(0, 0);
            this.Url_DVG.Name = "Url_DVG";
            this.Url_DVG.RowHeadersWidth = 10;
            this.Url_DVG.RowTemplate.Height = 37;
            this.Url_DVG.Size = new System.Drawing.Size(561, 564);
            this.Url_DVG.TabIndex = 0;
            // 
            // InvalidUrl_DGV
            // 
            this.InvalidUrl_DGV.AutoGenerateColumns = false;
            this.InvalidUrl_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.InvalidUrl_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.InvalidUrl_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvalidUrl_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexDataGridViewTextBoxColumn1,
            this.urlDataGridViewTextBoxColumn1});
            this.InvalidUrl_DGV.DataMember = "InvallidUrList";
            this.InvalidUrl_DGV.DataSource = this.crawlerBindingSource1;
            this.InvalidUrl_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvalidUrl_DGV.Location = new System.Drawing.Point(0, 0);
            this.InvalidUrl_DGV.Name = "InvalidUrl_DGV";
            this.InvalidUrl_DGV.RowHeadersWidth = 10;
            this.InvalidUrl_DGV.RowTemplate.Height = 37;
            this.InvalidUrl_DGV.Size = new System.Drawing.Size(602, 564);
            this.InvalidUrl_DGV.TabIndex = 0;
            // 
            // indexDataGridViewTextBoxColumn
            // 
            this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
            this.indexDataGridViewTextBoxColumn.HeaderText = "Index";
            this.indexDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
            this.indexDataGridViewTextBoxColumn.ReadOnly = true;
            this.indexDataGridViewTextBoxColumn.Width = 115;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.ReadOnly = true;
            this.urlDataGridViewTextBoxColumn.Width = 91;
            // 
            // crawlerBindingSource
            // 
            this.crawlerBindingSource.DataSource = typeof(Class5.Crawler);
            // 
            // indexDataGridViewTextBoxColumn1
            // 
            this.indexDataGridViewTextBoxColumn1.DataPropertyName = "Index";
            this.indexDataGridViewTextBoxColumn1.HeaderText = "Index";
            this.indexDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.indexDataGridViewTextBoxColumn1.Name = "indexDataGridViewTextBoxColumn1";
            this.indexDataGridViewTextBoxColumn1.ReadOnly = true;
            this.indexDataGridViewTextBoxColumn1.Width = 115;
            // 
            // urlDataGridViewTextBoxColumn1
            // 
            this.urlDataGridViewTextBoxColumn1.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn1.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.urlDataGridViewTextBoxColumn1.Name = "urlDataGridViewTextBoxColumn1";
            this.urlDataGridViewTextBoxColumn1.ReadOnly = true;
            this.urlDataGridViewTextBoxColumn1.Width = 91;
            // 
            // crawlerBindingSource1
            // 
            this.crawlerBindingSource1.DataSource = typeof(Class5.Crawler);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1167, 564);
            this.panel2.TabIndex = 3;
            // 
            // CrawlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 678);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CrawlerForm";
            this.Text = "WebCrawler";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Url_DVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvalidUrl_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crawlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crawlerBindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Url_TB;
        private System.Windows.Forms.Button Crawl_Btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Url_DVG;
        private System.Windows.Forms.DataGridView InvalidUrl_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource crawlerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource crawlerBindingSource1;
        private System.Windows.Forms.Panel panel2;
    }
}