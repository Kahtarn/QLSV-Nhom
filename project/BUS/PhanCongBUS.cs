using System.Data;
using Project_QuanLiSinhVien_DoAn.DAO;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.BUS
{
    class PhanCongBUS
    {
        PhanCongDAO pcDAO = new PhanCongDAO();
        public DataTable DSPhanCong()
        {
            return pcDAO.DSPhanCong();
        }
        public DataTable DSLop()
        {
            return pcDAO.DSLop();
        }
        public DataTable DSMonHoc()
        {
            return pcDAO.DSMonHoc();
        }
        public DataTable DSGiaoVien()
        {
            return pcDAO.DSGiaoVien();
        }
        public bool ThemPhanCong(PhanCong pc)
        {
            return pcDAO.ThemPhanCong(pc);
        }
        public bool XoaPhanCong(PhanCong pc)
        {
            return pcDAO.XoaPhanCong(pc);
        }
        public DataTable TimPhanCong(Lop l)
        {
            return pcDAO.TimPhanCong(l);
        }
    }
}
