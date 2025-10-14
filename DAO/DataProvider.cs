using System.Data.SqlClient;

namespace Project_QuanLiSinhVien_DoAn.DAO
{
    class DataProvider
    {
        public SqlConnection strConnection()
        {
            string query = "Data Source=DESKTOP-GB854KQ\\SQLEXPRESS;Initial Catalog=QUANLISINHVIEN_DB;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(query);
            return sqlCon;
        }
    }
}
