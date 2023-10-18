CREATE DATABASE QLSK

USE QLSK

CREATE TABLE TAIKHOAN(
	maTaiKhoan  nvarchar(20) not null primary key,
	tenTaiKhoan nvarchar (20) not null ,
	matKhau  nvarchar(20) not null,
	tenNguoiChuTri nvarchar(20) not null,
	email nvarchar(20) not null,
	sdt nvarchar(20) not null,
	diaChi nvarchar(20) not null,
)

	CREATE TABLE SUKIEN(
	maTaiKhoan nvarchar(20) not null FOREIGN KEY REFERENCES dbo.TAIKHOAN(maTaiKhoan),
	maSuKien nvarchar (20) not null primary key,
	tenSuKien nvarchar(20) not null,
	diaDiem nvarchar(20) not null,
	soLuongDuKien int not null,
	tinhTrangThanhToan int not null,
	ghiChu nvarchar (20),
	trangThai int not null,
	thoiGian DATETIME not null

)

	CREATE TABLE PHONG(
	maSuKien nvarchar(20) not null FOREIGN KEY REFERENCES dbo.SUKIEN(maSuKien),
	maPhong nvarchar (20) not null primary key,
	tenPhong nvarchar(20) not null,
	sucChuaToiDa int not null,
	moTaChiTiet nvarchar(20) not null,
	moTaVanTat nvarchar(20) not null,
	)



	CREATE TABLE VOUCHER(
	maVoucher nvarchar(20) not null primary key,
	phanTramGiamGia int not null,
	moTaVoucher nvarchar(20) not null,
	thoiGianBatDau DATETIME,
	thoiGianKetThuc DATETIME
	)
	CREATE TABLE TAIKHOAN_VOUCHER(
		maTaiKhoan nvarchar(20) not null FOREIGN KEY REFERENCES dbo.TAIKHOAN(maTaiKhoan),
		maVoucher nvarchar(20) not null FOREIGN KEY REFERENCES dbo.VOUCHER(maVoucher),
		PRIMARY KEY (maTaiKhoan, maVoucher)
	)

	INSERT INTO TAIKHOAN
	VALUES 
		('admin123' , 'admin1', 'admin123', 'ADMIN' , 'admin1@gmail.com', '0123456789', 'HAUI'),
		('admin111' , 'admin2', 'admin123', 'ADMIN' , 'admin2@gmail.com', '0123456789', 'HAUI')
	SELECT * FROM TAIKHOAN