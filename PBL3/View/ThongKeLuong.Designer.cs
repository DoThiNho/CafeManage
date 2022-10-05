namespace PBL3
{
    partial class ThongKeLuong
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
            this.panel_body = new System.Windows.Forms.Panel();
            this.butThongKe = new System.Windows.Forms.Button();
            this.butHienThi = new System.Windows.Forms.Button();
            this.dateDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dateTungay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbbSort = new System.Windows.Forms.ComboBox();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel_top = new System.Windows.Forms.Panel();
            this.lb_top = new System.Windows.Forms.Label();
            this.panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.Color.FloralWhite;
            this.panel_body.Controls.Add(this.butThongKe);
            this.panel_body.Controls.Add(this.butHienThi);
            this.panel_body.Controls.Add(this.dateDenNgay);
            this.panel_body.Controls.Add(this.dateTungay);
            this.panel_body.Controls.Add(this.label3);
            this.panel_body.Controls.Add(this.label2);
            this.panel_body.Controls.Add(this.txtTong);
            this.panel_body.Controls.Add(this.btnTong);
            this.panel_body.Controls.Add(this.txtSearch);
            this.panel_body.Controls.Add(this.dataGridView1);
            this.panel_body.Controls.Add(this.cbbSort);
            this.panel_body.Controls.Add(this.btn_sort);
            this.panel_body.Controls.Add(this.btn_search);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 121);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1724, 849);
            this.panel_body.TabIndex = 4;
            // 
            // butThongKe
            // 
            this.butThongKe.BackColor = System.Drawing.SystemColors.Info;
            this.butThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butThongKe.Image = global::PBL3.Properties.Resources.pie_chart;
            this.butThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butThongKe.Location = new System.Drawing.Point(1277, 741);
            this.butThongKe.Name = "butThongKe";
            this.butThongKe.Size = new System.Drawing.Size(166, 77);
            this.butThongKe.TabIndex = 22;
            this.butThongKe.Text = "Thống kê";
            this.butThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butThongKe.UseVisualStyleBackColor = false;
            this.butThongKe.Click += new System.EventHandler(this.butThongKe_Click);
            // 
            // butHienThi
            // 
            this.butHienThi.BackColor = System.Drawing.SystemColors.Info;
            this.butHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHienThi.Image = global::PBL3.Properties.Resources.view;
            this.butHienThi.Location = new System.Drawing.Point(1291, 50);
            this.butHienThi.Name = "butHienThi";
            this.butHienThi.Size = new System.Drawing.Size(166, 65);
            this.butHienThi.TabIndex = 21;
            this.butHienThi.Text = "Hiển thị";
            this.butHienThi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butHienThi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butHienThi.UseVisualStyleBackColor = false;
            this.butHienThi.Click += new System.EventHandler(this.butHienThi_Click);
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.Location = new System.Drawing.Point(1018, 67);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Size = new System.Drawing.Size(204, 22);
            this.dateDenNgay.TabIndex = 19;
            // 
            // dateTungay
            // 
            this.dateTungay.Location = new System.Drawing.Point(564, 70);
            this.dateTungay.Name = "dateTungay";
            this.dateTungay.Size = new System.Drawing.Size(200, 22);
            this.dateTungay.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(871, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Từ ngày";
            // 
            // txtTong
            // 
            this.txtTong.Enabled = false;
            this.txtTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTong.Location = new System.Drawing.Point(827, 764);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(215, 30);
            this.txtTong.TabIndex = 16;
            // 
            // btnTong
            // 
            this.btnTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTong.Location = new System.Drawing.Point(628, 761);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(117, 38);
            this.btnTong.TabIndex = 15;
            this.btnTong.Text = "Tính tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(1018, 175);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(263, 34);
            this.txtSearch.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(318, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1149, 463);
            this.dataGridView1.TabIndex = 12;
            // 
            // cbbSort
            // 
            this.cbbSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSort.FormattingEnabled = true;
            this.cbbSort.Location = new System.Drawing.Point(564, 169);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Size = new System.Drawing.Size(263, 33);
            this.cbbSort.TabIndex = 11;
            // 
            // btn_sort
            // 
            this.btn_sort.BackColor = System.Drawing.SystemColors.Info;
            this.btn_sort.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sort.Image = global::PBL3.Properties.Resources.sort;
            this.btn_sort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sort.Location = new System.Drawing.Point(415, 151);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(93, 86);
            this.btn_sort.TabIndex = 10;
            this.btn_sort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sort.UseVisualStyleBackColor = false;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = global::PBL3.Properties.Resources.search;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Location = new System.Drawing.Point(903, 163);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(64, 48);
            this.btn_search.TabIndex = 8;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_top.Controls.Add(this.lb_top);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1724, 121);
            this.panel_top.TabIndex = 3;
            // 
            // lb_top
            // 
            this.lb_top.AutoSize = true;
            this.lb_top.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_top.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_top.Location = new System.Drawing.Point(760, 29);
            this.lb_top.Name = "lb_top";
            this.lb_top.Size = new System.Drawing.Size(282, 44);
            this.lb_top.TabIndex = 0;
            this.lb_top.Text = "Thống kê lương";
            // 
            // ThongKeLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1724, 970);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_top);
            this.Name = "ThongKeLuong";
            this.Text = "Thống kê lương";
            this.panel_body.ResumeLayout(false);
            this.panel_body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button butThongKe;
        private System.Windows.Forms.Button butHienThi;
        private System.Windows.Forms.DateTimePicker dateDenNgay;
        private System.Windows.Forms.DateTimePicker dateTungay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbSort;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label lb_top;
    }
}

