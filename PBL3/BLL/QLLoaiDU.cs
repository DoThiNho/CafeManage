using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class QLLoaiDU
    {
        QLCF db = new QLCF();
        private static QLLoaiDU _Instance;
        public static QLLoaiDU Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLLoaiDU();
                }
                return _Instance;
            }
            private set { }
        }
        private QLLoaiDU()
        {

        }
        public List<CBBItem> GetLoaiDU()
        {
            List<CBBItem> data = new List<CBBItem>();
            var l = db.LOAIDOUONGs.Select(s => s);
            l.ToList();
            foreach (LOAIDOUONG i in l)
            {
                data.Add(new CBBItem
                {
                    Value = i.MaLoaiThucUong,
                    Text = i.TenLoaiThucUong
                });
            }
            return data;
        }

    }
}
