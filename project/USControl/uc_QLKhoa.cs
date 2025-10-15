using System;
using System.Data;
using System.Windows.Forms;
using Project_QuanLiSinhVien_DoAn.BUS;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.USControl
{
    public partial class uc_QLKhoa : UserControl
    {
        QuanLiKhoaBUS khoaBUS = new QuanLiKhoaBUS();
        public uc_QLKhoa()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            dgv_DanhSach.DataSource = khoaBUS.DSKhoa();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaKhoa.Text) || string.IsNullOrEmpty(txt_TenKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Khoa k = new Khoa()
            {
                MaKhoa = Convert.ToInt32(txt_MaKhoa.Text.Trim()),
                TenKhoa = txt_TenKhoa.Text.Trim()
            };
            if (khoaBUS.ThemKhoa(k))
            {
                MessageBox.Show("Thêm khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            else
            {
                MessageBox.Show("Thêm khoa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_MaKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DanhSach.Rows[e.RowIndex];

                txt_MaKhoa.Text = row.Cells["MaKhoa"].Value.ToString();
                txt_TenKhoa.Text = row.Cells["TenKhoa"].Value.ToString();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaKhoa.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Khoa k = new Khoa()
            {
                MaKhoa = Convert.ToInt32(txt_MaKhoa.Text.Trim()),
                TenKhoa = txt_TenKhoa.Text.Trim()
            };
            DialogResult rs = MessageBox.Show("Bạn muốn xóa khoa này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (khoaBUS.XoaKhoa(k))
                {
                    MessageBox.Show("Xóa khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaKhoa.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Khoa k = new Khoa()
            {
                MaKhoa = Convert.ToInt32(txt_MaKhoa.Text.Trim()),
                TenKhoa = txt_TenKhoa.Text.Trim()
            };
            DialogResult rs = MessageBox.Show("Bạn muốn sửa khoa này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (khoaBUS.SuaKhoa(k))
                {
                    MessageBox.Show("Sửa khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
            }
        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            loadData();
            txt_TenKhoa.Clear();
            txt_MaKhoa.Clear();
            txt_Tim.Clear();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Tim.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khoa để tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Khoa k = new Khoa()
            {
                TenKhoa = txt_Tim.Text.Trim()
            };
            if (khoaBUS.TimKhoa(k))
            {
                DataTable kqTim = new DataTable();
                kqTim.Columns.Add("MaKhoa");
                kqTim.Columns.Add("TenKhoa");
                kqTim.Rows.Add(k.MaKhoa, k.TenKhoa);
                dgv_DanhSach.DataSource = kqTim;
                MessageBox.Show("Đã tìm thấy khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
