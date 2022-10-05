using PBL3.BLL;
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
using PBL3.DTO;

namespace PBL3.View
{
    public partial class Ban : Form
    {
        Button[,] buttons = new Button[3,4];
        public delegate void Mydel();
        public Mydel d { get; set; }
        public Mydel d1 { get; set; }
        private string MB { get; set; }
        public Ban(string m)
        {
            MB = m;
            InitializeComponent();
            txtMaBan.Text = "B";
            GUI(MB);
        }
        private void Ban_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BAN b = new BAN
            {
                MaBan = txtMaBan.Text,
                TenBan = txtTenBan.Text,
                TrangThai = false,
            };
            QLBan_BLL.Instance.AddUpdate(b);
            d();
            d1();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void GUI(string MB)
        {
            BAN b = QLBan_BLL.Instance.GetBanByMB(MB);
            if (b != null)
            {
                txtMaBan.Text = b.MaBan;
                txtTenBan.Text = b.TenBan;
            }    
        }
    }
}
