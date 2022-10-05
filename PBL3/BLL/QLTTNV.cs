using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class QLTTNV
    {
        QLCF db = new QLCF();
        private static QLTTNV _Instance;
        public static QLTTNV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLTTNV();
                }
                return _Instance;
            }
            private set { }
        }
        private QLTTNV()
        {

        }
        public List<THONGTINNHANVIEN> GetAllTTNV()
        {
            var l = db.THONGTINNHANVIENs.Select(s => s);
            return l.ToList();
        }
        public List<TTNV_View> GetAllTTNVView(List<THONGTINNHANVIEN> list)
        {
            List<TTNV_View> v = new List<TTNV_View>();
            foreach (THONGTINNHANVIEN i in list)
            {
                v.Add(new TTNV_View
                {
                    MaNhanVien = i.MaNhanVien,
                    TenNhanVien = i.TenNhanVien,
                    GioiTinh = i.GioiTinh,
                    SDT = i.SDT
                });
            }
            return v;
        }
        public THONGTINNHANVIEN GetTTNVByMNV(string MaNhanVien)
        {
            THONGTINNHANVIEN t = null;
            t = db.THONGTINNHANVIENs.Find(MaNhanVien);
            return t;
        }
        public void AddNV(THONGTINNHANVIEN t)
        {

            db.THONGTINNHANVIENs.Add(t);
            db.SaveChanges();
        }
        public void UpdateNV(THONGTINNHANVIEN t)
        {
            var nv = db.THONGTINNHANVIENs.Find(t.MaNhanVien);
            nv.MaNhanVien = t.MaNhanVien;
            nv.TenNhanVien = t.TenNhanVien;
            nv.GioiTinh = t.GioiTinh;
            nv.SDT = t.SDT;
            nv.DiaChi = t.DiaChi;
            nv.CCCD = t.CCCD;
            nv.NgaySinh = t.NgaySinh;
            db.SaveChanges();
        }
/*        public bool Check(string MaNhanVien)
        {
            bool Add = true;
            foreach (THONGTINNHANVIEN i in GetAllTTNV())
            {
                if (i.MaNhanVien.Equals(MaNhanVien))
                    Add = false;
            }
            return Add;
        }*/
/*        public void AddUpdate(THONGTINNHANVIEN t)
        {
            if (Check(t.MaNhanVien))
            {
                AddNV(t);
            }
            else
            {
                UpdateNV(t);
            }
        }*/
        public void DelNV(string MaNhanVien)
        {
            var l = db.THONGTINNHANVIENs.Find(MaNhanVien);
            db.THONGTINNHANVIENs.Remove(l);
            db.SaveChanges();
        }
        public List<THONGTINNHANVIEN> GetNVBySearch(string txt)
        {
            if (txt == "Mã nhân viên hoặc Tên")
            {
                return GetAllTTNV();
            }
            else
            {
                var l2 = db.THONGTINNHANVIENs.Where(s => s.MaNhanVien.Contains(txt) || s.TenNhanVien.Contains(txt));
                return l2.ToList();
            }
        }

        public List<TAIKHOAN> GetAllTK()
        {
            var l = db.TAIKHOANs.Select(s => s);
            return l.ToList();
        }
        public List<CHUCVU> GetAllCV()
        {
            var l = db.CHUCVUs.Select(s => s);
            return l.ToList();
        }
        public List<TKNV_View> GetAllTKView(List<TAIKHOAN> list)
        {
            List<TKNV_View> v = new List<TKNV_View>();
            foreach (TAIKHOAN i in list)
            {
                v.Add(new TKNV_View
                {
                    MaNhanVien = i.MaNhanVien,
                    TenNhanVien = i.THONGTINNHANVIEN.TenNhanVien,
                    MatKhau = i.MatKhau
                });
            }
            return v;
        }
        public TAIKHOAN GetTKByMNV(string MaNhanVien)
        {
            TAIKHOAN t = null;
            t = db.TAIKHOANs.Find(MaNhanVien);
            return t;
        }
        public List<TAIKHOAN> GetTKBySearch(string txt)
        {
            if (txt == "User hoặc Tên")
            {
                return GetAllTK();
            }
            else
            {
                var l2 = db.TAIKHOANs.Where(s => s.MaNhanVien.Contains(txt) || s.THONGTINNHANVIEN.TenNhanVien.Contains(txt));
                return l2.ToList();
            }
        }
        public void AddTK(TAIKHOAN tk)
        {
            db.TAIKHOANs.Add(tk);
            db.SaveChanges();
        }
        public bool CheckMNV(string MaNhanVien)
        {
            bool check_Add = true;
            foreach (THONGTINNHANVIEN i in GetAllTTNV())
            {
                if (i.MaNhanVien.Equals(MaNhanVien))
                    check_Add = false;
            }
            return check_Add;
        }             
        public void DelTK(string MaNhanVien)
        {
            var l = db.TAIKHOANs.Find(MaNhanVien);
            db.TAIKHOANs.Remove(l);
            db.SaveChanges();
        }
        public void ResetMK(string MaNhanVien)
        {
            var nv = db.TAIKHOANs.Find(MaNhanVien);
            nv.MatKhau = MaNhanVien;
            db.SaveChanges();
        }
    }
}
