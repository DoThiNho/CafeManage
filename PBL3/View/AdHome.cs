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
    public partial class AdHome : Form
    {
        string MNV { get; set; }
        public AdHome(string m)
        {
            MNV = m;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnQL_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin(MNV);
            this.Visible = false;
            ad.ShowDialog();
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            login lg = new login();
            this.Visible = false;
            lg.ShowDialog();
        }
    }
}
