using System;
using System.Data;
using System.Windows.Forms;
using Project_QuanLiSinhVien_DoAn.BUS;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.USControl
{
    public partial class uc_QLUsers : UserControl
    {
        QuanLiUsersBUS userBUS = new QuanLiUsersBUS();
        public uc_QLUsers()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            cb_VaiTro.DataSource = userBUS.VaiTro();
            cb_VaiTro.DisplayMember = "Roles";
            cb_VaiTro.ValueMember = "Roles";
            dgv_DanhSach.DataSource = userBUS.DSUser();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_HoTen.Text) || string.IsNullOrEmpty(txt_MatKhau.Text) || string.IsNullOrEmpty(txt_TenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Users u = new Users()
            {
                HoTen = txt_HoTen.Text.Trim(),
                TenDangNhap = txt_TenDangNhap.Text.Trim(),
                MatKhau = txt_MatKhau.Text,
                Roles = cb_VaiTro.SelectedValue.ToString()
            };
            if (userBUS.ThemUser(u))
            {
                MessageBox.Show("Thêm user thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            else
            {
                MessageBox.Show("Thêm user thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_HoTen.Text))
            {
                MessageBox.Show("Vui lòng chọn user hoặc nhập tên đăng nhập để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Users u = new Users()
            {
                HoTen = txt_HoTen.Text.Trim(),
                TenDangNhap = txt_TenDangNhap.Text.Trim(),
                MatKhau = txt_MatKhau.Text,
                Roles = cb_VaiTro.SelectedValue.ToString()
            };
            DialogResult rs = MessageBox.Show("Bạn muốn sửa user này!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (userBUS.SuaUser(u))
                {
                    MessageBox.Show("Sửa user thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                else
                {
                    MessageBox.Show("Sửa user thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DanhSach.Rows[e.RowIndex];

                txt_TenDangNhap.Text = row.Cells["TenDangNhap"].Value.ToString();
                txt_HoTen.Text = row.Cells["HoTen"].Value.ToString();
                txt_MatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                cb_VaiTro.SelectedValue = row.Cells["Roles"].Value.ToString();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_HoTen.Text))
            {
                MessageBox.Show("Vui lòng chọn user hoặc nhập tên đăng nhập để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Users u = new Users()
            {
                HoTen = txt_HoTen.Text.Trim(),
                TenDangNhap = txt_TenDangNhap.Text.Trim(),
                MatKhau = txt_MatKhau.Text,
                Roles = cb_VaiTro.SelectedValue.ToString()
            };
            DialogResult rs = MessageBox.Show("Bạn muốn xóa user này!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (userBUS.XoaUser(u))
                {
                    MessageBox.Show("Xóa user thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                else
                {
                    MessageBox.Show("Xóa user thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            loadData();
            txt_HoTen.Clear();
            txt_MatKhau.Clear();
            txt_TenDangNhap.Clear();
            txt_Tim.Clear();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Tim.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hoTenCanTim = txt_Tim.Text.Trim();
            DataTable dt = userBUS.TimUser(hoTenCanTim);

            if (dt.Rows.Count > 0)
            {
                dgv_DanhSach.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy user nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
