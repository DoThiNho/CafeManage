namespace PBL3
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.butQLB = new System.Windows.Forms.Button();
            this.btnCaNhan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.butQLDT = new System.Windows.Forms.Button();
            this.butQLDU = new System.Windows.Forms.Button();
            this.butQLNV = new System.Windows.Forms.Button();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.butQLB);
            this.panel1.Controls.Add(this.btnCaNhan);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.butQLDT);
            this.panel1.Controls.Add(this.butQLDU);
            this.panel1.Controls.Add(this.butQLNV);
            this.panel1.Controls.Add(this.pictureBoxHome);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 842);
            this.panel1.TabIndex = 0;
            // 
            // butQLB
            // 
            this.butQLB.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butQLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butQLB.Image = global::PBL3.Properties.Resources.chair1;
            this.butQLB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butQLB.Location = new System.Drawing.Point(0, 285);
            this.butQLB.Name = "butQLB";
            this.butQLB.Size = new System.Drawing.Size(254, 106);
            this.butQLB.TabIndex = 1;
            this.butQLB.Text = "Quản lí bàn";
            this.butQLB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butQLB.UseVisualStyleBackColor = false;
            this.butQLB.Click += new System.EventHandler(this.butQLB_Click);
            // 
            // btnCaNhan
            // 
            this.btnCaNhan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCaNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaNhan.Image = global::PBL3.Properties.Resources.user1;
            this.btnCaNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaNhan.Location = new System.Drawing.Point(0, 173);
            this.btnCaNhan.Name = "btnCaNhan";
            this.btnCaNhan.Size = new System.Drawing.Size(254, 106);
            this.btnCaNhan.TabIndex = 2;
            this.btnCaNhan.Text = "Cá nhân";
            this.btnCaNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCaNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaNhan.UseVisualStyleBackColor = false;
            this.btnCaNhan.Click += new System.EventHandler(this.btnCaNhan_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::PBL3.Properties.Resources.pie_chart;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 733);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 106);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thống kê lương";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.butTKLuong_Click);
            // 
            // butQLDT
            // 
            this.butQLDT.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butQLDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butQLDT.Image = global::PBL3.Properties.Resources.salary;
            this.butQLDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butQLDT.Location = new System.Drawing.Point(0, 621);
            this.butQLDT.Name = "butQLDT";
            this.butQLDT.Size = new System.Drawing.Size(254, 106);
            this.butQLDT.TabIndex = 1;
            this.butQLDT.Text = "Quản lí doanh thu";
            this.butQLDT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butQLDT.UseVisualStyleBackColor = false;
            this.butQLDT.Click += new System.EventHandler(this.butQLDT_Click);
            // 
            // butQLDU
            // 
            this.butQLDU.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butQLDU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butQLDU.Image = global::PBL3.Properties.Resources.soda;
            this.butQLDU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butQLDU.Location = new System.Drawing.Point(0, 509);
            this.butQLDU.Name = "butQLDU";
            this.butQLDU.Size = new System.Drawing.Size(254, 106);
            this.butQLDU.TabIndex = 1;
            this.butQLDU.Text = "Quản lí đồ uống";
            this.butQLDU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butQLDU.UseVisualStyleBackColor = false;
            this.butQLDU.Click += new System.EventHandler(this.butQLDU_Click);
            // 
            // butQLNV
            // 
            this.butQLNV.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butQLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butQLNV.Image = global::PBL3.Properties.Resources.network;
            this.butQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butQLNV.Location = new System.Drawing.Point(0, 397);
            this.butQLNV.Name = "butQLNV";
            this.butQLNV.Size = new System.Drawing.Size(254, 106);
            this.butQLNV.TabIndex = 1;
            this.butQLNV.Text = "Quản lí nhân viên";
            this.butQLNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butQLNV.UseVisualStyleBackColor = false;
            this.butQLNV.Click += new System.EventHandler(this.butQLNV_Click);
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.Image = global::PBL3.Properties.Resources.logo;
            this.pictureBoxHome.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(254, 164);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHome.TabIndex = 0;
            this.pictureBoxHome.TabStop = false;
            this.pictureBoxHome.Click += new System.EventHandler(this.pictureBoxHome_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(254, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1340, 839);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(494, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 94);
            this.label1.TabIndex = 1;
            this.label1.Text = "The Starbug Coffee";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            //this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1337, 768);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1595, 842);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butQLB;
        private System.Windows.Forms.Button butQLDT;
        private System.Windows.Forms.Button butQLDU;
        private System.Windows.Forms.Button butQLNV;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCaNhan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}