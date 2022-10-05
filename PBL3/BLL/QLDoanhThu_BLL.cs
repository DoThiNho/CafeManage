using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class QLDoanhThu_BLL
    {
        private static QLDoanhThu_BLL _Instance;
        public static QLDoanhThu_BLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLDoanhThu_BLL();
                return _Instance;
            }
            private set { }
        }
        public QLDoanhThu_BLL()
        {

        }
        QLCF db = new QLCF();
        public List<HOADON> GetAllHoaDon()
        {
            var data = db.HOADONs.Select(s => s);
            return data.ToList();
        }
        public List<HOADON> GetHoaDonTheoDate(DateTime tungay, DateTime denngay)
        {
            var data = db.HOADONs.Where(s => s.Ngay >= tungay && s.Ngay <= denngay);
            return data.ToList();
        }
        public List<HOADON> SortDT(string Sort)
        {
            List<HOADON> list = new List<HOADON>();
            list = GetAllHoaDon();
            if (Sort == "TongTien")
            {
                list = list.OrderBy(x => x.TongTien).ToList();
            }
            if (Sort == "Ngay")
            {
                list = list.OrderBy(x => x.Ngay).ToList();
            }
            return list;
        }
        public List<Doanhthu_View> GetDoanhThu_Views(List<HOADON> temp)
        {
            List<Doanhthu_View> data = new List<Doanhthu_View>();
            foreach (HOADON i in temp)
            {
                data.Add(new Doanhthu_View
                {
                    MaHoaDon = i.MaHoaDon,
                    MaNhanVien = i.MaNhanVien,
                    Ngay = Convert.ToDateTime(i.Ngay),
                    TongTien = Convert.ToDouble(i.TongTien)
                });
            }
            return data;
        }
        public List<HOADON> GetHoaDonBySearch(DateTime ngay)
        {
            var l = db.HOADONs.Where(s => ((DateTime)s.Ngay).Day == ngay.Day && ((DateTime)s.Ngay).Month == ngay.Month && ((DateTime)s.Ngay).Year == ngay.Year);
            return l.ToList();
        }
        public List<HOADON> GetDoanhThu_Thang(int year)
        {
            var l1 = db.HOADONs.Where(s => s.Ngay.Year == year);
            return l1.ToList();
        }
        
    }
}
