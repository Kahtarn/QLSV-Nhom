using System.Data;
using Project_QuanLiSinhVien_DoAn.DAO;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.BUS
{
    class QuanLiGiaoVienBUS
    {
        QuanLiGiaoVienDAO gvDAO = new QuanLiGiaoVienDAO();
        public DataTable DSGiaoVien()
        {
            return gvDAO.DSGiaoVien();
        }
        public bool ThemGiaoVien(GiaoVien gv, Users u)
        {
            return gvDAO.ThemGiaoVien(gv, u);
        }
        public bool SuaGiaoVien(GiaoVien gv, Users u)
        {
            return gvDAO.SuaGiaoVien(gv, u);
        }
        public bool XoaGiaoVien(GiaoVien gv, Users u)
        {
            return gvDAO.XoaGiaoVien(gv, u);
        }
        public DataTable TimGiaoVien(string hoTen)
        {
            return gvDAO.TimDanhSachGiaoVienTheoHoTen(hoTen);
        }
    }
}
