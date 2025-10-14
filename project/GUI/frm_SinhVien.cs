using System;
using System.Data;
using System.Windows.Forms;
using Project_QuanLiSinhVien_DoAn.BUS;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.GUI
{
    public partial class frm_SinhVien : Form
    {
        private int receive_maUser;
        public frm_SinhVien(int maUser)
        {
            //nhan ma user tu form login

            InitializeComponent();
            receive_maUser = maUser;
        }

        private void frm_SinhVien_Load(object sender, EventArgs e)
        {
            //Load thong tin sinh vien
            User_SinhVienBUS sv_BUS = new User_SinhVienBUS();
            DataTable dt_thongTin = new DataTable();

            Users usr = new Users();
            usr.MaUser = receive_maUser;

            dt_thongTin = sv_BUS.loadThongTinSinhVien(usr);
            if (dt_thongTin.Rows.Count > 0)
            {
                foreach (DataRow row in dt_thongTin.Rows)
                {
                    lbl_MSSV_value.Text = row["MaSinhVien"].ToString();
                    lbl_hoten_value.Text = row["HoTen"].ToString();
                    lbl_lop_value.Text = row["TenLop"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Đã có lỗi khi lấy dữ liệu");
                return;
            }
            //Load diem sinh vien

            DataTable dt_diem = new DataTable();

            dt_diem = sv_BUS.loadDiemSV(usr);

            if (dt_diem.Rows.Count > 0)
            {
                dgv_sinhvien.DataSource = dt_diem;

            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi lấy dữ liệu");
                return;

            }

        }
   
    }
}
