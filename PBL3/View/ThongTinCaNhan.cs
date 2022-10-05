using PBL3.BLL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class ThongTinCaNhan : Form
    {
        private string MSNV;
        public ThongTinCaNhan(string m)
        {
            MSNV = m;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
            StartPosition = FormStartPosition.CenterScreen;

            foreach (CHUCVU i in QLTTNV.Instance.GetAllCV())
            {
                cbbChucVu.Items.Add(new CBBItem
                {
                    Value = i.MaChucVu,
                    Text = i.TenChucVu
                });
            }
            SetThongTin();
            
        }
        public void SetThongTin()
        {
            THONGTINNHANVIEN nv = new THONGTINNHANVIEN();
            nv = QLTTNV.Instance.GetTTNVByMNV(MSNV);
            txtName.Text = nv.TenNhanVien;
            string MNV = nv.MaChucVu;
            if(nv.MaChucVu == "ST")
            {
                cbbChucVu.Enabled = false;
            }
            else
            {
                txtNL.Visible = false;
                label12.Visible = false;
            }
            foreach (CBBItem i in cbbChucVu.Items)
            {
                if (i.Value == MNV)
                {
                    cbbChucVu.SelectedItem = i;
                }
            }
            txtMNV.Text = MSNV;
            txtMNV.Enabled = false;
            txtSDT.Text = nv.SDT.ToString();
            if(nv.GioiTinh == false)
            {
                rbtnMale.Checked = true;
            }
            else rbtnFemale.Checked = true;
            txtCCCD.Text = nv.CCCD;
            dateNS.Value = nv.NgaySinh;
            txtAddress.Text = nv.DiaChi;
            txtNL.Text = DiemDanh_BLL.Instance.TongLuongNhanVien(MSNV).ToString();
            txtNL.Enabled = false;
            txtTK.Text = MSNV;
            txtTK.Enabled = false;
            txtMK.Text = QLDANGNHAP.Instance.GetDangNhapByMNV(MSNV).MatKhau;
            txtMK.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau(txtMNV.Text);
            dmk.d += new DoiMatKhau.Mydel(SetThongTin);
            dmk.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool GT = false;
            if (rbtnFemale.Checked == true)
            {
                GT = true;
            }
            THONGTINNHANVIEN tt = new THONGTINNHANVIEN
            {
                MaNhanVien = txtMNV.Text,
                TenNhanVien = txtName.Text,
                GioiTinh = GT,
                MaChucVu = ((CBBItem)cbbChucVu.SelectedItem).Value,
                SDT = txtSDT.Text,
                DiaChi = txtAddress.Text,
                CCCD = txtCCCD.Text,
                NgaySinh = dateNS.Value,
            };
            QLTTNV.Instance.UpdateNV(tt);
            MessageBox.Show("Cập nhật thông tin thành công!", "Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private static bool IsNumber(string val)
        {
            if (val != "")
                return Regex.IsMatch(val, @"^[0-9]\d*\.?[0]*$");
            else return true;
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

    }
}
