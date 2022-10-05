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
using PBL3.View;

namespace PBL3
{
    public partial class ThongKeLuong : Form
    {
        public ThongKeLuong()
        {
            InitializeComponent();
            GUI();
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
        }
        public void GUI()
        {
            cbbSort.Items.AddRange(new object[]
            {
                "Mã nhân viên",
                "Tên nhân viên",
                "Lương"
            });
            cbbSort.SelectedIndex = 0;
            DateTime d = DateTime.Now;
            dataGridView1.DataSource = ThongKeLuong_BLL.Instance.GetViewNhanVien(ThongKeLuong_BLL.Instance.GetALLLuongNhanVien());
        }
        private void btn_sort_Click(object sender, EventArgs e)
        {
            List<int> ID = new List<int>();
            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                ID.Add(Convert.ToInt32(i.Cells["ID"].Value));
            }
            dataGridView1.DataSource = ThongKeLuong_BLL.Instance.Sort(ID, cbbSort.SelectedItem.ToString());
            dataGridView1.Columns[0].Visible = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;
            dataGridView1.DataSource = ThongKeLuong_BLL.Instance.GetViewNhanVien(ThongKeLuong_BLL.Instance.Search(txt));
            dataGridView1.Columns[0].Visible = false;
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            List<int> ID = new List<int>();
            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                ID.Add(Convert.ToInt32(i.Cells["ID"].Value));
            }
            txtTong.Text = (ThongKeLuong_BLL.Instance.TongLuong(ID)).ToString() + " VNĐ";
        }

        private void butHienThi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ThongKeLuong_BLL.Instance.GetViewNhanVien(ThongKeLuong_BLL.Instance.GetLuongNVTheoDate(dateTungay.Value, dateDenNgay.Value));
            dataGridView1.Columns[0].Visible = false;
        }

        private void butThongKe_Click(object sender, EventArgs e)
        {
            BieuDoLuong f = new BieuDoLuong();
            f.Show();
        }
    }
}
