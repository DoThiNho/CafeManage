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
using PBL3.BLL;

namespace PBL3.View
{
    public partial class BieuDoDoUong : Form
    {
        QLCF db = new QLCF();
        public BieuDoDoUong()
        {
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            cbbLoaiThongKe.Items.Add(new CBBItem { Value = "0", Text = "Loại thức uống" });
            cbbLoaiThongKe.Items.Add(new CBBItem { Value = "1", Text = "Thức uống" });
            cbbLoaiThongKe.SelectedIndex = 0;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void cbbLoaiThongKe_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbLoaiThongKe.SelectedIndex != 0)
            {
                cbbLoaiThucUong.Items.Clear();
                cbbLoaiThucUong.Items.AddRange(QLLoaiDU.Instance.GetLoaiDU().ToArray());
                cbbLoaiThucUong.SelectedIndex = 0;
            }
            else
            {
                cbbLoaiThucUong.Text = "";
                cbbLoaiThucUong.Items.Clear();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            chart1.Series["Thuc uong"].Points.Clear();
            if (cbbLoaiThucUong.SelectedItem != null)
            {
                chart1.Titles[0].Text = "BIỂU ĐỒ THỨC UỐNG";
                List<DoUongOrLoaiDoUong_ThongKe> data = new List<DoUongOrLoaiDoUong_ThongKe>();
                data = QLBieuDo_BLL.Instance.ThongKeDoUong(QLBieuDo_BLL.Instance.GetCHITIETHOADONsByMaLoaiThucUong(cbbLoaiThucUong.SelectedItem.ToString()));
                int index = 0;
                foreach (var i in data)
                {
                    chart1.Series["Thuc uong"].Points.AddXY(i.Name, i.SoLuong);
                    chart1.Series[0].Points[index].LegendText = i.Name;
                    ++index;
                }
            }
            else
            {
                chart1.Titles[0].Text = "BIỂU ĐỒ LOẠI THỨC UỐNG";
                List<DoUongOrLoaiDoUong_ThongKe> data = new List<DoUongOrLoaiDoUong_ThongKe>();
                data = QLBieuDo_BLL.Instance.ThongKeLoaiDoUong(QLBieuDo_BLL.Instance.GetAllChiTietHoaDon());
                int index = 0;
                foreach (var i in data)
                {
                    chart1.Series["Thuc uong"].Points.AddXY(i.Name, i.SoLuong);
                    chart1.Series[0].Points[index].LegendText = i.Name;
                    ++index;
                }
            }
        }
    }
}
