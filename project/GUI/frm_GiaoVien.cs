using System;
using System.Data;
using System.Windows.Forms;
using Project_QuanLiSinhVien_DoAn.BUS;
using Project_QuanLiSinhVien_DoAn.DTO;

namespace Project_QuanLiSinhVien_DoAn.GUI
{
    public partial class frm_GiaoVien : Form
    {
        private int receive_maUser;
        public frm_GiaoVien(int maUser)
        {
            //nhan ma user tu form login
            receive_maUser = maUser;
            InitializeComponent();
        }

        private void frm_giaoVien_Load(object sender, EventArgs e)
        {
            User_GiaoVienBUS gv_BUS = new User_GiaoVienBUS();
            Users us = new Users();

            us.MaUser = receive_maUser;

            //load thong tin sinh vien thuoc lop cua gvien vao datagridview Sinh Vien
            dgv_sinhVien.DataSource = gv_BUS.loadDSSV(us);
            dgv_sinhVien.Columns["MaLop"].Visible = false;
            dgv_sinhVien.ClearSelection();

            //load thong tin giao vien
            DataTable gv = gv_BUS.loadThongTinGiaoVien(us);
            string tenGV = "";
            string tenLop = "";
            int maGV = 0;
            foreach (DataRow row in gv.Rows)
            {
                tenGV = row["HoTen"].ToString();
                tenLop = row["TenLop"].ToString();
                maGV = int.Parse(row["MaGiaoVien"].ToString());
                break;
            }

            if (tenLop == "")
            {
                tenLop = "Hiện tại không chủ nhiệm lớp nào";
            }

            //Hien thi thong tin cua giao vien
            this.Text = $"Tên giáo viên: {tenGV} \t Chủ nhiệm: {tenLop}";

            //load cbb lop cua giao vien day
            DataTable lop = gv_BUS.loadLopcuaGiaoVien(us);

            DataRow Newrow = lop.NewRow();

            Newrow["MaLop"] = 0;
            Newrow["TenLop"] = "Tất cả";
            lop.Rows.InsertAt(Newrow, 0);

            cbb_lopGVDay.DataSource = lop;
            cbb_lopGVDay.DisplayMember = "TenLop";
            cbb_lopGVDay.ValueMember = "MaLop";



        }

        private void btn_chonMon_Click(object sender, EventArgs e)
        {
            int maMonHoc = 0;
            try
            {
                if (cbb_monHoc.DataSource == null)
                {
                    MessageBox.Show("Lỗi khi chọn môn");
                    return;
                }
                else
                {
                    maMonHoc = int.Parse(cbb_monHoc.SelectedValue.ToString());
                }

                User_GiaoVienBUS gv_BUS = new User_GiaoVienBUS();
                SinhVien sv = new SinhVien();
                Diem diem = new Diem();
                Users us = new Users();
                PhanCong pc = new PhanCong();
                GiaoVien gv = new GiaoVien();

                //thong tin sinh vien
                DataGridViewRow selectedRow = dgv_sinhVien.SelectedRows[0];
                string mssv = selectedRow.Cells["MaSinhVien"].Value.ToString();
                string tenSV = selectedRow.Cells["HoTen"].Value.ToString();
                int maLop = int.Parse(selectedRow.Cells["MaLop"].Value.ToString());

                //magv
                int maGV = 0;
                us.MaUser = receive_maUser;
                DataTable TTgv = gv_BUS.loadThongTinGiaoVien(us);
                foreach (DataRow row in TTgv.Rows)
                {
                    maGV = int.Parse(row["MaGiaoVien"].ToString());
                    break;
                }

                // truyen MSSV
                sv.MaSinhVien = mssv;
                diem.MaSinhVien = mssv;

                //truyen ma giao vien
                gv.MaGiaoVien = maGV;
                pc.MaGiaoVien = maGV;
                //truyen ma lop
                sv.MaLop = maLop;
                pc.MaLop = maLop;

                //ma mon hoc
                pc.MaMonHoc = maMonHoc;

                DataTable monHocvaDiem = gv_BUS.loadMonHocvaDiem(sv, diem, gv, pc);

                //load danh sach mon hoc cua sinh vien thuoc lop, mac dinh la mon dau tien
                if (monHocvaDiem.Rows.Count > 0)
                {

                    //dien vao textbox dong dau tien
                    foreach (DataRow row in monHocvaDiem.Rows)
                    {
                        int maMonrow = int.Parse(row["MaMonHoc"].ToString());
                        if (maMonHoc == maMonrow)
                        {
                            txt_chuyenCan.Text = row["DiemChuyenCan"].ToString();
                            txt_TBKT.Text = row["DiemTrungBinhKT"].ToString();
                            txt_thiLan1.Text = row["DiemThiLan1"].ToString();
                            txt_thiLan2.Text = row["DiemThiLan2"].ToString();
                            txt_tongKet.Text = row["DiemTongKet"].ToString();
                            return;
                        }

                    }
                    MessageBox.Show("Đã có lỗi khi load điểm");
                    return;
                }
                else
                {
                    MessageBox.Show("Đã có lỗi khi load điểm");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgv_sinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            User_GiaoVienBUS gv_BUS = new User_GiaoVienBUS();
            SinhVien sv = new SinhVien();
            Diem diem = new Diem();
            Users us = new Users();
            PhanCong pc = new PhanCong();
            GiaoVien gv = new GiaoVien();

            //thong tin sinh vien
            DataGridViewRow selectedRow = dgv_sinhVien.SelectedRows[0];
            string mssv = selectedRow.Cells["MaSinhVien"].Value.ToString();
            string tenSV = selectedRow.Cells["HoTen"].Value.ToString();
            int maLop = int.Parse(selectedRow.Cells["MaLop"].Value.ToString());

            //magv
            int maGV = 0;
            us.MaUser = receive_maUser;
            DataTable TTgv = gv_BUS.loadThongTinGiaoVien(us);
            foreach (DataRow row in TTgv.Rows)
            {
                maGV = int.Parse(row["MaGiaoVien"].ToString());
            }

            // truyen MSSV
            sv.MaSinhVien = mssv;
            diem.MaSinhVien = mssv;

            //truyen ma giao vien
            gv.MaGiaoVien = maGV;
            pc.MaGiaoVien = maGV;

            //truyen ma lop
            sv.MaLop = maLop;
            pc.MaLop = maLop;

            //Lay ten sv
            lbl_tenSV_TXT.Text = selectedRow.Cells["HoTen"].Value.ToString();

            // ds mon hoc combobox
            DataTable dsMonHoc = gv_BUS.loadMonHoccuaSV(pc, sv);
            if (dsMonHoc.Rows.Count > 0)
            {
                cbb_monHoc.DataSource = dsMonHoc;
                cbb_monHoc.DisplayMember = "TenMonHoc";
                cbb_monHoc.ValueMember = "MaMonHoc";
            }
            //lay du lieu nhap diem 
            DataTable monHocvaDiem = gv_BUS.loadMonHocvaDiem(sv, diem, gv, pc);

            //load danh sach mon hoc cua sinh vien thuoc lop
            btn_chonMon_Click(sender, e);

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            User_GiaoVienBUS gv_BUS = new User_GiaoVienBUS();
            SinhVien sv = new SinhVien();
            Diem diem = new Diem();
            PhanCong pc = new PhanCong();
            Users us = new Users();

            try
            {
                //kiem tra input 
                if (dgv_sinhVien.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một sinh viên bên dưới để cập nhật điểm !"
                                    , "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    int maMonHoc = int.Parse(cbb_monHoc.SelectedValue.ToString());
                    float diemChuyenCan = float.Parse(txt_chuyenCan.Text.ToString()),
                          diemTBKTra = float.Parse(txt_TBKT.Text.ToString()),
                          diemThilan1 = float.Parse(txt_thiLan1.Text.ToString()),
                          diemThiLan2 = float.Parse(txt_thiLan2.Text.ToString()),
                          diemTongKet = float.Parse(txt_tongKet.Text.ToString());

                    //lay ttin tu dgv_sinhVien
                    DataGridViewRow selectedRow = dgv_sinhVien.SelectedRows[0];
                    string mssv = selectedRow.Cells["MaSinhVien"].Value.ToString();
                    int maLop = int.Parse(selectedRow.Cells["MaLop"].Value.ToString());

                    // ma gv 
                    int maGV = 0;
                    us.MaUser = receive_maUser;
                    DataTable TTgv = gv_BUS.loadThongTinGiaoVien(us);
                    foreach (DataRow row in TTgv.Rows)
                    {
                        maGV = int.Parse(row["MaGiaoVien"].ToString());
                        break;
                    }

                    //kiem tra input
                    if (diemChuyenCan < 0 || diemChuyenCan > 10)
                    {
                        MessageBox.Show("Điểm chuyên cần chỉ trong khoản 0 - 10 ");
                        return;
                    }
                    else if (string.IsNullOrEmpty(txt_chuyenCan.Text))
                    {
                        diem.DiemChuyenCan = 0;
                    }
                    else
                    {
                        diem.DiemChuyenCan = diemChuyenCan;
                    }

                    //
                    if (diemTBKTra < 0 || diemTBKTra > 10)
                    {
                        MessageBox.Show("Điểm trung bình kiểm tra chỉ trong khoản 0 - 10 ");
                        return;
                    }
                    else if (string.IsNullOrEmpty(txt_TBKT.Text))
                    {
                        diem.DiemTrungBinhKT = 0;
                    }
                    else
                    {
                        diem.DiemTrungBinhKT = diemTBKTra;
                    }

                    //
                    if (diemThilan1 < 0 || diemThilan1 > 10)
                    {
                        MessageBox.Show("Điểm thi lần 1 chỉ trong khoản 0 - 10 ");
                        return;
                    }
                    else if (string.IsNullOrEmpty(txt_thiLan1.Text))
                    {
                        diem.DiemThiLan1 = 0;
                    }
                    else
                    {
                        diem.DiemThiLan1 = diemThilan1;
                    }

                    //
                    if (diemTongKet < 0 || diemTongKet > 10)
                    {
                        MessageBox.Show("Điểm tổng kết chỉ trong khoản 0 - 10 ");
                        return;
                    }
                    else if (string.IsNullOrEmpty(txt_tongKet.Text))
                    {
                        diem.DiemTongKet = 0;
                    }
                    else
                    {
                        diem.DiemTongKet = diemTongKet;
                    }

                    //
                    if (diemTongKet > 5)
                    {
                        txt_thiLan2.Enabled = false;
                    }
                    else
                    {
                        if (diemThiLan2 < 0 || diemThiLan2 > 10)
                        {
                            MessageBox.Show("Điểm thi lần 2 chỉ trong khoản 0 - 10 ");
                            return;
                        }
                        else if (string.IsNullOrEmpty(txt_thiLan2.Text))
                        {
                            diem.DiemThiLan2 = 0;
                        }
                        else
                        {
                            diem.DiemTongKet = diemTongKet;
                        }
                    }

                    //cap nhat theo tung mon
                    diem.MaSinhVien = mssv;
                    diem.MaMonHoc = maMonHoc;
                    sv.MaSinhVien = mssv;
                    pc.MaGiaoVien = maGV;
                    pc.MaLop = maLop;
                    pc.MaMonHoc = maMonHoc;

                    bool result = gv_BUS.capNhatDiemSV(diem, pc, sv);

                    if (result)
                    {
                        MessageBox.Show("Cập nhật thành công.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại.");
                        return;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            User_GiaoVienBUS gv_BUS = new User_GiaoVienBUS();

            SinhVien sv = new SinhVien();
            Users us = new Users();
            us.MaUser = receive_maUser;

            //load thong tin sinh vien thuoc lop cua gvien
            dgv_sinhVien.DataSource = gv_BUS.loadDSSV(us);
            dgv_sinhVien.ClearSelection();

            //load cbb lop cua giao vien day
            DataTable lop = gv_BUS.loadLopcuaGiaoVien(us);

            DataRow Newrow = lop.NewRow();

            Newrow["MaLop"] = 0;
            Newrow["TenLop"] = "Tất cả";
            lop.Rows.InsertAt(Newrow, 0);

            cbb_lopGVDay.DataSource = lop;
            cbb_lopGVDay.DisplayMember = "TenLop";
            cbb_lopGVDay.ValueMember = "MaLop";

            //
            txt_chuyenCan.Clear();
            txt_TBKT.Clear();
            txt_thiLan1.Clear();
            txt_thiLan2.Clear();
            txt_timMSSV.Clear();
            txt_tongKet.Clear();

            txt_timMSSV.Clear();

            lbl_tenSV_TXT.Text = string.Empty;
            cbb_monHoc.DataSource = null;
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            User_GiaoVienBUS gv = new User_GiaoVienBUS();

            Users usr = new Users();
            SinhVien svien = new SinhVien();

            string mssv_input = txt_timMSSV.Text;

            if (string.IsNullOrEmpty(mssv_input))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên để tìm");
                return;
            }

            usr.MaUser = receive_maUser;
            svien.MaSinhVien = mssv_input;

            DataTable sv_result = gv.timSVTheoMSSV(usr, svien);

            if (sv_result != null)
            {
                dgv_sinhVien.DataSource = sv_result;
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên");
            }
        }

        private void btn_inDSLop_Click(object sender, EventArgs e)
        {
            frm_inAnGVien frm_in = new frm_inAnGVien(receive_maUser);
            frm_in.Show();
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            User_GiaoVienBUS gv_BUS = new User_GiaoVienBUS();
            Users us = new Users();
            Lop lop = new Lop();

            //truyen du lieu
            int selected_lop = int.Parse(cbb_lopGVDay.SelectedValue.ToString());

            us.MaUser = receive_maUser;
            lop.MaLop = selected_lop;


            if (selected_lop == 0)
            {
                dgv_sinhVien.DataSource = gv_BUS.loadDSSV(us);
                dgv_sinhVien.Columns["MaLop"].Visible = false;
                dgv_sinhVien.ClearSelection();
            }
            else
            {
                lop.MaLop = selected_lop;
                dgv_sinhVien.DataSource = gv_BUS.load_SinhVienTheoLop(lop, us);
                dgv_sinhVien.Columns["MaLop"].Visible = false;
                dgv_sinhVien.ClearSelection();
            }
        }


        private void txt_chuyenCan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && txt_chuyenCan.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txt_TBKT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txt_TBKT.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txt_thiLan1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txt_thiLan1.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txt_thiLan2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txt_thiLan2.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txt_tongKet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txt_tongKet.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        // tong ket >= 5 thi tat textbox thi lan 2
        private void txt_tongKet_TextChanged(object sender, EventArgs e)
        {
            float diemTongKet = 0;
            if (string.IsNullOrEmpty(txt_tongKet.Text))
            {
                txt_thiLan2.Enabled = true;
            }
            else
            {

                diemTongKet = float.Parse(txt_tongKet.Text);

                if (diemTongKet < 0 || diemTongKet > 10)
                {
                    MessageBox.Show("Điểm tổng kết chỉ trong khoản 0 - 10 ");
                    return;
                }
                else if (diemTongKet >= 5)
                {
                    txt_thiLan2.Enabled = false;
                }
            }
        }
    }
}
