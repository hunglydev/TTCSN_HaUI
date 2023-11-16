CREATE DATABASE QLSK

USE QLSK

CREATE TABLE TAIKHOAN(
	maTaiKhoan  nvarchar(20) not null primary key,
	tenTaiKhoan nvarchar (20) not null ,
	matKhau  nvarchar(20) not null,
	tenNguoiChuTri nvarchar(20) not null,
	email nvarchar(20) not null,
	sdt nvarchar(20) not null,
)

	CREATE TABLE SUKIEN(
	maTaiKhoan nvarchar(20) not null FOREIGN KEY REFERENCES dbo.TAIKHOAN(maTaiKhoan),
	maSuKien nvarchar (20) not null primary key,
	maPhong nvarchar (20) not null FOREIGN KEY REFERENCES dbo.PHONG(maPhong),
	tenSuKien nvarchar(20) not null,
	diaDiem nvarchar(20) not null,
	soLuongDuKien int not null,
	tinhTrangThanhToan int not null,
	ghiChu nvarchar(50),
	trangThai int not null,
	thoiGian DATE not null
)


	CREATE TABLE PHONG(
	maPhong nvarchar (20) not null primary key,
	tenPhong nvarchar(20) not null,
	sucChuaToiDa int not null,
	moTaChiTiet nvarchar(225) not null,
	moTaVanTat nvarchar(100) not null,
	)
	DRop table SUKIEN
	Drop table PHONG



	CREATE TABLE VOUCHER(
	maVoucher nvarchar(20) not null primary key,
	phanTramGiamGia float,
	moTaVoucher nvarchar(100) ,
	thoiGianBatDau DATE,
	thoiGianKetThuc DATE,
	)

	CREATE TABLE TAIKHOAN_VOUCHER(
		maTaiKhoan nvarchar(20) not null FOREIGN KEY REFERENCES dbo.TAIKHOAN(maTaiKhoan),
		maVoucher nvarchar(20) not null FOREIGN KEY REFERENCES dbo.VOUCHER(maVoucher),
		PRIMARY KEY (maTaiKhoan, maVoucher)
	)

	INSERT INTO TAIKHOAN
	VALUES 
	('user125', 'dat', 'dat123' , N'Dương Tất Đạt', 'dat@gmail.com', '0123456789'),
		('admin123' , 'admin1', 'admin123', N'Lương Bá Hoàng', 'hoang@gmail.com','0123456452'),
		('admin124' , 'admin2', 'admin123', N'Lý Hải Hưng' , 'hung@gmail.com', '0145688959'),
		('user123' , 'hieu', 'hieu123', N'Trần Minh Hiếu' , 'hieu@gmail.com', '0154879516'),
		('user124' , 'dong', 'dong12', N'Phạm Đăng Đông' , 'dong@gmail.com', '0154896348')
		
	SELECT * FROM TAIKHOAN
	INSERT INTO SUKIEN
	VALUES 
		('user123' , 'H01', 'P01', N'Đám cưới Hoàng và Hà', N'158 Cầu Giấy', 600,0, '', 0, '2023-10-20'),
		('user124' , 'H02', 'P02', N'Sinh nhật Thùy Linh', N'162 Tôn Đức Thắng', 300,0, '', 0, '2023-12-03')
	SELECT * FROM SUKIEN
	INSERT INTO PHONG
	VALUES 
		('P01', N'Phòng A', '600',N'Phòng có đầy đủ điều hòa, quạt, sân khấu, có hệ thống chiếu sáng, âm thanh thích hợp cho nhóm đông người', N'Phòng có đầy đủ đồ phục vụ các sự kiện'),
		('P02', N'Phòng B', '700', N'Phòng có đầy đủ điều hòa, quạt, sân khấu, có hệ thống chiếu sáng, âm thanh thích hợp cho nhóm đông người', N'Phòng có đầy đủ đồ phục vụ các sự kiện'),
		('P03', N'Phòng C', '800',N'Phòng có đầy đủ điều hòa, quạt, sân khấu, có hệ thống chiếu sáng, âm thanh thích hợp cho nhóm đông người', N'Phòng có đầy đủ đồ phục vụ các sự kiện'),
		('P04', N'Phòng D', '700', N'Phòng có đầy đủ điều hòa, quạt, sân khấu, có hệ thống chiếu sáng, âm thanh thích hợp cho nhóm đông người', N'Phòng có đầy đủ đồ phục vụ các sự kiện'),
		('P05', N'Phòng E', '800', N'Phòng có đầy đủ điều hòa, quạt, sân khấu, có hệ thống chiếu sáng, âm thanh thích hợp cho nhóm đông người', N'Phòng có đầy đủ đồ phục vụ các sự kiện'),
		('P06', N'Phòng F', '900', N'Phòng có đầy đủ điều hòa, quạt, sân khấu, có hệ thống chiếu sáng, âm thanh thích hợp cho nhóm đông người', N'Phòng có đầy đủ đồ phục vụ các sự kiện')
	SELECT * FROM PHONG
	INSERT INTO VOUCHER
	VALUES 
		('V0123333', 0.1, N'Giảm giá 20-10', '2023-10-18', '2023-10-25'),
		('V123456', 0.2, N'Giảm giá 20-10',  '2023-10-18', '2023-10-25'),
		('V333456', 0.3, N'Giảm giá 20-10',  '2023-10-18', '2023-10-25'),
		('V678456', 0.15, N'Giảm giá 20-10',  '2023-10-18', '2023-10-25')
	SELECT * FROM VOUCHER
	INSERT INTO TAIKHOAN_VOUCHER
	VALUES
		('user123', 'V0123333'),
		('user123', 'V333456'),
		('user124', 'V678456'),
		('user124', 'V0123333')
	SELECT*FROM TAIKHOAN_VOUCHER