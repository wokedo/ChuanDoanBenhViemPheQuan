create database DULIEUBENH1
use DULIEUBENH1

create table ThongTin
(
	STT int not null primary key,
	HoTen nvarchar(100)  not null  ,
	Ho nvarchar(50),
	KhacDom nvarchar(50), 
	BieuHien nvarchar(50),
	Sot nvarchar(50),
	HoHap nvarchar(50),
	XQuang nvarchar(50),
	SucCanDuongTho nvarchar(50),
	DLCO nvarchar(50),
	KhiMau nvarchar(50),
	KetQua nvarchar(50)
)
delete ThongTin