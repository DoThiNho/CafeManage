use DataBase_PBL

create table DANGNHAP(
MaNhanVien char(20) primary key,
MatKhau varchar(50),
Quyen int
)

create table CHUCVU(
MaChucVu char(20) primary key,
TenChucVu nvarchar(50), 
HeSoLuong float,
)


create table LOAIDOUONG(
MaLoaiThucUong char(20) primary key,
TenLoaiThucUong nvarchar(50))

create table MENU(
MaThucUong char(20) primary key,
MaLoaiThucUong char(20),
TenThucUong nvarchar(30),
DonGia float,
constraint fk_loaidouong foreign key (MaLoaiThucUong) references LOAIDOUONG(MaLoaiThucUong),
)

create table BAN(
MaBan char(20) primary key,
TenBan nvarchar(50),
TrangThai nvarchar(20)
)

create table BANTHANHTOAN(
MaBanTT char(20) ,
MaHoaDon char(50) ,
MaBan char(20),
constraint pk primary key (MaBanTT, MaHoaDon),
constraint fk_ban foreign key (MaBan) references BAN(MaBan),
)

create table THONGTINCHUNG(
MaNhanVien char(20) primary key,
TenNhanVien nvarchar(50), 
Gioitinh nvarchar(6) check (GioiTinh in ('Nam','Nữ')),
MaChucVu char(20),
SDT int,
DiaChi nvarchar(50),
CCCD varchar(20),
Ngaysinh datetime,
NgayLam int,
constraint fk_dangnhap foreign key (MaNhanVien) references DANGNHAP(MaNhanVien),
constraint fk_chucvu foreign key (MaChucVu) references CHUCVU(MaChucVu),
)
create table HOADON(
MaHoaDon char(50) primary key,
MaNhanVien char(20),
MaBanTT char(20),
Ngay datetime,
TongTien float,
constraint fk_banthanhtoan foreign key (MaBanTT, MaHoaDon) references BANTHANHTOAN(MaBanTT, MaHoaDon),
constraint fk_nhanvien foreign key (MaNhanVien) references THONGTINCHUNG(MaNhanVien)
)

create table CHITIETHOADON(
ID int primary key,
MaHoaDon char(50) ,
MaThucUong char(20),
SoLuong int,
Gia float, 
constraint fk_menu foreign key (MaThucUong) references MENU(MaThucUong),
constraint fk_hoadon foreign key (MaHoaDon) references HOADON(MaHoaDon),
)









