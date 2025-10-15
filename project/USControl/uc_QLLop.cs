using System;
using System.Data;
using System.Windows.Forms;
using Project_QuanLiSinhVien_DoAn.BUS;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.USControl
{
    public partial class uc_QLLop : UserControl
    {
        QuanLiLopBUS lopBUS = new QuanLiLopBUS();
        public uc_QLLop()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            dgv_DanhSach.DataSource = lopBUS.DSLop();
            cb_GVCN.DataSource = lopBUS.DSGiaoVien();
            cb_Khoa.DataSource = lopBUS.DSKhoa();

            cb_GVCN.DisplayMember = "HoTen";
            cb_GVCN.ValueMember = "MaGiaoVien";

            cb_Khoa.DisplayMember = "TenKhoa";
            cb_Khoa.ValueMember = "MaKhoa";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaLop.Text) || string.IsNullOrEmpty(txt_TenLop.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Lop l = new Lop()
            {
                MaLop = Convert.ToInt32(txt_MaLop.Text),
                TenLop = txt_TenLop.Text,
                MaKhoa = Convert.ToInt32(cb_Khoa.SelectedValue),
                GiaoVienCN = Convert.ToInt32(cb_GVCN.SelectedValue)
            };
            if (lopBUS.ThemLop(l))
            {
                MessageBox.Show("Thêm lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaLop.Text))
            {
                MessageBox.Show("Vui lòng nhập mã lớp hoặc chọn lớp để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Lop l = new Lop()
            {
                MaLop = Convert.ToInt32(txt_MaLop.Text),
                TenLop = txt_TenLop.Text,
                MaKhoa = Convert.ToInt32(cb_Khoa.SelectedValue),
                GiaoVienCN = Convert.ToInt32(cb_GVCN.SelectedValue)
            };
            DialogResult rs = MessageBox.Show("Bạn muốn sửa lớp này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (lopBUS.SuaLop(l))
                {
                    MessageBox.Show("Sửa lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                else
                {
                    MessageBox.Show("Sửa lớp thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DanhSach.Rows[e.RowIndex];

                txt_MaLop.Text = row.Cells["MaLop"].Value.ToString();
                txt_TenLop.Text = row.Cells["TenLop"].Value.ToString();
                cb_GVCN.SelectedValue = row.Cells["GiaoVienCN"].Value;
                cb_Khoa.SelectedValue = row.Cells["MaKhoa"].Value;
            }
        }

        private void txt_MaLop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaLop.Text))
            {
                MessageBox.Show("Vui lòng nhập mã lớp hoặc chọn lớp để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Lop l = new Lop()
            {
                MaLop = Convert.ToInt32(txt_MaLop.Text),
                TenLop = txt_TenLop.Text,
                MaKhoa = Convert.ToInt32(cb_Khoa.SelectedValue),
                GiaoVienCN = Convert.ToInt32(cb_GVCN.SelectedValue)
            };
            DialogResult rs = MessageBox.Show("Bạn muốn xóa lớp này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (lopBUS.XoaLop(l))
                {
                    MessageBox.Show("Xóa lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                else
                {
                    MessageBox.Show("Xóa lớp thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string tenLop = txt_TimKiem.Text.Trim();
            if (string.IsNullOrEmpty(tenLop))
            {
                MessageBox.Show("Vui lòng nhập họ tên cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable dt = lopBUS.TimLop(tenLop);

            if (dt.Rows.Count > 0)
            {
                dgv_DanhSach.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_DanhSach.DataSource = null;
            }
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            loadData();
            txt_TimKiem.Clear();
            txt_TenLop.Clear();
            txt_MaLop.Clear();
        }
    }
}
