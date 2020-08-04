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
	MaKH int identity(1,1) primary key,
	HoTen nvarchar(50) not null,
	SoDT char(11) not null,

)
create table loaisp(
	Maloai char(10) primary key,
	Loai nvarchar(20),
	
)
create table Mon
(
	MaMon varchar(5) primary key,
	TenMon nvarchar(50),
	maLoai char(10) references loaisp(maloai),
	Gia money,
	hinh image NULL,
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
--create table hoadon
--(
--	MaHD int identity(1,1) primary key,
--	MaKH int references KhachHang(MaKH),
--	MaNV varchar(10) references NhanVien(MaNV),
--	Ngaylap date,
--)
create table hoadon
(
MaHD int identity(1,1) primary key,
Ngaylap date,
MaKH int references KhachHang(MaKH),
MaNV varchar(10) references NhanVien(MaNV),
)
create table chitiethoadon
(
	MaCTHD int identity(1,1) primary key,
	MaHD int references hoadon(MaHD),
	MaMon varchar(5) references Mon(MaMon),
	Maloai char(10) references Loaisp(MaLoai),
	Soluong int,
	Gia money,
	ThanhTien money,
	
)
ALTER TABLE KhachHang ADD CONSTRAINT CHECK_SDT CHECK(LEN(SoDT)=10)
/****** Object:  ForeignKey FK_NhanVien_LoaiTK    Script Date: 04/05/2016 14:01:49 ******/
ALTER TABLE NHANVIEN   ADD  CONSTRAINT FK_NhanVien_LoaiTK FOREIGN KEY(MaLTK) REFERENCES LOAITK (MaLTK)
GO
/****** Object:  ForeignKey FK_NhanVien_LoaiTK    Script Date: 04/05/2016 14:01:49 ******/
ALTER TABLE CHAMCONG   ADD  CONSTRAINT FK_ChamCong_NhanVien FOREIGN KEY(MaNV) REFERENCES NHANVIEN (MaNV)
alter table chitiethoadon add constraint soluong1 default 0 for Soluong
GO

insert into loaisp values('Cafe','cafe')
insert into loaisp values('NuocNgot','Nước ngọt')
insert into loaisp values ('AnVat','Đồ ăn')

insert into Mon values('cafe1','Cafe den','Cafe',15000,NULL)
insert into Mon values('cafe2',N'Cafe sữa','Cafe',15000,NULL)
insert into Mon values('cafe3',N'Bạc xỉu','Cafe',15000,NULL)
insert into Mon values('nt1','Coca','NuocNgot',15000,NULL)
insert into Mon values('nt2','Mirina','NuocNgot',15000,NULL)
insert into Mon values('nt3','Pepsi','NuocNgot',15000,NULL)
insert into Mon values('dav1',N'Bánh Tráng Trộn','AnVat',15000,NULL)
insert into Mon values('dav2',N'Bánh Hoa Quả','AnVat',15000,NULL)
insert into Mon values('dav3',N'Bánh Dây Tây','AnVat',15000,NULL)
insert into Mon values('dav4',N'Pancake','AnVat',15000,NULL)

--Insert table LOAITK
insert into LOAITK values(1,N'Admin')
insert into LOAITK values(2,N'Nhân Viên Bán Hàng')
insert into LOAITK values(3,N'Nhân Viên Quản Lý Kho')


--Insert table NHANVIEN
insert into NHANVIEN values('NV0001', N'Aoki Daisuke', 1 ,N'Osaka','123456', 'aokidaisuke91@gmail.com','admin','123',1)
insert into NHANVIEN values('NV0002', N'Trần Tiến Đạt', 1 ,N'An Giang', '0913131788', 'đâtt@gmail.com','nvdat','123',2)
insert into NHANVIEN values('NV0003', N'Nguyễn Kim Ngân',0 ,N'Bình Dương', '098123733', 'vinhquang@gmail.com','nkngan','123',3)


CREATE TRIGGER TRG_KTRA_KQ ON dbo.chitiethoadon
AFTER UPDATE, INSERT
AS
	BEGIN TRANSACTION
		DECLARE @MaCTHD int, @Soluong int, @Gia money,@Thanhtien money
		SELECT @MaCTHD=MaCTHD,@Soluong = Soluong, @Gia = Gia FROM INSERTED
		SELECT @Thanhtien = @Soluong*@Gia FROM DBO.chitiethoadon 
		UPDATE dbo.chitiethoadon SET thanhtien = @thanhtien WHERE MaCTHD=@MaCTHD
		IF(@@ERROR != 0)
	BEGIN
		RAISERROR(N'KHONG THE UPDATE DU LIEU', 0 , 1)
		ROLLBACK TRANSACTION
	END
		ELSE COMMIT TRANSACTION
GO


