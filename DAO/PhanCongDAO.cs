using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.DAO
{
    class PhanCongDAO : DataProvider
    {
        DataProvider dt = new DataProvider();
        public DataTable DSPhanCong()
        {
            string query = "SELECT pc.MaGiaoVien, gv.HoTen AS TenGV, l.TenLop, mh.TenMonHoc " +
                "FROM PHANCONG pc " +
                "JOIN GIAOVIEN gv ON pc.MaGiaoVien = gv.MaGiaoVien " +
                "JOIN LOP l ON pc.MaLop = l.MaLop " +
                "JOIN MONHOC mh ON pc.MaMonHoc = mh.MaMonHoc";
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
        public DataTable DSLop()
        {
            string query = "SELECT MaLop, TenLop FROM LOP";
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
        public DataTable DSMonHoc()
        {
            string query = "SELECT MaMonHoc, TenMonHoc FROM MonHoc";
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
        public bool ThemPhanCong(PhanCong pc)
        {
            string queryCheck = "SELECT COUNT(*) FROM PHANCONG WHERE MaLop = @MaLop AND MaMonHoc = @MaMonHoc";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                SqlCommand cmdCheck = new SqlCommand(queryCheck, sqlCon);
                cmdCheck.Parameters.AddWithValue("@MaLop", pc.MaLop);
                cmdCheck.Parameters.AddWithValue("@MaMonHoc", pc.MaMonHoc);

                int count = (int)cmdCheck.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Môn học này đã được phân công cho lớp này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            string query = "INSERT INTO PHANCONG (MaGiaoVien, MaLop, MaMonHoc) VALUES (@MaGV, @MaLop, @MaMon)";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@MaGV", pc.MaGiaoVien);
                    cmd.Parameters.AddWithValue("@MaLop", pc.MaLop);
                    cmd.Parameters.AddWithValue("@MaMon", pc.MaMonHoc);
                    int d = cmd.ExecuteNonQuery();
                    {
                        if (d > 0)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public bool XoaPhanCong(PhanCong pc)
        {
            string query = "DELETE FROM PHANCONG WHERE MaGiaoVien = @MaGV AND MaLop = @MaLop AND MaMonHoc = @MaMon";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@MaGV", pc.MaGiaoVien);
                    cmd.Parameters.AddWithValue("@MaLop", pc.MaLop);
                    cmd.Parameters.AddWithValue("@MaMon", pc.MaMonHoc);
                    int d = cmd.ExecuteNonQuery();
                    if (d > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public DataTable TimPhanCong(Lop l)
        {
            string query = "SELECT PC.MaGiaoVien, GV.HoTen AS TenGiaoVien, PC.MaLop, L.TenLop, PC.MaMonHoc, MH.TenMonHoc " +
                "FROM PHANCONG PC JOIN GIAOVIEN GV ON PC.MaGiaoVien = GV.MaGiaoVien JOIN LOP L ON PC.MaLop = L.MaLop JOIN MONHOC MH ON PC.MaMonHoc = MH.MaMonHoc WHERE " +
                "L.MaLop = @MaLop";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@MaLop", l.MaLop);
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
