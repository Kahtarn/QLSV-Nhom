using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.DAO
{
    class QuanLiMonHocDAO : DataProvider
    {
        DataProvider dt = new DataProvider();
        public DataTable DSMonHoc()
        {
            string query = "SELECT * FROM MonHoc";
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
        public bool ThemMonHoc(MonHoc mh)
        {
            string queryCheck = "SELECT COUNT(*) FROM MonHoc WHERE MaMonHoc = @MaMonHoc";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                SqlCommand cmdCheck = new SqlCommand(queryCheck, sqlCon);
                cmdCheck.Parameters.AddWithValue("@MaMonHoc", mh.MaMonHoc);

                int count = (int)cmdCheck.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Sinh viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            string query = "INSERT INTO MonHoc(MaMonHoc, TenMonHoc, SoTinChi) VALUES(@MaMonHoc, @TenMonHoc, @SoTinChi)";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@MaMonHoc", mh.MaMonHoc);
                    cmd.Parameters.AddWithValue("@TenMonHoc", mh.TenMonHoc);
                    cmd.Parameters.AddWithValue("@SoTinChi", mh.SoTinChi);
                    int d = cmd.ExecuteNonQuery();
                    if (d > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool SuaMonHoc(MonHoc mh)
        {
            string query = "UPDATE MonHoc SET TenMonHoc = @TenMonHoc, SoTinChi = @SoTinChi WHERE MaMonHoc = @MaMonHoc";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@MaMonHoc", mh.MaMonHoc);
                    cmd.Parameters.AddWithValue("@TenMonHoc", mh.TenMonHoc);
                    cmd.Parameters.AddWithValue("@SoTinChi", mh.SoTinChi);
                    int d = cmd.ExecuteNonQuery();
                    if (d > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool XoaMonHoc(MonHoc mh)
        {
            string query = "DELETE FROM MonHoc WHERE MaMonHoc = @MaMonHoc";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@MaMonHoc", mh.MaMonHoc);
                    int d = cmd.ExecuteNonQuery();
                    if (d > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
