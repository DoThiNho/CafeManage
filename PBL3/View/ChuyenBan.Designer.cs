namespace PBL3
{
    partial class ChuyenBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChuyenBan));
            this.panel3 = new System.Windows.Forms.Panel();
            this.butChuyen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbDenBan = new System.Windows.Forms.ComboBox();
            this.cbbTuBan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_left = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.lb_top = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.butChuyen);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.cbbDenBan);
            this.panel3.Controls.Add(this.cbbTuBan);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lb_left);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(931, 191);
            this.panel3.TabIndex = 5;
            // 
            // butChuyen
            // 
            this.butChuyen.BackColor = System.Drawing.SystemColors.Info;
            this.butChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butChuyen.Image = ((System.Drawing.Image)(resources.GetObject("butChuyen.Image")));
            this.butChuyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butChuyen.Location = new System.Drawing.Point(282, 114);
            this.butChuyen.Name = "butChuyen";
            this.butChuyen.Size = new System.Drawing.Size(136, 44);
            this.butChuyen.TabIndex = 9;
            this.butChuyen.Text = "Chuyển";
            this.butChuyen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butChuyen.UseVisualStyleBackColor = false;
            this.butChuyen.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::PBL3.Properties.Resources.Close_2_icon1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(532, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Hủy";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbDenBan
            // 
            this.cbbDenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDenBan.FormattingEnabled = true;
            this.cbbDenBan.Location = new System.Drawing.Point(675, 38);
            this.cbbDenBan.Name = "cbbDenBan";
            this.cbbDenBan.Size = new System.Drawing.Size(189, 33);
            this.cbbDenBan.TabIndex = 5;
            // 
            // cbbTuBan
            // 
            this.cbbTuBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTuBan.FormattingEnabled = true;
            this.cbbTuBan.Location = new System.Drawing.Point(212, 38);
            this.cbbTuBan.Name = "cbbTuBan";
            this.cbbTuBan.Size = new System.Drawing.Size(189, 33);
            this.cbbTuBan.TabIndex = 4;
            this.cbbTuBan.SelectedIndexChanged += new System.EventHandler(this.cbbTuBan_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sang bàn";
            // 
            // lb_left
            // 
            this.lb_left.AutoSize = true;
            this.lb_left.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_left.Location = new System.Drawing.Point(44, 41);
            this.lb_left.Name = "lb_left";
            this.lb_left.Size = new System.Drawing.Size(96, 30);
            this.lb_left.TabIndex = 2;
            this.lb_left.Text = "Từ bàn";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel_top.Controls.Add(this.lb_top);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(931, 93);
            this.panel_top.TabIndex = 4;
            // 
            // lb_top
            // 
            this.lb_top.AutoSize = true;
            this.lb_top.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_top.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_top.Location = new System.Drawing.Point(313, 32);
            this.lb_top.Name = "lb_top";
            this.lb_top.Size = new System.Drawing.Size(217, 44);
            this.lb_top.TabIndex = 1;
            this.lb_top.Text = "Chuyển bàn";
            // 
            // ChuyenBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(931, 284);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_top);
            this.Name = "ChuyenBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button butChuyen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbbDenBan;
        private System.Windows.Forms.ComboBox cbbTuBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_left;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label lb_top;
    }
}