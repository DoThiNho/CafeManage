using PBL3.BLL;
using PBL3.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class login : Form
    {
        QLCF db = new QLCF();
        public login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtUser.TabIndex = 0;
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "User" || txtPW.Text == "Password")
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được để trống!", "Chú ý");
            }
            else
            {
                int check = QLDANGNHAP.Instance.Account(txtUser.Text, txtPW.Text);
                if (check == 1)
                {
                    AdHome ad1 = new AdHome(txtUser.Text);
                    this.Visible = false;
                    ad1.ShowDialog();
                }
                if (check == 0)
                {
                    NVHome nv = new NVHome(txtUser.Text);
                    this.Visible = false;
                    nv.ShowDialog();
                }
                if (check == 2)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai, vui lòng nhập lại!");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "User")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "User";
                txtUser.ForeColor = Color.Gray;
            }
        }

        private void cbHT_CheckedChanged(object sender, EventArgs e)
        {
            if(cbHT.Checked == true)
            {
                txtPW.UseSystemPasswordChar = true; 
            }
            else txtPW.UseSystemPasswordChar = false;
        }

        private void txtPw_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "Password")
            {
                txtPW.Text = "";
                txtPW.ForeColor = Color.Black;
            }
        }

        private void txtPw_Leave(object sender, EventArgs e)
        {
            if (txtPW.Text == "")
            {
                txtPW.Text = "Password";
                txtPW.ForeColor = Color.Gray;
            }
        }


    }
}