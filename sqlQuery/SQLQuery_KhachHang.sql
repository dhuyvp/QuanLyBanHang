drop procedure spGetDSKhachHang
GO
drop procedure spDeleteKhachHang
GO
drop procedure spInsertKhachHang
GO
drop procedure spUpdateKhachHang
GO

create procedure spGetDSKhachHang
as
begin
	update ThongKe set
		TongTien = (select sum(GiaTien) from HoaDon where ThongKe.id_KhachHang = HoaDon.id_KhachHang)
	where (select count(*) from HoaDon where HoaDon.id_KhachHang = ThongKe.id_KhachHang) <> 0;
	
	select KhachHang.id_KhachHang, KhachHang.HoTen, KhachHang.GioiTinh, KhachHang.NgaySinh, KhachHang.DienThoai, KhachHang.Email, KhachHang.DiaChi, ThongKe.TongTien
	from KhachHang 
	inner join ThongKe
	on KhachHang.id_KhachHang = ThongKe.id_KhachHang
	order by ThongKe.TongTien desc;
end
GO

/* Xoa Khach hang */
create procedure spDeleteKhachHang
	@id_KhachHang nvarchar(100)
as 
begin
	delete from KhachHang where id_KhachHang=@id_KhachHang;

	delete from TaiKhoan where tk_Username = @id_KhachHang;

	delete from ThongKe where id_KhachHang = @id_KhachHang;
end
GO

/* Them Khach hang */
create procedure spInsertKhachHang
	@id_KhachHang nvarchar(100),
	@MatKhau nvarchar(100),
	@HoTen nvarchar(100) ,
	@GioiTinh nvarchar(100) ,
	@NgaySinh datetime ,
	@DienThoai nvarchar(100) ,
	@Email nvarchar(100),
	@DiaChi nvarchar(100)
as
begin
	insert into KhachHang(id_KhachHang, HoTen, GioiTinh, NgaySinh, DienThoai, Email, DiaChi)
	values(@id_KhachHang, @HoTen, @GioiTinh, @NgaySinh, @DienThoai, @Email, @DiaChi);
	
	insert into TaiKhoan(tk_Username, tk_Password, is_Admin, is_NhanVien, is_KhachHang, id_KhoQuanLy)
	values(@id_KhachHang, @MatKhau, 0, 0, 1, 0);

	declare @id_ThongKe nvarchar(100) = (select dbo.funGetNextIDThongKe());
	insert into ThongKe(id_ThongKe, id_KhachHang, TongTien)
	values (@id_ThongKe, @id_KhachHang, 0);
end
GO

/* Cap nhat Khach hang */
create procedure spUpdateKhachHang
	@id_KhachHang nvarchar(100),
	@MatKhau nvarchar(100),
	@HoTen nvarchar(100),
	@GioiTinh nvarchar(100),
	@NgaySinh datetime,
	@DienThoai nvarchar(100),
	@Email nvarchar(100),
	@DiaChi nvarchar(100)
as
begin
	update KhachHang set 
		@id_KhachHang = @id_KhachHang, 
		HoTen = @HoTen, 
		GioiTinh = @GioiTinh, 
		NgaySinh = @NgaySinh, 
		DienThoai = @DienThoai, 
		Email = @Email, 
		DiaChi = @DiaChi
	where id_KhachHang = @id_KhachHang;

	update TaiKhoan set
		tk_Username = @id_KhachHang,
		tk_Password = @MatKhau,
		is_Admin = 0,
		is_NhanVien = 0, 
		is_KhachHang = 1,
		id_KhoQuanLy = 0
	where tk_Username = @id_KhachHang;
end
GO

select * from TaiKhoan
GO