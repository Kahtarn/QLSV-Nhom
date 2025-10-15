namespace Project_QuanLiSinhVien_DoAn.USControl
{
    partial class uc_QLLop
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_QLLop));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgv_DanhSach = new System.Windows.Forms.DataGridView();
            this.gbx_QLLop = new System.Windows.Forms.GroupBox();
            this.gbx_nhapLieu = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.cb_Khoa = new System.Windows.Forms.ComboBox();
            this.cb_GVCN = new System.Windows.Forms.ComboBox();
            this.txt_TenLop = new System.Windows.Forms.TextBox();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.lbl_giaoVienCN = new System.Windows.Forms.Label();
            this.lbl_khoa = new System.Windows.Forms.Label();
            this.lbl_tenLop = new System.Windows.Forms.Label();
            this.lbl_maLop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).BeginInit();
            this.gbx_QLLop.SuspendLayout();
            this.gbx_nhapLieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DanhSach
            // 
            this.dgv_DanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSach.Location = new System.Drawing.Point(19, 28);
            this.dgv_DanhSach.Name = "dgv_DanhSach";
            this.dgv_DanhSach.RowHeadersWidth = 72;
            this.dgv_DanhSach.RowTemplate.Height = 31;
            this.dgv_DanhSach.Size = new System.Drawing.Size(1184, 369);
            this.dgv_DanhSach.TabIndex = 0;
            this.dgv_DanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSach_CellClick);
            // 
            // gbx_QLLop
            // 
            this.gbx_QLLop.Controls.Add(this.dgv_DanhSach);
            this.gbx_QLLop.Location = new System.Drawing.Point(28, 270);
            this.gbx_QLLop.Name = "gbx_QLLop";
            this.gbx_QLLop.Size = new System.Drawing.Size(1209, 414);
            this.gbx_QLLop.TabIndex = 1;
            this.gbx_QLLop.TabStop = false;
            this.gbx_QLLop.Text = "Quản lí Lớp Học";
            // 
            // gbx_nhapLieu
            // 
            this.gbx_nhapLieu.Controls.Add(this.btn_TimKiem);
            this.gbx_nhapLieu.Controls.Add(this.txt_TimKiem);
            this.gbx_nhapLieu.Controls.Add(this.label1);
            this.gbx_nhapLieu.Controls.Add(this.btn_refresh);
            this.gbx_nhapLieu.Controls.Add(this.btn_xoa);
            this.gbx_nhapLieu.Controls.Add(this.btn_sua);
            this.gbx_nhapLieu.Controls.Add(this.btn_them);
            this.gbx_nhapLieu.Controls.Add(this.cb_Khoa);
            this.gbx_nhapLieu.Controls.Add(this.cb_GVCN);
            this.gbx_nhapLieu.Controls.Add(this.txt_TenLop);
            this.gbx_nhapLieu.Controls.Add(this.txt_MaLop);
            this.gbx_nhapLieu.Controls.Add(this.lbl_giaoVienCN);
            this.gbx_nhapLieu.Controls.Add(this.lbl_khoa);
            this.gbx_nhapLieu.Controls.Add(this.lbl_tenLop);
            this.gbx_nhapLieu.Controls.Add(this.lbl_maLop);
            this.gbx_nhapLieu.Location = new System.Drawing.Point(28, 18);
            this.gbx_nhapLieu.Name = "gbx_nhapLieu";
            this.gbx_nhapLieu.Size = new System.Drawing.Size(1209, 246);
            this.gbx_nhapLieu.TabIndex = 2;
            this.gbx_nhapLieu.TabStop = false;
            this.gbx_nhapLieu.Text = "Nhập Lớp";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.BackgroundImage")));
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TimKiem.Location = new System.Drawing.Point(991, 186);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(98, 54);
            this.btn_TimKiem.TabIndex = 15;
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(884, 157);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(294, 23);
            this.txt_TimKiem.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nhập tên lớp để tìm kiếm:";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_refresh.BackgroundImage")));
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_refresh.Location = new System.Drawing.Point(464, 143);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(115, 43);
            this.btn_refresh.TabIndex = 12;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_xoa.BackgroundImage")));
            this.btn_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_xoa.Location = new System.Drawing.Point(320, 143);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(115, 43);
            this.btn_xoa.TabIndex = 11;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sua.BackgroundImage")));
            this.btn_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sua.Location = new System.Drawing.Point(178, 143);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(115, 43);
            this.btn_sua.TabIndex = 10;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_them.BackgroundImage")));
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_them.Location = new System.Drawing.Point(31, 143);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(117, 43);
            this.btn_them.TabIndex = 9;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // cb_Khoa
            // 
            this.cb_Khoa.FormattingEnabled = true;
            this.cb_Khoa.Location = new System.Drawing.Point(620, 32);
            this.cb_Khoa.Name = "cb_Khoa";
            this.cb_Khoa.Size = new System.Drawing.Size(319, 24);
            this.cb_Khoa.TabIndex = 8;
            // 
            // cb_GVCN
            // 
            this.cb_GVCN.FormattingEnabled = true;
            this.cb_GVCN.Location = new System.Drawing.Point(620, 99);
            this.cb_GVCN.Name = "cb_GVCN";
            this.cb_GVCN.Size = new System.Drawing.Size(319, 24);
            this.cb_GVCN.TabIndex = 7;
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Location = new System.Drawing.Point(141, 95);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(294, 23);
            this.txt_TenLop.TabIndex = 6;
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Location = new System.Drawing.Point(141, 32);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(294, 23);
            this.txt_MaLop.TabIndex = 5;
            this.txt_MaLop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaLop_KeyPress);
            // 
            // lbl_giaoVienCN
            // 
            this.lbl_giaoVienCN.AutoSize = true;
            this.lbl_giaoVienCN.Location = new System.Drawing.Point(486, 102);
            this.lbl_giaoVienCN.Name = "lbl_giaoVienCN";
            this.lbl_giaoVienCN.Size = new System.Drawing.Size(87, 16);
            this.lbl_giaoVienCN.TabIndex = 4;
            this.lbl_giaoVienCN.Text = "Giáo Viên CN:";
            // 
            // lbl_khoa
            // 
            this.lbl_khoa.AutoSize = true;
            this.lbl_khoa.Location = new System.Drawing.Point(486, 35);
            this.lbl_khoa.Name = "lbl_khoa";
            this.lbl_khoa.Size = new System.Drawing.Size(65, 16);
            this.lbl_khoa.TabIndex = 2;
            this.lbl_khoa.Text = "Tên Khoa:";
            // 
            // lbl_tenLop
            // 
            this.lbl_tenLop.AutoSize = true;
            this.lbl_tenLop.Location = new System.Drawing.Point(27, 102);
            this.lbl_tenLop.Name = "lbl_tenLop";
            this.lbl_tenLop.Size = new System.Drawing.Size(58, 16);
            this.lbl_tenLop.TabIndex = 1;
            this.lbl_tenLop.Text = "Tên Lớp:";
            // 
            // lbl_maLop
            // 
            this.lbl_maLop.AutoSize = true;
            this.lbl_maLop.Location = new System.Drawing.Point(27, 39);
            this.lbl_maLop.Name = "lbl_maLop";
            this.lbl_maLop.Size = new System.Drawing.Size(54, 16);
            this.lbl_maLop.TabIndex = 0;
            this.lbl_maLop.Text = "Mã Lớp:";
            // 
            // uc_QLLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbx_nhapLieu);
            this.Controls.Add(this.gbx_QLLop);
            this.Font = new System.Drawing.Font("Times New Roman", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uc_QLLop";
            this.Size = new System.Drawing.Size(1240, 681);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).EndInit();
            this.gbx_QLLop.ResumeLayout(false);
            this.gbx_nhapLieu.ResumeLayout(false);
            this.gbx_nhapLieu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgv_DanhSach;
        private System.Windows.Forms.GroupBox gbx_QLLop;
        private System.Windows.Forms.GroupBox gbx_nhapLieu;
        private System.Windows.Forms.Label lbl_khoa;
        private System.Windows.Forms.Label lbl_tenLop;
        private System.Windows.Forms.Label lbl_maLop;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ComboBox cb_Khoa;
        private System.Windows.Forms.TextBox txt_TenLop;
        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.ComboBox cb_GVCN;
        private System.Windows.Forms.Label lbl_giaoVienCN;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label1;
    }
}
