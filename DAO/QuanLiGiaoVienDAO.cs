using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.DAO
{
    class QuanLiGiaoVienDAO : DataProvider
    {
        DataProvider dt = new DataProvider();
        public DataTable DSGiaoVien()
        {

            string query = "SELECT * FROM GiaoVien";
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
        public bool ThemGiaoVien(GiaoVien gv, Users u)
        {
            // Kiểm tra xem giáo viên đã tồn tại trong cơ sở dữ liệu chưa
            string queryCheck = "SELECT COUNT(*) FROM GiaoVien WHERE MaGiaoVien = @MaGiaoVien";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                SqlCommand cmdCheck = new SqlCommand(queryCheck, sqlCon);
                cmdCheck.Parameters.AddWithValue("@MaGiaoVien", gv.MaGiaoVien);

                int count = (int)cmdCheck.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Giáo viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            string queryUsers = "INSERT INTO Users(TenDangNhap, MatKhau, Roles, HoTen) VALUES(@TenDangNhap, @MatKhau, @Roles, @HoTen); SELECT SCOPE_IDENTITY();";
            string queryGV = "INSERT INTO GiaoVien(MaGiaoVien, HoTen, NgaySinh, GioiTinh, CCCD, Email, NamBatDauGiangDay, MaUser) " +
                "VALUES(@MaGiaoVien, @HoTen, @NgaySinh, @GioiTinh, @CCCD, @Email, @NamBatDauGiangDay, @MaUser)";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                SqlCommand cmdUser = new SqlCommand(queryUsers, sqlCon);
                cmdUser.Parameters.AddWithValue("@TenDangNhap", u.TenDangNhap);
                cmdUser.Parameters.AddWithValue("@MatKhau", u.MatKhau);
                cmdUser.Parameters.AddWithValue("@HoTen", gv.HoTen);
                cmdUser.Parameters.AddWithValue("@Roles", "Giáo viên");

                object resuilt = cmdUser.ExecuteScalar();
                if (resuilt != null)
                {
                    int maUser = Convert.ToInt32(resuilt);

                    SqlCommand cmdGV = new SqlCommand(queryGV, sqlCon);
                    cmdGV.Parameters.AddWithValue("@MaGiaoVien", gv.MaGiaoVien);
                    cmdGV.Parameters.AddWithValue("@HoTen", gv.HoTen);
                    cmdGV.Parameters.AddWithValue("@NgaySinh", gv.NgaySinh);
                    cmdGV.Parameters.AddWithValue("@GioiTinh", gv.GioiTinh);
                    cmdGV.Parameters.AddWithValue("@CCCD", gv.CCCD);
                    cmdGV.Parameters.AddWithValue("@Email", gv.Email);
                    cmdGV.Parameters.AddWithValue("@NamBatDauGiangDay", gv.NamBatDauGiangDay);
                    cmdGV.Parameters.AddWithValue("@MaUser", maUser);
                    int d = cmdGV.ExecuteNonQuery();
                    if (d > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool SuaGiaoVien(GiaoVien gv, Users u)
        {
            string queryGV = "UPDATE GiaoVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, Email = @Email, CCCD = @CCCD, NamBatDauGiangDay = @NamBatDauGiangDay WHERE MaGiaoVien = @MaGiaoVien";
            string queryUsers = "UPDATE Users SET MatKhau = @MatKhau, HoTen = @HoTen WHERE TenDangNhap = @TenDangNhap";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                SqlCommand cmdGV = new SqlCommand(queryGV, sqlCon);
                cmdGV.Parameters.AddWithValue("@MaGiaoVien", gv.MaGiaoVien);
                cmdGV.Parameters.AddWithValue("@HoTen", gv.HoTen);
                cmdGV.Parameters.AddWithValue("@NgaySinh", gv.NgaySinh);
                cmdGV.Parameters.AddWithValue("@GioiTinh", gv.GioiTinh);
                cmdGV.Parameters.AddWithValue("@Email", gv.Email);
                cmdGV.Parameters.AddWithValue("@CCCD", gv.CCCD);
                cmdGV.Parameters.AddWithValue("NamBatDauGiangDay", gv.NamBatDauGiangDay);

                int d = cmdGV.ExecuteNonQuery();
                if (d > 0)
                {
                    SqlCommand cmdUsers = new SqlCommand(queryUsers, sqlCon);
                    cmdUsers.Parameters.AddWithValue("@TenDangNhap", u.TenDangNhap);
                    cmdUsers.Parameters.AddWithValue("@MatKhau", u.MatKhau);
                    cmdUsers.Parameters.AddWithValue("@HoTen", gv.HoTen);


                    int c = cmdUsers.ExecuteNonQuery();
                    if (c > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool XoaGiaoVien(GiaoVien gv, Users u)
        {
            string queryGV = "DELETE FROM GiaoVien WHERE MaGiaoVien = @MaGiaoVien";
            string queryUser = "DELETE FROM Users WHERE TenDangNhap = @TenDangNhap";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                SqlCommand cmdGV = new SqlCommand(queryGV, sqlCon);
                cmdGV.Parameters.AddWithValue("@MaGiaoVien", gv.MaGiaoVien);
                int d = cmdGV.ExecuteNonQuery();
                if (d > 0)
                {
                    SqlCommand cmdUsers = new SqlCommand(queryUser, sqlCon);
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
        public DataTable TimDanhSachGiaoVienTheoHoTen(string hoTen)
        {
            string query = "SELECT * FROM GiaoVien WHERE HoTen LIKE @HoTen";
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
