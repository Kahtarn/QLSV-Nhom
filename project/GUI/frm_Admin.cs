using System;
using System.Windows.Forms;
using Project_QuanLiSinhVien_DoAn.USControl;

namespace Project_QuanLiSinhVien_DoAn.GUI
{
    public partial class frm_Admin : Form
    {
        public frm_Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            uc_QLSV ucQLSV = new uc_QLSV();
            ucQLSV.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucQLSV);
        }

        private void btn_QuanLiLop_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            uc_QLGV ucQLGV = new uc_QLGV();
            ucQLGV.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucQLGV);
        }

        private void btn_QuanLiLop_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            uc_QLLop ucQLLop = new uc_QLLop();
            ucQLLop.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucQLLop);
        }

        private void btn_QuanLiKhoa_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            uc_QLKhoa ucQLKhoa = new uc_QLKhoa();
            ucQLKhoa.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucQLKhoa);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            uc_QLUsers ucQLUSers = new uc_QLUsers();
            ucQLUSers.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucQLUSers);
        }

        private void btn_QuanLiMonHoc_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            uc_QLMonHoc ucQLMH = new uc_QLMonHoc();
            ucQLMH.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucQLMH);
        }


        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            uc_PhanCong ucPhanCong = new uc_PhanCong();
            ucPhanCong.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucPhanCong);
        }
    }
}
