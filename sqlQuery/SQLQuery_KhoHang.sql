drop procedure spUpdateKhoHang
GO
/* Sua hang hoa */
create procedure spUpdateKhoHang
	@id_KhoQuanLy int,
	@TaiChinh int
as
begin
	update KhoHang set
		id_KhoQuanLy=@id_KhoQuanLy, 
		TaiChinh=TaiChinh + @TaiChinh
	where id_KhoQuanLy = @id_KhoQuanLy;
	
end
GO
