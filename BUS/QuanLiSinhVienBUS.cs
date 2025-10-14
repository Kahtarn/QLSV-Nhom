using System.Data;
using Project_QuanLiSinhVien_DoAn.DAO;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.BUS
{
    class QuanLiSinhVienBUS
    {
        QuanLiSinhVienDAO svDAO = new QuanLiSinhVienDAO();
        public DataTable DSLop()
        {
            return svDAO.DSLop();
        }
        public DataTable DSSinhVien()
        {
            return svDAO.DSSinhVien();
        }
        public DataTable LayDSSVTheoLop(int maLop)
        {
            return svDAO.LayDSSVTheoLop(maLop);
        }
        public bool ThemSinhVien(SinhVien sv, Users u)
        {
            return svDAO.ThemSinhVien(sv, u);
        }
        public bool SuaSinhVien(SinhVien sv, Users u)
        {
            return svDAO.SuaSinhVien(sv, u);
        }
        public bool XoaSinhVien(SinhVien sv, Users u)
        {
            return svDAO.XoaSinhVien(sv, u);
        }
        public DataTable TimSinhVien(string sv)
        {
            return svDAO.TimDanhSachSinhVienTheoHoTen(sv);
        }

    }
}
