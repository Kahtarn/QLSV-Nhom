namespace Project_QuanLiSinhVien_DoAn.USControl
{
    partial class uc_QLMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_QLMonHoc));
            this.gp_QLMH = new System.Windows.Forms.GroupBox();
            this.txt_SoTinChi = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_TaiLai = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_TenMonHoc = new System.Windows.Forms.TextBox();
            this.txt_MaMonHoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DanhSach = new System.Windows.Forms.DataGridView();
            this.gp_QLMH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // gp_QLMH
            // 
            this.gp_QLMH.Controls.Add(this.txt_SoTinChi);
            this.gp_QLMH.Controls.Add(this.btn_TimKiem);
            this.gp_QLMH.Controls.Add(this.txt_TimKiem);
            this.gp_QLMH.Controls.Add(this.label4);
            this.gp_QLMH.Controls.Add(this.btn_TaiLai);
            this.gp_QLMH.Controls.Add(this.btn_Xoa);
            this.gp_QLMH.Controls.Add(this.btn_Sua);
            this.gp_QLMH.Controls.Add(this.btn_Them);
            this.gp_QLMH.Controls.Add(this.txt_TenMonHoc);
            this.gp_QLMH.Controls.Add(this.txt_MaMonHoc);
            this.gp_QLMH.Controls.Add(this.label3);
            this.gp_QLMH.Controls.Add(this.label2);
            this.gp_QLMH.Controls.Add(this.label1);
            this.gp_QLMH.Location = new System.Drawing.Point(2, 2);
            this.gp_QLMH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gp_QLMH.Name = "gp_QLMH";
            this.gp_QLMH.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gp_QLMH.Size = new System.Drawing.Size(897, 166);
            this.gp_QLMH.TabIndex = 0;
            this.gp_QLMH.TabStop = false;
            this.gp_QLMH.Text = "Quản lí môn học";
            // 
            // txt_SoTinChi
            // 
            this.txt_SoTinChi.Location = new System.Drawing.Point(143, 127);
            this.txt_SoTinChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_SoTinChi.Name = "txt_SoTinChi";
            this.txt_SoTinChi.Size = new System.Drawing.Size(190, 22);
            this.txt_SoTinChi.TabIndex = 13;
            this.txt_SoTinChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoTinChi_KeyPress);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.BackgroundImage")));
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TimKiem.Location = new System.Drawing.Point(601, 69);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(78, 38);
            this.btn_TimKiem.TabIndex = 12;
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(551, 46);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(190, 22);
            this.txt_TimKiem.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nhập tên môn học để tìm kiếm:";
            // 
            // btn_TaiLai
            // 
            this.btn_TaiLai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TaiLai.BackgroundImage")));
            this.btn_TaiLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TaiLai.Location = new System.Drawing.Point(455, 80);
            this.btn_TaiLai.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_TaiLai.Name = "btn_TaiLai";
            this.btn_TaiLai.Size = new System.Drawing.Size(63, 38);
            this.btn_TaiLai.TabIndex = 9;
            this.btn_TaiLai.UseVisualStyleBackColor = true;
            this.btn_TaiLai.Click += new System.EventHandler(this.btn_TaiLai_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.BackgroundImage")));
            this.btn_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Xoa.Location = new System.Drawing.Point(455, 27);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(63, 38);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sua.BackgroundImage")));
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Sua.Location = new System.Drawing.Point(372, 82);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(63, 38);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Them.BackgroundImage")));
            this.btn_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Them.Location = new System.Drawing.Point(372, 27);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(63, 38);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_TenMonHoc
            // 
            this.txt_TenMonHoc.Location = new System.Drawing.Point(143, 80);
            this.txt_TenMonHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TenMonHoc.Name = "txt_TenMonHoc";
            this.txt_TenMonHoc.Size = new System.Drawing.Size(190, 22);
            this.txt_TenMonHoc.TabIndex = 4;
            // 
            // txt_MaMonHoc
            // 
            this.txt_MaMonHoc.Location = new System.Drawing.Point(143, 36);
            this.txt_MaMonHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_MaMonHoc.Name = "txt_MaMonHoc";
            this.txt_MaMonHoc.Size = new System.Drawing.Size(190, 22);
            this.txt_MaMonHoc.TabIndex = 3;
            this.txt_MaMonHoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaMonHoc_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tín chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên môn học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn học:";
            // 
            // dgv_DanhSach
            // 
            this.dgv_DanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSach.Location = new System.Drawing.Point(0, 172);
            this.dgv_DanhSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_DanhSach.Name = "dgv_DanhSach";
            this.dgv_DanhSach.RowHeadersWidth = 72;
            this.dgv_DanhSach.RowTemplate.Height = 31;
            this.dgv_DanhSach.Size = new System.Drawing.Size(900, 280);
            this.dgv_DanhSach.TabIndex = 1;
            this.dgv_DanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSach_CellClick);
            // 
            // uc_QLMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_DanhSach);
            this.Controls.Add(this.gp_QLMH);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "uc_QLMonHoc";
            this.Size = new System.Drawing.Size(902, 454);
            this.gp_QLMH.ResumeLayout(false);
            this.gp_QLMH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_QLMH;
        private System.Windows.Forms.DataGridView dgv_DanhSach;
        private System.Windows.Forms.TextBox txt_MaMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TenMonHoc;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_TaiLai;
        private System.Windows.Forms.TextBox txt_SoTinChi;
    }
}
