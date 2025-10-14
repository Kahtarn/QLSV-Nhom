using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Project_QuanLiSinhVien_DoAn.DTO;

namespace Project_QuanLiSinhVien_DoAn.DAO
{
    class User_GiaoVienDAO : DataProvider
    {
        public DataTable loadLopcuaGVien_DAO(Users usr)
        {
            string query = "SELECT distinct lop.MaLop, lop.TenLop " +
                            " FROM GIAOVIEN gv, PHANCONG pcong, LOP lop " +
                            " WHERE gv.MaGiaoVien = pcong.MaGiaoVien AND pcong.MaLop = lop.MaLop AND gv.MaUser = @maUser_cua_GV";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlDataAdapter adt = new SqlDataAdapter(query, sqlCon))
                {
                    adt.SelectCommand.Parameters.AddWithValue("@maUser_cua_GV", usr.MaUser);
                    DataTable dt = new DataTable();
                    adt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        return dt;
                    }
                    return null;
                }
            }
        }

        public DataTable loadAllSV_DAO(Users usr)
        {
            string query = "SELECT distinct LOP.MaLop , SINHVIEN.MaSinhVien, SINHVIEN.HoTen, SINHVIEN.GioiTinh, SINHVIEN.NgaySinh, SINHVIEN.Email, SINHVIEN.CCCD " +
                            " FROM SINHVIEN join LOP on SINHVIEN.MaLop = LOP.MaLop " +
                            " join PHANCONG on lop.MaLop = PHANCONG.MaLop " +
                            " join GIAOVIEN on PHANCONG.MaGiaoVien = GIAOVIEN.MaGiaoVien " +
                            " WHERE GIAOVIEN.MaUser = @maUser_GV ";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlDataAdapter adt = new SqlDataAdapter(query, sqlCon))
                {
                    adt.SelectCommand.Parameters.AddWithValue("@maUser_GV", usr.MaUser);
                    DataTable dt = new DataTable();
                    adt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        return dt;
                    }
                    return null;
                }
            }
        }

        public DataTable load_SinhVienTheoLop_DAO(Lop lop, Users us)
        {
            string query = "SELECT distinct LOP.MaLop, SINHVIEN.MaSinhVien, SINHVIEN.HoTen, SINHVIEN.GioiTinh, SINHVIEN.NgaySinh, SINHVIEN.Email, SINHVIEN.CCCD " +
                            " FROM SINHVIEN join LOP on SINHVIEN.MaLop = LOP.MaLop " +
                            " join PHANCONG on lop.MaLop = PHANCONG.MaLop " +
                            " join GIAOVIEN on PHANCONG.MaGiaoVien = GIAOVIEN.MaGiaoVien " +
                            " WHERE LOP.MaLop = @maLop AND GIAOVIEN.MaUser = @maUser_GV ";


            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlDataAdapter adt = new SqlDataAdapter(query, sqlCon))
                {
                    adt.SelectCommand.Parameters.AddWithValue("@maLop", lop.MaLop);
                    adt.SelectCommand.Parameters.AddWithValue("@maUser_GV", us.MaUser);
                    DataTable dt = new DataTable();
                    adt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        return dt;
                    }
                    return null;
                }
            }
        }
        public DataTable loadThongTinGV_DAO(Users usr)
        {
            string query = " SELECT gv.MaGiaoVien, gv.HoTen, lop.TenLop, lop.SiSo " +
                            " FROM GIAOVIEN gv, LOP lop " +
                            " WHERE  gv.MaGiaoVien = lop.GiaoVienCN AND gv.MaUser = @maUser_GV";
            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlDataAdapter adt = new SqlDataAdapter(query, sqlCon))
                {
                    adt.SelectCommand.Parameters.AddWithValue("@maUser_GV", usr.MaUser);
                    DataTable dt = new DataTable();
                    adt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        return dt;
                    }
                    return null;
                }
            }
        }


        public DataTable loadMonHoccuaSV_DAO(PhanCong pc, SinhVien sv)
        {
            string query = "SELECT sv.MaSinhVien, mh.MaMonHoc,mh.TenMonHoc " +
                            " FROM PHANCONG pc " +
                            " JOIN LOP l ON pc.MaLop = l.MaLop " +
                            " JOIN SINHVIEN sv ON sv.MaLop = l.MaLop " +
                            " JOIN MONHOC mh ON pc.MaMonHoc = mh.MaMonHoc " +
                            " LEFT JOIN DIEM d ON d.MaSinhVien = sv.MaSinhVien AND d.MaMonHoc = mh.MaMonHoc " +
                            " WHERE pc.MaGiaoVien = @maGV AND pc.MaLop = @maLop AND sv.MaSinhVien = @maSV";

            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlDataAdapter adt = new SqlDataAdapter(query, sqlCon))
                {
                    adt.SelectCommand.Parameters.AddWithValue("@maGV", pc.MaGiaoVien);
                    adt.SelectCommand.Parameters.AddWithValue("@maLop", pc.MaLop);
                    adt.SelectCommand.Parameters.AddWithValue("@maSV", sv.MaSinhVien);
                    DataTable dt = new DataTable();
                    adt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        return dt;
                    }
                    return null;
                }
            }
        }

        //kiem tra sv co  tom tai trong bang diem hay chua
        public bool chk_sinhVieninDiem(Diem diem)
        {
            //diem.MaSinhVien
            //pc.MaGiaoVien
            //pc.MaLop
            //sv.MaSinhVien

            //kiem tra lan luot cac cap ma SV, ma mon hoc da co trong bang diem hay chua

            string ktr_sv_exist = "SELECT 1 FROM DIEM WHERE MaMonHoc = @maMH AND MaSinhVien = @maSV";

            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlCommand cm_chekc = new SqlCommand(ktr_sv_exist, sqlCon))
                {
                    cm_chekc.Parameters.AddWithValue("@maMH", diem.MaMonHoc);
                    cm_chekc.Parameters.AddWithValue("@maSV", diem.MaSinhVien);
                    int? result = (int?)cm_chekc.ExecuteScalar();

                    if (result == null)
                    {
                        //khong ton tai
                        return true;
                    }
                    return false;
                }
            }


        }
        public bool themDiemSinhVien_DAO(Diem diem, PhanCong pc)
        {
            string query_insert = "INSERT DIEM " +
                                    "VALUES(@maSV, @maMonHoc, @diemChuyenCan, @diemTBKT, @diemThiLan1," +
                                    " @diemThiLan2, @diemTongKet)";


            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();

                using (SqlCommand cm = new SqlCommand(query_insert, sqlCon))
                {
                    cm.Parameters.AddWithValue("@diemChuyenCan", diem.DiemChuyenCan);
                    cm.Parameters.AddWithValue("@diemTBKT", diem.DiemTrungBinhKT);
                    cm.Parameters.AddWithValue("@diemThiLan1", diem.DiemThiLan1);
                    cm.Parameters.AddWithValue("@diemThiLan2", diem.DiemThiLan2.HasValue ? (object)diem.DiemThiLan2.Value : DBNull.Value);
                    cm.Parameters.AddWithValue("@diemTongKet", diem.DiemTongKet);
                    cm.Parameters.AddWithValue("@maMonHoc", pc.MaMonHoc);
                    cm.Parameters.AddWithValue("@maSV", diem.MaSinhVien);
                    DataTable dt = new DataTable();

                    int affect_row = cm.ExecuteNonQuery();

                    if (affect_row <= 0)
                    {
                        return false;
                    }
                }

            }
            return true;
        }
        public DataTable taoDiemSinhVienMoi(SinhVien sv, PhanCong pc)
        {
            DataTable result = new DataTable();

            string query = "SELECT mh.MaMonHoc,mh.TenMonHoc, " +
                        " ISNULL(d.DiemChuyenCan, 0) AS DiemChuyenCan," +
                        " ISNULL(d.DiemTrungBinhKT, 0) AS DiemTrungBinhKT, " +
                        " ISNULL(d.DiemThiLan1, 0) AS DiemThiLan1, " +
                        " ISNULL(d.DiemThiLan2, 0) AS DiemThiLan2," +
                        " ISNULL(d.DiemTongKet, 0) AS DiemTongKet " +
                        " FROM PHANCONG pc " +
                        " JOIN LOP l ON pc.MaLop = l.MaLop " +
                        " JOIN SINHVIEN sv ON sv.MaLop = l.MaLop " +
                        " JOIN MONHOC mh ON pc.MaMonHoc = mh.MaMonHoc " +
                        " LEFT JOIN DIEM d ON d.MaSinhVien = sv.MaSinhVien AND d.MaMonHoc = mh.MaMonHoc " +
                        " WHERE pc.MaGiaoVien = @maGV AND pc.MaLop = @malop AND sv.MaSinhVien = @maSinhVien " +
                        " AND mh.MaMonHoc = @maMonHoc";

            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlDataAdapter adt = new SqlDataAdapter(query, sqlCon))
                {

                    adt.SelectCommand.Parameters.AddWithValue("@maSinhVien", sv.MaSinhVien);
                    adt.SelectCommand.Parameters.AddWithValue("@maGV", pc.MaGiaoVien);
                    adt.SelectCommand.Parameters.AddWithValue("@malop", sv.MaLop);
                    adt.SelectCommand.Parameters.AddWithValue("@maMonHoc", pc.MaMonHoc);

                    DataTable dt = new DataTable();
                    adt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        return dt;
                    }
                }
            }

            return null;
        }
        public DataTable loadMonHocvaDiem_DAO(SinhVien svien, Diem diem, GiaoVien gv, PhanCong pc)
        {
            //kiem tra sv va ma sv co trong bang diem chua
            bool kq = chk_sinhVieninDiem(diem);
            if (kq)
            {
                return taoDiemSinhVienMoi(svien, pc);
            }
            else
            {
                string query = "SELECT mh.MaMonHoc, mh.TenMonHoc, di.DiemChuyenCan, di.DiemTrungBinhKT, di.DiemThiLan1, di.DiemThiLan2, di.DiemTongKet " +
                               " FROM SINHVIEN sv join DIEM di on sv.MaSinhVien = di.MaSinhVien " +
                               " join MONHOC mh on di.MaMonHoc = mh.MaMonHoc " +
                               " WHERE sv.MaSinhVien = @maSinhVien";
                using (SqlConnection sqlCon = strConnection())
                {
                    sqlCon.Open();
                    using (SqlDataAdapter adt = new SqlDataAdapter(query, sqlCon))
                    {
                        adt.SelectCommand.Parameters.AddWithValue("@maSinhVien", svien.MaSinhVien);
                        DataTable dt = new DataTable();
                        adt.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            return dt;
                        }
                        return null;
                    }
                }
            }
        }

        public bool capNhatDiemSVien_DAO(Diem diem, PhanCong pc, SinhVien svien)
        {
            try
            {
                using (SqlConnection sqlCon = strConnection())
                {
                    sqlCon.Open();
                    if (chk_sinhVieninDiem(diem))
                    {
                        return themDiemSinhVien_DAO(diem, pc);
                    }
                    else
                    {
                        string query_update = "UPDATE DIEM " +
                                " SET DiemChuyenCan = @diemChuyenCan," +
                                " DiemTrungBinhKT = @diemTBKT," +
                                " DiemThiLan1 = @diemThiLan1," +
                                " DiemThiLan2 = @diemThiLan2," +
                                " DiemTongKet = @diemTongKet" +
                                " WHERE MaSinhVien = @maSV AND MaMonHoc = @maMonhoc";
                        using (SqlCommand cm = new SqlCommand(query_update, sqlCon))
                        {
                            cm.Parameters.AddWithValue("@diemChuyenCan", diem.DiemChuyenCan);
                            cm.Parameters.AddWithValue("@diemTBKT", diem.DiemTrungBinhKT);
                            cm.Parameters.AddWithValue("@diemThiLan1", diem.DiemThiLan1);
                            cm.Parameters.AddWithValue("@diemThiLan2", diem.DiemThiLan2.HasValue ? (object)diem.DiemThiLan2.Value : DBNull.Value);
                            cm.Parameters.AddWithValue("@diemTongKet", diem.DiemTongKet);
                            cm.Parameters.AddWithValue("@maMonHoc", diem.MaMonHoc);
                            cm.Parameters.AddWithValue("@maSV", diem.MaSinhVien);
                            DataTable dt = new DataTable();

                            int row = cm.ExecuteNonQuery();

                            if (row > 0)
                            {
                                sqlCon.Close();
                                return true;
                            }
                            sqlCon.Close();
                            return false;
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public DataTable timSVTheoMSSV_DAO(Users usr, SinhVien svcanTim)
        {
            //lay bang dgv_sinhvien
            DataTable svien = loadAllSV_DAO(usr);
            //bang ket qua tra ve
            DataTable result_SV = new DataTable();
            try
            {
                foreach (DataRow row in svien.Rows)
                {
                    foreach (DataColumn col in svien.Columns)
                    {
                        string mssv = row[col].ToString();
                        if (mssv == svcanTim.MaSinhVien)
                        {
                            result_SV = row.Table.Clone();
                            result_SV.ImportRow(row);
                            return result_SV;
                        }
                    }
                }
                return null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public DataTable load_tableReportGV_DAO(Users usr)
        {
            string query = "SELECT sv.MaSinhVien, us.HoTen, sv.NgaySinh, sv.GioiTinh,sv.Email, sv.CCCD, diem.DiemTongKet " +
                                " FROM SINHVIEN sv, USERS us, LOP lop, GIAOVIEN gv, DIEM diem " +
                                " WHERE us.Roles = N'Sinh viên' AND us.MaUser = sv.MaUser AND sv.MaLop = lop.MaLop AND " +
                                " lop.GiaoVienCN = gv.MaGiaoVien  AND sv.MaSinhVien = diem.MaSinhVien AND gv.MaUser = @maUser_cua_GV";

            using (SqlConnection sqlCon = strConnection())
            {
                sqlCon.Open();
                using (SqlDataAdapter adt = new SqlDataAdapter(query, sqlCon))
                {
                    adt.SelectCommand.Parameters.AddWithValue("@maUser_cua_GV", usr.MaUser);
                    DataTable dt = new DataTable();
                    adt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        return dt;
                    }
                    return null;
                }
            }
        }

    }
}