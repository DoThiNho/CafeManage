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
    public partial class Admin : Form
    {
        string MNV { get; set; }
        public Admin(string m)
        {
            MNV = m;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.WindowState = FormWindowState.Maximized;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void butQLNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLNV());
        }

        private void butQLDU_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLDoUong());
        }

        private void butQLDT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLDoanhThu());
        }

        private void butQLB_Click(object sender, EventArgs e)
        {
            QLBan f = new QLBan(MNV);
            OpenChildForm(f);
            
        }

        private void butTKLuong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKeLuong());
        }
        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            AdHome ad = new AdHome(MNV);
            this.Visible = false;
            ad.ShowDialog();

        }

        private void btnCaNhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinCaNhan(MNV));
        }
    }
}
