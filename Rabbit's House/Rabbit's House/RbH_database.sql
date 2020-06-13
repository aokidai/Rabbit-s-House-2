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
	SoDT char(10) not null,

)
create table Cafe
(
	
)