using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeriesChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType;
using System.Windows.Forms.DataVisualization.Charting;
/*using System.Web.UI.DataVisualization.Charting;*/
using PBL3.DTO;
using PBL3.BLL;

namespace PBL3.View
{
    public partial class BieuDoDoanhThu : Form
    {
        QLCF db = new QLCF();
        public BieuDoDoanhThu()
        {
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            List<int> year = new List<int>();
            var l = db.HOADONs.Select(s => new
            {
                s.Ngay.Year
            }).Distinct().ToList();
            foreach (var i in l)
            {
                cbbYear.Items.Add(i.Year);
            }
            cbbYear.SelectedIndex = 0;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            List<DoanhThuOrLuong_Thang> data = new List<DoanhThuOrLuong_Thang>();
            data = QLBieuDo_BLL.Instance.GetDoanhThuThang_View(QLDoanhThu_BLL.Instance.GetDoanhThu_Thang(Convert.ToInt32(cbbYear.SelectedItem)));
            int index = 0;
            foreach (var i in data)
            {
                chart1.Series["Doanh thu"].Points.AddXY(i.Thang, i.Tong);
                chart1.Series["Doanh thu"].Points[index].Label = i.Tong.ToString();
                ++index;
            }
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            chart1.Legends.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
