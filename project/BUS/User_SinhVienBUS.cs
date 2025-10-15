using System.Data;
using Project_QuanLiSinhVien_DoAn.DAO;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.BUS
{
    class User_SinhVienBUS
    {
        User_SinhVienDAO SVDAO = new User_SinhVienDAO();
        public DataTable loadThongTinSinhVien(Users usr)
        {
            return SVDAO.layThongTinSinhVien_DAO(usr);
        }
        public DataTable loadDiemSV(Users usr)
        {
            return SVDAO.layDSDiem_DAO(usr);
        }
        public DataTable loadTableReportSV(Users usr)
        {
            return SVDAO.layTable_Report_SV_DAO(usr);
        }
    }
}
