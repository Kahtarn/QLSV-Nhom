using System.Data;
using Project_QuanLiSinhVien_DoAn.DAO;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.BUS
{
    class QuanLiUsersBUS
    {
        QuanLiUsersDAO userDAO = new QuanLiUsersDAO();
        public DataTable VaiTro()
        {
            return userDAO.VaiTro();
        }
        public DataTable DSUser()
        {
            return userDAO.DSUser();
        }
        public bool ThemUser(Users u)
        {
            return userDAO.ThemUser(u);
        }
        public bool SuaUser(Users u)
        {
            return userDAO.SuaUser(u);
        }
        public bool XoaUser(Users u)
        {
            return userDAO.XoaUser(u);
        }
        public DataTable TimUser(string hoTen)
        {
            return userDAO.TimUser(hoTen);
        }
    }
}
