using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BLL
{
    
    public class QLBieuDo_BLL
    {
        private static QLBieuDo_BLL _Instance;
        public static QLBieuDo_BLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLBieuDo_BLL();
                return _Instance;
            }
            private set { }
        }
        public QLBieuDo_BLL()
        {

        }
        QLCF db = new QLCF();
        public List<DoanhThuOrLuong_Thang> GetDoanhThuThang_View(List<HOADON> temp)
        {
            List<DoanhThuOrLuong_Thang> data = new List<DoanhThuOrLuong_Thang>();
            foreach (HOADON i in temp)
            {
                data.Add(new DoanhThuOrLuong_Thang
                {
                    Thang = i.Ngay.Month,
                    Tong = (double)i.TongTien,
                });
            }
            for (int i = 0; i < data.Count; i++)
            {
                for (int j = data.Count - 1; j > i; j--)
                {
                    if (data[i].Thang == data[j].Thang)
                    {
                        data[i].Tong += data[j].Tong;
                        data.RemoveAt(j);
                    }
                }

            }
            return data;
        }
        public List<CHITIETHOADON> GetAllChiTietHoaDon()
        {
            return db.CHITIETHOADONs.Select(s => s).ToList();
        }
        public List<CHITIETHOADON> GetCHITIETHOADONsByMaLoaiThucUong(string TenLoaiThucUong)
        {
            return db.CHITIETHOADONs.Where(s => s.DOUONG.LOAIDOUONG.TenLoaiThucUong == TenLoaiThucUong).ToList();
        }
        public List<DoUongOrLoaiDoUong_ThongKe> ThongKeLoaiDoUong(List<CHITIETHOADON> temp)
        {
            List<DoUongOrLoaiDoUong_ThongKe> data = new List<DoUongOrLoaiDoUong_ThongKe>();
            foreach (CHITIETHOADON i in temp)
            {
                data.Add(new DoUongOrLoaiDoUong_ThongKe
                {
                    Name = i.DOUONG.LOAIDOUONG.TenLoaiThucUong,
                    SoLuong = 1
                });
            }
            for (int i = 0; i < data.Count; i++)
            {
                for (int j = data.Count - 1; j > i; j--)
                {
                    if (data[i].Name == data[j].Name)
                    {
                        data[i].SoLuong += 1;
                        data.RemoveAt(j);
                    }
                }
            }
            return data;
        }
        public List<DoUongOrLoaiDoUong_ThongKe> ThongKeDoUong(List<CHITIETHOADON> temp)
        {
            List<DoUongOrLoaiDoUong_ThongKe> data = new List<DoUongOrLoaiDoUong_ThongKe>();
            foreach (CHITIETHOADON i in temp)
            {
                data.Add(new DoUongOrLoaiDoUong_ThongKe
                {
                    Name = i.DOUONG.TenThucUong,
                    SoLuong = i.SoLuong,
                });
            }
            for (int i = 0; i < data.Count; i++)
            {
                for (int j = data.Count - 1; j > i; j--)
                {
                    if (data[i].Name == data[j].Name)
                    {
                        data[i].SoLuong += data[j].SoLuong;
                        data.RemoveAt(j);
                    }
                }
            }
            return data;
        }

        //Lương
        public List<LUONGNHANVIEN> GetLuong_Thang(int year/*, int month*/)
        {
            var l1 = db.LUONGNHANVIENs.Where(s => s.Ngay.Year == year/* && s.Ngay.Value.Month == month*/);
            return l1.ToList();
        }
        public List<DoanhThuOrLuong_Thang> GetLuongThang_View(List<LUONGNHANVIEN> temp)
        {
            List<DoanhThuOrLuong_Thang> data = new List<DoanhThuOrLuong_Thang>();
            foreach (LUONGNHANVIEN i in temp)
            {
                data.Add(new DoanhThuOrLuong_Thang
                {
                    Thang = i.Ngay.Month,
                    Tong = (double)i.TongLuong,
                });
            }
            for (int i = 0; i < data.Count; i++)
            {
                for (int j = data.Count - 1; j > i; j--)
                {
                    if (data[i].Thang == data[j].Thang)
                    {
                        data[i].Tong += data[j].Tong;
                        data.RemoveAt(j);
                    }
                }

            }
            return data;
        }

    }
}
