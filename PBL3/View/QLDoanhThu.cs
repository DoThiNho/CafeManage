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
    public partial class QLDoanhThu : Form
    {
        QLCF db = new QLCF();
        public QLDoanhThu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
            cbbSort.SelectedIndex = 0;
            dataGridView1.DataSource = QLDoanhThu_BLL.Instance.GetDoanhThu_Views(QLDoanhThu_BLL.Instance.GetAllHoaDon());
        }

        private void butSort_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = QLDoanhThu_BLL.Instance.GetDoanhThu_Views(QLDoanhThu_BLL.Instance.SortDT(cbbSort.SelectedItem.ToString()));
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = QLDoanhThu_BLL.Instance.GetDoanhThu_Views(QLDoanhThu_BLL.Instance.GetHoaDonBySearch(dateSearch.Value));
        }

        private void butThongKe_Click(object sender, EventArgs e)
        {
            BieuDoDoanhThu f = new BieuDoDoanhThu();
            f.Show();
        }

        private void butHienThi_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = QLDoanhThu_BLL.Instance.GetHoaDonTheoDate(dateTungay.Value, dateDenNgay.Value).Select(s => new
            {
                MaHoaDon = s.MaHoaDon,
                MaNhanVien = s.MaNhanVien,
                Ngay = s.Ngay,
                TongTien = s.TongTien,
            }).ToList();
        }
    }
}
