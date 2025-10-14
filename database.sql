-- Tạo cơ sở dữ liệu
CREATE DATABASE QUANLISINHVIEN_DB
GO

USE QUANLISINHVIEN_DB
GO

-- Bảng quản lí tài khoản
CREATE TABLE USERS(
    MaUser INT IDENTITY(1,1) PRIMARY KEY,
	HoTen NVARCHAR(255),
    TenDangNhap NVARCHAR(50) UNIQUE NOT NULL,
    MatKhau NVARCHAR(255) NOT NULL,
    Roles NVARCHAR(10) CHECK (Roles IN ('Admin', 'Giáo viên', 'Sinh viên')) NOT NULL
);

-- Bảng khoa, thuộc về 1 bậc đào tạo
CREATE TABLE KHOA(
    MaKhoa INT PRIMARY KEY,
    TenKhoa NVARCHAR(100) NOT NULL
);
	
-- Bảng giáo viên
CREATE TABLE GIAOVIEN(
    MaGiaoVien int PRIMARY KEY,
    MaUser INT UNIQUE,
	HoTen NVARCHAR(255),
    NgaySinh DATETIME,
	CCCD NVARCHAR(12),
	Email NVARCHAR(255),
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN (N'Nam', N'Nữ')) NOT NULL,
    NamBatDauGiangDay DATETIME NOT NULL,
    FOREIGN KEY (MaUser) REFERENCES Users(MaUser) ON DELETE CASCADE
);

-- Bảng liên kết giáo viên với nhiều khoa
CREATE TABLE GIAOVIEN_KHOA(
    MaGiaoVien INT,
    MaKhoa INT,
    PRIMARY KEY (MaGiaoVien, MaKhoa),
    FOREIGN KEY (MaGiaoVien) REFERENCES GiaoVien(MaGiaoVien) ON DELETE CASCADE,
    FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa) ON DELETE CASCADE
);

-- Bảng lớp học, lớp chỉ thuộc về 1 khoa
CREATE TABLE LOP(
    MaLop INT PRIMARY KEY,
    TenLop NVARCHAR(50) NOT NULL,
    MaKhoa INT,
    SiSo INT DEFAULT 0,
    GiaoVienCN INT NULL, -- Giáo viên chủ nhiệm
    FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa) ON DELETE CASCADE,
    FOREIGN KEY (GiaoVienCN) REFERENCES GiaoVien(MaGiaoVien) ON DELETE SET NULL
);

-- Bảng sinh viên, sinh viên thì chỉ thuộc 1 lớp
CREATE TABLE SINHVIEN (
    MaSinhVien NVARCHAR(20) PRIMARY KEY,
    MaLop INT,
	MaUser INT UNIQUE,
	HoTen NVARCHAR(255),
    NgaySinh DATETIME,
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN (N'Nam', N'Nữ')) NOT NULL,
	Email NVARCHAR(255),
	CCCD NVARCHAR(12),
    FOREIGN KEY (MaLop) REFERENCES Lop(MaLop) ON DELETE CASCADE,
    FOREIGN KEY (MaUser) REFERENCES Users(MaUser) ON DELETE CASCADE
);

go
-- Trigger để tự động tăng sĩ số lớp khi thêm sinh viên
drop trigger trg_after_delete_sinhvien

CREATE TRIGGER trg_after_insert_sinhvien
ON SinhVien
AFTER INSERT
AS
BEGIN
    UPDATE LOP
    SET SiSo = SiSo + 1
    FROM LOP
    INNER JOIN inserted ON Lop.MaLop = inserted.MaLop;
END;
GO

-- Trigger để tự động giảm sĩ số lớp khi xóa sinh viên
CREATE TRIGGER trg_after_delete_sinhvien
ON SinhVien
AFTER DELETE
AS
BEGIN
    UPDATE LOP
    SET SiSo = SiSo - 1
    FROM Lop
    INNER JOIN deleted ON Lop.MaLop = deleted.MaLop;
END;
GO

-- Bảng môn học
CREATE TABLE MONHOC(
    MaMonHoc INT PRIMARY KEY,
    TenMonHoc NVARCHAR(100) NOT NULL,
    SoTinChi INT NOT NULL
);

-- Bảng phân công giảng dạy
CREATE TABLE PHANCONG(
    MaGiaoVien INT,
    MaLop INT,
    MaMonHoc INT,
    PRIMARY KEY (MaGiaoVien, MaLop, MaMonHoc),
    FOREIGN KEY (MaGiaoVien) REFERENCES GiaoVien(MaGiaoVien) ON DELETE CASCADE,
    FOREIGN KEY (MaLop) REFERENCES Lop(MaLop) ON DELETE CASCADE,
    FOREIGN KEY (MaMonHoc) REFERENCES MonHoc(MaMonHoc) ON DELETE CASCADE
);

-- Bảng điểm sinh viên
CREATE TABLE DIEM(
    MaSinhVien NVARCHAR(20),
    MaMonHoc INT,
    DiemChuyenCan FLOAT CHECK (DiemChuyenCan BETWEEN 0 AND 10),
    DiemTrungBinhKT FLOAT CHECK (DiemTrungBinhKT BETWEEN 0 AND 10),
    DiemThiLan1 FLOAT CHECK (DiemThiLan1 BETWEEN 0 AND 10),
    DiemThiLan2 FLOAT CHECK (DiemThiLan2 BETWEEN 0 AND 10),
    DiemTongKet FLOAT CHECK (DiemTongKet BETWEEN 0 AND 10),
    PRIMARY KEY (MaSinhVien, MaMonHoc),
    FOREIGN KEY (MaSinhVien) REFERENCES SinhVien(MaSinhVien) ON DELETE CASCADE,
    FOREIGN KEY (MaMonHoc) REFERENCES MonHoc(MaMonHoc) ON DELETE CASCADE
);

INSERT INTO USERS (HoTen, TenDangNhap, MatKhau, Roles)
VALUES 
(N'Admin hệ thống', 'admin', 'admin123', 'Admin'),
(N'Nguyễn Văn An', 'gv.an', 'gv123456', N'Giáo viên'),
(N'Trần Minh Hoàng', 'sv.hoang', 'sv123456', N'Sinh viên'),
(N'Lê Thị Mai', 'sv.mai', 'sv123789', N'Sinh viên');


INSERT INTO KHOA (Makhoa, TenKhoa)
VALUES 
(1, N'Công nghệ thông tin'),
(2, N'Kinh tế'),
(3, N'Kỹ thuật xây dựng');

INSERT INTO GIAOVIEN (MaGiaoVien, MaUser, HoTen, NgaySinh, CCCD, Email, GioiTinh, NamBatDauGiangDay)
VALUES 
(1001, 2, N'Nguyễn Văn An', '1980-03-15', '123456789012', 'an.nv@school.edu.vn', N'Nam', '2005-09-01');

INSERT INTO GIAOVIEN_KHOA (MaGiaoVien, MaKhoa)
VALUES 
(1001, 1),
(1001, 2);

INSERT INTO LOP (MaLop, TenLop, MaKhoa, SiSo, GiaoVienCN)
VALUES 
(1, N'DHTH20A', 1, 0, 1001),
(2, N'KT21B', 2, 0, NULL);

INSERT INTO SINHVIEN (MaSinhVien, MaLop, MaUser, HoTen, NgaySinh, GioiTinh, Email, CCCD)
VALUES 
('0306231201', 1, 3, N'Trần Minh Hoàng', '2003-06-23', N'Nam', 'hoang.tm@student.edu.vn', '987654321001'),
('0306231202', 1, 4, N'Lê Thị Mai', '2003-12-01', N'Nữ', 'mai.lt@student.edu.vn', '987654321002');

INSERT INTO MONHOC (MaMonHoc,TenMonHoc, SoTinChi)
VALUES 
(1,N'Lập trình C#', 3),
(2,N'Cơ sở dữ liệu', 3),
(3,N'Toán rời rạc', 2);

INSERT INTO PHANCONG (MaGiaoVien, MaLop, MaMonHoc)
VALUES 
(1001, 1, 1),
(1001, 1, 2);

INSERT INTO DIEM (MaSinhVien, MaMonHoc, DiemChuyenCan, DiemTrungBinhKT, DiemThiLan1, DiemThiLan2, DiemTongKet)
VALUES 
('0306231201', 1, 9.0, 8.0, 7.5, NULL, 8.0),
('0306231202', 1, 7.0, 6.5, 4.5, 6.0, 5.8);

select * from USERS
select * from SINHVIEN
