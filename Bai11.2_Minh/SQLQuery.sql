create database Bai11_2_QLBanHang
go
use Bai11_2_QLBanHang
go
create table HoaDon
(
	MaHD char(4) not null primary key,
	Ngaylap Date,
	MaKH char(4),
	NguoiLap varchar(10)
)
go
insert into HoaDon values('HD01','01/01/2021','KH03','A'),
						('HD02','10/10/2021','KH01','B'),
						('HD03','05/05/2021','KH02','C')
go
create table KhachHang
(
	MaKH char(4) not null primary key,
	TenKH nvarchar(50),
	SoDT varchar(12),
	DiaChi nvarchar(50)
)
go
insert into KhachHang values('KH01','Pham Thi D','5432178906','Hà Nội'),
							('KH02','Đồng Xuân E','0123456789','Bắc Ninh'),
							('KH03','Ma Văn F','0987654321','Thái Nguyên')
go
create table HoaDonChiTiet
(
	MaHD char(4) not null,
	MaSP char(4) not null,
	SoLuongMua int,
	primary key(MaHD,MaSP)
)
go
insert into HoaDonChiTiet values('HD01','SP03',10),
								('HD02','SP01',5),
								('HD03','SP02',20)
go
create table LoaiSanPham
(
	MaLoai char(3	) not null primary key,
	TenLoai nvarchar(50) not null
)
go
insert into LoaiSanPham values('L01','Sony'),
							('L02','Samsung'),
							('L03','LG')
go
create table NguoiDung
(
	TenDangNhap varchar(10) not null primary key,
	Matkhau varchar(10) not null,
	Hoten nvarchar(50) not null
)
go
insert into NguoiDung values('Admin','12345','Chu Văn A'),
						('Customer','54321','Nguyễn Thị B'),
						('Manager','23123','Hoàng Văn C')
go
create table SanPham
(
	MaSP char(4) not null primary key,
	TenSP nvarchar(50) not null,
	MaLoai char(3),
	SoLuong int,
	DonGia int
)
go
insert into SanPham values('SP01','Tivi','L03',300,1500),
						('SP02','Điện thoại','L01',150,800),
						('SP03','Máy giặt','L02',100,1000)

Select*from HoaDon
Select*from KhachHang
Select*from HoaDonChiTiet
Select*from LoaiSanPham
Select*from NguoiDung
Select*from SanPham