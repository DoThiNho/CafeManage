create table DANGNHAP(
MaNhanVien varchar(20) primary key,
MatKhau varchar(50),
Quyen int
)

create table CHUCVU(
MaChucVu varchar(20) primary key,
TenChucVu nvarchar(50), 
HeSoLuong float,
)


create table LOAIDOUONG(
MaLoaiThucUong varchar(20) primary key,
TenLoaiThucUong nvarchar(50))

create table MENU(
MaThucUong varchar(20) primary key,
MaLoaiThucUong varchar(20),
TenThucUong nvarchar(30),
DonGia float,
constraint fk_loaidouong foreign key (MaLoaiThucUong) references LOAIDOUONG(MaLoaiThucUong),
)

create table BAN(
MaBan varchar(20) primary key,
TenBan nvarchar(50),
TrangThai nvarchar(20)
)

create table BANTHANHTOAN(
MaBanTT varchar(20) ,
MaHoaDon varchar(50) ,
MaBan varchar(20),
constraint pk primary key (MaBanTT, MaHoaDon),
constraint fk_ban foreign key (MaBan) references BAN(MaBan),
)

create table THONGTINCHUNG(
MaNhanVien varchar(20) primary key,
TenNhanVien nvarchar(50), 
GioiTinh nvarchar(6) check (GioiTinh in ('Nam',N'Nữ')),
MaChucVu varchar(20),
SDT int,
DiaChi nvarchar(50),
CCCD varchar(20),
Ngaysinh datetime,
NgayLam int,
Status_Login bit,
DateTime_Login datetime,
constraint fk_dangnhap foreign key (MaNhanVien) references DANGNHAP(MaNhanVien),
constraint fk_chucvu foreign key (MaChucVu) references CHUCVU(MaChucVu),
)
create table HOADON(
MaHoaDon varchar(50) primary key,
MaNhanVien varchar(20),
MaBanTT varchar(20),
Ngay datetime,
TongTien float,
constraint fk_banthanhtoan foreign key (MaBanTT, MaHoaDon) references BANTHANHTOAN(MaBanTT, MaHoaDon),
constraint fk_nhanvien foreign key (MaNhanVien) references THONGTINCHUNG(MaNhanVien)
)

create table CHITIETHOADON(
ID int primary key,
MaHoaDon varchar(50) ,
MaThucUong varchar(20),
SoLuong int,
Gia float, 
constraint fk_menu foreign key (MaThucUong) references MENU(MaThucUong),
constraint fk_hoadon foreign key (MaHoaDon) references HOADON(MaHoaDon),
)

INSERT INTO DANGNHAP (MaNhanVien, MatKhau, Quyen)
VALUES
	('102200176', 'kiet123', 0),
	('102200177', 'kiet1234', 0),
	('102200348', 'kiet12', 0),
	('102200373', 'admin', 1);

INSERT INTO CHUCVU (MaChucVu, TenChucVu, HeSoLuong)
VALUES
	('AD', 'Management', 3),
	('ST', 'Staff', 1);

INSERT INTO LOAIDOUONG (MaLoaiThucUong, TenLoaiThucUong	)
VALUES
	('L1', 'Cafe'),
	('L2', 'Trà'),
	('L3', 'Nước ép'),
	('L4', 'Soda'),
	('L5', 'Sữa chua'),
	('L6', 'Nước ngọt');

INSERT INTO MENU(MaThucUong, MaLoaiThucUong, TenThucUong, DonGia)
VALUES
	('L1_1', 'L1', 'Cafe đen', 10000),
	('L1_2', 'L1', 'Cafe sữa', 12000),
	('L1_3', 'L1', 'Bạc xỉu', 15000),
	('L1_4', 'L1', 'Latte', 15000),
	('L1_5', 'L1', 'Cappuchino', 20000),
	('L1_6', 'L1', 'Espresso', 20000),
	('L1_7', 'L1', 'Mocha', 20000),
	('L2_1', 'L2', 'Trà thảo dược', 15000),
	('L2_2', 'L2', 'Lipton chanh dây', 15000),
	('L2_3', 'L2', 'Trà sữa đào', 20000),
	('L2_4', 'L2', 'Trà sữa thái xanh', 20000),
	('L2_5', 'L2', 'Trà sữa đặc biệt', 25000),
	('L2_6', 'L2', 'Trà sữa matcha', 20000),
	('L2_7', 'L2', 'Hồng trà', 15000),
	('L2_8', 'L2', 'Hồng trà chanh', 20000),
	('L2_9', 'L2', 'Hồng trà tắc', 20000),
	('L3_1', 'L3', 'Nước ép cam', 15000),
	('L3_2', 'L3', 'Nước ép ổi', 15000),
	('L3_3', 'L3', 'Nước ép táo', 15000),
	('L3_4', 'L3', 'Nước ép dưa hấu', 15000),
	('L3_5', 'L3', 'Nước ép cà rốt', 15000),
	('L4_1', 'L4', 'Soda dâu', 15000),
	('L4_2', 'L4', 'Soda việt quất', 15000),
	('L4_3', 'L4', 'Soda blue', 15000),
	('L4_4', 'L4', 'Soda socola', 15000),
	('L4_5', 'L4', 'Soda chanh', 15000),
	('L4_6', 'L4', 'Soda chanh dây', 15000),
	('L4_7', 'L4', 'Soda vải', 15000),
	('L5_1', 'L5', 'Sữa chua đá', 12000),
	('L5_2', 'L5', 'Sữa chua việt quất', 12000),
	('L5_3', 'L5', 'Sữa chua dâu', 12000),
	('L5_4', 'L5', 'Sữa chua nha đam', 12000),
	('L5_5', 'L5', 'Sữa chua trái cây', 15000),
	('L6_1', 'L6', 'Sting dâu', 12000),
	('L6_2', 'L6', 'Sting vàng', 12000),
	('L6_3', 'L6', 'Pepsi', 12000),
	('L6_4', 'L6', 'CocaCola', 12000),
	('L6_5', 'L6', '7up', 12000),
	('L6_6', 'L6', 'Bò húc', 15000),
	('L6_7', 'L6', 'Revive', 12000);

INSERT INTO BAN(MaBan, TenBan, TrangThai)
VALUES
	('B1', 'Bàn 1', 0),
	('B2', 'Bàn 2', 0),
	('B3', 'Bàn 3', 1),
	('B4', 'Bàn 4', 1),
	('B5', 'Bàn 5', 0),
	('B6', 'Bàn 6', 0),
	('B7', 'Bàn 7', 0),
	('B8', 'Bàn 8', 0),
	('B9', 'Bàn 9', 0),
	('B10', 'Bàn 10', 1);

INSERT INTO BANTHANHTOAN(MaBanTT, MaHoaDon, MaBan)
VALUES
	('BTT1', 'HD1', 'B10'),
	('BTT2', 'HD2', 'B3'),
	('BTT3', 'HD3', 'B4');

INSERT INTO THONGTINCHUNG(MaNhanVien, TenNhanVien, Gioitinh, MaChucVu, SDT, DiaChi, CCCD, Ngaysinh, NgayLam)
VALUES 
	('102200176', 'Trương Tuấn Kiệt', 'Nam', 'ST', '0899897683', 'Quảng Nam', '8347537', '2002-06-09', 3),
	('102200177', 'Trần Thị Kim Quy', N'Nữ', 'ST', '0783373534', 'Quảng Nam', '7675766', '2002-05-04', 2),
	('102200348', 'Đỗ Thị Nhớ', N'Nữ', 'ST', '0446646464', 'Đà Nẵng', '9538535', '2002-04-06', 1),
	('102200373', 'Admin', 'Nam', 'AD', '0954544452', 'Huế', '4664645', '2002-06-04', 7);

INSERT INTO HOADON(MaHoaDon, MaNhanVien, MaBanTT, Ngay, TongTien)
VALUES 
	('HD1', '102200176', 'BTT1', '2022-05-20', '65000'),
	('HD2', '102200177', 'BTT2', '2022-05-19', '42000'),
	('HD3', '102200348', 'BTT3', '2022-05-20', '48000');

INSERT INTO CHITIETHOADON(ID, MaHoaDon, MaThucUong, SoLuong, Gia)
VALUES
	(1, 'HD1', 'L1_1', 1, '10000'),
	(2, 'HD1', 'L2_2', 1, '15000'),
	(3, 'HD1', 'L2_4', 2, '40000'),
	(4, 'HD2', 'L4_1', 2, '30000'),
	(5, 'HD2', 'L5_1', 1, '12000'),
	(6, 'HD3', 'L6_2', 2, '36000'),
	(7, 'HD3', 'L6_3', 1, '12000');

SELECT * FROM THONGTINCHUNG