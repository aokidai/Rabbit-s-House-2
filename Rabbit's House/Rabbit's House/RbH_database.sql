create database Rabbit_s_House on primary
(
	name = 'Rabbit_s_House',
	filename = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLSinhVien.mdf',
	size =30MB, filegrowth =10%, maxsize=200mb
)
log on
(
	name = 'Rabbit_s_House_Log',
	filename = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLSinhVien_log.ldf',
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
)
create table datmon
(
	MaKH char(4) references KhachHang(MaKH),
	MaMon varchar(5) references Mon(MaMon),
	primary key(MaKH,MaMon)
)
ALTER TABLE SINHVIEN ADD CONSTRAINT CHECK_SDT CHECK(LEN(DIENTHOAI)=10)

insert into Mon values('cafe1','Cafe den',15000)
insert into Mon values('cafe2',N'Cafe sữa',15000)
insert into Mon values('cafe3',N'Bạc xỉu',15000)
insert into Mon values('cafe4','Ca cao',15000)
insert into Mon values('cafe5',N'Socala dá xay',15000)
insert into Mon values('cafe6',N'Caramel dá xay',15000)
insert into Mon values('nt1','Coca',15000)
insert into Mon values('nt2','Mirina',15000)
insert into Mon values('nt3','Pepsi',15000)
insert into Mon values('nt4','7 up',15000)
insert into Mon values('nt5','Fanta',15000)
insert into Mon values('nt6','Sprite',15000)
insert into Mon values('dav1',N'Bánh Tráng Trộn',15000)
insert into Mon values('dav2',N'Bánh Hoa Quả',15000)
insert into Mon values('dav3',N'Bánh Dây Tây',15000)
insert into Mon values('dav4',N'Pancake',15000)
insert into Mon values('dav5',N'Cupcake',15000)
insert into Mon values('dav6','jelly cake',15000)