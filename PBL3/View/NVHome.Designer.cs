namespace PBL3.View
{
    partial class NVHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NVHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheck_Out = new System.Windows.Forms.Button();
            this.btnCN = new System.Windows.Forms.Button();
            this.btnDX = new System.Windows.Forms.Button();
            this.btnQLB = new System.Windows.Forms.Button();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.btnDD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.btnCheck_Out);
            this.panel1.Controls.Add(this.btnCN);
            this.panel1.Controls.Add(this.btnDX);
            this.panel1.Controls.Add(this.btnQLB);
            this.panel1.Controls.Add(this.pictureBoxHome);
            this.panel1.Controls.Add(this.btnDD);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 800);
            this.panel1.TabIndex = 16;
            // 
            // btnCheck_Out
            // 
            this.btnCheck_Out.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCheck_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck_Out.Image = global::PBL3.Properties.Resources.button;
            this.btnCheck_Out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheck_Out.Location = new System.Drawing.Point(3, 503);
            this.btnCheck_Out.Name = "btnCheck_Out";
            this.btnCheck_Out.Size = new System.Drawing.Size(249, 106);
            this.btnCheck_Out.TabIndex = 18;
            this.btnCheck_Out.Text = "Check Out";
            this.btnCheck_Out.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheck_Out.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheck_Out.UseVisualStyleBackColor = false;
            this.btnCheck_Out.Click += new System.EventHandler(this.btnCheck_Out_Click);
            // 
            // btnCN
            // 
            this.btnCN.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCN.Image = global::PBL3.Properties.Resources.user1;
            this.btnCN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCN.Location = new System.Drawing.Point(0, 391);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(249, 106);
            this.btnCN.TabIndex = 2;
            this.btnCN.Text = "Cá nhân";
            this.btnCN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCN.UseVisualStyleBackColor = false;
            this.btnCN.Click += new System.EventHandler(this.btnCN_Click);
            // 
            // btnDX
            // 
            this.btnDX.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDX.Image = global::PBL3.Properties.Resources.turn_off;
            this.btnDX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDX.Location = new System.Drawing.Point(2, 615);
            this.btnDX.Name = "btnDX";
            this.btnDX.Size = new System.Drawing.Size(249, 106);
            this.btnDX.TabIndex = 17;
            this.btnDX.Text = "Đăng Xuất";
            this.btnDX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDX.UseVisualStyleBackColor = false;
            this.btnDX.Click += new System.EventHandler(this.btnDX_Click);
            // 
            // btnQLB
            // 
            this.btnQLB.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnQLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLB.Image = global::PBL3.Properties.Resources.chair1;
            this.btnQLB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLB.Location = new System.Drawing.Point(2, 279);
            this.btnQLB.Name = "btnQLB";
            this.btnQLB.Size = new System.Drawing.Size(249, 106);
            this.btnQLB.TabIndex = 1;
            this.btnQLB.Text = "Quản lí bàn";
            this.btnQLB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLB.UseVisualStyleBackColor = false;
            this.btnQLB.Click += new System.EventHandler(this.btnQLBan_Click);
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.Image = global::PBL3.Properties.Resources.logo;
            this.pictureBoxHome.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(249, 164);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHome.TabIndex = 1;
            this.pictureBoxHome.TabStop = false;
            // 
            // btnDD
            // 
            this.btnDD.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDD.Image = global::PBL3.Properties.Resources.attendance;
            this.btnDD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDD.Location = new System.Drawing.Point(3, 167);
            this.btnDD.Name = "btnDD";
            this.btnDD.Size = new System.Drawing.Size(249, 106);
            this.btnDD.TabIndex = 1;
            this.btnDD.Text = "Điểm danh";
            this.btnDD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDD.UseVisualStyleBackColor = false;
            this.btnDD.Click += new System.EventHandler(this.btnDD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(218, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1154, 111);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to The Starbug Coffee!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gigi", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(1222, 849);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 39);
            this.label2.TabIndex = 17;
            this.label2.Text = "_Have a good day_";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(255, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1667, 975);
            this.panel2.TabIndex = 19;
            this.panel2.Click += new System.EventHandler(this.btnQLBan_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(224, 101);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1184, 745);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // NVHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1924, 978);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NVHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NVHome";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnQLB;
        private System.Windows.Forms.Button btnCN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCheck_Out;
    }
}