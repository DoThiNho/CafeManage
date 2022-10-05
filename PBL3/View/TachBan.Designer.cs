namespace PBL3.View
{
    partial class TachBan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTuBan = new System.Windows.Forms.ComboBox();
            this.cbbDenBan = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butTach = new System.Windows.Forms.Button();
            this.butHuy = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(511, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÁCH BÀN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ bàn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(692, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đến bàn";
            // 
            // cbbTuBan
            // 
            this.cbbTuBan.FormattingEnabled = true;
            this.cbbTuBan.Location = new System.Drawing.Point(171, 111);
            this.cbbTuBan.Name = "cbbTuBan";
            this.cbbTuBan.Size = new System.Drawing.Size(167, 24);
            this.cbbTuBan.TabIndex = 1;
            this.cbbTuBan.SelectedIndexChanged += new System.EventHandler(this.cbbTuBan_SelectedIndexChanged);
            // 
            // cbbDenBan
            // 
            this.cbbDenBan.FormattingEnabled = true;
            this.cbbDenBan.Location = new System.Drawing.Point(866, 108);
            this.cbbDenBan.Name = "cbbDenBan";
            this.cbbDenBan.Size = new System.Drawing.Size(182, 24);
            this.cbbDenBan.TabIndex = 1;
            this.cbbDenBan.SelectedIndexChanged += new System.EventHandler(this.cbbDenBan_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(448, 229);
            this.dataGridView1.TabIndex = 2;
            // 
            // butTach
            // 
            this.butTach.BackColor = System.Drawing.Color.Wheat;
            this.butTach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTach.Image = global::PBL3.Properties.Resources.separate;
            this.butTach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butTach.Location = new System.Drawing.Point(343, 429);
            this.butTach.Name = "butTach";
            this.butTach.Size = new System.Drawing.Size(108, 49);
            this.butTach.TabIndex = 3;
            this.butTach.Text = "Tách";
            this.butTach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butTach.UseVisualStyleBackColor = false;
            this.butTach.Click += new System.EventHandler(this.butTach_Click);
            // 
            // butHuy
            // 
            this.butHuy.BackColor = System.Drawing.Color.Wheat;
            this.butHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHuy.Image = global::PBL3.Properties.Resources.multiply;
            this.butHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butHuy.Location = new System.Drawing.Point(697, 429);
            this.butHuy.Name = "butHuy";
            this.butHuy.Size = new System.Drawing.Size(102, 49);
            this.butHuy.TabIndex = 3;
            this.butHuy.Text = "Hủy";
            this.butHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butHuy.UseVisualStyleBackColor = false;
            this.butHuy.Click += new System.EventHandler(this.butHuy_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(673, 163);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(448, 229);
            this.dataGridView2.TabIndex = 4;
            // 
            // TachBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1177, 516);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.butHuy);
            this.Controls.Add(this.butTach);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbbDenBan);
            this.Controls.Add(this.cbbTuBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TachBan";
            this.Text = "TachBan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTuBan;
        private System.Windows.Forms.ComboBox cbbDenBan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butTach;
        private System.Windows.Forms.Button butHuy;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}