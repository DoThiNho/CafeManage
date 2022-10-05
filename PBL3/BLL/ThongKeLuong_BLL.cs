using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BLL
{
    public class ThongKeLuong_BLL
    {
        QLCF db = new QLCF();
        private static ThongKeLuong_BLL _Instance;
        public static ThongKeLuong_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ThongKeLuong_BLL();
                }
                return _Instance;
            }
            private set { }
        }
        private ThongKeLuong_BLL()
        {

        }
        public List<LUONGNHANVIEN> GetALLLuongNhanVien()
        {
            var data = db.LUONGNHANVIENs.Select(p => p);
            return data.ToList();
        }
        public List<NhanVien_Luong> GetViewNhanVien(List<LUONGNHANVIEN> nhanvien)
        {
            List<NhanVien_Luong> data = new List<NhanVien_Luong>();
            foreach (LUONGNHANVIEN i in nhanvien)
            {
                data.Add(new NhanVien_Luong
                {
                    ID = i.ID,
                    MaNhanVien = i.MaNhanVien,
                    TenNhanVien = i.THONGTINNHANVIEN.TenNhanVien,
                    Date = i.Ngay.Day + "/" + i.Ngay.Month + "/" + i.Ngay.Year,
                    LuongNhanVien = i.TongLuong,
                });
            }
            /*for(int i = 0; i < data.Count; i++)
            {
                for(int j = data.Count - 1;j > 1; j --)
                {
                    if(data[i].MaNhanVien == data[j].MaNhanVien)
                    {
                        data[i].LuongNhanVien += data[j].LuongNhanVien;
                        data.RemoveAt(j);
                    }    
                }    
            }    */
            return data;
        }
        public List<LUONGNHANVIEN> Search(string txt)
        {
            if (txt == null)
            {
                return (GetALLLuongNhanVien()).ToList();
            }
            var l = db.LUONGNHANVIENs.Where(p => p.THONGTINNHANVIEN.TenNhanVien.Contains(txt) || p.MaNhanVien.Contains(txt));
            return l.ToList();
        }
        public List<NhanVien_Luong> Sort(List<int> ID, string type)
        {
            List<LUONGNHANVIEN> temp = new List<LUONGNHANVIEN>();
            foreach (int i in ID)
            {
                temp.Add(db.LUONGNHANVIENs.Find(i));
            }
            List<NhanVien_Luong> data = new List<NhanVien_Luong>();
            data = GetViewNhanVien(temp);
            if (type == "Mã nhân viên")
            {
                return data.OrderBy(s => s.MaNhanVien).ToList();
            }
            else if (type == "Tên nhân viên")
            {
                return data.OrderBy(s => s.TenNhanVien).ToList();
            }
            else if (type == "Lương")
            {
                return data.OrderBy(s => s.LuongNhanVien).ToList();
            }
            else return data;
        }
        public double TongLuong(List<int> ID)
        {
            double data = 0;
            List<LUONGNHANVIEN> temp = new List<LUONGNHANVIEN>();
            foreach (int i in ID)
            {
                temp.Add(db.LUONGNHANVIENs.Find(i));
            }
            
            foreach (LUONGNHANVIEN s in temp)
            {
                data += Convert.ToDouble(s.TongLuong);
            }
            return data;
        }
        public List<LUONGNHANVIEN> GetLuongNVTheoDate(DateTime tungay, DateTime denngay)
        {
            var data = db.LUONGNHANVIENs.Where(s => s.Ngay >= tungay && s.Ngay <= denngay);
            return data.ToList();
        }
        
        
    }
}
