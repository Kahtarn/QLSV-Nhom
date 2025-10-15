using System;
using System.Data;
using System.Windows.Forms;
using Project_QuanLiSinhVien_DoAn.BUS;
using Project_QuanLiSinhVien_DoAn.DTO;
namespace Project_QuanLiSinhVien_DoAn.USControl
{
    public partial class uc_PhanCong : UserControl
    {
        PhanCongBUS pcBUS = new PhanCongBUS();
        public uc_PhanCong()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            dgv_DanhSach.DataSource = pcBUS.DSPhanCong();
            cb_GiaoVien.DataSource = pcBUS.DSGiaoVien();
            cb_Lop.DataSource = pcBUS.DSLop();
            cb_MonHoc.DataSource = pcBUS.DSMonHoc();
            cb_Tim.DataSource = pcBUS.DSLop();

            cb_GiaoVien.DisplayMember = "HoTen";
            cb_GiaoVien.ValueMember = "MaGiaoVien";

            cb_Lop.DisplayMember = "TenLop";
            cb_Lop.ValueMember = "MaLop";

            cb_MonHoc.DisplayMember = "TenMonHoc";
            cb_MonHoc.ValueMember = "MaMonHoc";

            cb_Tim.DisplayMember = "TenLop";
            cb_Tim.ValueMember = "MaLop";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            PhanCong pc = new PhanCong()
            {
                MaGiaoVien = Convert.ToInt32(cb_GiaoVien.SelectedValue),
                MaLop = Convert.ToInt32(cb_Lop.SelectedValue),
                MaMonHoc = Convert.ToInt32(cb_MonHoc.SelectedValue)
            };
            if (pcBUS.ThemPhanCong(pc))
            {
                MessageBox.Show("Phân công giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            else
            {
                MessageBox.Show("Phân công thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            Lop l = new Lop()
            {
                MaLop = Convert.ToInt32(cb_Lop.SelectedValue)
            };
            DataTable dt = pcBUS.TimPhanCong(l);
            if (dt.Rows.Count > 0)
            {
                dgv_DanhSach.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy phân công cho lớp này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
