using System.Data;
using System.Data.SqlClient;
using Project_QuanLiSinhVien_DoAn.DTO;

namespace Project_QuanLiSinhVien_DoAn.DAO
{
    class KiemTraDangNhapDAO : DataProvider
    {
        DataProvider dt = new DataProvider();

        //Dữ liệu vai trò;
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

        //Kiểm tra đăng nhập:
        public (bool kq, int maUser) KiemTraDangNhap(Users u)
        {
            string query = "SELECT Roles, MaUser FROM Users WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", u.TenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", u.MatKhau);

                    int maUser = 0;
                    string actual_role = string.Empty;

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        maUser = int.Parse(reader["MaUser"].ToString());
                        actual_role = reader["Roles"].ToString();
                    }
                    reader.Close();

                    string user_selectRole = u.Roles;

                    if (actual_role != null && actual_role.Equals(user_selectRole))
                    {
                        return (true, maUser);
                    }
                    else
                    {
                        return (false, maUser);
                    }
                }
            }
        }
    }
}
