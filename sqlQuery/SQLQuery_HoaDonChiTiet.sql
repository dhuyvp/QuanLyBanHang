drop procedure spGetDSHoaDonChiTiet
GO
drop procedure spDeleteHoaDonChiTiet
GO
drop procedure spInsertHoaDonChiTiet
GO
drop procedure spUpdateHoaDonChiTiet
GO

create procedure spGetDSHoaDonChiTiet
as
begin
	select * from HoaDonChiTiet
end
GO

/* Xoa Khach hang */
create procedure spDeleteHoaDonChiTiet
	@id_GiaoDich nvarchar(100)
as 
begin
	delete from HoaDonChiTiet where id_GiaoDich=@id_GiaoDich;
end
GO

/* Them Khach hang */
create procedure spInsertHoaDonChiTiet
	@id_GiaoDich  nvarchar(100),
	@id_HangHoa nvarchar(100) ,
	@MaHoaDon nvarchar(100) 
as
begin
	insert into HoaDonChiTiet(id_GiaoDich, id_HangHoa, MaHoaDon)
	values(@id_GiaoDich, @id_HangHoa, @MaHoaDon);
	
end
GO

/* Cap nhat Khach hang */
create procedure spUpdateHoaDonChiTiet
	@id_GiaoDich  nvarchar(100),
	@id_HangHoa nvarchar(100) ,
	@MaHoaDon nvarchar(100) 
as
begin
	update HoaDonChiTiet set 
		id_GiaoDich = @id_GiaoDich, 
		id_HangHoa = @id_HangHoa, 
		MaHoaDon = @MaHoaDon
	where id_GiaoDich = @id_GiaoDich;

end
GO

