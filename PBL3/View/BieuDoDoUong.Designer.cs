namespace PBL3.View
{
    partial class BieuDoDoUong
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BieuDoDoUong));
            this.cbbLoaiThucUong = new System.Windows.Forms.ComboBox();
            this.cbbLoaiThongKe = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbLoaiThucUong
            // 
            this.cbbLoaiThucUong.FormattingEnabled = true;
            this.cbbLoaiThucUong.Location = new System.Drawing.Point(420, 47);
            this.cbbLoaiThucUong.Name = "cbbLoaiThucUong";
            this.cbbLoaiThucUong.Size = new System.Drawing.Size(121, 24);
            this.cbbLoaiThucUong.TabIndex = 29;
            // 
            // cbbLoaiThongKe
            // 
            this.cbbLoaiThongKe.FormattingEnabled = true;
            this.cbbLoaiThongKe.Location = new System.Drawing.Point(244, 47);
            this.cbbLoaiThongKe.Name = "cbbLoaiThongKe";
            this.cbbLoaiThongKe.Size = new System.Drawing.Size(121, 24);
            this.cbbLoaiThongKe.TabIndex = 27;
            this.cbbLoaiThongKe.SelectedValueChanged += new System.EventHandler(this.cbbLoaiThongKe_SelectedValueChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(114, 110);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Label = "#PERCENT";
            series1.Legend = "Legend1";
            series1.Name = "Thuc uong";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(548, 308);
            this.chart1.TabIndex = 25;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            this.chart1.Titles.Add(title1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Info;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::PBL3.Properties.Resources.Close_2_icon1;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(609, 33);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 45);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.SystemColors.Info;
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Image = ((System.Drawing.Image)(resources.GetObject("btnDisplay.Image")));
            this.btnDisplay.Location = new System.Drawing.Point(67, 33);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(125, 45);
            this.btnDisplay.TabIndex = 26;
            this.btnDisplay.Text = "Hiển thị";
            this.btnDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDisplay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // BieuDoDoUong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbLoaiThucUong);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbbLoaiThongKe);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.chart1);
            this.Name = "BieuDoDoUong";
            this.Text = "BieuDoDoUong";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbLoaiThucUong;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbbLoaiThongKe;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}