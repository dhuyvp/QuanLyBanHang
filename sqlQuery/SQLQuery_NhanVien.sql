/* drop */
drop proc spGetDSNhanVien
GO
drop proc spDeleteNhanVien
GO
drop proc spInsertNhanVien
GO
drop proc spUpdateNhanVien
GO

create procedure spGetDSNhanVien
as
begin
	select * from NhanVien
end
GO

/* Xoa Nhan Vien */
create procedure spDeleteNhanVien
	@id_NhanVien nvarchar(10)
as 
begin
	delete from NhanVien where id_NhanVien=@id_NhanVien
end
GO

/* Them Nhan Vien */
create procedure spInsertNhanVien
	@id_NhanVien nvarchar(100),
	@id_KhoQuanLy int ,
	@HoTen nvarchar(100),
	@GioiTinh nvarchar(100),
	@NgaySinh datetime,
	@DienThoai nvarchar(100),
	@Email nvarchar(100),
	@DiaChi nvarchar(100)
as
begin
	insert into NhanVien(id_NhanVien, id_KhoQuanLy, HoTen, GioiTinh, NgaySinh, DienThoai, Email, DiaChi)
	values(@id_NhanVien, @id_KhoQuanLy, @HoTen, @GioiTinh, @NgaySinh, @DienThoai, @Email, @DiaChi)
end
GO

/* Cap nhat Nhan Vien */
create procedure spUpdateNhanVien
	@id_NhanVien nvarchar(100),
	@id_KhoQuanLy int ,
	@HoTen nvarchar(100),
	@GioiTinh nvarchar(100),
	@NgaySinh datetime,
	@DienThoai nvarchar(100),
	@Email nvarchar(100),
	@DiaChi nvarchar(100)
as
begin
	update NhanVien set 
		id_NhanVien = @id_NhanVien, 
		id_KhoQuanLy = @id_KhoQuanLy, 
		HoTen = @HoTen, 
		GioiTinh = @GioiTinh, 
		NgaySinh = @NgaySinh, 
		DienThoai = @DienThoai, 
		Email = @Email, 
		DiaChi = @DiaChi
	where id_NhanVien = @id_NhanVien
end
GO
