namespace Project_QuanLiSinhVien_DoAn.GUI
{
    partial class frm_GiaoVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GiaoVien));
            this.grb_nhanpDiem = new System.Windows.Forms.GroupBox();
            this.lbl_tenSV_TXT = new System.Windows.Forms.Label();
            this.lbl_hoten = new System.Windows.Forms.Label();
            this.btn_chonMon = new System.Windows.Forms.Button();
            this.cbb_monHoc = new System.Windows.Forms.ComboBox();
            this.txt_tongKet = new System.Windows.Forms.TextBox();
            this.txt_thiLan2 = new System.Windows.Forms.TextBox();
            this.txt_thiLan1 = new System.Windows.Forms.TextBox();
            this.txt_TBKT = new System.Windows.Forms.TextBox();
            this.lbl_diemTongKet = new System.Windows.Forms.Label();
            this.lbl_diemthi2 = new System.Windows.Forms.Label();
            this.lbl_diemThi1 = new System.Windows.Forms.Label();
            this.lbl_TBKT = new System.Windows.Forms.Label();
            this.lbl_diemChuyenCan = new System.Windows.Forms.Label();
            this.txt_chuyenCan = new System.Windows.Forms.TextBox();
            this.btn_inDSLop = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.txt_timMSSV = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.grb_thongTinSV = new System.Windows.Forms.GroupBox();
            this.cbb_lopGVDay = new System.Windows.Forms.ComboBox();
            this.btn_loc = new System.Windows.Forms.Button();
            this.lbl_lopGVDay = new System.Windows.Forms.Label();
            this.dgv_sinhVien = new System.Windows.Forms.DataGridView();
            this.tt_GiaoVien = new System.Windows.Forms.ToolTip(this.components);
            this.grb_nhanpDiem.SuspendLayout();
            this.grb_thongTinSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_nhanpDiem
            // 
            this.grb_nhanpDiem.Controls.Add(this.lbl_tenSV_TXT);
            this.grb_nhanpDiem.Controls.Add(this.lbl_hoten);
            this.grb_nhanpDiem.Controls.Add(this.btn_chonMon);
            this.grb_nhanpDiem.Controls.Add(this.cbb_monHoc);
            this.grb_nhanpDiem.Controls.Add(this.txt_tongKet);
            this.grb_nhanpDiem.Controls.Add(this.txt_thiLan2);
            this.grb_nhanpDiem.Controls.Add(this.txt_thiLan1);
            this.grb_nhanpDiem.Controls.Add(this.txt_TBKT);
            this.grb_nhanpDiem.Controls.Add(this.lbl_diemTongKet);
            this.grb_nhanpDiem.Controls.Add(this.lbl_diemthi2);
            this.grb_nhanpDiem.Controls.Add(this.lbl_diemThi1);
            this.grb_nhanpDiem.Controls.Add(this.lbl_TBKT);
            this.grb_nhanpDiem.Controls.Add(this.lbl_diemChuyenCan);
            this.grb_nhanpDiem.Controls.Add(this.txt_chuyenCan);
            this.grb_nhanpDiem.Controls.Add(this.btn_inDSLop);
            this.grb_nhanpDiem.Controls.Add(this.btn_tim);
            this.grb_nhanpDiem.Controls.Add(this.txt_timMSSV);
            this.grb_nhanpDiem.Controls.Add(this.btn_update);
            this.grb_nhanpDiem.Controls.Add(this.btn_refresh);
            this.grb_nhanpDiem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_nhanpDiem.Location = new System.Drawing.Point(26, 12);
            this.grb_nhanpDiem.Name = "grb_nhanpDiem";
            this.grb_nhanpDiem.Size = new System.Drawing.Size(1055, 308);
            this.grb_nhanpDiem.TabIndex = 10;
            this.grb_nhanpDiem.TabStop = false;
            this.grb_nhanpDiem.Text = "Nhập điểm";
            // 
            // lbl_tenSV_TXT
            // 
            this.lbl_tenSV_TXT.AutoSize = true;
            this.lbl_tenSV_TXT.Location = new System.Drawing.Point(160, 49);
            this.lbl_tenSV_TXT.Name = "lbl_tenSV_TXT";
            this.lbl_tenSV_TXT.Size = new System.Drawing.Size(0, 20);
            this.lbl_tenSV_TXT.TabIndex = 36;
            // 
            // lbl_hoten
            // 
            this.lbl_hoten.AutoSize = true;
            this.lbl_hoten.Location = new System.Drawing.Point(37, 49);
            this.lbl_hoten.Name = "lbl_hoten";
            this.lbl_hoten.Size = new System.Drawing.Size(69, 20);
            this.lbl_hoten.TabIndex = 35;
            this.lbl_hoten.Text = "Họ Tên:";
            // 
            // btn_chonMon
            // 
            this.btn_chonMon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_chonMon.BackgroundImage")));
            this.btn_chonMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_chonMon.Location = new System.Drawing.Point(934, 43);
            this.btn_chonMon.Name = "btn_chonMon";
            this.btn_chonMon.Size = new System.Drawing.Size(115, 33);
            this.btn_chonMon.TabIndex = 34;
            this.tt_GiaoVien.SetToolTip(this.btn_chonMon, "Lấy diểm sinh viên theo môn học");
            this.btn_chonMon.UseVisualStyleBackColor = true;
            this.btn_chonMon.Click += new System.EventHandler(this.btn_chonMon_Click);
            // 
            // cbb_monHoc
            // 
            this.cbb_monHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_monHoc.FormattingEnabled = true;
            this.cbb_monHoc.Location = new System.Drawing.Point(757, 46);
            this.cbb_monHoc.Name = "cbb_monHoc";
            this.cbb_monHoc.Size = new System.Drawing.Size(160, 28);
            this.cbb_monHoc.TabIndex = 33;
            // 
            // txt_tongKet
            // 
            this.txt_tongKet.Location = new System.Drawing.Point(540, 167);
            this.txt_tongKet.Name = "txt_tongKet";
            this.txt_tongKet.Size = new System.Drawing.Size(182, 28);
            this.txt_tongKet.TabIndex = 32;
            this.txt_tongKet.TextChanged += new System.EventHandler(this.txt_tongKet_TextChanged);
            this.txt_tongKet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tongKet_KeyPress);
            // 
            // txt_thiLan2
            // 
            this.txt_thiLan2.Location = new System.Drawing.Point(540, 99);
            this.txt_thiLan2.Name = "txt_thiLan2";
            this.txt_thiLan2.Size = new System.Drawing.Size(182, 28);
            this.txt_thiLan2.TabIndex = 31;
            this.txt_thiLan2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_thiLan2_KeyPress);
            // 
            // txt_thiLan1
            // 
            this.txt_thiLan1.Location = new System.Drawing.Point(540, 41);
            this.txt_thiLan1.Name = "txt_thiLan1";
            this.txt_thiLan1.Size = new System.Drawing.Size(182, 28);
            this.txt_thiLan1.TabIndex = 30;
            this.txt_thiLan1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_thiLan1_KeyPress);
            // 
            // txt_TBKT
            // 
            this.txt_TBKT.Location = new System.Drawing.Point(164, 167);
            this.txt_TBKT.Name = "txt_TBKT";
            this.txt_TBKT.Size = new System.Drawing.Size(182, 28);
            this.txt_TBKT.TabIndex = 28;
            this.txt_TBKT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TBKT_KeyPress);
            // 
            // lbl_diemTongKet
            // 
            this.lbl_diemTongKet.AutoSize = true;
            this.lbl_diemTongKet.Location = new System.Drawing.Point(424, 175);
            this.lbl_diemTongKet.Name = "lbl_diemTongKet";
            this.lbl_diemTongKet.Size = new System.Drawing.Size(78, 20);
            this.lbl_diemTongKet.TabIndex = 27;
            this.lbl_diemTongKet.Text = "Tổng kết:";
            // 
            // lbl_diemthi2
            // 
            this.lbl_diemthi2.AutoSize = true;
            this.lbl_diemthi2.Location = new System.Drawing.Point(424, 107);
            this.lbl_diemthi2.Name = "lbl_diemthi2";
            this.lbl_diemthi2.Size = new System.Drawing.Size(78, 20);
            this.lbl_diemthi2.TabIndex = 26;
            this.lbl_diemthi2.Text = "Thi lần 2:";
            // 
            // lbl_diemThi1
            // 
            this.lbl_diemThi1.AutoSize = true;
            this.lbl_diemThi1.Location = new System.Drawing.Point(424, 49);
            this.lbl_diemThi1.Name = "lbl_diemThi1";
            this.lbl_diemThi1.Size = new System.Drawing.Size(78, 20);
            this.lbl_diemThi1.TabIndex = 25;
            this.lbl_diemThi1.Text = "Thi lần 1:";
            // 
            // lbl_TBKT
            // 
            this.lbl_TBKT.AutoSize = true;
            this.lbl_TBKT.Location = new System.Drawing.Point(37, 175);
            this.lbl_TBKT.Name = "lbl_TBKT";
            this.lbl_TBKT.Size = new System.Drawing.Size(122, 20);
            this.lbl_TBKT.TabIndex = 23;
            this.lbl_TBKT.Text = "Trung bình KT:";
            // 
            // lbl_diemChuyenCan
            // 
            this.lbl_diemChuyenCan.AutoSize = true;
            this.lbl_diemChuyenCan.Location = new System.Drawing.Point(37, 107);
            this.lbl_diemChuyenCan.Name = "lbl_diemChuyenCan";
            this.lbl_diemChuyenCan.Size = new System.Drawing.Size(103, 20);
            this.lbl_diemChuyenCan.TabIndex = 22;
            this.lbl_diemChuyenCan.Text = "Chuyên Cần:";
            // 
            // txt_chuyenCan
            // 
            this.txt_chuyenCan.Location = new System.Drawing.Point(164, 99);
            this.txt_chuyenCan.Name = "txt_chuyenCan";
            this.txt_chuyenCan.Size = new System.Drawing.Size(182, 28);
            this.txt_chuyenCan.TabIndex = 21;
            this.txt_chuyenCan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_chuyenCan_KeyPress);
            // 
            // btn_inDSLop
            // 
            this.btn_inDSLop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_inDSLop.BackgroundImage")));
            this.btn_inDSLop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_inDSLop.Location = new System.Drawing.Point(878, 248);
            this.btn_inDSLop.Name = "btn_inDSLop";
            this.btn_inDSLop.Size = new System.Drawing.Size(89, 39);
            this.btn_inDSLop.TabIndex = 20;
            this.tt_GiaoVien.SetToolTip(this.btn_inDSLop, "In báo cáo danh sách sinh viên của lớp chủ nhiệm");
            this.btn_inDSLop.UseVisualStyleBackColor = true;
            this.btn_inDSLop.Click += new System.EventHandler(this.btn_inDSLop_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_tim.BackgroundImage")));
            this.btn_tim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_tim.Location = new System.Drawing.Point(275, 234);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(101, 30);
            this.btn_tim.TabIndex = 18;
            this.tt_GiaoVien.SetToolTip(this.btn_tim, "Nhâp mã số sinh viên để tìm");
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // txt_timMSSV
            // 
            this.txt_timMSSV.Location = new System.Drawing.Point(41, 236);
            this.txt_timMSSV.Name = "txt_timMSSV";
            this.txt_timMSSV.Size = new System.Drawing.Size(210, 28);
            this.txt_timMSSV.TabIndex = 17;
            // 
            // btn_update
            // 
            this.btn_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_update.BackgroundImage")));
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_update.Location = new System.Drawing.Point(871, 107);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(96, 42);
            this.btn_update.TabIndex = 16;
            this.tt_GiaoVien.SetToolTip(this.btn_update, "Cập nhật");
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_refresh.BackgroundImage")));
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_refresh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(871, 175);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(96, 37);
            this.btn_refresh.TabIndex = 12;
            this.tt_GiaoVien.SetToolTip(this.btn_refresh, "Tải lại");
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // grb_thongTinSV
            // 
            this.grb_thongTinSV.Controls.Add(this.cbb_lopGVDay);
            this.grb_thongTinSV.Controls.Add(this.btn_loc);
            this.grb_thongTinSV.Controls.Add(this.lbl_lopGVDay);
            this.grb_thongTinSV.Controls.Add(this.dgv_sinhVien);
            this.grb_thongTinSV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_thongTinSV.Location = new System.Drawing.Point(26, 326);
            this.grb_thongTinSV.Name = "grb_thongTinSV";
            this.grb_thongTinSV.Size = new System.Drawing.Size(1055, 432);
            this.grb_thongTinSV.TabIndex = 11;
            this.grb_thongTinSV.TabStop = false;
            this.grb_thongTinSV.Text = "Thông tin sinh viên";
            // 
            // cbb_lopGVDay
            // 
            this.cbb_lopGVDay.FormattingEnabled = true;
            this.cbb_lopGVDay.Location = new System.Drawing.Point(739, 43);
            this.cbb_lopGVDay.Name = "cbb_lopGVDay";
            this.cbb_lopGVDay.Size = new System.Drawing.Size(199, 28);
            this.cbb_lopGVDay.TabIndex = 26;
            // 
            // btn_loc
            // 
            this.btn_loc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_loc.BackgroundImage")));
            this.btn_loc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_loc.Location = new System.Drawing.Point(957, 43);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(78, 32);
            this.btn_loc.TabIndex = 25;
            this.tt_GiaoVien.SetToolTip(this.btn_loc, "Lọc danh sách sinh viên theo lớp");
            this.btn_loc.UseVisualStyleBackColor = true;
            this.btn_loc.Click += new System.EventHandler(this.btn_loc_Click);
            // 
            // lbl_lopGVDay
            // 
            this.lbl_lopGVDay.AutoSize = true;
            this.lbl_lopGVDay.Location = new System.Drawing.Point(657, 49);
            this.lbl_lopGVDay.Name = "lbl_lopGVDay";
            this.lbl_lopGVDay.Size = new System.Drawing.Size(43, 20);
            this.lbl_lopGVDay.TabIndex = 24;
            this.lbl_lopGVDay.Text = "Lớp:";
            // 
            // dgv_sinhVien
            // 
            this.dgv_sinhVien.AllowUserToAddRows = false;
            this.dgv_sinhVien.AllowUserToDeleteRows = false;
            this.dgv_sinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sinhVien.Location = new System.Drawing.Point(11, 104);
            this.dgv_sinhVien.Name = "dgv_sinhVien";
            this.dgv_sinhVien.ReadOnly = true;
            this.dgv_sinhVien.RowHeadersWidth = 51;
            this.dgv_sinhVien.RowTemplate.Height = 24;
            this.dgv_sinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sinhVien.Size = new System.Drawing.Size(1038, 322);
            this.dgv_sinhVien.TabIndex = 0;
            this.dgv_sinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sinhVien_CellClick);
            // 
            // frm_GiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 770);
            this.Controls.Add(this.grb_thongTinSV);
            this.Controls.Add(this.grb_nhanpDiem);
            this.Name = "frm_GiaoVien";
            this.Text = "Giáo Viên";
            this.Load += new System.EventHandler(this.frm_giaoVien_Load);
            this.grb_nhanpDiem.ResumeLayout(false);
            this.grb_nhanpDiem.PerformLayout();
            this.grb_thongTinSV.ResumeLayout(false);
            this.grb_thongTinSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_nhanpDiem;
        private System.Windows.Forms.GroupBox grb_thongTinSV;
        private System.Windows.Forms.DataGridView dgv_sinhVien;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.ToolTip tt_GiaoVien;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.TextBox txt_timMSSV;
        private System.Windows.Forms.Button btn_inDSLop;
        private System.Windows.Forms.ComboBox cbb_lopGVDay;
        private System.Windows.Forms.Button btn_loc;
        private System.Windows.Forms.Label lbl_lopGVDay;
        private System.Windows.Forms.TextBox txt_chuyenCan;
        private System.Windows.Forms.Label lbl_diemChuyenCan;
        private System.Windows.Forms.Label lbl_diemthi2;
        private System.Windows.Forms.Label lbl_diemThi1;
        private System.Windows.Forms.Label lbl_TBKT;
        private System.Windows.Forms.TextBox txt_TBKT;
        private System.Windows.Forms.Label lbl_diemTongKet;
        private System.Windows.Forms.TextBox txt_thiLan2;
        private System.Windows.Forms.TextBox txt_thiLan1;
        private System.Windows.Forms.TextBox txt_tongKet;
        private System.Windows.Forms.Button btn_chonMon;
        private System.Windows.Forms.ComboBox cbb_monHoc;
        private System.Windows.Forms.Label lbl_hoten;
        private System.Windows.Forms.Label lbl_tenSV_TXT;
    }
}