create function checkTKKhachHang
(
	@tk_Username nvarchar(100)
)
returns nvarchar(100)
as
begin
	declare @cnt int = (select count(*) from TaiKhoan where tk_Username = @tk_Username);

	if @cnt > 0
		return 'true';
	return 'false';
end
GO

create function checkAdmin
(
	@tk_Username nvarchar(100),
	@tk_Password nvarchar(100)
)
returns nvarchar(100)
as
begin
	declare @cnt int = (select count(*) from TaiKhoan where tk_Username = @tk_Username and tk_Password = @tk_Password and is_Admin = 1);

	if @cnt > 0
		return 'true';
	return 'false';
end
GO

create function checkNhanVien
(
	@tk_Username nvarchar(100),
	@tk_Password nvarchar(100)
)
returns int
as
begin
	declare @cnt int = (select count(*) from TaiKhoan where tk_Username = @tk_Username and tk_Password = @tk_Password and is_NhanVien = 1);
	if @cnt = 0
		return 0;

	declare @id_kho int = (select id_KhoQuanLy from TaiKhoan where tk_Username = @tk_Username and tk_Password = @tk_Password and is_NhanVien = 1);
	return @id_kho;
end
GO


create function checkKhachHang
(
	@tk_Username nvarchar(100),
	@tk_Password nvarchar(100)
)
returns nvarchar(100)
as
begin
	declare @cnt int = (select count(*) from TaiKhoan where tk_Username = @tk_Username and tk_Password = @tk_Password and is_KhachHang = 1);

	if @cnt > 0
		return 'true';
	return 'false';
end
GO

create function funGetNextIDNhanVien()
returns nvarchar(100)
as
begin
	declare @current_ID nvarchar(100);
	begin
		if (select count(*) from NhanVien) = 0
			SET @current_ID = '0';
		else 
		begin
			declare @max_ID nvarchar(10);
			select @max_ID = SUBSTRING(CONVERT(nvarchar(10), MAX(id_NhanVien)), 3, 10) from NhanVien;
			SET @current_ID = CONVERT(nvarchar(10), @max_ID);
		end
	end
	/* format */
	SET @current_ID = @current_ID + 1;
	if @current_ID = 100000000
		SET @current_ID = 1;
	SET @current_ID = CONVERT(nvarchar(10), @current_ID);
	
	declare @n_loop int = 8 - len(@current_ID);
	while @n_loop > 0
		begin 
			SET @current_ID = '0' + @current_ID;
			SET @n_loop = @n_loop - 1;
		end

	return 'nv'+convert(nvarchar(10), @current_ID);
end
GO


create function funGetNextIDHangHoa()
returns nvarchar(100)
as
begin
	declare @current_ID nvarchar(100);
	begin
		if (select count(*) from HangHoa) = 0
			SET @current_ID = '0';
		else 
		begin
			declare @max_ID nvarchar(10);
			select @max_ID = SUBSTRING(CONVERT(nvarchar(10), MAX(id_HangHoa)), 3, 10) from HangHoa;
			SET @current_ID = CONVERT(nvarchar(10), @max_ID);
		end
	end
	/* format */
	SET @current_ID = @current_ID + 1;
	if @current_ID = 100000000
		SET @current_ID = 1;
	SET @current_ID = CONVERT(nvarchar(10), @current_ID);
	
	declare @n_loop int = 8 - len(@current_ID);
	while @n_loop > 0
		begin 
			SET @current_ID = '0' + @current_ID;
			SET @n_loop = @n_loop - 1;
		end

	return 'hh'+convert(nvarchar(10), @current_ID);
end
GO

create function funGetNextIDHoaDon()
returns nvarchar(100)
as
begin
	declare @current_ID nvarchar(100);
	begin
		if (select count(*) from HoaDon) = 0
			SET @current_ID = '0';
		else 
		begin
			declare @max_ID nvarchar(10);
			select @max_ID = SUBSTRING(CONVERT(nvarchar(10), MAX(MaHoaDon)), 3, 10) from HoaDon;
			SET @current_ID = CONVERT(nvarchar(10), @max_ID);
		end
	end
	/* format */
	SET @current_ID = @current_ID + 1;
	if @current_ID = 100000000
		SET @current_ID = 1;
	SET @current_ID = CONVERT(nvarchar(10), @current_ID);
	
	declare @n_loop int = 8 - len(@current_ID);
	while @n_loop > 0
		begin 
			SET @current_ID = '0' + @current_ID;
			SET @n_loop = @n_loop - 1;
		end

	return 'hd'+convert(nvarchar(10), @current_ID);
end
GO

create function funGetNextIDHoaDonChiTiet()
returns nvarchar(100)
as
begin
	declare @current_ID nvarchar(100);
	begin
		if (select count(*) from HoaDonChiTiet) = 0
			SET @current_ID = '0';
		else 
		begin
			declare @max_ID nvarchar(10);
			select @max_ID = SUBSTRING(CONVERT(nvarchar(10), MAX(id_GiaoDich)), 3, 10) from HoaDonChiTiet;
			SET @current_ID = CONVERT(nvarchar(10), @max_ID);
		end
	end
	/* format */
	SET @current_ID = @current_ID + 1;
	if @current_ID = 100000000
		SET @current_ID = 1;
	SET @current_ID = CONVERT(nvarchar(10), @current_ID);
	
	declare @n_loop int = 8 - len(@current_ID);
	while @n_loop > 0
		begin 
			SET @current_ID = '0' + @current_ID;
			SET @n_loop = @n_loop - 1;
		end

	return 'gd'+convert(nvarchar(10), @current_ID);
end
GO
