create database Rabbit_s_House on primary
(
	name = 'Rabbit_s_House',
	filename = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Rabbit_s House.mdf',
	size =30MB, filegrowth =10%, maxsize=200mb
)
log on
(
	name = 'Rabbit_s_House_Log',
	filename = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Rabbit_s House_log.ldf',
	size =10mb, filegrowth = 2mb, maxsize=unlimited
)
go 
use Rabbit_s_House
go

create table KhachHang
(
	MaKH char(4) primary key,
	HoTen nvarchar(50) not null,
	SoDT char(11) not null,

)
create table Mon
(
	MaMon varchar(5) primary key,
	TenMon nvarchar(50),
	Gia varchar(10),
	hinh image NULL,
)
create table hoadon
(
	MaKH char(4) references KhachHang(MaKH),
	MaMon varchar(5) references Mon(MaMon),
	primary key(MaKH,MaMon)
)
CREATE TABLE NHANVIEN(
	MaNV varchar(10) NOT NULL,
	TenNV nvarchar(30) NOT NULL,
	GioiTinh bit NOT NULL,
	DiaChi nvarchar(100) NOT NULL,
	SoDT varchar(12) NOT NULL,
	Email varchar(50) NULL,
	UserName nvarchar(30) NOT NULL,
	Password nvarchar(30) NOT NULL,
	MaLTK int NOT NULL,
 CONSTRAINT PK_NhanVien PRIMARY KEY (MaNV)
)
CREATE TABLE CHAMCONG(
	Id int  identity(1,1) NOT NULL,
	MaNV varchar(10) NOT NULL,
	Ngay datetime NOT NULL,
	SoGio int NOT NULL,
 CONSTRAINT PK_CHAMCONG PRIMARY KEY (Id)
)
CREATE TABLE LOAITK(
	MaLTK int NOT NULL,
	TenLTK nvarchar(30) NULL,
	CONSTRAINT PK_LOAITK PRIMARY KEY (MaLTK)
)

ALTER TABLE KhachHang ADD CONSTRAINT CHECK_SDT CHECK(LEN(SoDT)=10)
/****** Object:  ForeignKey FK_NhanVien_LoaiTK    Script Date: 04/05/2016 14:01:49 ******/
ALTER TABLE NHANVIEN   ADD  CONSTRAINT FK_NhanVien_LoaiTK FOREIGN KEY(MaLTK) REFERENCES LOAITK (MaLTK)
GO
/****** Object:  ForeignKey FK_NhanVien_LoaiTK    Script Date: 04/05/2016 14:01:49 ******/
ALTER TABLE CHAMCONG   ADD  CONSTRAINT FK_ChamCong_NhanVien FOREIGN KEY(MaNV) REFERENCES NHANVIEN (MaNV)
GO

insert into Mon values('cafe1','Cafe den',15000,NULL)
insert into Mon values('cafe2',N'Cafe sữa',15000,NULL)
insert into Mon values('cafe3',N'Bạc xỉu',15000,NULL)
insert into Mon values('cafe4','Ca cao',15000,NULL)
insert into Mon values('cafe5',N'Socala dá xay',15000,NULL)
insert into Mon values('cafe6',N'Caramel dá xay',15000,NULL)
insert into Mon values('nt1','Coca',15000,NULL)
insert into Mon values('nt2','Mirina',15000,NULL)
insert into Mon values('nt3','Pepsi',15000,NULL)
insert into Mon values('nt4','7 up',15000,NULL)
insert into Mon values('nt5','Fanta',15000,NULL)
insert into Mon values('nt6','Sprite',15000,NULL)
insert into Mon values('dav1',N'Bánh Tráng Trộn',15000,NULL)
insert into Mon values('dav2',N'Bánh Hoa Quả',15000,NULL)
insert into Mon values('dav3',N'Bánh Dây Tây',15000,NULL)
insert into Mon values('dav4',N'Pancake',15000,NULL)
insert into Mon values('dav5',N'Cupcake',15000,NULL)
insert into Mon values('dav6','jelly cake',15000,NULL)

--Insert table LOAITK
insert into LOAITK values(1,N'Admin')
insert into LOAITK values(2,N'Nhân Viên Bán Hàng')
insert into LOAITK values(3,N'Nhân Viên Quản Lý Kho')


--Insert table NHANVIEN
insert into NHANVIEN values('NV0001', N'Aoki Daisuke', 1 ,N'Osaka','123456', 'aokidaisuke91@gmail.com','admin','123',1)
insert into NHANVIEN values('NV0002', N'Trần Tiến Đạt', 1 ,N'An Giang', '0913131788', 'đâtt@gmail.com','nvdat','123',2)
insert into NHANVIEN values('NV0003', N'Nguyễn Kim Ngân',0 ,N'Bình Dương', '098123733', 'vinhquang@gmail.com','nkngan','123',3)
