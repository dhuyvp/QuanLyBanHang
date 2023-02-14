drop proc UpdateTongTien
GO
create procedure UpdateTongTien
as
begin
	update ThongKe set
		TongTien = (select sum(GiaTien) from HoaDon where ThongKe.id_KhachHang = HoaDon.id_KhachHang)
	where (select count(*) from HoaDon where HoaDon.id_KhachHang = ThongKe.id_KhachHang) <> 0
end
GO

exec UpdateTongTien
GO
