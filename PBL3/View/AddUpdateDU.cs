using PBL3.BLL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class AddUpdateDU : Form
    {
        public string MaThucUong { get; set; }

        public delegate void MyDel(string MaThucUong);
        public MyDel d { get; set; }
        public AddUpdateDU(string m)
        {
            InitializeComponent();
            MaThucUong = m;
            GUI();
        }
        bool kt = false;
        public void GUI()
        {
            SetCBB();
            DOUONG mn = new DOUONG();
            mn = QLMENU.Instance.GetDoUongByMDU(MaThucUong);
            if (QLMENU.Instance.GetDoUongByMDU(MaThucUong) != null)
            {
                cbbLTU.Enabled = false;
                txtMTU.Enabled = false;
                txtTTU.Enabled = false;
                txtMTU.Text = MaThucUong;
                foreach (CBBItem i in cbbLTU.Items)
                {
                    if (mn.MaLoaiThucUong == i.Value)
                    {
                        cbbLTU.SelectedItem = i;
                    }
                }
                txtTTU.Text = mn.TenThucUong;
                txtDG.Text = mn.DonGia.ToString();
                kt = true;
            } 
        }
        public void SetCBB()
        {
            cbbLTU.Items.AddRange(QLLoaiDU.Instance.GetLoaiDU().ToArray());
        }
        private static bool IsNumber(string val)
        {
            if (val != "")
                return Regex.IsMatch(val, @"^[0-9]\d*\.?[0]*$");
            else return true;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DOUONG mn = new DOUONG()
            {
                MaThucUong = txtMTU.Text,
                MaLoaiThucUong = ((CBBItem)cbbLTU.SelectedItem).Value,
                TenThucUong = txtTTU.Text,
                DonGia = Convert.ToInt32(txtDG.Text),
            };
            if (kt == false)
            {
                if (!QLMENU.Instance.Check(txtMTU.Text))
                {
                    QLMENU.Instance.AddDU(mn);
                    d("");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Mã thức uống đã tồn tại, vui lòng nhập mã khác!");
                }
            }
            else
            {
                QLMENU.Instance.UpdateDU(mn);
                d("");
                this.Dispose();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbbLTU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (QLMENU.Instance.GetDoUongByMDU(MaThucUong) == null)
            {
                string s = ((CBBItem)cbbLTU.SelectedItem).Value.ToString();
                txtMTU.Text = s + "_";
            }
        }

        private void txtDG_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtDG.Text) != true)
            {
                MessageBox.Show("Chỉ được nhập số!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDG.Clear();
            }
        }
    }
}

