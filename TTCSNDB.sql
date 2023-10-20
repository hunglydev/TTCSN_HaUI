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
	tinhTrangThanhToan nvarchar(25) not null,
	ghiChu nvarchar(50),
	trangThai nvarchar(25) not null,
	thoiGian nvarchar(50) not null

)

	CREATE TABLE PHONG(
	maSuKien nvarchar(20) not null FOREIGN KEY REFERENCES dbo.SUKIEN(maSuKien),
	maPhong nvarchar (20) not null primary key,
	tenPhong nvarchar(20) not null,
	sucChuaToiDa int not null,
	moTaChiTiet nvarchar(225) not null,
	moTaVanTat nvarchar(20) not null,
	)



	CREATE TABLE VOUCHER(
	maVoucher nvarchar(20) not null primary key,
	phanTramGiamGia float ,
	moTaVoucher nvarchar(20) ,
	thoiGianBatDau nvarchar(20),
	thoiGianKetThuc nvarchar(20)
	)
	CREATE TABLE TAIKHOAN_VOUCHER(
		maTaiKhoan nvarchar(20) not null FOREIGN KEY REFERENCES dbo.TAIKHOAN(maTaiKhoan),
		maVoucher nvarchar(20) not null FOREIGN KEY REFERENCES dbo.VOUCHER(maVoucher),
		PRIMARY KEY (maTaiKhoan, maVoucher)
	)

	INSERT INTO TAIKHOAN
	VALUES 
		('admin123' , 'admin1', 'admin123', 'HOANG', 'HOANG@gmail.com','012345645', 'HAUI'),
		('admin124' , 'admin2', 'admin123', 'HUNG' , 'HUNG@gmail.com', '014568895', 'HAUI'),
		('user125' , 'user3', 'user123', 'HIEU' , 'HIEU@gmail.com', '015487951', 'HAUI'),
		('user126' , 'user4', 'user123', 'DONG' , 'DONG@gmail.com', '015489634', 'HAUI')
	SELECT * FROM TAIKHOAN
	INSERT INTO SUKIEN
	VALUES 
		('admin123' , 'H01', 'dam cuoi', 'cau giay', '150','done', 'hoan thanh truoc 20_10', 'sap dien ra', '20-10'),
		('admin124' , 'H02', 'sinh nhat', 'dong da', '200','done', 'hoan thanh truoc 20_11', 'sap dien ra', '20-11')
	SELECT * FROM SUKIEN
	INSERT INTO PHONG
	VALUES 
		('H01', 'P01', 'Osaka', '200', 'phong co day du dieu hoa, quat, san khau', 'day du'),
		('H02', 'P02', 'Tokyo', '250', 'phong co day du dieu hoa, quat, san khau', 'day du'),
		('H02', 'P03', 'Ha Noi', '250', 'phong co day du dieu hoa, quat, san khau', 'day du'),
		('H01', 'P04', 'Con Dao', '250', 'phong co day du dieu hoa, quat, san khau', 'day du'),
		('H01', 'P05', 'Seoul', '250', 'phong co day du dieu hoa, quat, san khau', 'day du'),
		('H02', 'P06', 'Yokohama', '250', 'phong co day du dieu hoa, quat, san khau', 'day du')
	SELECT * FROM PHONG
	INSERT INTO VOUCHER
	VALUES 
		('V01', '0.1', 'giam gia 20/10', '18/10', '21/10'),
		('V02', '0.2', 'giam gia 20/10', '18/10', '21/10'),
		('V03', '0.3', 'giam gia 20/10', '18/10', '21/10'),
		('V04', '0.15', 'giam gia 20/10', '18/10', '21/10')
	SELECT * FROM VOUCHER