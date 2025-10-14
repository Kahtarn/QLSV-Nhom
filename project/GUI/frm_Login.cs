using System;
using System.Windows.Forms;
using Project_QuanLiSinhVien_DoAn.BUS;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.GUI
{
    public partial class frm_Login : Form
    {
        KiemTraDangNhapBUS ktBUS = new KiemTraDangNhapBUS();
        public frm_Login()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            cb_VaiTro.DataSource = ktBUS.VaiTro();
            cb_VaiTro.DisplayMember = "Roles";
            cb_VaiTro.ValueMember = "Roles";
        }
        private void frm_Login_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string user_SelectRole = cb_VaiTro.SelectedValue.ToString();
            Users u = new Users()
            {
                TenDangNhap = txt_TenDangNhap.Text.Trim(),
                MatKhau = txt_MatKhau.Text.Trim(),
                Roles = user_SelectRole
            };

            var kt = ktBUS.KiemTraDangNhap(u);


            if (string.IsNullOrEmpty(txt_TenDangNhap.Text) || string.IsNullOrEmpty(txt_MatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //xet ket qua : tai khoan mat khau va role
            if (kt.kq)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                int maUser = 0;

                if (user_SelectRole == "Admin")
                {
                    frm_Admin frm = new frm_Admin();
                    frm.Show();
                    this.Hide();
                }
                if (user_SelectRole == "Giáo viên")
                {
                    maUser = kt.maUser;
                    //xac dinh user cu the bang cach truyen ma user vao form

                    frm_GiaoVien frm = new frm_GiaoVien(maUser);
                    frm.Show();
                    this.Hide();
                }
                if (user_SelectRole == "Sinh viên")
                {
                    maUser = kt.maUser;
                    //xac dinh user cu the bang cach truyen ma user vao form
                    frm_SinhVien frm = new frm_SinhVien(maUser);
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản, mật khẩu hoặc vai trò!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
