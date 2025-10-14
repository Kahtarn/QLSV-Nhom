using System.Data;
using System.Data.SqlClient;
using Project_QuanLiSinhVien_DoAn.DTO;

namespace Project_QuanLiSinhVien_DoAn.DAO
{
    class User_SinhVienDAO : DataProvider
    {
        public DataTable layThongTinSinhVien_DAO(Users usr)
        {
            string query = "SELECT sv.MaSinhVien, sv.HoTen, l.TenLop " +
                           "FROM USERS usr, SINHVIEN sv, LOP l " +
                           "WHERE usr.MaUser = @maUser and usr.MaUser = sv.MaUser and sv.MaLop = l.MaLop ";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlDataAdapter adt = new SqlDataAdapter(query, sqlCon))
                {
                    adt.SelectCommand.Parameters.AddWithValue("@maUSer", usr.MaUser);
                    DataTable dt = new DataTable();
                    adt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        return dt;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public DataTable layDSDiem_DAO(Users usr)
        {
            string query = "SELECT mh.MaMonHoc, mh.TenMonHoc, mh.SoTinChi, d.DiemChuyenCan, " +
                            " d.DiemChuyenCan, d.DiemTrungBinhKT, d.DiemThiLan1, d.DiemThiLan2, d.DiemTongKet " +
                            " FROM MONHOC mh, DIEM d, SINHVIEN sv, USERS usr" +
                            " WHERE usr.MaUser = @maUser and mh.MaMonHoc =  d.MaMonHoc and d.MaSinhVien = sv.MaSinhVien and sv.MaUser = usr.MaUser";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlDataAdapter adt = new SqlDataAdapter(query, sqlCon))
                {
                    adt.SelectCommand.Parameters.AddWithValue("@maUSer", usr.MaUser);
                    DataTable dt = new DataTable();
                    adt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        return dt;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public DataTable layTable_Report_SV_DAO(Users usr)
        {
            string query = "SELECT SINHVIEN.MaSinhVien, USERS.HoTen, MONHOC.TenMonHoc, DIEM.DiemChuyenCan, DIEM.DiemTrungBinhKT, DIEM.DiemThiLan1, DIEM.DiemThiLan2, DIEM.DiemTongKet" +
                                " FROM DIEM INNER JOIN MONHOC ON DIEM.MaMonHoc = MONHOC.MaMonHoc INNER JOIN" +
                                " SINHVIEN ON DIEM.MaSinhVien = SINHVIEN.MaSinhVien INNER JOIN" +
                                " USERS ON SINHVIEN.MaUser = USERS.MaUser" +
                                " WHERE USERS.MaUser = @mauser ";

            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlDataAdapter adt = new SqlDataAdapter(query, sqlCon))
                {
                    adt.SelectCommand.Parameters.AddWithValue("@maUSer", usr.MaUser);
                    DataTable dt = new DataTable();
                    adt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        return dt;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
    }
}
