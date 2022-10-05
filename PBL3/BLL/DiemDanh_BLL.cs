using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BLL
{
    public class DiemDanh_BLL
    {
        QLCF db = new QLCF();
        private static DiemDanh_BLL _Instance;
        public static DiemDanh_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DiemDanh_BLL();
                }
                return _Instance;
            }
            private set { }
        }
        public DiemDanh_BLL()
        {

        }
        public void DiemDanh(string MaNhanVien)
        {
            var l = db.THONGTINNHANVIENs.FirstOrDefault(t => t.MaNhanVien.Trim().Contains(MaNhanVien.Trim()));
            l.TrangThai = true;
            l.Time_Login = DateTime.Now;
            db.SaveChanges();
        }
        public bool CheckDiemDanh(string MaNhanVien)
        {
            bool check = false;
            var l = db.THONGTINNHANVIENs.FirstOrDefault(t => t.MaNhanVien.Trim().Contains(MaNhanVien.Trim()));
            THONGTINNHANVIEN data = (THONGTINNHANVIEN)l;
            check = Convert.ToBoolean(data.TrangThai);
            return check;
        }
        public void ResetDiemDanh(string MaNhanVien)
        {
            var l = db.THONGTINNHANVIENs.FirstOrDefault(t => t.MaNhanVien.Trim().Contains(MaNhanVien.Trim()));
            THONGTINNHANVIEN data = (THONGTINNHANVIEN)l;
            data = (THONGTINNHANVIEN)l;
            l.TrangThai = false;
            db.SaveChanges();
        }
        public void TinhCong(string MaNhanVien, DateTime checkout)
        {
            var l = db.LUONGNHANVIENs.FirstOrDefault(t => t.MaNhanVien.Trim().Contains((MaNhanVien.Trim())) && t.Ngay.Day == checkout.Day && t.Ngay.Month == checkout.Month && t.Ngay.Year == checkout.Year);
            var l1 = db.THONGTINNHANVIENs.FirstOrDefault(t => t.MaNhanVien.Trim().Contains((MaNhanVien.Trim())));
            if (l != null)
            {
                l.Gio += checkout.Hour - l.THONGTINNHANVIEN.Time_Login.Hour;
                l.TongLuong = l.Gio * 14000;
                db.SaveChanges();
            }
            else
            {
                LUONGNHANVIEN data = new LUONGNHANVIEN
                {
                    MaNhanVien = MaNhanVien,
                    Gio = checkout.Hour - l1.Time_Login.Hour,
                    Ngay = checkout,
                    TongLuong = (checkout.Hour - l1.Time_Login.Hour) * 14000
                };
                db.LUONGNHANVIENs.Add(data);
                db.SaveChanges();
            }
        }
        public double TongLuongNhanVien(string MNV)
        {
            double tongluong = 0;
            var l = db.LUONGNHANVIENs.Where(s => s.MaNhanVien == MNV).ToList();
            foreach (LUONGNHANVIEN i in l)
            {
                tongluong += i.TongLuong;
            }
            return tongluong;
        }
    }
}
