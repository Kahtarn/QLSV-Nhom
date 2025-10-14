using System.Data;
using Project_QuanLiSinhVien_DoAn.DAO;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.BUS
{
    class KiemTraDangNhapBUS
    {
        KiemTraDangNhapDAO dtDAO = new KiemTraDangNhapDAO();
        public DataTable VaiTro()
        {
            return dtDAO.VaiTro();
        }
        public (bool kq, int maUser) KiemTraDangNhap(Users u)
        {
            return dtDAO.KiemTraDangNhap(u);
        }
    }
}
