using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.DAO
{
    class QuanLiLopDAO : DataProvider
    {
        DataProvider dt = new DataProvider();
        public DataTable DSLop()
        {
            string query = "SELECT * FROM Lop";
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
        public DataTable DSKhoa()
        {
            string query = "SELECT MaKhoa, TenKhoa FROM Khoa";
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
        public DataTable DSGiaoVien()
        {
            string query = "SELECT MaGiaoVien, HoTen FROM GiaoVien";
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
        public bool ThemLop(Lop l)
        {
            string queryCheck = "SELECT COUNT(*) FROM Lop WHERE MaLop = @MaLop";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                SqlCommand cmdCheck = new SqlCommand(queryCheck, sqlCon);
                cmdCheck.Parameters.AddWithValue("@MaLop", l.MaLop);

                int count = (int)cmdCheck.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Lớp đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            string query = "INSERT INTO Lop(MaLop, TenLop, MaKhoa, GiaoVienCN) VALUES(@MaLop, @TenLop, @MaKhoa, @GiaoVienCN)";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@MaLop", l.MaLop);
                    cmd.Parameters.AddWithValue("@TenLop", l.TenLop);
                    cmd.Parameters.AddWithValue("@MaKhoa", l.MaKhoa);
                    cmd.Parameters.AddWithValue("@GiaoVienCN", l.GiaoVienCN);

                    int d = cmd.ExecuteNonQuery();
                    if (d > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool SuaLop(Lop l)
        {
            string query = "UPDATE Lop SET TenLop = @TenLop, MaKhoa = @MaKhoa, GiaoVienCN = @GiaoVienCN WHERE MaLop = @MaLop";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("MaLop", l.MaKhoa);
                    cmd.Parameters.AddWithValue("@TenLop", l.TenLop);
                    cmd.Parameters.AddWithValue("@MaKhoa", l.MaKhoa);
                    cmd.Parameters.AddWithValue("@GiaoVienCN", l.GiaoVienCN);
                    int d = cmd.ExecuteNonQuery();
                    if (d > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool XoaLop(Lop l)
        {
            string query = "DELETE Lop WHERE MaLop = @MaLop";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@MaLop", l.MaLop);
                    int d = cmd.ExecuteNonQuery();
                    if (d > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public DataTable TimLop(string tenLop)
        {
            string query = "SELECT * FROM Lop WHERE TenLop LIKE @TenLop";
            using (SqlConnection sqlCon = strConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, sqlCon);
                da.SelectCommand.Parameters.AddWithValue("@TenLop", "%" + tenLop + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
