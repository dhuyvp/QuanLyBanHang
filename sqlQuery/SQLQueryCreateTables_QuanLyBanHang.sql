/* Drop tat ca cac bang
drop table HoaDonChiTiet
GO
drop table HoaDon
GO
drop table HangHoa
GO
drop table NhanVien
GO
drop table KhoHang
GO
drop table KhachHang
GO
drop table TaiKhoan
GO
*/

/* Tao bang tai khoan */
create table TaiKhoan
(
	tk_Username nvarchar(100) not null,
	tk_Password nvarchar(100) not null,
	is_Admin bit not null,
	is_NhanVien bit not null,
	is_KhachHang bit not null,
	id_KhoQuanLy int not null,

	primary key (tk_Username),
	foreign key(id_KhoQuanLy) references KhoHang(id_KhoQuanLy),
)
GO

/* Tao bang khach hang */
create table KhachHang
(
	id_KhachHang nvarchar(100) not null,
	HoTen nvarchar(100) not null,
	GioiTinh nvarchar(100) not null,
	NgaySinh datetime not null,
	DienThoai nvarchar(100) not null,
	Email nvarchar(100) not null,
	DiaChi nvarchar(100) not null,

	primary key (id_KhachHang),
)
GO

/* Tao bang kho hang */
create table KhoHang
(
	id_KhoQuanLy int not null,
	DiaChi nvarchar(100) not null,
	TaiChinh int not null,

	primary key(id_KhoQuanLy),
)
GO


--insert into KhoHang(id_KhoQuanLy, DiaChi, TaiChinh)
--values(0, N'Kho hàng', 0)
--GO
--select *from KhoHang
--GO

--delete from HangHoa where id_HangHoa = 1
--GO
--delete from TaiKhoan where tk_Username = 'nv0001'
--GO

--insert into TaiKhoan(tk_Username, tk_Password, is_Admin, is_NhanVien, is_KhachHang, id_KhoQuanLy)
--values('nv001', 'test', 0, 0, 1, 0)
--GO
--select * from TaiKhoan
--GO

/* Tao bang nhan vien */
create table NhanVien
(
	id_NhanVien nvarchar(100) not null,
	id_KhoQuanLy int not null, 
	HoTen nvarchar(100) not null,
	GioiTinh nvarchar(100) not null,
	NgaySinh datetime not null,
	DienThoai nvarchar(100) not null,
	Email nvarchar(100) not null,
	DiaChi nvarchar(100) not null,

	primary key (id_NhanVien),
	foreign key  (id_KhoQuanLy) references KhoHang(id_KhoQuanLy),
)
GO

/* Tao bang hang hoa' */
create table HangHoa
(
	id_HangHoa nvarchar(100) not null,
	id_KhoQuanLy int not null,
	MaHangHoa nvarchar(100) not null,
	TenHangHoa nvarchar(100) not null,
	GiaTien int not null,
	NgaySanXuat datetime not null, 
	HanSD datetime not null,
	is_Ban bit not null,

	primary key(id_HangHoa),
	foreign key(id_KhoQuanLy) references KhoHang(id_KhoQuanLy),
)
GO

/* Tao bang thong tin giao dich hang hoa */
create table ThongTinGiaoDich
(
	MaHoaDon nvarchar(100) not null,
	GiaTien int not null,

	primary key (MaHoaDon),
)
GO

/* Tao bang hoa don ban/xuat */
create table HoaDon
(
	MaHoaDon nvarchar(100) not null,
	id_KhachHang nvarchar(100) not null,
	ThoiGian datetime not null,
	GiaTien int not null,
	HinhThucThanhToan nvarchar(100) not null,
	

	primary key (MaHoaDon),
	foreign key (id_KhachHang) references KhachHang(id_KhachHang),
)
GO


/* Tao bang thong tin cac hang hoa giao dich*/
create table HoaDonChiTiet
(
	id_GiaoDich  nvarchar(100) not null,
	id_HangHoa nvarchar(100) not null,
	MaHoaDon nvarchar(100) not null,

	primary key (id_GiaoDich),
	foreign key (MaHoaDon) references HoaDon(MaHoaDon),
	foreign key (id_HangHoa) references HangHoa(id_HangHoa),
)
GO
