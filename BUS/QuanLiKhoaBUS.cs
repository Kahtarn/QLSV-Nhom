using System.Data;
using Project_QuanLiSinhVien_DoAn.DAO;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.BUS
{
    class QuanLiKhoaBUS
    {
        QuanLiKhoaDAO khoaDAO = new QuanLiKhoaDAO();
        public DataTable DSKhoa()
        {
            return khoaDAO.DSKhoa();
        }
        public bool ThemKhoa(Khoa k)
        {
            return khoaDAO.ThemKhoa(k);
        }
        public bool SuaKhoa(Khoa k)
        {
            return khoaDAO.SuaKhoa(k);
        }
        public bool XoaKhoa(Khoa k)
        {
            return khoaDAO.XoaKhoa(k);
        }
        public bool TimKhoa(Khoa k)
        {
            return khoaDAO.TimKhoa(k);
        }
    }
}
