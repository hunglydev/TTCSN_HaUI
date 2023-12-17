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
	soLuongDuKien int not null,
	tinhTrangThanhToan nvarchar(40) not null,
	ghiChu nvarchar(50),
	trangThai nvarchar(40) not null,
	thoiGian DATE not null,
	voucherDaSuDung nvarchar(30),

)
DROP TABLE SUKIEN
alter table SUKIEN
alter column trangThai nvarchar(40) not null;


	CREATE TABLE PHONG(
	maPhong nvarchar (20) not null primary key,
	tenPhong nvarchar(20) not null,
	diaDiem nvarchar(20) not null,
	sucChuaToiDa int not null,
	moTaChiTiet nvarchar(225) not null,
	moTaVanTat nvarchar(100) not null,
	giaPhong float not null
	)
	

	SELECT DISTINCT SUKIEN.*, PHONG.TenPhong, PHONG.giaPhong, TAIKHOAN_VOUCHER.maVoucher, VOUCHER.phanTramGiamGia 
FROM SUKIEN
INNER JOIN PHONG ON SUKIEN.maPhong = PHONG.maPhong	
INNER JOIN TAIKHOAN_VOUCHER ON TAIKHOAN_VOUCHER.maTaiKhoan = SUKIEN.maTaiKhoan 
INNER JOIN VOUCHER ON VOUCHER.maVoucher = TAIKHOAN_VOUCHER.maVoucher
WHERE SUKIEN.maTaiKhoan = 'user123'


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
		('admin123' , 'admin	1', 'admin123', N'Lương Bá Hoàng', 'hoang@gmail.com','0123456452'),
		('admin124' , 'admin2', 'admin123', N'Lý Hải Hưng' , 'hung@gmail.com', '0145688959'),
		('user123' , 'hieu', 'hieu123', N'Trần Minh Hiếu' , 'hieu@gmail.com', '0154879516'),
		('user124' , 'dong', 'dong12', N'Phạm Đăng Đông' , 'dong@gmail.com', '0154896348')
		
	SELECT * FROM TAIKHOAN
	SELECT tenTaiKhoan from TAIKHOAN WHERE tenTaiKhoan like 'admin%'
	INSERT INTO SUKIEN
	VALUES 
		('user123' , 'H01', 'P01', N'Đám cưới Hoàng và Hà', 600,N'chưa thanh toán', '', N'đã xác nhận', '2023-10-20',''),
		('user124' , 'H02', 'P02', N'Sinh nhật Thùy Linh', 300,N'chưa thanh toán', '', N'chưa xác nhận', '2023-12-03',''),
		('user123' , 'H04', 'P04', N'Sinh nhật', 700,N'chưa thanh toán', '', N'chưa xác nhận', '2023-10-20','')
	SELECT * FROM SUKIEN

	INSERT INTO PHONG
	VALUES 
		('P01', N'Phòng A', N'158 Cầu Giấy', '600',N'Phòng có đầy đủ điều hòa, quạt, sân khấu, có hệ thống chiếu sáng, âm thanh thích hợp cho nhóm đông người', N'Phòng có đầy đủ đồ phục vụ các sự kiện',10000000.0),
		('P02', N'Phòng B', N'181 Hồ Tùng Mậu', '700', N'Phòng có đầy đủ điều hòa, quạt, sân khấu, có hệ thống chiếu sáng, âm thanh thích hợp cho nhóm đông người', N'Phòng có đầy đủ đồ phục vụ các sự kiện',9000000.0),
		('P03', N'Phòng C', N'203 Đống Đa', '800',N'Phòng có đầy đủ điều hòa, quạt, sân khấu, có hệ thống chiếu sáng, âm thanh thích hợp cho nhóm đông người', N'Phòng có đầy đủ đồ phục vụ các sự kiện',5000000.0),
		('P04', N'Phòng D', N'120 Nguyễn Trãi', '700', N'Phòng có đầy đủ điều hòa, quạt, sân khấu, có hệ thống chiếu sáng, âm thanh thích hợp cho nhóm đông người', N'Phòng có đầy đủ đồ phục vụ các sự kiện',8000000.0),
		('P05', N'Phòng E', N'270 Cổ Nhuế', '800', N'Phòng có đầy đủ điều hòa, quạt, sân khấu, có hệ thống chiếu sáng, âm thanh thích hợp cho nhóm đông người', N'Phòng có đầy đủ đồ phục vụ các sự kiện',7000000.0),
		('P06', N'Phòng F', N'203 Phan Đình Phùng', '900', N'Phòng có đầy đủ điều hòa, quạt, sân khấu, có hệ thống chiếu sáng, âm thanh thích hợp cho nhóm đông người', N'Phòng có đầy đủ đồ phục vụ các sự kiện',6000000.0)
	SELECT * FROM PHONG
	INSERT INTO VOUCHER
	VALUES 
		(N'V0123333: giảm 50%', 0.5, N'Giảm giá 20-10', '2023-10-18', '2023-10-25'),
		(N'V123456: giảm 20%', 0.2, N'Giảm giá 20-10',  '2023-10-18', '2023-10-25'),
		(N'V333456: giảm 30%', 0.3, N'Giảm giá 20-10',  '2023-10-18', '2023-10-25'),
		(N'V678456: giảm 15%', 0.15, N'Giảm giá 20-10',  '2023-10-18', '2023-10-25')
	SELECT * FROM VOUCHER
	DELETE FROM VOUCHER

	INSERT INTO TAIKHOAN_VOUCHER
	VALUES
		('user123', N'V0123333: giảm 50%'),
		('user123', N'V123456: giảm 20%'),
		('user124', N'V333456: giảm 30%'),
		('user124', N'V678456: giảm 15%')
	SELECT*FROM TAIKHOAN_VOUCHER
	DELETE FROM TAIKHOAN_VOUCHER WHERE maTaiKhoan='admin123' and maVoucher='V0123333'



	SELECT SUKIEN.*, MAX(PHONG.TenPhong) AS TenPhong, MAX(PHONG.giaPhong) AS giaPhong, MAX(TAIKHOAN_VOUCHER.maVoucher) AS maVoucher, MAX(VOUCHER.phanTramGiamGia) AS phanTramGiamGia
FROM SUKIEN
LEFT JOIN 
    PHONG ON SUKIEN.maPhong = PHONG.maPhong	
LEFT JOIN 
    TAIKHOAN_VOUCHER ON TAIKHOAN_VOUCHER.maTaiKhoan = SUKIEN.maTaiKhoan 
LEFT JOIN 
    VOUCHER ON VOUCHER.maVoucher = TAIKHOAN_VOUCHER.maVoucher
WHERE 
    SUKIEN.maTaiKhoan = 'user124'
GROUP BY 
    SUKIEN.maTaiKhoan,
    SUKIEN.maSuKien,
    SUKIEN.maPhong,
    SUKIEN.tenSuKien,
    SUKIEN.soLuongDuKien,
    SUKIEN.tinhTrangThanhToan,
    SUKIEN.ghiChu,
    SUKIEN.trangThai,
    SUKIEN.thoiGian,
    SUKIEN.voucherDaSuDung;
