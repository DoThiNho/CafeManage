namespace PBL3
{
    partial class QLDoanhThu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTungay = new System.Windows.Forms.DateTimePicker();
            this.dateDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dateSearch = new System.Windows.Forms.DateTimePicker();
            this.cbbSort = new System.Windows.Forms.ComboBox();
            this.butHienThi = new System.Windows.Forms.Button();
            this.butThongKe = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            this.butSort = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1716, 132);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(700, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý doanh thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đến ngày";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(304, 418);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1156, 366);
            this.dataGridView1.TabIndex = 3;
            // 
            // dateTungay
            // 
            this.dateTungay.Location = new System.Drawing.Point(154, 3);
            this.dateTungay.Name = "dateTungay";
            this.dateTungay.Size = new System.Drawing.Size(200, 22);
            this.dateTungay.TabIndex = 4;
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.Location = new System.Drawing.Point(541, 3);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Size = new System.Drawing.Size(200, 22);
            this.dateDenNgay.TabIndex = 4;
            // 
            // dateSearch
            // 
            this.dateSearch.Location = new System.Drawing.Point(1260, 330);
            this.dateSearch.Name = "dateSearch";
            this.dateSearch.Size = new System.Drawing.Size(200, 22);
            this.dateSearch.TabIndex = 8;
            // 
            // cbbSort
            // 
            this.cbbSort.FormattingEnabled = true;
            this.cbbSort.Items.AddRange(new object[] {
            "Ngay",
            "Tong tien"});
            this.cbbSort.Location = new System.Drawing.Point(521, 328);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Size = new System.Drawing.Size(200, 24);
            this.cbbSort.TabIndex = 9;
            // 
            // butHienThi
            // 
            this.butHienThi.BackColor = System.Drawing.SystemColors.Info;
            this.butHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHienThi.Image = global::PBL3.Properties.Resources.view;
            this.butHienThi.Location = new System.Drawing.Point(1260, 186);
            this.butHienThi.Name = "butHienThi";
            this.butHienThi.Size = new System.Drawing.Size(166, 65);
            this.butHienThi.TabIndex = 10;
            this.butHienThi.Text = "Hiển thị";
            this.butHienThi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butHienThi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butHienThi.UseVisualStyleBackColor = false;
            this.butHienThi.Click += new System.EventHandler(this.butHienThi_Click);
            // 
            // butThongKe
            // 
            this.butThongKe.BackColor = System.Drawing.SystemColors.Info;
            this.butThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butThongKe.Image = global::PBL3.Properties.Resources.pie_chart;
            this.butThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butThongKe.Location = new System.Drawing.Point(1294, 833);
            this.butThongKe.Name = "butThongKe";
            this.butThongKe.Size = new System.Drawing.Size(166, 77);
            this.butThongKe.TabIndex = 5;
            this.butThongKe.Text = "Thống kê";
            this.butThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butThongKe.UseVisualStyleBackColor = false;
            this.butThongKe.Click += new System.EventHandler(this.butThongKe_Click);
            // 
            // butSearch
            // 
            this.butSearch.BackgroundImage = global::PBL3.Properties.Resources.search;
            this.butSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSearch.Location = new System.Drawing.Point(1110, 318);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(74, 51);
            this.butSearch.TabIndex = 7;
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butSort
            // 
            this.butSort.BackColor = System.Drawing.SystemColors.Info;
            this.butSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSort.Image = global::PBL3.Properties.Resources.sort;
            this.butSort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSort.Location = new System.Drawing.Point(304, 295);
            this.butSort.Name = "butSort";
            this.butSort.Size = new System.Drawing.Size(175, 83);
            this.butSort.TabIndex = 5;
            this.butSort.Text = "Sắp xếp";
            this.butSort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butSort.UseVisualStyleBackColor = false;
            this.butSort.Click += new System.EventHandler(this.butSort_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.8061F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.39335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.709141F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.59003F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.9169F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTungay, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateDenNgay, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(395, 202);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 49);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // QLDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1716, 922);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.butHienThi);
            this.Controls.Add(this.cbbSort);
            this.Controls.Add(this.dateSearch);
            this.Controls.Add(this.butThongKe);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.butSort);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "QLDoanhThu";
            this.Text = "Form10";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTungay;
        private System.Windows.Forms.DateTimePicker dateDenNgay;
        private System.Windows.Forms.Button butThongKe;
        private System.Windows.Forms.Button butSort;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.DateTimePicker dateSearch;
        private System.Windows.Forms.ComboBox cbbSort;
        private System.Windows.Forms.Button butHienThi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}