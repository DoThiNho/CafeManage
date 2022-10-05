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
using PBL3.DTO;
using System.Text.RegularExpressions;

namespace PBL3
{
    public partial class QLNV : Form
    {
        public QLNV()
        {
            InitializeComponent();
            dataGridViewTTNV.DataSource = QLTTNV.Instance.GetAllTTNVView(QLTTNV.Instance.GetAllTTNV());        
        }
        private void ShowNV(string MaNhanVien)
        {
            dataGridViewTTNV.DataSource = QLTTNV.Instance.GetAllTTNVView(QLTTNV.Instance.GetNVBySearch(txtSearchNV.Text));
        }
        private void ShowTK(string MaNhanVien)
        {
            dataGridViewTK.DataSource = QLTTNV.Instance.GetAllTKView(QLTTNV.Instance.GetTKBySearch(txtSearchtk.Text));
        }
        private void btnAddNV_Click(object sender, EventArgs e)
        {
            AddNV f = new AddNV(null);
            f.d += new AddNV.MyDel(ShowNV);
            f.Show();
        }

        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            if(dataGridViewTTNV.SelectedRows.Count == 1)
            {
                string MaNhanVien = dataGridViewTTNV.SelectedRows[0].Cells["MaNhanVien"].Value.ToString();
                AddNV f = new AddNV(MaNhanVien);
                f.d = new AddNV.MyDel(ShowNV);
                f.Show();
            }
        }

        private void btnDelNV_Click(object sender, EventArgs e)
        {
            if (dataGridViewTTNV.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dataGridViewTTNV.SelectedRows)
                {
                    string MaNhanVien = i.Cells["MaNhanVien"].Value.ToString();
                    QLTTNV.Instance.DelTK(MaNhanVien);
                    QLTTNV.Instance.DelNV(MaNhanVien);
                    
                }
                ShowNV("");
            }
        }

        private void btnSearchNV_Click(object sender, EventArgs e)
        {
            dataGridViewTTNV.DataSource = QLTTNV.Instance.GetAllTTNVView(QLTTNV.Instance.GetNVBySearch(txtSearchNV.Text));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (dataGridViewTK.SelectedRows.Count == 1)
            {
                string MaNhanVien = dataGridViewTK.SelectedRows[0].Cells["MaNhanVien"].Value.ToString();
                QLTTNV.Instance.ResetMK(MaNhanVien);
                MessageBox.Show("Reset mật khẩu thành công!");
            }
            ShowTK("");
        }

        private void btnSearchtk_Click(object sender, EventArgs e)
        {
            dataGridViewTK.DataSource = QLTTNV.Instance.GetAllTKView(QLTTNV.Instance.GetTKBySearch(txtSearchtk.Text));
        }

        private void dataGridViewTTNV_Click(object sender, EventArgs e)
        {
            if (dataGridViewTTNV.SelectedRows.Count == 1)
            {
                THONGTINNHANVIEN tt = new THONGTINNHANVIEN();
                string MaNhanVien = dataGridViewTTNV.SelectedRows[0].Cells["MaNhanVien"].Value.ToString();
                tt = QLTTNV.Instance.GetTTNVByMNV(MaNhanVien);
                txtMNV.Text = tt.MaNhanVien;
                txtTNV.Text = tt.TenNhanVien;
                string GT = "";
                if (tt.GioiTinh == false)
                {
                    GT = "Nam";
                }
                else GT = "Nữ";
                txtGT.Text = GT;
                txtCV.Text = tt.CHUCVU.TenChucVu;
                txtSDT.Text = tt.SDT.ToString();
                txtDC.Text = tt.DiaChi;
                txtCCCD.Text = tt.CCCD;
                dateTimePickerNS.Value = (DateTime)tt.NgaySinh;
            }
        }

        private void dataGridViewTK_Click(object sender, EventArgs e)
        {
            if (dataGridViewTK.SelectedRows.Count == 1)
            {
                TAIKHOAN tk = new TAIKHOAN();
                string MaNhanVien = dataGridViewTK.SelectedRows[0].Cells["MaNhanVien"].Value.ToString();
                tk = QLTTNV.Instance.GetTKByMNV(MaNhanVien);
                txtUsertk.Text = tk.MaNhanVien;
                txtPWtk.Text = tk.MatKhau;
                txtCVtk.Text = tk.THONGTINNHANVIEN.CHUCVU.TenChucVu;
                txtTNVtk.Text = tk.THONGTINNHANVIEN.TenNhanVien;               
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPage == tabPage1)
            {
                dataGridViewTTNV.DataSource = QLTTNV.Instance.GetAllTTNVView(QLTTNV.Instance.GetAllTTNV());
            }
            if(e.TabPage == tabPage2)
            {
                dataGridViewTK.DataSource = QLTTNV.Instance.GetAllTKView(QLTTNV.Instance.GetAllTK());
            }
        }
        private void txtSearchNV_Enter(object sender, EventArgs e)
        {
            if (txtSearchNV.Text == "Mã nhân viên hoặc Tên")
            {
                txtSearchNV.Text = "";
                txtSearchNV.ForeColor = Color.Black;
            }
        }
        private void txtSearchNV_Leave(object sender, EventArgs e)
        {
            if (txtSearchNV.Text == "")
            {
                txtSearchNV.Text = "Mã nhân viên hoặc Tên";
                txtSearchNV.ForeColor = Color.Gray;
            }
        }
        private void txtSearchtk_Enter(object sender, EventArgs e)
        {
            if (txtSearchtk.Text == "User hoặc Tên")
            {
                txtSearchtk.Text = "";
                txtSearchtk.ForeColor = Color.Black;
            }
        }
        private void txtSearchtk_Leave(object sender, EventArgs e)
        {
            if (txtSearchtk.Text == "")
            {
                txtSearchtk.Text = "User hoặc Tên";
                txtSearchtk.ForeColor = Color.Gray;
            }
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
