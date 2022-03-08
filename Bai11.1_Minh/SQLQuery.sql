CREATE DATABASE Bai11_1
GO
USE Bai11_1
GO
CREATE TABLE Brand(
MaHang char(3) PRIMARY KEY,
TenHang  nvarchar(20) )
GO
CREATE TABLE Product(
MaSP char(3) PRIMARY KEY,
TenSP  nvarchar(20),
DonGia float,
Mau nvarchar(20),
MaHang char(3) )

Select*from Brand
Select*from Product

insert into Product values('006','Tivi',500,'Do','003')