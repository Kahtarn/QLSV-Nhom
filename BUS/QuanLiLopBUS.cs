using System.Data;
using Project_QuanLiSinhVien_DoAn.DAO;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.BUS
{
    class QuanLiLopBUS
    {
        QuanLiLopDAO lopDAO = new QuanLiLopDAO();
        public DataTable DSLop()
        {
            return lopDAO.DSLop();
        }
        public DataTable DSKhoa()
        {
            return lopDAO.DSKhoa();
        }
        public DataTable DSGiaoVien()
        {
            return lopDAO.DSGiaoVien();
        }
        public bool ThemLop(Lop l)
        {
            return lopDAO.ThemLop(l);
        }
        public bool SuaLop(Lop l)
        {
            return lopDAO.SuaLop(l);
        }
        public bool XoaLop(Lop l)
        {
            return lopDAO.XoaLop(l);
        }
        public DataTable TimLop(string tenLop)
        {
            return lopDAO.TimLop(tenLop);
        }
    }
}
