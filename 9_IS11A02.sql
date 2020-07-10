
DROP TABLE dbo.Chi_tiet_hoa_don_ban
DROP TABLE dbo.Chi_tiet_hoa_don_nhap
DROP TABLE dbo.Hoa_don_ban
DROP TABLE dbo.Hoa_don_nhap
DROP TABLE dbo.Nha_cc
DROP TABLE dbo.Nhan_vien
DROP TABLE dbo.DM_Binh_ga


CREATE TABLE Loai_ga(
Maloai  NVARCHAR(5)PRIMARY KEY,
Tenloai  NVARCHAR(25),)
INSERT INTO  Loai_ga(Maloai,Tenloai)
 VALUES (N'001',N'GAS PETRO');
 INSERT INTO  Loai_ga(Maloai,Tenloai)
 VALUES (N'002',N'GAS TOTAL');
 INSERT INTO  Loai_ga(Maloai,Tenloai)
 VALUES (N'003',N'GAS eIF');
 INSERT INTO  Loai_ga(Maloai,Tenloai)
 VALUES (N'004',N'SHELL GAS');
 INSERT INTO  Loai_ga(Maloai,Tenloai)
 VALUES (N'005',N'GAS 123A');
 INSERT INTO  Loai_ga(Maloai,Tenloai)
 VALUES (N'006',N'GAS Gia Đình');
 INSERT INTO  Loai_ga(Maloai,Tenloai)
 VALUES (N'007',N'GAS Sang Phước');
 INSERT INTO  Loai_ga(Maloai,Tenloai)
 VALUES (N'008',N'GAS Du lịch');
 INSERT INTO  Loai_ga(Maloai,Tenloai)
 VALUES (N'009',N'GAS Mini');
 INSERT INTO  Loai_ga(Maloai,Tenloai)
 VALUES (N'010',N'GAS Lạnh');
 select * from Loai_ga;

 CREATE TABLE Mau(
Mamau NVARCHAR(5) PRIMARY KEY,
Tenmau NVARCHAR(25),)

 INSERT INTO Mau(Mamau,Tenmau)
 VALUES ( 101,N'Hồng');
 INSERT INTO Mau(Mamau,Tenmau)
 VALUES ( 102,N'Cam');
 INSERT INTO Mau(Mamau,Tenmau)
 VALUES ( 103,N'Đỏ');
 INSERT INTO Mau(Mamau,Tenmau)
 VALUES ( 104,N'Đen');
 INSERT INTO Mau(Mamau,Tenmau)
 VALUES ( 105,N'Trắng');
 INSERT INTO Mau(Mamau,Tenmau)
 VALUES ( 106,N'Tím');
 INSERT INTO Mau(Mamau,Tenmau)
 VALUES ( 107,N'Vàng');
 INSERT INTO Mau(Mamau,Tenmau)
 VALUES ( 108,N'Xanh');
 INSERT INTO Mau(Mamau,Tenmau)
 VALUES ( 109,N'Xanh lục');
 INSERT INTO Mau(Mamau,Tenmau)
 VALUES ( 110,N'Xám');

 SELECT * FROM Mau;

 CREATE TABLE Khoi_luong(
Makhoiluong NVARCHAR(5) PRIMARY KEY,)

INSERT INTO Khoi_luong(Makhoiluong)
VALUES (N'KL1');
INSERT INTO Khoi_luong(Makhoiluong)
VALUES (N'KL2');
INSERT INTO Khoi_luong(Makhoiluong)
VALUES (N'KL3');
INSERT INTO Khoi_luong(Makhoiluong)
VALUES (N'KL4');
INSERT INTO Khoi_luong(Makhoiluong)
VALUES (N'KL5');
INSERT INTO Khoi_luong(Makhoiluong)
VALUES (N'KL6');
INSERT INTO Khoi_luong(Makhoiluong)
VALUES (N'KL7');
INSERT INTO Khoi_luong(Makhoiluong)
VALUES (N'KL8');
INSERT INTO Khoi_luong(Makhoiluong)
VALUES (N'KL9');
INSERT INTO Khoi_luong(Makhoiluong)
VALUES (N'KL10');

SELECT * FROM Khoi_luong;

CREATE TABLE Nuoc_san_xuat(
ManuocSX NVARCHAR(5) PRIMARY KEY,
TennuocSX NVARCHAR(25),)

INSERT INTO Nuoc_san_xuat(ManuocSX,TennuocSX)
VALUES (N'VN',N' Việt Nam');
INSERT INTO Nuoc_san_xuat(ManuocSX,TennuocSX)
VALUES (N'CAN',N' Canada');
INSERT INTO Nuoc_san_xuat(ManuocSX,TennuocSX)
VALUES (N'US',N' America');
INSERT INTO Nuoc_san_xuat(ManuocSX,TennuocSX)
VALUES (N'AH',N' Anh');
INSERT INTO Nuoc_san_xuat(ManuocSX,TennuocSX)
VALUES (N'NB',N' Nhật Bản');
INSERT INTO Nuoc_san_xuat(ManuocSX,TennuocSX)
VALUES (N'TQ',N' Trung Quốc');
INSERT INTO Nuoc_san_xuat(ManuocSX,TennuocSX)
VALUES (N'LA',N' Lào');
INSERT INTO Nuoc_san_xuat(ManuocSX,TennuocSX)
VALUES (N'TT',N' Triều Tiên');
INSERT INTO Nuoc_san_xuat(ManuocSX,TennuocSX)
VALUES (N'AUS',N' Úc');
INSERT INTO Nuoc_san_xuat(ManuocSX,TennuocSX)
VALUES (N'SG',N' Singapore');

SELECT * FROM Nuoc_san_xuat;

CREATE TABLE Ca_lam(
Maca NVARCHAR(5) PRIMARY KEY,
Tenca NVARCHAR(25),)

INSERT INTO Ca_lam(Maca,Tenca)
VALUES (N'C1',N'Ca Sáng');
INSERT INTO Ca_lam(Maca,Tenca)
VALUES (N'C2',N'Ca Chiều');
INSERT INTO Ca_lam(Maca,Tenca)
VALUES (N'C3',N'Ca Tối');
INSERT INTO Ca_lam(Maca,Tenca)
VALUES (N'C4',N'Ca Full');


SELECT * FROM Ca_lam;

CREATE TABLE DM_Binh_ga(
Mabinh NVARCHAR(5) PRIMARY KEY,
Tenbinh NVARCHAR(25),
Maloai NVARCHAR(5),
CONSTRAINT ml_fk FOREIGN KEY (Maloai) REFERENCES dbo.Loai_ga(Maloai),
Mamau NVARCHAR(5),
CONSTRAINT mm_fk FOREIGN KEY (Mamau) REFERENCES dbo.Mau(Mamau),
Makhoiluong NVARCHAR(5),
CONSTRAINT mkl_fk FOREIGN KEY (Makhoiluong) REFERENCES dbo.Khoi_luong(Makhoiluong),
ManuocSX NVARCHAR(5),
CONSTRAINT mnsx_fk FOREIGN KEY (ManuocSX) REFERENCES dbo.Nuoc_san_xuat(ManuocSX),
Soluong FLOAT,
Dongianhap FLOAT,
Dongiaban FLOAT,
Thoigianbaohanh NVARCHAR(50) NOT NULL,
Anh NVARCHAR(200),
Ghichu NVARCHAR(200),)
select * from DM_Binh_ga;
insert into DM_Binh_ga(Mabinh,Tenbinh,Maloai,Mamau,Makhoiluong,ManuocSX,Soluong,Dongianhap,Dongiaban,Thoigianbaohanh,Anh,Ghichu)
values (N'BG1',N'Bình Gas Công Nghiệp',N'002',110,N'KL5',N'VN',150,750000,990000,N'2020-02-06',null,N'Bình ga dễ nổ');
insert into DM_Binh_ga(Mabinh,Tenbinh,Maloai,Mamau,Makhoiluong,ManuocSX,Soluong,Dongianhap,Dongiaban,Thoigianbaohanh,Anh,Ghichu)
values (N'BG2',N'Bình Gas Dân dụng',N'005',106,N'KL3',N'Can',400,290000,360000,N'2020-11-09',null,N'Bình ga dễ nổ');
insert into DM_Binh_ga(Mabinh,Tenbinh,Maloai,Mamau,Makhoiluong,ManuocSX,Soluong,Dongianhap,Dongiaban,Thoigianbaohanh,Anh,Ghichu)
values (N'BG3',N'Bình Gas Mini',N'006',102,N'KL1',N'TQ',200,15000,21000,N'2020-07-26',null,N'Bình ga dễ nổ');
insert into DM_Binh_ga(Mabinh,Tenbinh,Maloai,Mamau,Makhoiluong,ManuocSX,Soluong,Dongianhap,Dongiaban,Thoigianbaohanh,Anh,Ghichu)
values (N'BG4',N'Bình Gas Thông Thường',N'010',105,N'KL7',N'AUS',751,110000,270000,N'2020-09-28',null,N'Bình ga dễ nổ');
select * from DM_Binh_ga;





CREATE TABLE Cong_viec(
 MaCV NVARCHAR(5) PRIMARY KEY,
 TenCV NVARCHAR(25) ,)
INSERT INTO Cong_viec(MaCV,TenCV)
VALUES (N'CV1',N'Bán hàng');
INSERT INTO Cong_viec(MaCV,TenCV)
VALUES (N'CV2',N'Kế toán');
INSERT INTO Cong_viec(MaCV,TenCV)
VALUES (N'CV3',N'Marketing');
INSERT INTO Cong_viec(MaCV,TenCV)
VALUES (N'CV4',N'Kiểm kho');
INSERT INTO Cong_viec(MaCV,TenCV)
VALUES (N'CV5',N'Quản lý nhân sự');
INSERT INTO Cong_viec(MaCV,TenCV)
VALUES (N'CV6',N'Lắp đặt');
INSERT INTO Cong_viec(MaCV,TenCV)
VALUES (N'CV7',N'Giao hàng');
 SELECT * FROM Cong_viec;


 CREATE TABLE Nhan_Vien(
MaNV NVARCHAR(5) PRIMARY KEY,
TenNV NVARCHAR(25),
Gioitinh NVARCHAR(25),
Ngaysinh DATETIME,
Dienthoai NVARCHAR(15),
Diachi NVARCHAR(50),
Maca NVARCHAR(5),
CONSTRAINT mc_fk FOREIGN KEY (Maca) REFERENCES dbo.Ca_lam(Maca),
MaCV NVARCHAR(5),
CONSTRAINT mcv_fk FOREIGN KEY (MaCV) REFERENCES dbo.Cong_viec(MaCV),)

Insert into Nhan_Vien(MaNV,TenNV,Gioitinh,Ngaysinh,Dienthoai,Diachi,Maca,MaCV)
values(N'NV1',N'Lê Văn Luyện',N'Nam','1990-05-01',N'0399294534',N'Uông Bí - Quảng Ninh',N'C1',N'CV4');
Insert into Nhan_Vien(MaNV,TenNV,Gioitinh,Ngaysinh,Dienthoai,Diachi,Maca,MaCV)
values(N'NV2',N'Nguyễn Ngọc Ánh',N'Nữ','1986-03-06',N'0398294536',N'Quỳnh Lưu - Nghệ An',N'C3',N'CV3');
Insert into Nhan_Vien(MaNV,TenNV,Gioitinh,Ngaysinh,Dienthoai,Diachi,Maca,MaCV)
values(N'NV3',N'Nguyễn Hoài An',N'Nam','1987-01-08',N'0390299584',N'Hà Nội',N'C2',N'CV7');
Insert into Nhan_Vien(MaNV,TenNV,Gioitinh,Ngaysinh,Dienthoai,Diachi,Maca,MaCV)
values(N'NV4',N'Nguyễn Trâm Anh',N'Nữ','1988-12-18',N'0399292758',N'Thái Nguyên',N'C2',N'CV5');
Insert into Nhan_Vien(MaNV,TenNV,Gioitinh,Ngaysinh,Dienthoai,Diachi,Maca,MaCV)
values(N'NV5',N'Hoàng Thị Bình',N'Nữ','1986-01-26',N'0390892758',N'Hà nam',N'C4',N'CV2');
Insert into Nhan_Vien(MaNV,TenNV,Gioitinh,Ngaysinh,Dienthoai,Diachi,Maca,MaCV)
values(N'NV6',N'Nguyễn Văn Hải',N'Nam','1980-05-06',N'039975432',N'Hải Dương',N'C1',N'CV6');
Insert into Nhan_Vien(MaNV,TenNV,Gioitinh,Ngaysinh,Dienthoai,Diachi,Maca,MaCV)
values(N'NV7',N'Trần Thị Liên',N'Nữ','1995-10-08',N'03999924567',N'Hải Phòng',N'C2',N'CV1');
Insert into Nhan_Vien(MaNV,TenNV,Gioitinh,Ngaysinh,Dienthoai,Diachi,Maca,MaCV)
values(N'NV8',N'Hoàng Quỳnh Hương',N'Nữ','1994-07-11',N'0399838657',N'Nam Định',N'C3',N'CV1');
Insert into Nhan_Vien(MaNV,TenNV,Gioitinh,Ngaysinh,Dienthoai,Diachi,Maca,MaCV)
values(N'NV9',N'Lê Tiến Đạt',N'Nam','1995-06-19',N'03999973567',N'Hà Nội',N'C1',N'CV1');
Insert into Nhan_Vien(MaNV,TenNV,Gioitinh,Ngaysinh,Dienthoai,Diachi,Maca,MaCV)
values(N'NV10',N'Lưu Mạnh Cường',N'Nam','1996-02-06',N'03934924565',N'Hải Phòng',N'C4',N'CV1');
select * from Nhan_Vien;





CREATE TABLE Khach_hang(
Makhach NVARCHAR(5) PRIMARY KEY,
Tenkhach NVARCHAR(25),
Diachi NVARCHAR(25),
Dienthoai NVARCHAR(15),)
insert into Khach_hang(Makhach,Tenkhach,Diachi,Dienthoai)
values(N'KH1',N'Nguyễn Thị Thủy Tiên',N'Hà Nội',N'0911426019');
insert into Khach_hang(Makhach,Tenkhach,Diachi,Dienthoai)
values(N'KH2',N'Nguyễn Thị Linh',N'Hà Nội',N'0971697133');
insert into Khach_hang(Makhach,Tenkhach,Diachi,Dienthoai)
values(N'KH3',N'Dương Bích Liên',N'Hà Nội',N'0347385861');
insert into Khach_hang(Makhach,Tenkhach,Diachi,Dienthoai)
values(N'KH4',N'Triệu Thị Hà',N'Hà Nội',N'01664171035');
insert into Khach_hang(Makhach,Tenkhach,Diachi,Dienthoai)
values(N'KH5',N'Nguyễn Thúy Hằng',N'Hà Nội',N'0886817116');
insert into Khach_hang(Makhach,Tenkhach,Diachi,Dienthoai)
values(N'KH6',N'Trần Hoàng My Na',N'Hà Nội',N'02435725152');
insert into Khach_hang(Makhach,Tenkhach,Diachi,Dienthoai)
values(N'KH7',N'Nguyễn Thị Hồng',N'Hà Nội',N'0360963471');
insert into Khach_hang(Makhach,Tenkhach,Diachi,Dienthoai)
values(N'KH8',N'Dương Minh Ánh',N'Hà Nội',N'0962330258');
insert into Khach_hang(Makhach,Tenkhach,Diachi,Dienthoai)
values(N'KH9',N'Phạm Thu Hà',N'Hà Nội',N'0967071764');
insert into Khach_hang(Makhach,Tenkhach,Diachi,Dienthoai)
values(N'KH10',N'Vũ Hải Vân',N'Hà Nội',N'04299959939');


select * from Khach_hang;








CREATE TABLE Hoa_don_ban(
SoHDB NVARCHAR(50) PRIMARY KEY,
MaNV NVARCHAR(5),
CONSTRAINT mnv_fk FOREIGN KEY (MaNV) REFERENCES dbo.Nhan_vien(MaNV),
NgayBan DATE,
MaKhach NVARCHAR(5),
CONSTRAINT mk_fk FOREIGN KEY (MaKhach) REFERENCES dbo.Khach_hang(Makhach),
Tongtien FLOAT)
Insert into Hoa_don_ban(SoHDB,MaNV,NgayBan,MaKhach,Tongtien)
Values (N'HD1',N'NV7','2020-03-05',N'KH1',990000);
Insert into Hoa_don_ban(SoHDB,MaNV,NgayBan,MaKhach,Tongtien)
Values (N'HD2',N'NV8','2020-10-15',N'KH2',105000);
Insert into Hoa_don_ban(SoHDB,MaNV,NgayBan,MaKhach,Tongtien)
Values (N'HD3',N'NV9','2020-05-23',N'KH3',135000);
Insert into Hoa_don_ban(SoHDB,MaNV,NgayBan,MaKhach,Tongtien)
Values (N'HD4',N'NV10','2020-07-18',N'KH4',450000);
Insert into Hoa_don_ban(SoHDB,MaNV,NgayBan,MaKhach,Tongtien)
Values (N'HD5',N'NV7','2020-10-05',N'KH5',740000);
Insert into Hoa_don_ban(SoHDB,MaNV,NgayBan,MaKhach,Tongtien)
Values (N'HD6',N'NV8','2020-11-12',N'KH6',360000);
Insert into Hoa_don_ban(SoHDB,MaNV,NgayBan,MaKhach,Tongtien)
Values (N'HD7',N'NV8','2020-09-03',N'KH7',990000);
Insert into Hoa_don_ban(SoHDB,MaNV,NgayBan,MaKhach,Tongtien)
Values (N'HD8',N'NV10','2020-07-29',N'KH8',360000);
Insert into Hoa_don_ban(SoHDB,MaNV,NgayBan,MaKhach,Tongtien)
Values (N'HD9',N'NV9','2020-08-19',N'KH9',270000);
Insert into Hoa_don_ban(SoHDB,MaNV,NgayBan,MaKhach,Tongtien)
Values (N'HD10',N'NV7','2020-12-01',N'KH10',270000);
select * from Hoa_don_ban;
SELECT * FROM nhan_vien WHERE tennv LIKE '%L%'



CREATE TABLE Nha_cc(
MaNCC NVARCHAR(5) PRIMARY KEY,
TenNCC NVARCHAR(25),
Diachi NVARCHAR(50),
Dienthoai NVARCHAR(15),)

INSERT INTO Nha_cc(MaNCC,TenNCC,Diachi,Dienthoai)
VALUES (N'NCC1',N' Công ty Petrolimex',N'Hà Nội',18009675);
INSERT INTO Nha_cc(MaNCC,TenNCC,Diachi,Dienthoai)
VALUES (N'NCC2',N' Công ty Total',N'Hải Dương',18003232);
INSERT INTO Nha_cc(MaNCC,TenNCC,Diachi,Dienthoai)
VALUES (N'NCC3',N' Công ty Gia Đình',N'Vĩnh Phúc',19004567);
INSERT INTO Nha_cc(MaNCC,TenNCC,Diachi,Dienthoai)
VALUES (N'NCC4',N'Công ty Phúc Hưng',N'Hưng Yên',19005252);
INSERT INTO Nha_cc(MaNCC,TenNCC,Diachi,Dienthoai)
VALUES (N'NCC5',N' Công ty EiF',N'Hà Nội',18009685);
INSERT INTO Nha_cc(MaNCC,TenNCC,Diachi,Dienthoai)
VALUES (N'NCC6',N'Công ty Sang Phước',N'Huế',18007875);
INSERT INTO Nha_cc(MaNCC,TenNCC,Diachi,Dienthoai)
VALUES (N'NCC7',N'Công ty Vạn An',N'Đồng Tháp',19001675);
INSERT INTO Nha_cc(MaNCC,TenNCC,Diachi,Dienthoai)
VALUES (N'NCC8',N'Công ty Á Đông',N'Hà Tĩnh',18009275);

select * from Nha_cc;

CREATE TABLE Hoa_don_nhap(
SoHDN NVARCHAR(50) PRIMARY KEY,
MaNV NVARCHAR(5),
CONSTRAINT manv_fk FOREIGN KEY (MaNV) REFERENCES dbo.Nhan_vien(MaNV),
NgayNhap DATE,
MaNCC NVARCHAR(5),
CONSTRAINT mncc_fk FOREIGN KEY (MaNCC) REFERENCES dbo.Nha_cc(MaNCC),
Tongtien FLOAT,)
select * from Hoa_don_nhap;
Insert into Hoa_don_nhap(SoHDN,MaNV,NgayNhap,MaNCC,Tongtien)
Values (N'HDN1',N'NV1','2020-01-05',N'NCC8',N'148500000');
Insert into Hoa_don_nhap(SoHDN,MaNV,NgayNhap,MaNCC,Tongtien)
Values (N'HDN2',N'NV1','2020-02-19',N'NCC5',N'1230000');
Insert into Hoa_don_nhap(SoHDN,MaNV,NgayNhap,MaNCC,Tongtien)
Values (N'HDN3',N'NV1','2020-02-07',N'NCC3',N'290000000');
Insert into Hoa_don_nhap(SoHDN,MaNV,NgayNhap,MaNCC,Tongtien)
Values (N'HDN4',N'NV1','2020-01-22',N'NCC7',N'87200000');
Insert into Hoa_don_nhap(SoHDN,MaNV,NgayNhap,MaNCC,Tongtien)
Values (N'HDN5',N'NV1','2020-04-25',N'NCC1',N'94327000');
Insert into Hoa_don_nhap(SoHDN,MaNV,NgayNhap,MaNCC,Tongtien)
Values (N'HDN6',N'NV1','2020-03-17',N'NCC4',N'29400000');
Insert into Hoa_don_nhap(SoHDN,MaNV,NgayNhap,MaNCC,Tongtien)
Values (N'HD7',N'NV1','2020-12-03',N'NCC6',N'88865430000');
Insert into Hoa_don_nhap(SoHDN,MaNV,NgayNhap,MaNCC,Tongtien)
Values (N'HD8',N'NV1','2020-09-24',N'NCC2',N'75290000');

CREATE TABLE Chi_tiet_hoa_don_ban(
SoHDB NVARCHAR(50),
Mabinh NVARCHAR(5),
PRIMARY KEY(SoHDB,Mabinh),
CONSTRAINT shd_pk FOREIGN KEY (SoHDB) REFERENCES dbo.Hoa_don_ban(SoHDB),
CONSTRAINT mb_pk FOREIGN KEY (Mabinh) REFERENCES dbo.DM_Binh_ga(Mabinh),
Soluong FLOAT,
Giamgia FLOAT,
Thanhtien FLOAT,)
insert into Chi_tiet_hoa_don_ban(SoHDB,Mabinh,Soluong,Giamgia,Thanhtien)
values(N'HD2',N'BG1',700,0.25,173250000);
insert into Chi_tiet_hoa_don_ban(SoHDB,Mabinh,Soluong,Giamgia,Thanhtien)
values(N'HD3',N'BG2',20,0.12,864000);
insert into Chi_tiet_hoa_don_ban(SoHDB,Mabinh,Soluong,Giamgia,Thanhtien)
values(N'HD1',N'BG3',46,0.03,289800);
insert into Chi_tiet_hoa_don_ban(SoHDB,Mabinh,Soluong,Giamgia,Thanhtien)
values(N'HD8',N'BG4',14,0.3,11340000);
insert into Chi_tiet_hoa_don_ban(SoHDB,Mabinh,Soluong,Giamgia,Thanhtien)
values(N'HD4',N'BG4',50,0.21,2835000);
insert into Chi_tiet_hoa_don_ban(SoHDB,Mabinh,Soluong,Giamgia,Thanhtien)
values(N'HD5',N'BG2',54,0.11,21384000);
insert into Chi_tiet_hoa_don_ban(SoHDB,Mabinh,Soluong,Giamgia,Thanhtien)
values(N'HD6',N'BG1',68,0.24,16156800);
insert into Chi_tiet_hoa_don_ban(SoHDB,Mabinh,Soluong,Giamgia,Thanhtien)
values(N'HD7',N'BG3',45,0.03,28350);
select * from Chi_tiet_hoa_don_ban;

SELECT*FROM dbo.Chi_tiet_hoa_don_ban

CREATE TABLE Chi_tiet_hoa_don_nhap(
SoHDN NVARCHAR(50),
Mabinh NVARCHAR(5),
PRIMARY KEY(SoHDN,Mabinh),
CONSTRAINT sdn_pk FOREIGN KEY (SoHDN) REFERENCES dbo.Hoa_don_nhap(SoHDN),
CONSTRAINT mab_pk FOREIGN KEY (Mabinh) REFERENCES dbo.DM_Binh_ga(Mabinh),
Soluong FLOAT,
Dongia FLOAT,
Giamgia FLOAT,
Thanhtien FLOAT,)
select * from Chi_tiet_hoa_don_nhap;
insert into Chi_tiet_hoa_don_nhap(SoHDN,Mabinh,Soluong,Dongia,Giamgia,Thanhtien)
values (N'HDN1',N'BG1',450,337500000,0.32,108000000);
insert into Chi_tiet_hoa_don_nhap(SoHDN,Mabinh,Soluong,Dongia,Giamgia,Thanhtien)
values (N'HDN3',N'BG2',30,5800000,0.02,116000);
insert into Chi_tiet_hoa_don_nhap(SoHDN,Mabinh,Soluong,Dongia,Giamgia,Thanhtien)
values (N'HDN5',N'BG1',19,18810000,0.41,771210);
insert into Chi_tiet_hoa_don_nhap(SoHDN,Mabinh,Soluong,Dongia,Giamgia,Thanhtien)
values (N'HDN6',N'BG3',89,1335000,0.2,267000);
insert into Chi_tiet_hoa_don_nhap(SoHDN,Mabinh,Soluong,Dongia,Giamgia,Thanhtien)
values (N'HDN4',N'BG4',150,24750000,0.47,11632500);
insert into Chi_tiet_hoa_don_nhap(SoHDN,Mabinh,Soluong,Dongia,Giamgia,Thanhtien)
values (N'HDN2',N'BG3',20,6000000,0.7,420000);

SELECT * FROM dbo.Chi_tiet_hoa_don_nhap
