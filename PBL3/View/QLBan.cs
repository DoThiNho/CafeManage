using PBL3.BLL;
using PBL3.DTO;
using PBL3.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class QLBan : Form
    {
        QLCF db = new QLCF();
        List<Button> listTable = new List<Button>();
        private string MNV { get; set; }
        public QLBan(string m)
        {
            MNV = m;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
            LoadTable();
            LoadLDU();
            var list = db.BANs.Select(s => new { s.MaBan, s.TenBan, s.TrangThai });
            dataGridView1.DataSource = list.ToList();  
        }
        public void LoadTable()
        {
            listTable.Clear();
            flpTable.Controls.Clear();
            List<BAN> list = QLBan_BLL.Instance.GetAllBan();
            foreach(BAN b in list)
            {
                Button btn = new Button() { Width = 190, Height = 220 };
                btn.Text = b.TenBan;
                btn.Tag = b;
                btn.Name = b.MaBan;
                btn.Image = ((System.Drawing.Image)(Resources.Ban1));
                btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.Click += new System.EventHandler(btn_Click);
                if(b.TrangThai == true)
                {
                    string MHD = QLBan_BLL.Instance.GetMHDByMB(b.MaBan);
                    if (MHD != null)
                    {
                        btn.BackColor = Color.Gold;
                    }    
                    else
                    {
                        btn.BackColor = Color.RoyalBlue;
                    }    
                }  
                if(b.TrangThai == false)
                {
                    btn.BackColor = Color.RoyalBlue;
                }    
                listTable.Add(btn);
                flpTable.Controls.Add(btn);
            }    

        }
        public void LoadLDU()
        {
            List<LOAIDOUONG> list = QLMENU.Instance.GetAllLDU();
            foreach(LOAIDOUONG i in list)
            {
                Button btn = new Button() { Width = 250, Height = 100};
                btn.Text = i.TenLoaiThucUong;
                btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.BackColor = Color.RoyalBlue;
                btn.ForeColor = Color.White;
                btn.Click += new System.EventHandler(L1_Click);
                flpDU.Controls.Add(btn);
            }    
        }
        public void LoadDU(string Name)
        {
            List<DOUONG> list = QLMENU.Instance.GetAllDoUong();
            foreach (DOUONG i in list)
            {
                if (i.LOAIDOUONG.TenLoaiThucUong == Name)
                {
                    Button btn = new Button() { Width = 250, Height = 100 };
                    btn.Text = i.TenThucUong;
                    btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                    btn.Click += new System.EventHandler(Oder_Click);
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.BackColor = Color.LightBlue;
                    flpLDU.Controls.Add(btn);
                }
            }
        }
        private void L1_Click(object sender, EventArgs e)
        {
            flpLDU.Controls.Clear();
            Button b = (Button)sender;
            string Name = b.Text;
            LoadDU(Name);
        }
        public void ShowBill(string MB)
        {
            dataGridView2.Rows.Clear();
            double Total = 0;
            string MHD = QLBan_BLL.Instance.GetMHDByMB(MB);
            if(MHD != "")
            {
                if (QLBan_BLL.Instance.CheckTT(MB) == 1)
                {
                    if (QLBan_BLL.Instance.GetHDByMHD(MHD).TrangThaiThanhToan == false)
                    {
                        foreach (DoUong_View duv in QLBan_BLL.Instance.GetDoUong_Views(MHD))
                        {
                            Total += duv.ThanhTien;
                            dataGridView2.Rows.Add(duv.TenDoUong, duv.Soluong, duv.Gia, duv.ThanhTien);
                        }
                    }
                }
            }    
            txtTongTien.Text = Total.ToString();
        }
        public void btn_Click(object sender, EventArgs e)
        {
            string MB = ((sender as Button).Tag as BAN).MaBan;
            dataGridView2.Tag = (sender as Button).Tag;
            txtTenBan.Text = (sender as Button).Text;
            ShowBill(MB);
        }
        private void ShowBan()
        {
            dataGridView1.DataSource = QLBan_BLL.Instance.GetAllBan();
            dataGridView1.Columns["BANTHANHTOANs"].Visible = false;
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            flpTable.Controls.Clear();
            Ban b = new Ban("");
            b.d += new Ban.Mydel(ShowBan);
            b.d1 += new Ban.Mydel(LoadTable);
            b.Show();
        }
        public void DoiMau(string MB, bool check)
        {
            foreach (Button i in listTable)
            {
                if (i.Name == MB && check == true)
                {
                    i.BackColor = Color.Gold;
                    break;
                }
                if (i.Name == MB && check == false)
                {
                    i.BackColor = Color.RoyalBlue;
                    break;
                }
 
            }
        }
        private void Oder_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            BAN b = dataGridView2.Tag as BAN;
            if (b != null)
            {
                QLBan_BLL.Instance.Order(btn.Text, b.MaBan, MNV);
                DoiMau(b.MaBan, true);
                ShowBill(b.MaBan);
                ShowBan();
            }
            else
                MessageBox.Show("Vui lòng chọn bàn trước khi order!");
        }
        private void butDel_Click(object sender, EventArgs e)
        {
            flpTable.Controls.Clear();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    string MaBan = i.Cells["MaBan"].Value.ToString();
                    if(Convert.ToBoolean(i.Cells["TrangThai"].Value.ToString()) == true)
                    {
                        MessageBox.Show("Bàn đang có khách, không thể xóa!");
                    }
                    else
                        QLBan_BLL.Instance.DelBan(MaBan);
                }
                ShowBan();
                LoadTable();
            }
        }
        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                flpTable.Controls.Clear();
                string MB = dataGridView1.SelectedRows[0].Cells["MaBan"].Value.ToString();
                Ban b = new Ban(MB);
                b.d += new Ban.Mydel(ShowBan);
                b.d1 += new Ban.Mydel(LoadTable);
                b.Show();
            }
        }
        private void butSearch_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = QLBan_BLL.Instance.GetBanBySearch(txtSearch.Text);
        }
        private void butGiam_Click(object sender, EventArgs e)
        {
            BAN b = dataGridView2.Tag as BAN;
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string TTU = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                QLBan_BLL.Instance.GiamTU(TTU, b.MaBan);
                ShowBill(b.MaBan);
            }
        }
        private void butPayment_Click(object sender, EventArgs e)
        {
            BAN b = dataGridView2.Tag as BAN;
            int s = 0;
            for(int i = 0;i < dataGridView2.Rows.Count - 1;i++)
            {
                s += int.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString());
            }
            string txt = "Tổng tiền của bàn này là : " + s + "\n" + "Bạn có muốn xác nhận và in hóa đơn không ?";
            DialogResult dlr = MessageBox.Show(txt, "Thông báo",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                Inhoadon(); 
            }
        }
        public void Inhoadon()
        {
            pddHoaDon.Document = pdHoaDon;
            pddHoaDon.ShowDialog();
        }
        private void pdHoaDon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            BAN b = dataGridView2.Tag as BAN;
            string MHD = QLBan_BLL.Instance.GetMHDByMB(b.MaBan);
            string TenBan = "";
            foreach (string i in QLBan_BLL.Instance.GetMBByMHD(MHD))
            {
                if (TenBan == "")
                {
                    TenBan = QLBan_BLL.Instance.GetTBByMB(i);
                }
                else TenBan = TenBan + " + " + QLBan_BLL.Instance.GetTBByMB(i);
            }
            //Lấy bề rộng của giấy in
            var hd = pdHoaDon.DefaultPageSettings.PaperSize.Width;
            //Vẽ header của bill
            e.Graphics.DrawString("StarBug".ToUpper(), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(300, 20));
            //Tên nhân viên
            e.Graphics.DrawString("Tên nhân viên : " + QLTTNV.Instance.GetTTNVByMNV(MNV).TenNhanVien, new Font("Courier New", 12, FontStyle.Bold),
                                    Brushes.Black, new Point(100, 50));
            //Tên bàn
            e.Graphics.DrawString("Tên bàn : " + txtTenBan.Text, new Font("Courier New", 12, FontStyle.Bold),
                                    Brushes.Black, new Point(100, 80));
            //Thời gian in hóa đơn
            e.Graphics.DrawString(String.Format("{0}", "Ngày in hóa đơn : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm")), new Font("Courier New", 12, FontStyle.Bold),
                                    Brushes.Black, new Point(100, 110));
            var y = 150;
            e.Graphics.DrawString("Tên mặt hàng", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(100, y));
            e.Graphics.DrawString("Số lượng", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(300, y));
            e.Graphics.DrawString("Đơn giá", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(hd / 2, y));
            e.Graphics.DrawString("Thành tiền", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(hd - 300, y));   
            y += 20;
            foreach (DoUong_View duv in QLBan_BLL.Instance.GetDoUong_Views(MHD))
            {
                    e.Graphics.DrawString(duv.TenDoUong, new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(100, y));
                    e.Graphics.DrawString(duv.Soluong.ToString(), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(300, y));
                    e.Graphics.DrawString(duv.Gia.ToString(), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(hd / 2, y));
                    e.Graphics.DrawString(duv.ThanhTien.ToString(), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(hd - 300, y));
                    y += 20;
            }
            y += 20;
            e.Graphics.DrawString(String.Format("Tổng tiền : {0:N0} VND", Convert.ToDouble(txtTongTien.Text)), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(hd - 400, y));

            y += 40;
            e.Graphics.DrawString("Xin chân thành cảm ơn quý khách!", new Font("Courier New", 12, FontStyle.Italic), Brushes.Black, new Point(hd / 2 - 200, y));

            foreach (string i in QLBan_BLL.Instance.GetMBByMHD(MHD))
            {
                QLBan_BLL.Instance.UpdateTTB(i, false);
                ShowBill(i);
                DoiMau(i, false);
            }
            QLBan_BLL.Instance.UpdateTTHD(MHD);
        }
        private void butChuyenBan_Click(object sender, EventArgs e)
        {
            BAN b = dataGridView2.Tag as BAN;
            ChuyenBan cb = new ChuyenBan(b.TenBan);
            cb.d += new ChuyenBan.Mydel(LoadTable);
            cb.ShowDialog();
            ShowBan();
        }

        private void butGopBan_Click(object sender, EventArgs e)
        {
            BAN b = dataGridView2.Tag as BAN;
            GopBan cb = new GopBan(b.TenBan);
            cb.d += new GopBan.Mydel(LoadTable);
            cb.ShowDialog();
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            BAN b = dataGridView2.Tag as BAN;
            List<string> list = new List<string>();
            string MHD = QLBan_BLL.Instance.GetMHDByMB(b.MaBan);
            list = QLBan_BLL.Instance.GetMBByMHD(MHD);
            if (MHD != "")
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn hủy bill không !", "Thông báo",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    if (QLBan_BLL.Instance.CheckTT(b.MaBan) == 1)
                    {
                        if (QLBan_BLL.Instance.GetHDByMHD(MHD).TrangThaiThanhToan == false)
                        {
                            string MBTT = QLBan_BLL.Instance.GetMBTTByMB(b.MaBan);
                            foreach (CHITIETHOADON i in QLBan_BLL.Instance.GetCHTHByMHD(MHD))
                            {
                                QLBan_BLL.Instance.DelCTHD(i);
                            }
                            QLBan_BLL.Instance.UpdateTTB(b.MaBan, false);
                            QLBan_BLL.Instance.DelBTT(MBTT);
                            QLBan_BLL.Instance.DelHD(MHD);
                            foreach (string i in list)
                            {
                                QLBan_BLL.Instance.UpdateTTB(i, false);
                                ShowBill(i);
                                DoiMau(i, false);
                            }
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Bàn này hiện không có thức uống!");
            }    
        }

        private void butTach_Click(object sender, EventArgs e)
        {
            BAN b = dataGridView2.Tag as BAN;
            TachBan cb = new TachBan(MNV);
            cb.d += new TachBan.Mydel(LoadTable);
            cb.ShowDialog();
        }
    }
}

