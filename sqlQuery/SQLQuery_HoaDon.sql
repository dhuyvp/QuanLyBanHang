drop procedure spDeleteHoaDon
GO
drop procedure spInsertHoaDon
GO
drop procedure spUpdateHoaDon
GO
drop procedure spGetDSHangHoaTheoHoaDon
GO
drop procedure spGetDSHoaDonTheoKhachHang
GO


/* Xoa Khach hang */
create procedure spDeleteHoaDon
	@MaHoaDon nvarchar(100)
as 
begin
	delete from HoaDon where MaHoaDon=@MaHoaDon;
end
GO

/* Them Khach hang */
create procedure spInsertHoaDon
	@MaHoaDon nvarchar(100) ,
	@id_KhachHang nvarchar(100) ,
	@ThoiGian datetime ,
	@GiaTien int ,
	@HinhThucThanhToan nvarchar(100) 
as
begin
	insert into HoaDon(MaHoaDon, id_KhachHang, ThoiGian, GiaTien, HinhThucThanhToan)
	values(@MaHoaDon, @id_KhachHang, @ThoiGian, @GiaTien, @HinhThucThanhToan);
	
end
GO

/* Cap nhat Khach hang */
create procedure spUpdateHoaDon
	@MaHoaDon nvarchar(100) ,
	@id_KhachHang nvarchar(100) ,
	@ThoiGian datetime ,
	@GiaTien int ,
	@HinhThucThanhToan nvarchar(100) 
as
begin
	update HoaDon set 
		MaHoaDon = @MaHoaDon, 
		id_KhachHang = @id_KhachHang, 
		ThoiGian = @ThoiGian, 
		GiaTien = @GiaTien, 
		HinhThucThanhToan = @HinhThucThanhToan
	where MaHoaDon = @MaHoaDon;

end
GO

/*
select HoaDonChiTiet.MaHoaDon, HangHoa.id_HangHoa, HangHoa.id_KhoQuanLy, HangHoa.MaHangHoa, HangHoa.TenHangHoa, HangHoa.GiaTien, HangHoa.NgaySanXuat, HangHoa.HanSD
from HangHoa
inner join HoaDonChiTiet 
on HangHoa.id_HangHoa = HoaDonChiTiet.id_HangHoa
where HoaDonChiTiet.MaHoaDon = ''
GO
*/


create procedure spGetDSHangHoaTheoHoaDon
	@MaHoaDon nvarchar(100),
	@id_KhachHang nvarchar(100) 
as
begin
	select HoaDonChiTiet.MaHoaDon, HangHoa.id_HangHoa, HangHoa.id_KhoQuanLy, HangHoa.MaHangHoa, HangHoa.TenHangHoa, HangHoa.GiaTien, HangHoa.NgaySanXuat, HangHoa.HanSD
	from (HangHoa
	inner join HoaDonChiTiet 
	on HangHoa.id_HangHoa = HoaDonChiTiet.id_HangHoa)
	inner join HoaDon 
	on HoaDonChiTiet.MaHoaDon = HoaDon.MaHoaDon
	where HoaDonChiTiet.MaHoaDon like @MaHoaDon and HoaDon.id_KhachHang = @id_KhachHang;
end
GO


create procedure spGetDSHoaDonTheoKhachHang
	@id_KhachHang nvarchar(100)
as
begin
	select MaHoaDon from HoaDon 
	where id_KhachHang = @id_KhachHang;
end



