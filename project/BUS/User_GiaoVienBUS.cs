using System.Data;
using Project_QuanLiSinhVien_DoAn.DAO;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.BUS
{
    class User_GiaoVienBUS
    {
        User_GiaoVienDAO gv = new User_GiaoVienDAO();

        public DataTable loadDSSV(Users usr)
        {
            return gv.loadAllSV_DAO(usr);
        }

        public DataTable loadThongTinGiaoVien(Users usr)
        {
            return gv.loadThongTinGV_DAO(usr);
        }
        public DataTable loadMonHocvaDiem(SinhVien sv, Diem diem, GiaoVien gvien, PhanCong pc)
        {
            return gv.loadMonHocvaDiem_DAO(sv, diem, gvien, pc);
        }
        public DataTable loadMonHoccuaSV(PhanCong pc, SinhVien sv)
        {
            return gv.loadMonHoccuaSV_DAO(pc, sv);
        }
        public bool capNhatDiemSV(Diem diem, PhanCong pc, SinhVien svien)
        {
            return gv.capNhatDiemSVien_DAO(diem, pc, svien);
        }
        public DataTable timSVTheoMSSV(Users usr, SinhVien svienCanTim)
        {
            return gv.timSVTheoMSSV_DAO(usr, svienCanTim);
        }
        public DataTable load_tableReportGV(Users usr)
        {
            return gv.load_tableReportGV_DAO(usr);
        }
        public DataTable loadLopcuaGiaoVien(Users usr)
        {
            return gv.loadLopcuaGVien_DAO(usr);
        }
        public DataTable load_SinhVienTheoLop(Lop lop, Users us)
        {
            return gv.load_SinhVienTheoLop_DAO(lop, us);
        }
    }
}
