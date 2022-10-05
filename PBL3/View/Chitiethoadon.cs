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
    public partial class Chitiethoadon : Form
    {
        public Chitiethoadon()
        {
            InitializeComponent();
            Creatable();
            StartPosition = FormStartPosition.CenterScreen;
        }
        public void Creatable()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn { ColumnName = "MaHoaDon", DataType = typeof(string) },
                new DataColumn { ColumnName = "MaThucUong", DataType = typeof(string) },
                new DataColumn { ColumnName = "DonGia", DataType = typeof(double) },
                new DataColumn { ColumnName = "SoLuong", DataType = typeof(int) },
            });
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
