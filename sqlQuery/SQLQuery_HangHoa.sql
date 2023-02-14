drop proc spGetDSHangHoa
GO
drop proc spGetDSHangHoaByID
GO
drop proc spInsertHangHoa
GO
drop proc spUpdateHangHoa
GO
drop proc spDeleteHangHoa
GO
drop proc spUpdateBanHang
GO

create procedure spGetDSHangHoa
as
begin 
	select id_HangHoa, id_KhoQuanLy, MaHangHoa, TenHangHoa, GiaTien, NgaySanXuat, HanSD from HangHoa 
	where is_Ban = 0;
end
GO

create procedure spGetDSHangHoaByID
	@id_KhoQuanLy int
as
begin 
	select id_HangHoa, id_KhoQuanLy, MaHangHoa, TenHangHoa, GiaTien, NgaySanXuat, HanSD from HangHoa
	where id_KhoQuanLy = @id_KhoQuanLy and is_Ban = 0;
end
GO

/* Them hang hoa */
create procedure spInsertHangHoa
	@id_HangHoa nvarchar(100),
	@id_KhoQuanLy int,
	@MaHangHoa nvarchar(100),
	@TenHangHoa nvarchar(100),
	@GiaTien int,
	@NgaySanXuat datetime,
	@HanSD datetime, 
	@is_Ban bit
as
begin
	insert into HangHoa(id_HangHoa, id_KhoQuanLy, MaHangHoa, TenHangHoa, GiaTien, NgaySanXuat, HanSD, is_Ban)
	values(@id_HangHoa, @id_KhoQuanLy, @MaHangHoa, @TenHangHoa, @GiaTien, @NgaySanXuat, @HanSD, @is_Ban);

	exec spSoHangHoaTrongKhoHang @id_Kho=@id_KhoQuanLy, @val = 1;
end
GO

/* Sua hang hoa */
create procedure spUpdateHangHoa
	@id_HangHoa nvarchar(100),
	@id_KhoQuanLy int,
	@MaHangHoa nvarchar(100),
	@TenHangHoa nvarchar(100),
	@GiaTien int,
	@NgaySanXuat datetime,
	@HanSD datetime,
	@is_Ban bit
as
begin
	update HangHoa set
		id_KhoQuanLy=@id_KhoQuanLy,
		MaHangHoa=@MaHangHoa,
		TenHangHoa=@TenHangHoa,
		GiaTien=@GiaTien,
		NgaySanXuat=@NgaySanXuat,
		HanSD=@HanSD,
		is_Ban = @is_Ban
	where id_HangHoa = @id_HangHoa
	
end
GO

/* Xoa hang hoa */
create procedure spDeleteHangHoa
	@id_HangHoa nvarchar(100),
	@id_KhoQuanLy int
as
begin
	update HangHoa set
		is_Ban = 1
	where id_HangHoa = @id_HangHoa;

	exec spSoHangHoaTrongKhoHang @id_Kho=@id_KhoQuanLy, @val = -1;
	
end
GO

/* Cap nhat hang da ban */
create procedure spUpdateBanHang
	@id_HangHoa nvarchar(100)
as 
begin
	update HangHoa set
		is_Ban = 1
	where id_HangHoa = @id_HangHoa
end
GO

