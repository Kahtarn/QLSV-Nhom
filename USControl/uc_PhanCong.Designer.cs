namespace Project_QuanLiSinhVien_DoAn.USControl
{
    partial class uc_PhanCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_PhanCong));
            this.gp_PhanCong = new System.Windows.Forms.GroupBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Tim = new System.Windows.Forms.ComboBox();
            this.btn_TaiLai = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.cb_MonHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Lop = new System.Windows.Forms.ComboBox();
            this.cb_GiaoVien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DanhSach = new System.Windows.Forms.DataGridView();
            this.gp_PhanCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // gp_PhanCong
            // 
            this.gp_PhanCong.Controls.Add(this.btn_Tim);
            this.gp_PhanCong.Controls.Add(this.label4);
            this.gp_PhanCong.Controls.Add(this.cb_Tim);
            this.gp_PhanCong.Controls.Add(this.btn_TaiLai);
            this.gp_PhanCong.Controls.Add(this.btn_Sua);
            this.gp_PhanCong.Controls.Add(this.btn_Them);
            this.gp_PhanCong.Controls.Add(this.cb_MonHoc);
            this.gp_PhanCong.Controls.Add(this.label3);
            this.gp_PhanCong.Controls.Add(this.label2);
            this.gp_PhanCong.Controls.Add(this.cb_Lop);
            this.gp_PhanCong.Controls.Add(this.cb_GiaoVien);
            this.gp_PhanCong.Controls.Add(this.label1);
            this.gp_PhanCong.Location = new System.Drawing.Point(2, 2);
            this.gp_PhanCong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gp_PhanCong.Name = "gp_PhanCong";
            this.gp_PhanCong.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gp_PhanCong.Size = new System.Drawing.Size(897, 165);
            this.gp_PhanCong.TabIndex = 0;
            this.gp_PhanCong.TabStop = false;
            this.gp_PhanCong.Text = "Phân công giáo viên";
            // 
            // btn_Tim
            // 
            this.btn_Tim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tim.BackgroundImage")));
            this.btn_Tim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Tim.Location = new System.Drawing.Point(724, 115);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(63, 38);
            this.btn_Tim.TabIndex = 17;
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Chọn lớp để tìm giáo viên được phân công*";
            // 
            // cb_Tim
            // 
            this.cb_Tim.FormattingEnabled = true;
            this.cb_Tim.Location = new System.Drawing.Point(522, 99);
            this.cb_Tim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Tim.Name = "cb_Tim";
            this.cb_Tim.Size = new System.Drawing.Size(189, 24);
            this.cb_Tim.TabIndex = 15;
            // 
            // btn_TaiLai
            // 
            this.btn_TaiLai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TaiLai.BackgroundImage")));
            this.btn_TaiLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TaiLai.Location = new System.Drawing.Point(169, 99);
            this.btn_TaiLai.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_TaiLai.Name = "btn_TaiLai";
            this.btn_TaiLai.Size = new System.Drawing.Size(63, 38);
            this.btn_TaiLai.TabIndex = 14;
            this.btn_TaiLai.UseVisualStyleBackColor = true;
            this.btn_TaiLai.Click += new System.EventHandler(this.btn_TaiLai_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sua.BackgroundImage")));
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Sua.Location = new System.Drawing.Point(95, 99);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(63, 38);
            this.btn_Sua.TabIndex = 12;
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Them.BackgroundImage")));
            this.btn_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Them.Location = new System.Drawing.Point(23, 99);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(63, 38);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // cb_MonHoc
            // 
            this.cb_MonHoc.FormattingEnabled = true;
            this.cb_MonHoc.Location = new System.Drawing.Point(422, 47);
            this.cb_MonHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_MonHoc.Name = "cb_MonHoc";
            this.cb_MonHoc.Size = new System.Drawing.Size(155, 24);
            this.cb_MonHoc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Môn học*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lớp*";
            // 
            // cb_Lop
            // 
            this.cb_Lop.FormattingEnabled = true;
            this.cb_Lop.Location = new System.Drawing.Point(209, 47);
            this.cb_Lop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Lop.Name = "cb_Lop";
            this.cb_Lop.Size = new System.Drawing.Size(155, 24);
            this.cb_Lop.TabIndex = 2;
            // 
            // cb_GiaoVien
            // 
            this.cb_GiaoVien.FormattingEnabled = true;
            this.cb_GiaoVien.Location = new System.Drawing.Point(4, 47);
            this.cb_GiaoVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_GiaoVien.Name = "cb_GiaoVien";
            this.cb_GiaoVien.Size = new System.Drawing.Size(155, 24);
            this.cb_GiaoVien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giáo viên*";
            // 
            // dgv_DanhSach
            // 
            this.dgv_DanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSach.Location = new System.Drawing.Point(0, 171);
            this.dgv_DanhSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_DanhSach.Name = "dgv_DanhSach";
            this.dgv_DanhSach.RowHeadersWidth = 72;
            this.dgv_DanhSach.RowTemplate.Height = 31;
            this.dgv_DanhSach.Size = new System.Drawing.Size(900, 281);
            this.dgv_DanhSach.TabIndex = 1;
            // 
            // uc_PhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_DanhSach);
            this.Controls.Add(this.gp_PhanCong);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "uc_PhanCong";
            this.Size = new System.Drawing.Size(902, 454);
            this.gp_PhanCong.ResumeLayout(false);
            this.gp_PhanCong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_PhanCong;
        private System.Windows.Forms.DataGridView dgv_DanhSach;
        private System.Windows.Forms.ComboBox cb_MonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Lop;
        private System.Windows.Forms.ComboBox cb_GiaoVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TaiLai;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Tim;
    }
}
