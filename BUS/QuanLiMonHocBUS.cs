using System.Data;
using Project_QuanLiSinhVien_DoAn.DAO;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.BUS
{
    class QuanLiMonHocBUS
    {
        QuanLiMonHocDAO mhDAO = new QuanLiMonHocDAO();
        public DataTable DSMonHoc()
        {
            return mhDAO.DSMonHoc();
        }
        public bool ThemMonHoc(MonHoc mh)
        {
            return mhDAO.ThemMonHoc(mh);
        }
        public bool SuaMonHoc(MonHoc mh)
        {
            return mhDAO.SuaMonHoc(mh);
        }
        public bool XoaMonHoc(MonHoc mh)
        {
            return mhDAO.XoaMonHoc(mh);
        }
    }
}
