drop proc spInsertTaiKhoan
GO
drop proc spUpdateTaiKhoan
GO
drop proc spDeleteTaiKhoan
GO

/* Them tai khoan */
create procedure spInsertTaiKhoan
	@tk_Username nvarchar(100),
	@tk_Password nvarchar(100),
	@is_Admin bit,
	@is_NhanVien bit,
	@is_KhachHang bit,
	@id_KhoQuanLy int
as
begin
	insert into TaiKhoan(tk_Username, tk_Password, is_Admin, is_NhanVien, is_KhachHang, id_KhoQuanLy)
	values(@tk_Username, @tk_Password, @is_Admin, @is_NhanVien, @is_KhachHang, @id_KhoQuanLy);
end
GO

/* Sua tai khoan */
create procedure spUpdateTaiKhoan
	@tk_Username nvarchar(100),
	@tk_Password nvarchar(100),
	@is_Admin bit,
	@is_NhanVien bit,
	@is_KhachHang bit,
	@id_KhoQuanLy int
as
begin
	update TaiKhoan set
		tk_Username = @tk_Username,
		tk_Password = @tk_Password,
		is_Admin = @is_Admin,
		is_NhanVien = @is_NhanVien, 
		is_KhachHang = @is_KhachHang,
		id_KhoQuanLy = @id_KhoQuanLy
	where tk_Username = @tk_Username
end
GO

/* Xoa tai khoan */
create procedure spDeleteTaiKhoan
	@tk_Username nvarchar(100)
as
begin
	delete from TaiKhoan where tk_Username = @tk_Username;
end

select * from TaiKhoan