using System;
using System.Windows.Forms;
using Project_QuanLiSinhVien_DoAn.BUS;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.USControl
{
    public partial class uc_QLMonHoc : UserControl
    {
        QuanLiMonHocBUS mhBUS = new QuanLiMonHocBUS();
        public uc_QLMonHoc()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            dgv_DanhSach.DataSource = mhBUS.DSMonHoc();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaMonHoc.Text) || string.IsNullOrEmpty(txt_TenMonHoc.Text) || string.IsNullOrEmpty(txt_SoTinChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MonHoc mh = new MonHoc()
            {
                MaMonHoc = Convert.ToInt32(txt_MaMonHoc.Text),
                TenMonHoc = txt_TenMonHoc.Text,
                SoTinChi = Convert.ToInt32(txt_SoTinChi.Text)
            };
            if (mhBUS.ThemMonHoc(mh))
            {
                MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            else
            {
                MessageBox.Show("Thêm môn học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaMonHoc.Text))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập mã môn học để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MonHoc mh = new MonHoc()
            {
                MaMonHoc = Convert.ToInt32(txt_MaMonHoc.Text),
                TenMonHoc = txt_TenMonHoc.Text,
                SoTinChi = Convert.ToInt32(txt_SoTinChi.Text)
            };
            DialogResult rs = MessageBox.Show("Bạn muốn sửa môn học này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (mhBUS.SuaMonHoc(mh))
                {
                    MessageBox.Show("Sửa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                else
                {
                    MessageBox.Show("Sửa môn học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DanhSach.Rows[e.RowIndex];
                txt_MaMonHoc.Text = row.Cells["MaMonHoc"].Value.ToString();
                txt_TenMonHoc.Text = row.Cells["TenMonHoc"].Value.ToString();
                txt_SoTinChi.Text = row.Cells["SoTinChi"].Value.ToString();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaMonHoc.Text))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập mã môn học để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MonHoc mh = new MonHoc()
            {
                MaMonHoc = Convert.ToInt32(txt_MaMonHoc.Text),
                TenMonHoc = txt_TenMonHoc.Text,
                SoTinChi = Convert.ToInt32(txt_SoTinChi.Text)
            };
            DialogResult rs = MessageBox.Show("Bạn muốn xóa môn học này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (mhBUS.XoaMonHoc(mh))
                {
                    MessageBox.Show("Xóa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                else
                {
                    MessageBox.Show("Xóa môn học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            loadData();
            txt_MaMonHoc.Clear();
            txt_TenMonHoc.Clear();
            txt_SoTinChi.Clear();
        }

        private void txt_MaMonHoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_SoTinChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
