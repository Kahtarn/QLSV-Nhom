using System.Data;
using System.Data.SqlClient;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.DAO
{
    class QuanLiUsersDAO : DataProvider
    {
        DataProvider dt = new DataProvider();
        public DataTable VaiTro()
        {
            string query = "SELECT DISTINCT Roles FROM Users";
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
        public DataTable DSUser()
        {
            string query = "SELECT * FROM Users";
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
        public bool ThemUser(Users u)
        {
            string query = "INSERT INTO Users (HoTen, TenDangNhap, MatKhau, Roles) VALUES (@HoTen, @TenDangNhap, @MatKhau, @Roles)";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@HoTen", u.HoTen);
                    cmd.Parameters.AddWithValue("@TenDangNhap", u.TenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", u.MatKhau);
                    cmd.Parameters.AddWithValue("@Roles", u.Roles);

                    int d = cmd.ExecuteNonQuery();
                    if (d > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool SuaUser(Users u)
        {
            string query = "UPDATE Users SET HoTen = @HoTen, MatKhau = @MatKhau, Roles = @Roles WHERE TenDangNhap = @TenDangNhap";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@HoTen", u.HoTen);
                    cmd.Parameters.AddWithValue("@MatKhau", u.MatKhau);
                    cmd.Parameters.AddWithValue("@Roles", u.Roles);
                    cmd.Parameters.AddWithValue("@TenDangNhap", u.TenDangNhap);

                    int d = cmd.ExecuteNonQuery();
                    if (d > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool XoaUser(Users u)
        {
            string query = "DELETE FROM Users WHERE TenDangNhap = @TenDangNhap";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", u.TenDangNhap);

                    int d = cmd.ExecuteNonQuery();
                    if (d > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public DataTable TimUser(string hoTen)
        {
            string query = "SELECT * FROM Users WHERE HoTen LIKE @HoTen";
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
