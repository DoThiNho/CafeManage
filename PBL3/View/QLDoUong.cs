using PBL3.BLL;
using PBL3.DTO;
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
    public partial class QLDoUong : Form
    {
        public QLDoUong()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
            dataGridViewDoUong.DataSource = QLMENU.Instance.GetAllDoUongView(QLMENU.Instance.GetAllDoUong());
        }
        private void ShowMENU(string MaThucUong)
        {
            dataGridViewDoUong.DataSource = QLMENU.Instance.GetAllDoUongView(QLMENU.Instance.GetDUBySearch(txtSearch.Text));
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUpdateDU f = new AddUpdateDU(null);
            f.d += new AddUpdateDU.MyDel(ShowMENU);
            f.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoUong.SelectedRows.Count == 1)
            {
                string MaThucUong = dataGridViewDoUong.SelectedRows[0].Cells["MaThucUong"].Value.ToString();
                AddUpdateDU f = new AddUpdateDU(MaThucUong);
                f.d = new AddUpdateDU.MyDel(ShowMENU);
                f.Show();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoUong.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dataGridViewDoUong.SelectedRows)
                {
                    string MaThucUong = i.Cells["MaThucUong"].Value.ToString();
                    QLMENU.Instance.DelDoUong(MaThucUong);
                }
                ShowMENU("");
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridViewDoUong.DataSource = QLMENU.Instance.GetAllDoUongView(QLMENU.Instance.GetDUBySearch(txtSearch.Text));
        }
        private void dataGridViewDoUong_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoUong.SelectedRows.Count == 1)
            {
                DOUONG mn = new DOUONG();
                string MaThucUong = dataGridViewDoUong.SelectedRows[0].Cells["MaThucUong"].Value.ToString();
                mn = QLMENU.Instance.GetDoUongByMDU(MaThucUong);
                txtMDU.Text = mn.MaThucUong;
                txtTDU.Text = mn.TenThucUong;
                txtTLTU.Text = mn.LOAIDOUONG.TenLoaiThucUong;
                txtGia.Text = mn.DonGia.ToString();
            }
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Mã đồ uống hoặc Tên đồ uống";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Mã đồ uống hoặc Tên đồ uống")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void butThongKe_Click(object sender, EventArgs e)
        {
            BieuDoDoUong f = new BieuDoDoUong();
            f.Show();
        }

    }
    }


