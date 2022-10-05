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

namespace PBL3
{
    public partial class ChuyenBan : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        public ChuyenBan(string TB)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            foreach (BAN s in QLBan_BLL.Instance.GetBanByTT())
            {
                cbbTuBan.Items.Add(new CBBItem
                {
                    Value = s.MaBan,
                    Text = s.TenBan
                });
            }
            foreach (CBBItem i in cbbTuBan.Items)
            {
                if (i.Text == TB)
                {
                    cbbTuBan.SelectedItem = i;
                }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string MB1 = ((CBBItem)cbbTuBan.SelectedItem).Value;
            string MB2 = ((CBBItem)cbbDenBan.SelectedItem).Value;
            QLBan_BLL.Instance.ChuyenBan(MB1, MB2);
            this.Dispose();
            d();
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
