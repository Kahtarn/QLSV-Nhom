using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.DAO
{
    class QuanLiKhoaDAO : DataProvider
    {
        DataProvider dt = new DataProvider();
        public DataTable DSKhoa()
        {
            string query = "SELECT * FROM Khoa";
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
        public bool ThemKhoa(Khoa k)
        {
            string query = "INSERT INTO Khoa(MaKhoa, TenKhoa) VALUES(@MaKhoa, @TenKhoa)";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@MaKhoa", k.MaKhoa);
                    cmd.Parameters.AddWithValue("@TenKhoa", k.TenKhoa);

                    int d = cmd.ExecuteNonQuery();
                    if (d > 0)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public bool SuaKhoa(Khoa k)
        {
            string query = "UPDATE Khoa SET TenKhoa = @TenKhoa WHERE MaKhoa = @MaKhoa";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@MaKhoa", k.MaKhoa);
                    cmd.Parameters.AddWithValue("@TenKhoa", k.TenKhoa);
                    int d = cmd.ExecuteNonQuery();
                    if (d > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool XoaKhoa(Khoa k)
        {
            // Kiểm tra xem khoa đã tồn tại chưa
            string checkQuery = "SELECT COUNT(*) FROM Khoa WHERE MaKhoa = @MaKhoa OR TenKhoa = @TenKhoa";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlCommand cmdCheck = new SqlCommand(checkQuery, sqlCon))
                {
                    cmdCheck.Parameters.AddWithValue("@MaKhoa", k.MaKhoa);
                    cmdCheck.Parameters.AddWithValue("@TenKhoa", k.TenKhoa);

                    int count = (int)cmdCheck.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Khoa đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            string query = "DELETE FROM Khoa WHERE MaKhoa = @MaKhoa";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@Makhoa", k.MaKhoa);
                    int d = cmd.ExecuteNonQuery();
                    if (d > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool TimKhoa(Khoa k)
        {
            string query = "SELECT * FROM Khoa WHERE TenKhoa LIKE @TenKhoa";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@TenKhoa", "%" + k.TenKhoa + "%");
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    k.MaKhoa = Convert.ToInt32(rd["MaKhoa"].ToString());
                    k.TenKhoa = rd["TenKhoa"].ToString();
                    return true;
                }
            }
            return false;
        }
    }
}
