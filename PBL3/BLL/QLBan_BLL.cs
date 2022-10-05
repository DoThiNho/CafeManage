using PBL3.DTO;
using PBL3.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.BLL
{
    public class QLBan_BLL
    {
        QLCF db = new QLCF();
        private static QLBan_BLL _Instance;
        public static QLBan_BLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLBan_BLL();
                return _Instance;
            }
            private set { }
        }
        public QLBan_BLL()
        {

        }
        public string GetNewMaHD()
        {
            int max = 1;
            foreach (HOADON i in GetAllHD())
            {
                if (int.Parse(i.MaHoaDon.Substring(2)) > max)
                {
                    max = int.Parse(i.MaHoaDon.Substring(2));
                }
            }
            max++;
            return "HD" + max;
        }
        public string GetNewMaBTT()
        {
            int max = 1;
            foreach (BANTHANHTOAN i in GetAllBanTT())
            {
                if (int.Parse(i.MaBanTT.Substring(3)) > max)
                {
                    max = int.Parse(i.MaBanTT.Substring(3));
                }
            }
            max++;
            return "BTT" + max;
        }
        public List<BAN> GetAllBan()
        {
            return db.BANs.Select(s => s).ToList();
        }
        public List<BANTHANHTOAN> GetAllBanTT()
        {
            return db.BANTHANHTOANs.Select(s => s).ToList();
        }
        public List<CHITIETHOADON> GetAllCTHD()
        {
            return db.CHITIETHOADONs.Select(s => s).ToList();
        }
        public List<HOADON> GetAllHD()
        {
            return db.HOADONs.Select(s => s).ToList();
        }
        public List<DoUong_View> GetAllDoUong_View()
        {
            List<DoUong_View> data = new List<DoUong_View>();
            var l = db.CHITIETHOADONs.Select(s => s);
            l.ToList();
            foreach (CHITIETHOADON i in l)
            {
                data.Add(new DoUong_View
                {
                    TenDoUong = QLMENU.Instance.GetDoUongByMDU(i.MaThucUong).TenThucUong,
                    Soluong = (int)i.SoLuong,
                    Gia = (double)QLMENU.Instance.GetDoUongByMDU(i.MaThucUong).DonGia,
                    ThanhTien = (double)i.ThanhTien,
                });
            }
            return data;
        }
        public DoUong_View GetDoUongView_ByName(string NameDU)
        {
            DoUong_View ldu = new DoUong_View();
            var l = db.DOUONGs.Select(s => s);
            foreach (DOUONG i in l)
            {
                if (i.TenThucUong.Equals(NameDU))
                {
                    ldu.TenDoUong = i.TenThucUong;
                    ldu.Soluong = 1;
                    ldu.Gia = i.DonGia;
                    ldu.ThanhTien = i.DonGia;
                }
            }
            return ldu;
        }
        public List<DoUong_View> GetDoUong_ViewByMB(string MB)
        {
            List<DoUong_View> list = new List<DoUong_View>();
            string MHD = QLBan_BLL.Instance.GetMHDByMB(MB);
            if (MHD != "")
            {
                if (QLBan_BLL.Instance.CheckTT(MB) == 1)
                {
                    if (QLBan_BLL.Instance.GetHDByMHD(MHD).TrangThaiThanhToan == false)
                    {
                        foreach (DoUong_View duv in QLBan_BLL.Instance.GetDoUong_Views(MHD))
                        {
                            list.Add(duv);
                        }
                    }
                }
            }
            return list;
        }
        public List<DoUong_View> GetDoUong_Views(string MaHoaDon)
        {
            List<DoUong_View> data = new List<DoUong_View>();
            var l = db.CHITIETHOADONs.Where(s => s.MaHoaDon == MaHoaDon);
            l.ToList();
            foreach (CHITIETHOADON i in l)
            {
                data.Add(new DoUong_View
                {
                    TenDoUong = QLMENU.Instance.GetDoUongByMDU(i.MaThucUong).TenThucUong,
                    Soluong = (int)i.SoLuong,
                    Gia = (double)QLMENU.Instance.GetDoUongByMDU(i.MaThucUong).DonGia,
                    ThanhTien = (double)i.ThanhTien,
                });
            }
            return data;
        }
        public BANTHANHTOAN GetBTTByMB(string MB)
        {
            BANTHANHTOAN b = null;
            foreach (BANTHANHTOAN i in GetAllBanTT())
            {
                if (i.MaBan == MB) b = i;
            }
            return b;
        }
        public int CheckTU(string MHD, string MTU)
        {
            int a = 0;
            foreach (CHITIETHOADON i in GetAllCTHD())
            {
                if (i.MaHoaDon == MHD && i.MaThucUong == MTU)
                {
                    a = 1;
                    break;
                }
            }
            return a;
        }
        public int CheckTT(string MB)
        {
            int a = 0;
            foreach (BAN i in GetAllBan())
            {
                if (i.MaBan == MB && i.TrangThai == true)
                {
                    a = 1;
                    break;
                }
            }
            return a;
        }
        public List<BAN> GetBanByTT()
        {
            var list = db.BANs.Where(s => s.TrangThai == true).ToList();
            return list;
        }
        public BAN GetBanByMB(string MB)
        {
            return db.BANs.Find(MB);
        }
        public string GetMBTTByMB(string MB)
        {
            string MBTT = "";
            foreach (BANTHANHTOAN i in GetAllBanTT())
            {
                if (i.MaBan == MB && GetHDByMHD(i.MaHoaDon).TrangThaiThanhToan == false)
                {
                    MBTT = i.MaBanTT;
                    break;
                }
            }
            return MBTT;
        }
        public string GetTBByMB(string MB)
        {
            string TB = " ";
            foreach (BAN i in GetAllBan())
            {
                if (i.MaBan == MB)
                {
                    TB = i.TenBan;
                    break;
                }
            }
            return TB;
        }
        public BANTHANHTOAN GetBanTTByBan(string MB)
        {
            return db.BANTHANHTOANs.Find(MB);
        }
        public List<string> GetMBByMHD(string MHD)
        {
            List<string> list = new List<string>();
            foreach (BANTHANHTOAN i in GetAllBanTT())
            {
                if (i.MaHoaDon == MHD)
                {
                    list.Add(i.MaBan);
                }
            }
            return list;
        }
        public HOADON GetHDByMHD(string MHD)
        {
            return db.HOADONs.Find(MHD);
        }
        public string GetMHDByMB(string MB)
        {
            string MHD = "";
            var l = db.BANTHANHTOANs.Where(s => s.MaBan == MB).ToList();
            var l1 = l.Select(s => s.MaHoaDon).ToList();
            if (l.Count != 0 && l1.Count != 0)
            {
                foreach (string i in l1)
                {
                    if (GetHDByMHD(i).TrangThaiThanhToan == false)
                    {
                        MHD = i;
                    }
                }
            }

            return MHD;
        }
        public CHITIETHOADON GetCTHDByMHDMLTU(string MHD, string MTU)
        {
            CHITIETHOADON cthd = null;
            cthd = db.CHITIETHOADONs.Where(s => s.MaHoaDon == MHD && s.MaThucUong == MTU).FirstOrDefault();
            return cthd;

        }
        public List<CHITIETHOADON> GetCHTHByMHD(string MHD)
        {
            return db.CHITIETHOADONs.Where(s => s.MaHoaDon == MHD).ToList();
        }

        public void AddBan(BAN b)
        {
            db.BANs.Add(b);
            db.SaveChanges();
        }
        public void DelBan(string MaBan)
        {
            var s = db.BANs.Find(MaBan);
            db.BANs.Remove(s);
            db.SaveChanges();
        }
        public bool Check(string MB)
        {
            bool Add = true;
            foreach (BAN i in GetAllBan())
            {
                if (i.MaBan.Equals(MB))
                    Add = false;
            }
            return Add;
        }
        public void UpdateBan(BAN b)
        {
            var bt = db.BANs.Find(b.MaBan);
            bt.MaBan = b.MaBan;
            bt.TenBan = b.TenBan;
            bt.TrangThai = b.TrangThai;
            db.SaveChanges();
        }
        public void AddUpdate(BAN b)
        {
            if (Check(b.MaBan))
            {
                AddBan(b);
            }
            else
            {
                UpdateBan(b);
            }
        }
        public List<BAN> GetBanBySearch(string MB)
        {
            var l = db.BANs.Where(s => s.MaBan.Contains(MB) || s.TenBan.Contains(MB));
            return l.ToList();
        }
        public void UpdateTTB(string MB, bool check)
        {
            foreach (BAN i in GetAllBan())
            {
                if (i.MaBan == MB)
                {
                    i.TrangThai = check;
                    db.SaveChanges();
                    break;
                }
            }
        }
        public void UpdateTTHD(string MHD)
        {
            foreach (HOADON i in GetAllHD())
            {
                if (i.MaHoaDon == MHD)
                {
                    i.TrangThaiThanhToan = true;
                    db.SaveChanges();
                    break;
                }
            }
        }
        public void AddHD(string MNV, double sum, string MHD)
        {
            HOADON hd = new HOADON();
            hd.MaHoaDon = MHD;
            hd.MaNhanVien = MNV;
            hd.Ngay = DateTime.Now;
            hd.TongTien = sum;
            hd.TrangThaiThanhToan = false;
            db.HOADONs.Add(hd);
            db.SaveChanges();
        }
        public void AddCTHD(string MHD, string MTU, int sl, double gia)
        {
            CHITIETHOADON cthd = new CHITIETHOADON();
            cthd.MaHoaDon = MHD;
            cthd.MaThucUong = MTU;
            cthd.SoLuong = sl;
            cthd.ThanhTien = gia;
            db.CHITIETHOADONs.Add(cthd);
            db.SaveChanges();
        }
        public void UpdateCTHD(CHITIETHOADON cthd)
        {
            foreach (CHITIETHOADON i in GetAllCTHD())
            {
                if (i.MaHoaDon == cthd.MaHoaDon && i.MaThucUong == cthd.MaThucUong)
                {
                    i.MaHoaDon = cthd.MaHoaDon;
                    i.MaThucUong = cthd.MaThucUong;
                    i.SoLuong = cthd.SoLuong;
                    i.ThanhTien = cthd.ThanhTien;
                    db.SaveChanges();
                }
            }
        }
        public void UpdateHD(string MHD)
        {
            double sum = 0;
            var l = db.CHITIETHOADONs.Where(s => s.MaHoaDon == MHD);
            l.ToList();
            foreach (CHITIETHOADON i in l)
            {
                sum = (double)(sum + i.ThanhTien);
            }
            foreach (HOADON i in GetAllHD())
            {
                if (i.MaHoaDon == MHD)
                {
                    i.TongTien = sum;
                    db.SaveChanges();
                    break;
                }
            }
        }
        public void UpdateBTT(string MBTT, string MHD)
        {
            BANTHANHTOAN btt = db.BANTHANHTOANs.Where(s => s.MaBanTT == MBTT).FirstOrDefault();
            btt.MaHoaDon = MHD;
            db.SaveChanges();
        }
        public void AddBTT(string MB, string MBTT, string MHD)
        {
            BANTHANHTOAN btt = new BANTHANHTOAN();
            btt.MaBanTT = MBTT;
            btt.MaHoaDon = MHD;
            btt.MaBan = MB;
            db.BANTHANHTOANs.Add(btt);
            db.SaveChanges();
        }
        public void DelCTHD(CHITIETHOADON cthd)
        {
            CHITIETHOADON ct = null;
            ct = db.CHITIETHOADONs.Where(s => s.MaHoaDon == cthd.MaHoaDon && s.MaThucUong == cthd.MaThucUong).FirstOrDefault();
            db.CHITIETHOADONs.Remove(ct);
            db.SaveChanges();
        }
        public void DelHD(string MHD)
        {
            var hd = db.HOADONs.Where(s => s.MaHoaDon == MHD && s.TrangThaiThanhToan == false).FirstOrDefault();
            db.HOADONs.Remove(hd);
            db.SaveChanges();
        }
        public void DelBTT(string MBTT)
        {
            var btt = db.BANTHANHTOANs.Where(s => s.MaBanTT == MBTT).FirstOrDefault();
            db.BANTHANHTOANs.Remove(btt);
            db.SaveChanges();
        }
        public void GiamTU(string TTU, string MB)
        {
            string MTU = QLMENU.Instance.GetDoUongByTTU(TTU).MaThucUong;
            string MHD = GetBTTByMB(MB).MaHoaDon;
            CHITIETHOADON cthd = new CHITIETHOADON();
            cthd = GetCTHDByMHDMLTU(MHD, MTU);
            cthd.SoLuong = cthd.SoLuong - 1;
            if (cthd.SoLuong > 0)
            {
                UpdateCTHD(cthd);
            }
            else
            {
                DelCTHD(cthd);
            }
            UpdateHD(MHD);
        }
        public void Order(string TTU, string MB, string MNV)
        {
            DoUong_View du = new DoUong_View();
            du = GetDoUongView_ByName(TTU);
            string MBTT = GetNewMaBTT();
            string MTU = QLMENU.Instance.GetDoUongByTTU(TTU).MaThucUong;
            if (CheckTT(MB) == 0)
            {
                string MHD = GetNewMaHD();
                AddHD(MNV, du.Gia, MHD);
                AddBTT(MB, MBTT, MHD);
                AddCTHD(MHD, MTU, 1, du.Gia);
            }
            else
            {
                string MHD = GetBTTByMB(MB).MaHoaDon;
                if (CheckTU(MHD, MTU) == 1)
                {
                    CHITIETHOADON cthd = new CHITIETHOADON();
                    cthd = GetCTHDByMHDMLTU(MHD, MTU);
                    cthd.SoLuong = cthd.SoLuong + 1;
                    cthd.ThanhTien = du.Gia * cthd.SoLuong;
                    UpdateCTHD(cthd);
                    UpdateHD(MHD);
                }
                else
                {
                    AddCTHD(MHD, MTU, 1, du.Gia);
                    UpdateHD(MHD);
                }
            }
            UpdateTTB(MB, true);
            UpdateBan(GetBanByMB(MB));
        }
        public void ChuyenBan(string MaBan1, string MaBan2)
        {
            string MaBanTT1 = GetMBTTByMB(MaBan1);
            string MaBanTT2 = GetMBTTByMB(MaBan2);
            BANTHANHTOAN b1 = db.BANTHANHTOANs.Where(s => s.MaBanTT == MaBanTT1).FirstOrDefault();
            BANTHANHTOAN b2 = db.BANTHANHTOANs.Where(s => s.MaBanTT == MaBanTT2).FirstOrDefault();
            if (b2 != null)
            {

                string temp = b1.MaBan;
                b1.MaBan = b2.MaBan;
                b2.MaBan = temp;
                db.SaveChanges();
            }
            else
            {
                b1.MaBan = MaBan2;
                UpdateTTB(MaBan2, true);
                UpdateTTB(MaBan1, false);
                db.SaveChanges();
            }
        }
        public void GopBan(string MaBan1, string MaBan2)
        {
            string MaBanTT1 = GetMBTTByMB(MaBan1);
            string MaBanTT2 = GetMBTTByMB(MaBan2);
            BANTHANHTOAN b1 = db.BANTHANHTOANs.Where(s => s.MaBanTT == MaBanTT1).FirstOrDefault();
            BANTHANHTOAN b2 = db.BANTHANHTOANs.Where(s => s.MaBanTT == MaBanTT2).FirstOrDefault();
            var l = db.CHITIETHOADONs.Where(s => s.MaHoaDon == b1.MaHoaDon).ToList();
            if (b2 != null)
            {
                var l1 = db.CHITIETHOADONs.Where(s => s.MaHoaDon == b2.MaHoaDon).ToList();
                string MHD = b1.MaHoaDon;
                UpdateBTT(b1.MaBanTT, b2.MaHoaDon);
                foreach (CHITIETHOADON i in l1)
                {
                    foreach (CHITIETHOADON j in l)
                    {
                        if (j.MaThucUong == i.MaThucUong)
                        {
                            i.SoLuong += j.SoLuong;
                            i.ThanhTien += j.ThanhTien;
                            UpdateCTHD(i);
                            UpdateHD(b2.MaHoaDon);
                            DelCTHD(j);
                        }
                        else
                        {
                            j.MaHoaDon = b2.MaHoaDon;
                            UpdateHD(b2.MaHoaDon);
                        }
                    }
                }
                //db.SaveChanges();
                DelHD(MHD);
            }
            else
            {
                string MBTT = GetNewMaBTT();
                AddBTT(MaBan2, MBTT, b1.MaHoaDon);
                UpdateTTB(MaBan2, true);
            }
        }
        public void TachBan(string MaBan1, string MaBan2, List<DoUong_View> list, string MNV)
        {
            string MaBanTT1 = GetMBTTByMB(MaBan1);
            string MaBanTT2 = GetMBTTByMB(MaBan2);
            BANTHANHTOAN b1 = db.BANTHANHTOANs.Where(s => s.MaBanTT == MaBanTT1).FirstOrDefault();
            BANTHANHTOAN b2 = db.BANTHANHTOANs.Where(s => s.MaBanTT == MaBanTT2).FirstOrDefault();
            var l = db.CHITIETHOADONs.Where(s => s.MaHoaDon == b1.MaHoaDon).ToList();
            if (b2 != null)
            {
                var l1 = db.CHITIETHOADONs.Where(s => s.MaHoaDon == b2.MaHoaDon).ToList();
                foreach (CHITIETHOADON i in l1)
                {
                    foreach (DoUong_View j in list)
                    {
                        if (QLMENU.Instance.GetDoUongByMDU(i.MaThucUong).TenThucUong.Equals(j.TenDoUong))
                        {
                            i.SoLuong += 1;
                            i.ThanhTien += j.Gia;
                            UpdateCTHD(i);
                            UpdateHD(b2.MaHoaDon);
                            var l2 = l.Where(s => QLMENU.Instance.GetDoUongByMDU(s.MaThucUong).TenThucUong == j.TenDoUong).FirstOrDefault();
                            if (l2.SoLuong > 1)
                            {
                                l2.SoLuong -= 1;
                                UpdateCTHD(l2);
                                UpdateHD(b1.MaHoaDon);
                            }
                            else
                            {
                                DelCTHD(l2);
                                if (l.Count == 1)
                                {
                                    UpdateTTB(MaBan1, false);
                                    DelHD(b1.MaHoaDon);
                                }
                            }
                            list.Remove(j);
                            break;
                        }
                    }
                }
                foreach (DoUong_View j in list)
                {
                    var l2 = l.Where(s => QLMENU.Instance.GetDoUongByMDU(s.MaThucUong).TenThucUong == j.TenDoUong).FirstOrDefault();
                    if (l2 != null)
                    {
                        if (l2.SoLuong > 1)
                        {
                            Order(j.TenDoUong, MaBan2, MNV);
                            l2.SoLuong -= 1;
                            UpdateCTHD(l2);
                            UpdateHD(b1.MaHoaDon);
                        }
                        else
                        {
                            l2.MaHoaDon = b2.MaHoaDon;
                            UpdateHD(b2.MaHoaDon);
                            if (l.Count == 1)
                            {
                                UpdateTTB(MaBan1, false);
                                DelHD(b1.MaHoaDon);
                            }
                        }
                        db.SaveChanges();
                    }
                }

            }
            else
            {
                foreach (DoUong_View j in list)
                {
                    Order(j.TenDoUong, MaBan2, MNV);
                    var l2 = l.Where(s => QLMENU.Instance.GetDoUongByMDU(s.MaThucUong).TenThucUong == j.TenDoUong).FirstOrDefault();
                    if (l2.SoLuong > 1)
                    {
                        l2.SoLuong -= 1;
                        UpdateCTHD(l2);
                        UpdateHD(b1.MaHoaDon);
                    }
                    else
                    {
                        DelCTHD(l2);
                        if (l.Count == 1)
                        {
                            UpdateTTB(MaBan1, false);
                            DelHD(b1.MaHoaDon);
                        }
                    }
                }
            }
        }
    }

    }


