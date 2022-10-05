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

namespace PBL3
{
    public partial class DoiMatKhau : Form
    {
        QLCF db = new QLCF();
        public delegate void Mydel();
        public Mydel d { get; set; }
        private string MNV;
        public DoiMatKhau(string mnv)
        {
            MNV = mnv;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void butHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void butDMK_Click(object sender, EventArgs e)
        {
            #region rang_buoc
            if (string.IsNullOrEmpty(txtMKHT.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu hiện tại", "Chú ý!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMKHT.Select();
                return; // Không thực hiện các câu lệnh phía dưới
            }
            if (string.IsNullOrEmpty(txtMKHT.Text) || string.IsNullOrEmpty(txtMKM.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới", "Chú ý!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMKM.Select();
                return; // Không thực hiện các câu lệnh phía dưới
            }
            if (!txtMKM.Text.Equals(txtNLMKM.Text))
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp", "Chú ý!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNLMKM.Select();
                return; // Không thực hiện các câu lệnh phía dưới
            }
            #endregion

            else
            {
                var tk = db.TAIKHOANs.SingleOrDefault(x => x.MaNhanVien == MNV && x.MatKhau == txtMKHT.Text);
                if (tk == null)
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng", "Chú ý!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMKHT.Select();
                    return; // Không thực hiện các câu lệnh phía dưới
                }
                tk.MatKhau = txtMKM.Text;
                QLDANGNHAP.Instance.UpdateMK(tk);
                MessageBox.Show("Đổi mật khẩu thành công!", "Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                d();
                this.Dispose();
            }
        }
    }
}
