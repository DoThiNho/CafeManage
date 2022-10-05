using PBL3.BLL;
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
    public partial class NVHome : Form
    {
        string MNV { get; set; }
        public NVHome(string m)
        {
            MNV = m;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
            if(DiemDanh_BLL.Instance.CheckDiemDanh(MNV) == false)
            {
                btnCheck_Out.Enabled = false;
            }    
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

        private void btnQLBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLBan(MNV));
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            login lg = new login();
            this.Visible = false;
            lg.ShowDialog();
        }

        private void btnDD_Click(object sender, EventArgs e)
        {
            if (DiemDanh_BLL.Instance.CheckDiemDanh(MNV) == false)
            {
                DiemDanh_BLL.Instance.DiemDanh(MNV);
                MessageBox.Show("Bạn đã điểm danh vào lúc " + DateTime.Now.ToString());
                btnCheck_Out.Enabled = true;
            }
            else
            {
                MessageBox.Show("Bạn đã điểm danh!");
            }    
        }

        private void btnCN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinCaNhan(MNV));
        }
        public void ResetDiemDanh()
        {
            DiemDanh_BLL.Instance.ResetDiemDanh(MNV);
        }

        private void btnCheck_Out_Click(object sender, EventArgs e)
        {
            DateTime checkout = DateTime.Now;
            DiemDanh_BLL.Instance.TinhCong(MNV, checkout);
            ResetDiemDanh();
            MessageBox.Show("Thời gian check out" + checkout.ToString());
            btnCheck_Out.Enabled = false;
        }
    }
}
