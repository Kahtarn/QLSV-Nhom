using System;
using System.Windows.Forms;
using Project_QuanLiSinhVien_DoAn.BUS;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.USControl
{
    public partial class uc_QLGV : UserControl
    {
        QuanLiGiaoVienBUS gvBUS = new QuanLiGiaoVienBUS();
        public uc_QLGV()
        {
            InitializeComponent();
            loadData();
        }
        private void txt_MaGiaoVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_CCCD_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        public void loadData()
        {
            dgv_DanhSach.DataSource = gvBUS.DSGiaoVien();
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaGiaoVien.Text) || string.IsNullOrEmpty(txt_HoTen.Text) || string.IsNullOrEmpty(txt_Email.Text) || string.IsNullOrEmpty(txt_CCCD.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!rbtn_Nam.Checked == false && !rbtn_Nu.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_CCCD.Text.Length != 12)
            {
                MessageBox.Show("CCCD phải có 12 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GiaoVien gv = new GiaoVien()
            {
                MaGiaoVien = Convert.ToInt32(txt_MaGiaoVien.Text),
                HoTen = txt_HoTen.Text.Trim(),
                NgaySinh = Convert.ToDateTime(dtp_NgaySinh.Value),
                GioiTinh = rbtn_Nam.Checked ? "Nam" : "Nữ",
                CCCD = txt_CCCD.Text.Trim(),
                Email = txt_Email.Text.Trim(),
                NamBatDauGiangDay = Convert.ToDateTime(dtp_NamGD.Value)
            };
            Users u = new Users()
            {
                TenDangNhap = txt_MaGiaoVien.Text,
                MatKhau = txt_CCCD.Text,
                Roles = "Giáo viên"
            };
            if (gvBUS.ThemGiaoVien(gv, u))
            {
                MessageBox.Show("Thêm giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            else
            {
                MessageBox.Show("Thêm giáo viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DanhSach.Rows[e.RowIndex];

                txt_MaGiaoVien.Text = row.Cells["MaGiaoVien"].Value.ToString();
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
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaGiaoVien.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GiaoVien gv = new GiaoVien()
            {
                MaGiaoVien = Convert.ToInt32(txt_MaGiaoVien.Text),
                HoTen = txt_HoTen.Text.Trim(),
                NgaySinh = Convert.ToDateTime(dtp_NgaySinh.Value),
                GioiTinh = rbtn_Nam.Checked ? "Nam" : "Nữ",
                CCCD = txt_CCCD.Text.Trim(),
                Email = txt_Email.Text.Trim(),
                NamBatDauGiangDay = Convert.ToDateTime(dtp_NamGD.Value)
            };
            Users u = new Users()
            {
                TenDangNhap = txt_MaGiaoVien.Text,
                MatKhau = txt_CCCD.Text,
                Roles = "Giáo viên"
            };
            DialogResult rs = MessageBox.Show("Bạn muốn sửa sinh viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (gvBUS.SuaGiaoVien(gv, u))
                {
                    MessageBox.Show("Sửa giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaGiaoVien.Text))
            {
                MessageBox.Show("Vui lòng chọn giáo viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GiaoVien gv = new GiaoVien()
            {
                MaGiaoVien = Convert.ToInt32(txt_MaGiaoVien.Text),
                HoTen = txt_HoTen.Text.Trim(),
                NgaySinh = Convert.ToDateTime(dtp_NgaySinh.Value),
                GioiTinh = rbtn_Nam.Checked ? "Nam" : "Nữ",
                CCCD = txt_CCCD.Text.Trim(),
                Email = txt_Email.Text.Trim(),
                NamBatDauGiangDay = Convert.ToDateTime(dtp_NamGD.Value)
            };
            Users u = new Users()
            {
                TenDangNhap = txt_MaGiaoVien.Text,
                MatKhau = txt_CCCD.Text,
                Roles = "Giáo viên"
            };
            DialogResult rs = MessageBox.Show("Bạn muốn xóa giáo viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (gvBUS.XoaGiaoVien(gv, u))
                {
                    MessageBox.Show("Xóa giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                else
                {
                    MessageBox.Show("Xóa giáo viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Tim.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên cần tìm!", "Thông báo");
                return;
            }

            string hoTen = txt_Tim.Text.Trim();
            dgv_DanhSach.DataSource = gvBUS.TimGiaoVien(hoTen);
        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            loadData();
            txt_Tim.Clear();
            txt_MaGiaoVien.Clear();
            txt_HoTen.Clear();
            txt_Email.Clear();
            txt_CCCD.Clear();
            txt_MaGiaoVien.Clear();
            rbtn_Nam.Checked = false;
            rbtn_Nu.Checked = false;
        }
    }
}
