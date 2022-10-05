namespace PBL3
{
    partial class DoiMatKhau
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtMKHT = new System.Windows.Forms.TextBox();
            this.txtMKM = new System.Windows.Forms.TextBox();
            this.txtNLMKM = new System.Windows.Forms.TextBox();
            this.butHuy = new System.Windows.Forms.Button();
            this.butDMK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu hiện tại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhập lại mật khẩu mới";
            // 
            // txtMKHT
            // 
            this.txtMKHT.Location = new System.Drawing.Point(392, 116);
            this.txtMKHT.Name = "txtMKHT";
            this.txtMKHT.Size = new System.Drawing.Size(225, 22);
            this.txtMKHT.TabIndex = 2;
            // 
            // txtMKM
            // 
            this.txtMKM.Location = new System.Drawing.Point(392, 188);
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.Size = new System.Drawing.Size(225, 22);
            this.txtMKM.TabIndex = 2;
            // 
            // txtNLMKM
            // 
            this.txtNLMKM.Location = new System.Drawing.Point(392, 261);
            this.txtNLMKM.Name = "txtNLMKM";
            this.txtNLMKM.Size = new System.Drawing.Size(225, 22);
            this.txtNLMKM.TabIndex = 2;
            // 
            // butHuy
            // 
            this.butHuy.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHuy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butHuy.Image = global::PBL3.Properties.Resources.Close_2_icon;
            this.butHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butHuy.Location = new System.Drawing.Point(446, 348);
            this.butHuy.Name = "butHuy";
            this.butHuy.Size = new System.Drawing.Size(135, 65);
            this.butHuy.TabIndex = 3;
            this.butHuy.Text = "Hủy";
            this.butHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butHuy.UseVisualStyleBackColor = false;
            this.butHuy.Click += new System.EventHandler(this.butHuy_Click);
            // 
            // butDMK
            // 
            this.butDMK.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butDMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDMK.Image = global::PBL3.Properties.Resources._172497_lock_icon;
            this.butDMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butDMK.Location = new System.Drawing.Point(169, 348);
            this.butDMK.Name = "butDMK";
            this.butDMK.Size = new System.Drawing.Size(186, 65);
            this.butDMK.TabIndex = 3;
            this.butDMK.Text = "Đổi Mật Khẩu";
            this.butDMK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butDMK.UseVisualStyleBackColor = false;
            this.butDMK.Click += new System.EventHandler(this.butDMK_Click);
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.butHuy);
            this.Controls.Add(this.butDMK);
            this.Controls.Add(this.txtNLMKM);
            this.Controls.Add(this.txtMKM);
            this.Controls.Add(this.txtMKHT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DoiMatKhau";
            this.Text = "DoiMatKhau";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMKHT;
        private System.Windows.Forms.TextBox txtMKM;
        private System.Windows.Forms.TextBox txtNLMKM;
        private System.Windows.Forms.Button butDMK;
        private System.Windows.Forms.Button butHuy;
    }
}