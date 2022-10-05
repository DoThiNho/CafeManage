using PBL3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;
using System.Text.RegularExpressions;

namespace PBL3.View
{
    public partial class AddNV : Form
    {
        public string MaNhanVien { get; set; }
        public delegate void MyDel(string MaNhanVien);
        public MyDel d { get; set; }
        public AddNV(string m)
        {
            InitializeComponent();
            MaNhanVien = m;
            GUI();
            txtUser.Enabled = false;
        }
        bool kt = false;
        public void GUI()
        {
            if (QLTTNV.Instance.GetTTNVByMNV(MaNhanVien) != null)
            {
                txtMNV.Enabled = false;
                panelTTTK.Visible = false;
                txtMNV.Text = MaNhanVien;
                txtTNV.Text = QLTTNV.Instance.GetTTNVByMNV(MaNhanVien).TenNhanVien;
                if(QLTTNV.Instance.GetTTNVByMNV(MaNhanVien).GioiTinh == true)
                {
                    rbtnMale.Checked = true;
                }    
                else rbtnFemale.Checked = true;
                txtSDT.Text = QLTTNV.Instance.GetTTNVByMNV(MaNhanVien).SDT.ToString();
                txtDC.Text = QLTTNV.Instance.GetTTNVByMNV(MaNhanVien).DiaChi;
                txtCCCD.Text = QLTTNV.Instance.GetTTNVByMNV(MaNhanVien).CCCD;
                dateTimePickerNS.Value = (DateTime)QLTTNV.Instance.GetTTNVByMNV(MaNhanVien).NgaySinh;
                txtPW.Text = QLTTNV.Instance.GetTTNVByMNV(MaNhanVien).TAIKHOAN.MatKhau;
                kt = true;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {

            THONGTINNHANVIEN tt = new THONGTINNHANVIEN
            {
                MaNhanVien = txtMNV.Text,
                TenNhanVien = txtTNV.Text,
                GioiTinh = rbtnMale.Checked,
                SDT = txtSDT.Text,
                DiaChi = txtDC.Text,
                CCCD = txtCCCD.Text,
                NgaySinh = dateTimePickerNS.Value,
                Time_Login = new DateTime(2020, 1, 1),
                TrangThai = false,
                MaChucVu = "ST",
            };
            TAIKHOAN tk = new TAIKHOAN
            {
                MaNhanVien = txtMNV.Text,
                MatKhau = txtPW.Text,
                Quyen = 0
            };
            if (kt == false)
            {
                if (QLTTNV.Instance.CheckMNV(txtMNV.Text))
                {
                    QLTTNV.Instance.AddNV(tt);
                    QLTTNV.Instance.AddTK(tk);
                    d("");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng nhập mã khác!");
                }
            }
            else
            {
                QLTTNV.Instance.UpdateNV(tt);
                d("");
                this.Dispose();
            }
        }
        private static bool IsNumber(string val)
        {
            if (val != "")
                return Regex.IsMatch(val, @"^[0-9]\d*\.?[0]*$");
            else return true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtSDT.Text) != true)
            {
                MessageBox.Show("Chỉ được nhập số!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Clear();
            }
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtCCCD.Text) != true)
            {
                MessageBox.Show("Chỉ được nhập số!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCCCD.Clear();
            }
        }

        private void txtMNV_TextChanged(object sender, EventArgs e)
        {
            txtUser.Text = txtMNV.Text;
        }
    }
}
