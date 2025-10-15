using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.DAO
{
    class QuanLiSinhVienDAO : DataProvider
    {
        DataProvider dt = new DataProvider();
        //Danh sách lớp
        public DataTable DSLop()
        {
            string query = "SELECT TenLop, MaLop FROM Lop";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlDataAdapter adt = new SqlDataAdapter(query, sqlCon))
                {
                    DataTable dt = new DataTable();
                    adt.Fill(dt);
                    return dt;
                }
            }
        }

        //Lấy danh sách sinh viên theo lớp
        public DataTable LayDSSVTheoLop(int maLop)
        {
            string query = "SELECT * FROM SinhVien WHERE MaLop = @MaLop";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@MaLop", maLop);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        //Danh sách sinh viên
        public DataTable DSSinhVien()
        {
            string query = "SELECT * FROM SINHVIEN";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlDataAdapter adt = new SqlDataAdapter(query, sqlCon))
                {
                    DataTable dt = new DataTable();
                    adt.Fill(dt);
                    return dt;
                }
            }
        }
        //Thêm sinh viên
        public bool ThemSinhVien(SinhVien sv, Users u)
        {
            // Kiểm tra xem sinh viên đã tồn tại trong cơ sở dữ liệu chưa
            string queryCheck = "SELECT COUNT(*) FROM SINHVIEN WHERE MaSinhVien = @MaSinhVien";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                SqlCommand cmdCheck = new SqlCommand(queryCheck, sqlCon);
                cmdCheck.Parameters.AddWithValue("@MaSinhVien", sv.MaSinhVien);

                int count = (int)cmdCheck.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Sinh viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            string queryUserSV = "INSERT INTO Users(TenDangNhap, MatKhau, Roles, HoTen) VALUES(@TenDangNhap, @MatKhau, @Roles, @HoTen); SELECT SCOPE_IDENTITY();";
            string querySV = "INSERT INTO SINHVIEN(MaSinhVien, MaLop, HoTen, NgaySinh, GioiTinh, Email, CCCD, MaUser) " +
                             "VALUES(@MaSinhVien, @MaLop, @HoTen, @NgaySinh, @GioiTinh, @Email, @CCCD, @MaUser)";

            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();

                SqlCommand cmdUS = new SqlCommand(queryUserSV, sqlCon);
                cmdUS.Parameters.AddWithValue("@TenDangNhap", u.TenDangNhap);
                cmdUS.Parameters.AddWithValue("@MatKhau", u.MatKhau);
                cmdUS.Parameters.AddWithValue("@Roles", "Sinh viên");
                cmdUS.Parameters.AddWithValue("@HoTen", sv.HoTen);

                object result = cmdUS.ExecuteScalar();
                if (result != null)
                {
                    int maUser = Convert.ToInt32(result);

                    SqlCommand cmdSV = new SqlCommand(querySV, sqlCon);
                    cmdSV.Parameters.AddWithValue("@MaSinhVien", sv.MaSinhVien);
                    cmdSV.Parameters.AddWithValue("@MaLop", sv.MaLop);
                    cmdSV.Parameters.AddWithValue("@HoTen", sv.HoTen);
                    cmdSV.Parameters.AddWithValue("@NgaySinh", sv.NgaySinh);
                    cmdSV.Parameters.AddWithValue("@GioiTinh", sv.GioiTinh);
                    cmdSV.Parameters.AddWithValue("@Email", sv.Email);
                    cmdSV.Parameters.AddWithValue("@CCCD", sv.CCCD);
                    cmdSV.Parameters.AddWithValue("@MaUser", maUser);

                    int d = cmdSV.ExecuteNonQuery();
                    if (d > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        //Sửa sinh viên
        public bool SuaSinhVien(SinhVien sv, Users u)
        {
            DataProvider dt = new DataProvider();
            string querySV = "UPDATE SINHVIEN SET HoTen = @HoTen, MaLop = @MaLop, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, Email = @Email, CCCD = @CCCD WHERE MaSinhVien = @MaSinhVien";
            string queryUserSV = "UPDATE Users SET MatKhau = @MatKhau, HoTen = @HoTen WHERE TenDangNhap = @TenDangNhap";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                SqlCommand cmdSV = new SqlCommand(querySV, sqlCon);
                cmdSV.Parameters.AddWithValue("@MaSinhVien", sv.MaSinhVien);
                cmdSV.Parameters.AddWithValue("@HoTen", sv.HoTen);
                cmdSV.Parameters.AddWithValue("@MaLop", sv.MaLop);
                cmdSV.Parameters.AddWithValue("@NgaySinh", sv.NgaySinh);
                cmdSV.Parameters.AddWithValue("@GioiTinh", sv.GioiTinh);
                cmdSV.Parameters.AddWithValue("@Email", sv.Email);
                cmdSV.Parameters.AddWithValue("@CCCD", sv.CCCD);
                int d = cmdSV.ExecuteNonQuery();
                if (d > 0)
                {
                    SqlCommand cmdUser = new SqlCommand(queryUserSV, sqlCon);
                    cmdUser.Parameters.AddWithValue("@TenDangNhap", u.TenDangNhap);
                    cmdUser.Parameters.AddWithValue("@MatKhau", u.MatKhau);
                    cmdUser.Parameters.AddWithValue("@HoTen", sv.HoTen);
                    int c = cmdUser.ExecuteNonQuery();
                    if (c > 0)
                    {
                        return true;
                    }
                }

            }
            return false;
        }

        //Xóa sinh viên
        public bool XoaSinhVien(SinhVien sv, Users u)
        {
            string querySV = "DELETE FROM SinhVien WHERE MaSinhVien = @MaSinhVien";
            string queryUserSV = "DELETE FROM Users WHERE TenDangNhap = @TenDangNhap";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                SqlCommand cmdSV = new SqlCommand(querySV, sqlCon);
                cmdSV.Parameters.AddWithValue("@MaSinhVien", sv.MaSinhVien);
                int d = cmdSV.ExecuteNonQuery();
                if (d > 0)
                {
                    SqlCommand cmdUsers = new SqlCommand(queryUserSV, sqlCon);
                    cmdUsers.Parameters.AddWithValue("@TenDangNhap", u.TenDangNhap);
                    int c = cmdUsers.ExecuteNonQuery();
                    if (c > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Tìm sinh viên
        public DataTable TimDanhSachSinhVienTheoHoTen(string hoTen)
        {
            string query = "SELECT * FROM SinhVien WHERE HoTen LIKE @HoTen";
            using (SqlConnection sqlCon = strConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, sqlCon);
                da.SelectCommand.Parameters.AddWithValue("@HoTen", "%" + hoTen + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}
