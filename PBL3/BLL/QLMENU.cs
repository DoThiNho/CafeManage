/*using PBL3.DTO;*/
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class QLMENU
    {
        QLCF db = new QLCF();
        private static QLMENU _Instance;
        public static QLMENU Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLMENU();
                }
                return _Instance;
            }
            private set { }
        }
        public QLMENU()
        {

        }
        public List<DOUONG> GetAllDoUong()
        {
            var data = db.DOUONGs.Select(p => p);
            return data.ToList();
        }
        public List<LOAIDOUONG> GetAllLDU()
        {
            var list = db.LOAIDOUONGs.Select(s => s);
            return list.ToList();
        }
        public List<DoUong_View1> GetAllDoUongView(List<DOUONG> menu)
        {
            List<DoUong_View1> data = new List<DoUong_View1>();
            foreach (DOUONG i in menu)
            {
                data.Add(new DoUong_View1
                {
                    MaThucUong = i.MaThucUong,
                    TenThucUong = i.TenThucUong,
                });
            }
            return data;
        }
        public DOUONG GetDoUongByMDU(string MaThucUong)
        {
            DOUONG menu = new DOUONG();
            menu = db.DOUONGs.Find(MaThucUong);
            return menu;
        }
        //public LOAIDOUONG GetLDUByMaLDU(string MLDU)
        //{
        //    LOAIDOUONG ldu = new LOAIDOUONG();
        //    ldu = db.LOAIDOUONGs.Find(MLDU);
        //    return ldu;
        //}
        public DOUONG GetDoUongByTTU(string Name)
        {
            DOUONG menu = new DOUONG();
            foreach (DOUONG i in QLMENU.Instance.GetAllDoUong())
            {
                if (i.TenThucUong == Name)
                {
                    menu = i;
                    break;
                }
            }
            return menu;
        }
        public void AddDU(DOUONG menu)
        {
            db.DOUONGs.Add(menu);
            db.SaveChanges();
        }
        public void UpdateDU(DOUONG menu)
        {
            var mn = db.DOUONGs.Find(menu.MaThucUong);
            mn.MaThucUong = menu.MaThucUong;
            mn.MaLoaiThucUong = menu.MaLoaiThucUong;
            mn.TenThucUong = menu.TenThucUong;
            mn.DonGia = menu.DonGia;
            db.SaveChanges();
        }
        public void DelDoUong(string MaThucUong)
        {
            var l = db.DOUONGs.Find(MaThucUong);
            db.DOUONGs.Remove(l);
            db.SaveChanges();
        }
        public bool Check(string MaThucUong)
        {
            bool c = false;
            foreach (DOUONG i in GetAllDoUong())
            {
                if (i.MaThucUong.Equals(MaThucUong))
                    c = true;
            }
            return c;
        }
        public List<DOUONG> GetDUBySearch(string txt)
        {
            if (txt == "Mã đồ uống hoặc Tên đồ uống")
            {
                return GetAllDoUong();
            }
            else
            {
                var l = db.DOUONGs.Where(s => s.MaThucUong.Contains(txt) || s.TenThucUong.Contains(txt));
                return l.ToList();
            }
        }
    }
}
