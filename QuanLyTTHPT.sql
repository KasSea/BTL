

create database QuanLyTTHPT
use QuanLyTTHPT

GO

create table Tailieugiangday(
	maTl nchar(5) primary key,
	tenTl nvarchar(35),
	taiLieumon nvarchar(35),
	ngayXuatban datetime
)
go
-- thủ tục thêm tài liệu giảng dạy
create procedure themTLGD(
	@maTl nchar(5) ,
	@tenTl nvarchar(35),
	@taiLieumon nvarchar(35),
	@ngayXuatban datetime
)as
begin
	insert into Tailieugiangday(maTl,tenTl,taiLieumon,ngayXuatban)
	values (@maTl,@tenTl,@taiLieumon,@ngayXuatban)
end;
go
-- sử dụng thủ tục thêm tài liệu giảng dạy
execute themTLGD @maTl = 'TL001',@tenTl=N'Thủ tục',@taiLieumon = N'Lập trình dotnet',@ngayXuatban ='1-24-2003'
go

-- thủ tục select all tài liệu giảng dạy
create procedure selectallTLGD
as select * from Tailieugiangday
go
-- sử dụng thủ tục
exec selectallTLGD
go
-- thủ tục sửa tài liệu giảng dạy
create procedure suaTLGD(
	@maTl nchar(5) ,
	@tenTl nvarchar(35),
	@taiLieumon nvarchar(35),
	@ngayXuatban datetime
)as
begin
	update Tailieugiangday
	set tenTl = @tenTl , taiLieumon = @taiLieumon,ngayXuatban = @ngayXuatban
	where maTl = @maTl
end;
go
-- thủ tục xóa tài liệu giảng dạy
create proc xoaTLGD(
	@maTl nchar(5)
)as 
begin 
	delete from Tailieugiangday
	where maTl = @maTl
end;

go
drop table HocSinh

create table Hocsinh(
	MaHs nchar(5) primary key not null,
	TenHs nvarchar(30),
	Ngaysinh datetime,
	Gioitinh nchar(3),
	Tuoi int,
	Dantoc nvarchar(10),
	Noisinh nvarchar(40),
	trangthai nvarchar(30),
	MaLop Nchar(5) foreign key references LOP(MaLop)
)
go
-- tạo thủ tục thêm học sinh--
create procedure themHS(
	@MaHs nchar(5),
	@TenHs nvarchar(30),
	@Ngaysinh datetime,
	@Gioitinh nchar(3),
	@Tuoi int,
	@Dantoc nvarchar(10),
	@Noisinh nvarchar(40),
	@trangthai nvarchar(30),
	@MaLop Nchar(5)
)as
begin
	insert into Hocsinh(MaHs,TenHs,Ngaysinh,Gioitinh,Tuoi,Dantoc,Noisinh,trangthai,MaLop)
	values (@MaHs,@TenHs,@Ngaysinh,@Gioitinh,@Tuoi,@Dantoc,@Noisinh,@trangthai,@MaLop)
end;
go
-- tạo thủ tục sửa học sinh
create procedure suaHS(
	@MaHs nchar(5),
	@TenHs nvarchar(30),
	@Ngaysinh datetime,
	@Gioitinh nchar(3),
	@Tuoi int,
	@Dantoc nvarchar(10),
	@Noisinh nvarchar(40),
	@trangthai nvarchar(30),
	@MaLop Nchar(5)
)as
begin
	update Hocsinh
	set TenHs = @TenHs,Ngaysinh=@Ngaysinh,Gioitinh =@Gioitinh,Tuoi=@Tuoi,Dantoc=@Dantoc,Noisinh=@Noisinh,trangthai=@trangthai,MaLop=@MaLop
	where MaHs=@MaHs
end;

go
-- tạo thủ tục xóa học sinh
create procedure xoaHS(
	@MaHs nchar(5)
)as
begin
	delete from Hocsinh
	where MaHs=@MaHs
end;
go
-- thủ tạo select ra toàn bộ học sinh
create proc selectallHS as select * from Hocsinh

go
drop table Diemso

create table Diemso(
	MaHs nchar(5) Foreign key references Hocsinh(MaHs),
	Mahocphan nchar(5)Foreign key references MonHoc(Mahocphan),
	Diemso int,
	primary key(MaHs,Mahocphan)
)
go
create table MonHoc(
	Mahocphan nchar(5) primary key,
	Tenhocphan nvarchar(20),
	maTl nchar(5) foreign key references Tailieugiangday(maTl)
)
go


create table Giaovien(
	MaGV nchar(5) primary key not null,
	TenGV nvarchar(30),
	Ngaysinh datetime,
	Gioitinh nchar(3),
	Tuoi int,
	Dantoc nvarchar(10),
	Noisinh nvarchar(40),
	trangthai nvarchar(30),
	MaLop Nchar(5) foreign key references LOP(MaLop)
)
go
-- thủ tục thêm giáo viên
create procedure themGV(
	@MaGV nchar(5),
	@TenGV nvarchar(30),
	@Ngaysinh datetime,
	@Gioitinh nchar(3),
	@Tuoi int,
	@Dantoc nvarchar(10),
	@Noisinh nvarchar(40),
	@trangthai nvarchar(30),
	@MaLop Nchar(5)
)as
begin
	insert into Giaovien(MaGV,TenGV,Ngaysinh,Gioitinh,Tuoi,Dantoc,Noisinh,trangthai,MaLop)
	values (@MaGV,@TenGV,@Ngaysinh,@Gioitinh,@Tuoi,@Dantoc,@Noisinh,@trangthai,@MaLop)
end;
GO
--thủ tục sửa giáo viên
create procedure suaGV(
	@MaGV nchar(5),
	@TenGV nvarchar(30),
	@Ngaysinh datetime,
	@Gioitinh nchar(3),
	@Tuoi int,
	@Dantoc nvarchar(10),
	@Noisinh nvarchar(40),
	@trangthai nvarchar(30),
	@MaLop Nchar(5)
)as
begin
	update Giaovien
	set TenGV = @TenGV,Ngaysinh=@Ngaysinh,Gioitinh =@Gioitinh,Tuoi=@Tuoi,Dantoc=@Dantoc,Noisinh=@Noisinh,trangthai=@trangthai,MaLop=@MaLop
	where MaGV=@MaGV
end;
GO
-- thủ tục xóa giáo viên
create procedure xoaGV(
	@MaGV nchar(5)
)AS
BEGIN
	delete from Giaovien 
	where MaGV=@MaGV
END;
go
-- thủ tục select toàn bộ giáo viên
create proc selectallGV as select * from Giaovien

go
CREATE TABLE LOP(
	MaLop Nchar(5) primary key,
	Tenlop nvarchar(20),
	Trangthai nvarchar(20),
	GhiChu nvarchar(50)
)
go
-- thủ tục thêm lớp
create proc themLop(
	@MaLop Nchar(5),
	@Tenlop nvarchar(20),
	@Trangthai nvarchar(20),
	@GhiChu nvarchar(50)
)as
begin
	insert into LOP(MaLop,Tenlop,Trangthai,GhiChu) values (@MaLop,@Tenlop,@Trangthai,@GhiChu)
end;

go
-- thủ tục xóa lớp
create proc SuaLop(
	@MaLop Nchar(5),
	@Tenlop nvarchar(20),
	@Trangthai nvarchar(20),
	@GhiChu nvarchar(50)
)as
begin
	update LOP
	set Tenlop =@Tenlop,Trangthai=@Trangthai,GhiChu=@GhiChu
	where MaLop = @MaLop
end;



go
-- thủ tục xóa lớp
create proc XoaLop(
	@MaLop Nchar(5)
	
)as
begin
	delete from LOP
	where MaLop = @MaLop
end;

go
create proc selectallLop as select * from LOP
go
create table Thoikhoabieu(
	Thoigian nvarchar(50),
	Mahocphan nchar(5) foreign key references MonHoc(Mahocphan),
	MaLop Nchar(5) foreign key references LOP(MaLop),
	MaGV nchar(5) foreign key references GiaoVien(MaGV),
	Thoigiangiailao nvarchar(50),
	primary key(Mahocphan,MaLop,MaGV)
)
go
-- thêm thời khóa biểu
create procedure themTKB(
	@Thoigian nvarchar(50),
	@Mahocphan nchar(5),
	@MaLop Nchar(5) ,
	@MaGV nchar(5) ,
	@Thoigiangiailao nvarchar(50)
	
)AS
 BEGIN
	insert into Thoikhoabieu(Thoigian,Mahocphan,MaLop,MaGV,Thoigiangiailao) values (@Thoigian,@Mahocphan,@MaLop,@MaGV,@Thoigiangiailao)
 END;

go
-- thủ tục sửa thời khóa biểu
create procedure suaTKB(
	@Thoigian nvarchar(50),
	@Mahocphan nchar(5),
	@MaLop Nchar(5) ,
	@MaGV nchar(5) ,
	@Thoigiangiailao nvarchar(50)
	
)AS
 BEGIN
	update Thoikhoabieu
	set Thoigian = @Thoigian, Thoigiangiailao =@Thoigiangiailao
	where Mahocphan=@Mahocphan and MaLop=@MaLop and MaGV =@MaGV
 END;
go
-- thủ tục xóa thời khóa biểu
	create procedure xoaTKB(
	@Mahocphan nchar(5),
	@MaLop Nchar(5) ,
	@MaGV nchar(5) 
)AS
 BEGIN
	delete from Thoikhoabieu
	where Mahocphan=@Mahocphan and MaLop=@MaLop and MaGV =@MaGV
 END;
go
Create table QuanlyTk(
	maTk nchar(5) primary key,
	tenTk nvarchar(30),
	matkhauTk nchar(15),
	thongtinTk nvarchar(30),
	GhiChu nvarchar(50)
)

go
-- thủ tục thêm tài khoản mới --
create proc themTk(
	@maTk nchar(5),
	@tenTk nvarchar(30),
	@matkhauTk nchar(15),
	@thongtinTk nvarchar(30),
	@GhiChu nvarchar(50)
)AS
BEGIN
	INSERT INTO QuanlyTk(maTk,tenTk,matkhauTk,thongtinTk,GhiChu)
	VALUES (@maTk,@tenTk,@matkhauTk,@thongtinTk,@GhiChu)
END;

go
--sử dụng thủ tục thêm tài khoản mới
exec themTk @maTk = 'TK001',@tenTk = 'lotienanh',@matkhauTk='abc@123',@thongtinTk = N'Gia nhập từ 2003',@GhiChu=N'Hoạt Động'

go
-- thủ tục sửa tài khoản ---
create proc suaTk(
	@maTk nchar(5),
	@tenTk nvarchar(30),
	@matkhauTk nchar(15),
	@thongtinTk nvarchar(30),
	@GhiChu nvarchar(50)
)AS
BEGIN
	update QuanlyTk 
	set tenTk = @tenTk, matkhauTk = @matkhauTk,thongtinTk=@thongtinTk,GhiChu=@GhiChu
	where maTk = @maTk 
END;
go

-- thủ tục xóa tài khoản

create proc xoaTk(
	@maTk nchar(5)
)AS
BEGIN
	delete from QuanlyTk
	where maTk = @maTk 
END;

go
-- thủ tục hiển thị tất cả tài khoản
	create proc selectallQuanlyTk
	as select * from QuanlyTk
go
--sử dụng thủ tục hiên thị
execute selectallQuanlyTk
go

create proc Check_login(
	@user nvarchar(50),
	@password nvarchar(50)
)as
begin
	select * from tblTaikhoan where tenTk = @user and matkhauTk =@password 
end;

go

create proc Dangky_Tk(
	@email nvarchar(max),
	@TenTk nvarchar(50),
	@matkhauTk nvarchar(50)
)as
begin
	insert into tblTaikhoan(emailTk,tenTk,matkhauTk) values (@email,@TenTk,@matkhauTk)
end;
go

ALTER TABLE [dbo].[tblTaikhoan]
DROP COLUMN Fk_maQuyen;
ALTER TABLE [dbo].[tblTaikhoan] ALTER COLUMN maTk nchar(10) NULL;

go

alter procedure ForgotPw(
	@email nvarchar(max)
)as
begin
	select * from tblTaikhoan where emailTk = @email
end;
go
exec ForgotPw @email = N'newbie@gmail.com'
go
 create proc HienTHiMkQuen(
	@email nvarchar(max) 
 )as
 begin
	select matkhauTk from tblTaikhoan where emailTk = @email
 end;

 exec HienTHiMkQuen @email = N'newbie@gmail.com'

 go
 exec selectallTLGD

 go
-- tạo thủ tục tìm kiếm tài liệu theo tên
ALTER PROCEDURE TimkiemTLtheoTen
    @taiLieumon NVARCHAR(50)
AS
BEGIN
    SELECT maTl,tenTl,taiLieumon,ngayXuatban
    FROM Tailieugiangday
    WHERE taiLieumon LIKE '%' + @taiLieumon + '%'
END

go 
exec TimkiemTLtheoTen @taiLieumon = N'l'