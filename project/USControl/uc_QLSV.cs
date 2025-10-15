using System;
using System.Data;
using System.Windows.Forms;
using Project_QuanLiSinhVien_DoAn.BUS;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.USControl
{
    public partial class uc_QLSV : UserControl
    {
        QuanLiSinhVienBUS svBUS = new QuanLiSinhVienBUS();
        public uc_QLSV()
        {
            InitializeComponent();
            loadData();
        }
        private void txt_MaSinhVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void txt_CCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        public void loadData()
        {
            dgv_DanhSachSinhVien.DataSource = svBUS.DSSinhVien();
            cb_Lop.DataSource = svBUS.DSLop();
            cb_Lop.DisplayMember = "TenLop";
            cb_Lop.ValueMember = "MaLop";
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {

            SinhVien sv = new SinhVien()
            {
                MaSinhVien = txt_MaSinhVien.Text,
                HoTen = txt_HoTen.Text,
                NgaySinh = dtp_NgaySinh.Value,
                GioiTinh = rbtn_Nam.Checked ? "Nam" : "Nữ",
                Email = txt_Email.Text,
                CCCD = txt_CCCD.Text,
                MaLop = Convert.ToInt32(cb_Lop.SelectedValue)
            };
            Users u = new Users()
            {
                TenDangNhap = txt_MaSinhVien.Text,
                MatKhau = txt_CCCD.Text,
                Roles = "Sinh viên"
            };
            if (string.IsNullOrEmpty(txt_MaSinhVien.Text) || string.IsNullOrEmpty(txt_HoTen.Text) || string.IsNullOrEmpty(txt_Email.Text) || string.IsNullOrEmpty(txt_CCCD.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_CCCD.Text.Length != 12)
            {
                MessageBox.Show("CCCD phải có 12 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rbtn_Nam.Checked == false && rbtn_Nu.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (svBUS.ThemSinhVien(sv, u))
            {
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            else
            {
                MessageBox.Show("Thêm sinh viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgv_DanhSachSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int lastRowIndex = dgv_DanhSachSinhVien.Rows.Count - 1;
            if (e.RowIndex > lastRowIndex)
            {
                MessageBox.Show("Vui lòng chọn dòng có dữ liệu");
                return;
            }
            else if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DanhSachSinhVien.Rows[e.RowIndex];

                txt_MaSinhVien.Text = row.Cells["MaSinhVien"].Value.ToString();
                txt_HoTen.Text = row.Cells["HoTen"].Value.ToString();
                txt_Email.Text = row.Cells["Email"].Value.ToString();
                txt_CCCD.Text = row.Cells["CCCD"].Value.ToString();
                dtp_NgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                if (row.Cells["GioiTinh"].Value.ToString() == "Nam")
                {
                    rbtn_Nam.Checked = true;
                }
                else if (row.Cells["GioiTinh"].Value.ToString() == "Nữ")
                {
                    rbtn_Nu.Checked = true;
                }
                cb_Lop.SelectedValue = row.Cells["MaLop"].Value;
            }

        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaSinhVien.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SinhVien sv = new SinhVien()
            {
                MaSinhVien = txt_MaSinhVien.Text,
                HoTen = txt_HoTen.Text,
                NgaySinh = dtp_NgaySinh.Value,
                GioiTinh = rbtn_Nam.Checked ? "Nam" : "Nữ",
                Email = txt_Email.Text,
                CCCD = txt_CCCD.Text,
                MaLop = Convert.ToInt32(cb_Lop.SelectedValue)
            };
            Users u = new Users()
            {
                TenDangNhap = txt_MaSinhVien.Text,
                MatKhau = txt_CCCD.Text,
                Roles = "Sinh viên"
            };
            DialogResult rs = MessageBox.Show("Bạn muốn sửa sinh viên này!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (svBUS.SuaSinhVien(sv, u))
                {
                    MessageBox.Show("Sửa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaSinhVien.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SinhVien sv = new SinhVien()
            {
                MaSinhVien = txt_MaSinhVien.Text,
                HoTen = txt_HoTen.Text,
                NgaySinh = dtp_NgaySinh.Value,
                GioiTinh = rbtn_Nam.Checked ? "Nam" : "Nữ",
                Email = txt_Email.Text,
                CCCD = txt_CCCD.Text,
                MaLop = Convert.ToInt32(cb_Lop.SelectedValue)
            };
            Users u = new Users();

            u.TenDangNhap = txt_MaSinhVien.Text.Trim();

            DialogResult rs = MessageBox.Show("Bạn muốn xóa sinh viên này!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (svBUS.XoaSinhVien(sv, u))
                {
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string hoTen = txt_Timkiem.Text.Trim();
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = svBUS.TimSinhVien(hoTen);

            if (dt.Rows.Count > 0)
            {
                dgv_DanhSachSinhVien.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_DanhSachSinhVien.DataSource = null;
            }
        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            loadData();
            MessageBox.Show("Tải lại dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_MaSinhVien.Clear();
            txt_HoTen.Clear();
            txt_CCCD.Clear();
            txt_Email.Clear();
            txt_Timkiem.Clear();
            rbtn_Nam.Checked = false;
            rbtn_Nu.Checked = false;
        }

    }
}
