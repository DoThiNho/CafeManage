using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PBL3.DTO;

namespace PBL3
{
    public class CreateDB : DropCreateDatabaseAlways<QLCF>
    {
        protected override void Seed(QLCF context)
        {
            context.TAIKHOANs.AddRange(new TAIKHOAN[]
            {
                new TAIKHOAN{MaNhanVien = "102200176", MatKhau = "kiet123", Quyen = 0},
                new TAIKHOAN{MaNhanVien = "102200177", MatKhau = "kiet1234", Quyen = 0},
                new TAIKHOAN{MaNhanVien = "102200348", MatKhau = "kiet12", Quyen = 0},
                new TAIKHOAN{MaNhanVien = "102200373", MatKhau = "admin", Quyen = 1}
            });
            context.CHUCVUs.AddRange(new CHUCVU[]
            {
                new CHUCVU{MaChucVu = "AD", TenChucVu = "Management", HeSoLuong = 3},
                new CHUCVU{MaChucVu = "ST", TenChucVu = "Staff", HeSoLuong = 1},
            });
            context.LOAIDOUONGs.AddRange(new LOAIDOUONG[]
            {
                new LOAIDOUONG{MaLoaiThucUong = "L1", TenLoaiThucUong = "Cafe"},
                new LOAIDOUONG{MaLoaiThucUong = "L2", TenLoaiThucUong = "Trà"},
                new LOAIDOUONG{MaLoaiThucUong = "L3", TenLoaiThucUong = "Nước ép"},
                new LOAIDOUONG{MaLoaiThucUong = "L4", TenLoaiThucUong = "Soda"},
                new LOAIDOUONG{MaLoaiThucUong = "L5", TenLoaiThucUong = "Sữa chua"},
                new LOAIDOUONG{MaLoaiThucUong = "L6", TenLoaiThucUong = "Nước ngọt"},
            });
            context.DOUONGs.AddRange(new DOUONG[]
            {
                new DOUONG{MaThucUong = "L1_1", MaLoaiThucUong = "L1", TenThucUong = "Cafe đen", DonGia = 10000},
                new DOUONG{MaThucUong = "L1_2", MaLoaiThucUong = "L1", TenThucUong = "Cafe sữa", DonGia = 12000},
                new DOUONG{MaThucUong = "L1_3", MaLoaiThucUong = "L1", TenThucUong = "Bạc xỉu", DonGia = 15000},
                new DOUONG{MaThucUong = "L1_4", MaLoaiThucUong = "L1", TenThucUong = "Latte", DonGia = 15000},
                new DOUONG{MaThucUong = "L1_5", MaLoaiThucUong = "L1", TenThucUong = "Cappuchino", DonGia = 20000},
                new DOUONG{MaThucUong = "L1_6", MaLoaiThucUong = "L1", TenThucUong = "Espresso", DonGia = 20000},
                new DOUONG{MaThucUong = "L1_7", MaLoaiThucUong = "L1", TenThucUong = "Mocha", DonGia = 20000},
                new DOUONG{MaThucUong = "L2_1", MaLoaiThucUong = "L2", TenThucUong = "Trà thảo dược", DonGia = 15000},
                new DOUONG{MaThucUong = "L2_2", MaLoaiThucUong = "L2", TenThucUong = "Lipton chanh dây", DonGia = 15000},
                new DOUONG{MaThucUong = "L2_3", MaLoaiThucUong = "L2", TenThucUong = "Trà sữa đào", DonGia = 20000},
                new DOUONG{MaThucUong = "L2_4", MaLoaiThucUong = "L2", TenThucUong = "Trà sữa thái xanh", DonGia = 20000},
                new DOUONG{MaThucUong = "L2_5", MaLoaiThucUong = "L2", TenThucUong = "Trà sữa đặc biệt", DonGia = 25000},
                new DOUONG{MaThucUong = "L2_6", MaLoaiThucUong = "L2", TenThucUong = "Trà sữa matcha", DonGia = 20000},
                new DOUONG{MaThucUong = "L2_7", MaLoaiThucUong = "L2", TenThucUong = "Hồng trà", DonGia = 15000},
                new DOUONG{MaThucUong = "L2_8", MaLoaiThucUong = "L2", TenThucUong = "Hồng trà chanh", DonGia = 20000},
                new DOUONG{MaThucUong = "L2_9", MaLoaiThucUong = "L2", TenThucUong = "Hồng trà tắc", DonGia = 20000},
                new DOUONG{MaThucUong = "L3_1", MaLoaiThucUong = "L3", TenThucUong = "Nước ép cam", DonGia = 15000},
                new DOUONG{MaThucUong = "L3_2", MaLoaiThucUong = "L3", TenThucUong = "Nước ép ổi", DonGia = 15000},
                new DOUONG{MaThucUong = "L3_3", MaLoaiThucUong = "L3", TenThucUong = "Nước ép táo", DonGia = 15000},
                new DOUONG{MaThucUong = "L3_4", MaLoaiThucUong = "L3", TenThucUong = "Nước ép dưa hấu", DonGia = 15000},
                new DOUONG{MaThucUong = "L3_5", MaLoaiThucUong = "L3", TenThucUong = "Nước ép cà rốt", DonGia = 15000},
                new DOUONG{MaThucUong = "L4_1", MaLoaiThucUong = "L4", TenThucUong = "Soda dâu", DonGia = 15000},
                new DOUONG{MaThucUong = "L4_2", MaLoaiThucUong = "L4", TenThucUong = "Soda việt quất", DonGia = 15000},
                new DOUONG{MaThucUong = "L4_3", MaLoaiThucUong = "L4", TenThucUong = "Soda blue", DonGia = 15000},
                new DOUONG{MaThucUong = "L4_4", MaLoaiThucUong = "L4", TenThucUong = "Soda socola", DonGia = 15000},
                new DOUONG{MaThucUong = "L4_5", MaLoaiThucUong = "L4", TenThucUong = "Soda chanh", DonGia = 15000},
                new DOUONG{MaThucUong = "L4_6", MaLoaiThucUong = "L4", TenThucUong = "Soda chanh dây", DonGia = 15000},
                new DOUONG{MaThucUong = "L4_7", MaLoaiThucUong = "L4", TenThucUong = "Soda vải", DonGia = 15000},
                new DOUONG{MaThucUong = "L5_1", MaLoaiThucUong = "L5", TenThucUong = "Sữa chua đá", DonGia = 12000},
                new DOUONG{MaThucUong = "L5_2", MaLoaiThucUong = "L5", TenThucUong = "Sữa chua việt quất", DonGia = 12000},
                new DOUONG{MaThucUong = "L5_3", MaLoaiThucUong = "L5", TenThucUong = "Sữa chua dâu", DonGia = 12000},
                new DOUONG{MaThucUong = "L5_4", MaLoaiThucUong = "L5", TenThucUong = "Sữa chua nha đam", DonGia = 12000},
                new DOUONG{MaThucUong = "L5_5", MaLoaiThucUong = "L5", TenThucUong = "Sữa chua nha trái cây", DonGia = 15000},
                new DOUONG{MaThucUong = "L6_1", MaLoaiThucUong = "L6", TenThucUong = "Sting dâu", DonGia = 12000},
                new DOUONG{MaThucUong = "L6_2", MaLoaiThucUong = "L6", TenThucUong = "Sting vàng", DonGia = 12000},
                new DOUONG{MaThucUong = "L6_3", MaLoaiThucUong = "L6", TenThucUong = "Pepsi", DonGia = 12000},
                new DOUONG{MaThucUong = "L6_4", MaLoaiThucUong = "L6", TenThucUong = "Cocacola", DonGia = 12000},
                new DOUONG{MaThucUong = "L6_5", MaLoaiThucUong = "L6", TenThucUong = "7up", DonGia = 12000},
                new DOUONG{MaThucUong = "L6_6", MaLoaiThucUong = "L6", TenThucUong = "Bò húc", DonGia = 15000},
                new DOUONG{MaThucUong = "L6_7", MaLoaiThucUong = "L6", TenThucUong = "Revive", DonGia = 12000},

            });
            context.BANs.AddRange(new BAN[]
            {
                new BAN{MaBan = "B1", TenBan = "Bàn 1", TrangThai = false},
                new BAN{MaBan = "B2", TenBan = "Bàn 2", TrangThai = false},
                new BAN{MaBan = "B3", TenBan = "Bàn 3", TrangThai = false},
                new BAN{MaBan = "B4", TenBan = "Bàn 4", TrangThai = false},
                new BAN{MaBan = "B5", TenBan = "Bàn 5", TrangThai = false},
                new BAN{MaBan = "B6", TenBan = "Bàn 6", TrangThai = false},
                new BAN{MaBan = "B7", TenBan = "Bàn 7", TrangThai = false},
                new BAN{MaBan = "B8", TenBan = "Bàn 8", TrangThai = false},
                new BAN{MaBan = "B9", TenBan = "Bàn 9", TrangThai = false},
                new BAN{MaBan = "B10", TenBan = "Bàn 10", TrangThai = false},
            });
            context.BANTHANHTOANs.AddRange(new BANTHANHTOAN[]
            {
                new BANTHANHTOAN{MaBanTT = "BTT1", MaHoaDon = "HD1", MaBan = "B10"},
                new BANTHANHTOAN{MaBanTT = "BTT2", MaHoaDon = "HD1", MaBan = "B3"},
                new BANTHANHTOAN{MaBanTT = "BTT3", MaHoaDon = "HD2", MaBan = "B4"},
                new BANTHANHTOAN{MaBanTT = "BTT4", MaHoaDon = "HD3", MaBan = "B5"},
            });
            context.THONGTINNHANVIENs.AddRange(new THONGTINNHANVIEN[]
            {
                new THONGTINNHANVIEN{MaNhanVien = "102200176", TenNhanVien = "Trương Tuấn Kiệt", GioiTinh = true, MaChucVu = "ST", SDT = "0899897683", DiaChi = "Quảng Nam", CCCD = "8348537",TrangThai = false,Time_Login = new DateTime(2022,1,1), NgaySinh = new DateTime(2002,06,09)},
                new THONGTINNHANVIEN{MaNhanVien = "102200177", TenNhanVien = "Trần Thi Kim Quy", GioiTinh = false, MaChucVu = "ST", SDT = "0783373534", DiaChi = "Quảng Nam", CCCD = "7675766",TrangThai = false,Time_Login = new DateTime(2022,1,1), NgaySinh = new DateTime(2002,05,04) },
                new THONGTINNHANVIEN{MaNhanVien = "102200348", TenNhanVien = "Đỗ Thị Nhớ", GioiTinh = false, MaChucVu = "ST", SDT = "0446646464", DiaChi = "Đà Nẵng", CCCD = "9538535",TrangThai = false,Time_Login = new DateTime(2022,1,1), NgaySinh = new DateTime(2002,04,06) },
                new THONGTINNHANVIEN{MaNhanVien = "102200373", TenNhanVien = "Admin", GioiTinh = false, MaChucVu = "AD", SDT = "0954544452", DiaChi = "Huế", CCCD = "4664645",TrangThai = false,Time_Login = new DateTime(2022,1,1), NgaySinh = new DateTime(2002,04,06)},
            });
            context.LUONGNHANVIENs.AddRange(new LUONGNHANVIEN[]
            {
                new LUONGNHANVIEN{MaNhanVien = "102200176", Gio = 4, Ngay = new DateTime(2022,6,27), TongLuong = 60000},
                new LUONGNHANVIEN{MaNhanVien = "102200176", Gio = 4, Ngay = new DateTime(2022,6,26), TongLuong = 60000},
                new LUONGNHANVIEN{MaNhanVien = "102200176", Gio = 4, Ngay = new DateTime(2022,6,21), TongLuong = 60000},
                new LUONGNHANVIEN{MaNhanVien = "102200177", Gio = 5, Ngay = new DateTime(2022,5,27), TongLuong = 75000},
                new LUONGNHANVIEN{MaNhanVien = "102200177", Gio = 2, Ngay = new DateTime(2022,6,27), TongLuong = 3000},
            });
            context.HOADONs.AddRange(new HOADON[] {
                //new HOADON{MaHoaDon = "HD1", MaNhanVien = "102200176", MaBanTT = "BTT1", Ngay = new DateTime(2022,04,20), TrangThaiThanhToan = true, TongTien = 65000},
                //new HOADON{MaHoaDon = "HD2", MaNhanVien = "102200177", MaBanTT = "BTT2", Ngay = new DateTime(2022,05,19), TrangThaiThanhToan = true, TongTien = 42000},
                //new HOADON{MaHoaDon = "HD3", MaNhanVien = "102200348", MaBanTT = "BTT3", Ngay = new DateTime(2022,05,20), TrangThaiThanhToan = true, TongTien = 36000},
                new HOADON{MaHoaDon = "HD1", MaNhanVien = "102200176", Ngay = new DateTime(2022,04,20), TrangThaiThanhToan = true, TongTien = 65000},
                new HOADON{MaHoaDon = "HD2", MaNhanVien = "102200177", Ngay = new DateTime(2022,05,19), TrangThaiThanhToan = true, TongTien = 42000},
                new HOADON{MaHoaDon = "HD3", MaNhanVien = "102200348", Ngay = new DateTime(2022,05,20), TrangThaiThanhToan = true, TongTien = 36000},

            });
            context.CHITIETHOADONs.AddRange(new CHITIETHOADON[] {
                new CHITIETHOADON{MaHoaDon = "HD1", MaThucUong = "L1_1", SoLuong = 1, ThanhTien = 10000},
                new CHITIETHOADON{MaHoaDon = "HD1", MaThucUong = "L2_2", SoLuong = 1, ThanhTien = 15000},
                new CHITIETHOADON{MaHoaDon = "HD1", MaThucUong = "L2_4", SoLuong = 2, ThanhTien = 40000},
                new CHITIETHOADON{MaHoaDon = "HD2", MaThucUong = "L4_1", SoLuong = 2, ThanhTien = 30000},
                new CHITIETHOADON{MaHoaDon = "HD2", MaThucUong = "L5_1", SoLuong = 1, ThanhTien = 12000},
                new CHITIETHOADON{MaHoaDon = "HD3", MaThucUong = "L6_2", SoLuong = 2, ThanhTien = 24000},
                new CHITIETHOADON{MaHoaDon = "HD3", MaThucUong = "L6_3", SoLuong = 1, ThanhTien = 12000},
            });
        }
    }
}
