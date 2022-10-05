using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BLL
{
    internal class QLDANGNHAP
    {
        QLCF db = new QLCF();
        private static QLDANGNHAP _Instance;
        public static QLDANGNHAP Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLDANGNHAP();
                }
                return _Instance;
            }
            private set { }
        }
        private QLDANGNHAP()
        {

        }
        public List<TAIKHOAN> GetAllTKDN()
        {
            var l1 = db.TAIKHOANs.Select(s => s);
            return l1.ToList();
        }
        public int Account(string MaNhanVien, string MatKhau)
        {
            int check = 2;
            foreach (TAIKHOAN i in GetAllTKDN())
            {
                if (i.MaNhanVien.Trim().Equals(MaNhanVien.Trim()) && i.MatKhau.Trim().Equals(MatKhau.Trim()))
                {
                    check = (int)i.Quyen;
                    break;
                }
            }
            return check;
        }
        public TAIKHOAN GetDangNhapByMNV(string MNV)
        {
            TAIKHOAN dn = null;
            dn = db.TAIKHOANs.Find(MNV);
            return dn;
        }
        public void UpdateMK(TAIKHOAN dn)
        {
            var dn1 = db.TAIKHOANs.Find(dn.MaNhanVien);
            dn1.MaNhanVien = dn.MaNhanVien;
            dn1.MatKhau = dn.MatKhau;
            dn1.Quyen = dn.Quyen;
            db.SaveChanges();
        }

    }
}
