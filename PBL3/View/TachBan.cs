using PBL3.BLL;
using PBL3.DTO;
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
    public partial class TachBan : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        private string MNV { get; set; }
        public TachBan(string m)
        {
            MNV = m;
            InitializeComponent();
            foreach (BAN s in QLBan_BLL.Instance.GetBanByTT())
            {
                cbbTuBan.Items.Add(new CBBItem
                {
                    Value = s.MaBan,
                    Text = s.TenBan
                });
            }
        }

        private void cbbTuBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbDenBan.Items.Clear();
            foreach (BAN s in QLBan_BLL.Instance.GetAllBan())
            {
                if (s.MaBan != ((CBBItem)cbbTuBan.SelectedItem).Value)
                {
                    cbbDenBan.Items.Add(new CBBItem
                    {
                        Value = s.MaBan,
                        Text = s.TenBan
                    });
                }
            }
            dataGridView1.DataSource = QLBan_BLL.Instance.GetDoUong_ViewByMB(((CBBItem)cbbTuBan.SelectedItem).Value);
        }

        private void cbbDenBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = QLBan_BLL.Instance.GetDoUong_ViewByMB(((CBBItem)cbbDenBan.SelectedItem).Value);
        }

        private void butTach_Click(object sender, EventArgs e)
        {
            string MB1 = ((CBBItem)cbbTuBan.SelectedItem).Value;
            string MB2 = ((CBBItem)cbbDenBan.SelectedItem).Value;
            List<DoUong_View> list = new List<DoUong_View>();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    string TTU = i.Cells[0].Value.ToString();
                    list.Add(QLBan_BLL.Instance.GetDoUongView_ByName(TTU));
                }
                QLBan_BLL.Instance.TachBan(MB1, MB2, list, MNV);
            }
            else MessageBox.Show("Chưa có đồ uống được chọn!");
            dataGridView1.DataSource = QLBan_BLL.Instance.GetDoUong_ViewByMB(MB1);
            dataGridView2.DataSource = QLBan_BLL.Instance.GetDoUong_ViewByMB(MB2);
            d();
        }

        private void butHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
