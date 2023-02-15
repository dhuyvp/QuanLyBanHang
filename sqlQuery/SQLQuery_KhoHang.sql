drop procedure spUpdateTaiChinhKhoHang
GO
drop proc spGetDSKho
GO
drop proc spGetKhoByIDKho
GO
drop proc spInsertKhoHang
GO
drop proc spUpdateKhoHang
GO
drop proc spDeleteKhoHangByID
GO
drop proc spSoNVTrongKhoHang
GO
drop proc spSoHangHoaTrongKhoHang
GO

/* Sua hang hoa */
create procedure spUpdateTaiChinhKhoHang
	@id_KhoQuanLy int,
	@TaiChinh int
as
begin
	update KhoHang set
		TaiChinh=TaiChinh + @TaiChinh
	where id_KhoQuanLy = @id_KhoQuanLy;
	
end
GO

create procedure spGetDSKho
as
begin 
	select id_KhoQuanLy, DiaChi, TaiChinh, soNhanVien, soHangHoa from KhoHang 
	where id_KhoQuanLy <> 0 and HoatDong = 1; 
end
GO

create procedure spGetKhoByIDKho
	@id_KhoQuanLy int
as
begin 
	select * from KhoHang
	where id_KhoQuanLy = @id_KhoQuanLy and id_KhoQuanLy <> 0 and HoatDong = 1;
end
GO

/*----------------------*/
create procedure spInsertKhoHang
	@id_KhoQuanLy int,
	@DiaChi nvarchar(100),
	@TaiChinh int,
	@soNhanVien int,
	@soHangHoa int
as
begin
	insert into KhoHang(id_KhoQuanLy, DiaChi, TaiChinh, soNhanVien, soHangHoa, HoatDong)
	values(@id_KhoQuanLy, @DiaChi, @TaiChinh, @soNhanVien, @soHangHoa, 1);
end
GO

create procedure spUpdateKhoHang
	@id_KhoQuanLy int,
	@DiaChi nvarchar(100),
	@TaiChinh int,
	@soNhanVien int,
	@soHangHoa int
as
begin
	update KhoHang set 
		id_KhoQuanLy = @id_KhoQuanLy,
		DiaChi = @DiaChi,
		TaiChinh = @TaiChinh,
		soNhanVien = @soNhanVien,
		soHangHoa = @soHangHoa
	where id_KhoQuanLy = @id_KhoQuanLy
end
GO

create procedure spDeleteKhoHangByID
	@id_KhoQuanLy int
as
begin
	delete from TaiKhoan where id_KhoQuanLy = @id_KhoQuanLy;
	delete from NhanVien where id_KhoQuanLy = @id_KhoQuanLy;
	update KhoHang set
		HoatDong = 0
	where id_KhoQuanLy = @id_KhoQuanLy;
end
GO

create procedure spSoNVTrongKhoHang
	@id_Kho int,
	@val int
as
begin
	update KhoHang set
		soNhanVien = soNhanVien + @val
	where id_KhoQuanLy = @id_Kho
end
GO

create procedure spSoHangHoaTrongKhoHang
	@id_Kho int,
	@val int
as
begin
	update KhoHang set
		soHangHoa = soHangHoa + @val
	where id_KhoQuanLy = @id_Kho
end
GO