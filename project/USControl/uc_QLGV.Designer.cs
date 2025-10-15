namespace Project_QuanLiSinhVien_DoAn.USControl
{
    partial class uc_QLGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_QLGV));
            this.dgv_DanhSach = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_TaiLai = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_NamGD = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.rbtn_Nu = new System.Windows.Forms.RadioButton();
            this.rbtn_Nam = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_MaGiaoVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DanhSach
            // 
            this.dgv_DanhSach.AllowUserToAddRows = false;
            this.dgv_DanhSach.AllowUserToDeleteRows = false;
            this.dgv_DanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSach.Location = new System.Drawing.Point(3, 272);
            this.dgv_DanhSach.Name = "dgv_DanhSach";
            this.dgv_DanhSach.RowHeadersWidth = 72;
            this.dgv_DanhSach.RowTemplate.Height = 31;
            this.dgv_DanhSach.Size = new System.Drawing.Size(1234, 406);
            this.dgv_DanhSach.TabIndex = 1;
            this.dgv_DanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSach_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_TaiLai);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Controls.Add(this.txt_Tim);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtp_NamGD);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rbtn_Nu);
            this.groupBox1.Controls.Add(this.rbtn_Nam);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_CCCD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtp_NgaySinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_HoTen);
            this.groupBox1.Controls.Add(this.txt_MaGiaoVien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1234, 263);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lí giáo viên";
            // 
            // btn_TaiLai
            // 
            this.btn_TaiLai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TaiLai.BackgroundImage")));
            this.btn_TaiLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TaiLai.Location = new System.Drawing.Point(1108, 199);
            this.btn_TaiLai.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TaiLai.Name = "btn_TaiLai";
            this.btn_TaiLai.Size = new System.Drawing.Size(87, 57);
            this.btn_TaiLai.TabIndex = 13;
            this.btn_TaiLai.UseVisualStyleBackColor = true;
            this.btn_TaiLai.Click += new System.EventHandler(this.btn_TaiLai_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.BackgroundImage")));
            this.btn_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Xoa.Location = new System.Drawing.Point(996, 199);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(87, 57);
            this.btn_Xoa.TabIndex = 12;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sua.BackgroundImage")));
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Sua.Location = new System.Drawing.Point(879, 199);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(87, 57);
            this.btn_Sua.TabIndex = 11;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Them.BackgroundImage")));
            this.btn_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Them.Location = new System.Drawing.Point(764, 199);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(87, 57);
            this.btn_Them.TabIndex = 10;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.BackgroundImage")));
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TimKiem.Location = new System.Drawing.Point(1084, 120);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(87, 57);
            this.btn_TimKiem.TabIndex = 14;
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_Tim
            // 
            this.txt_Tim.Location = new System.Drawing.Point(764, 135);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(274, 23);
            this.txt_Tim.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(760, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nhập tên để tìm giáo viên*";
            // 
            // dtp_NamGD
            // 
            this.dtp_NamGD.Location = new System.Drawing.Point(764, 63);
            this.dtp_NamGD.Name = "dtp_NamGD";
            this.dtp_NamGD.Size = new System.Drawing.Size(274, 23);
            this.dtp_NamGD.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(760, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Năm bắt đầu giảng dạy*";
            // 
            // rbtn_Nu
            // 
            this.rbtn_Nu.AutoSize = true;
            this.rbtn_Nu.Location = new System.Drawing.Point(536, 63);
            this.rbtn_Nu.Name = "rbtn_Nu";
            this.rbtn_Nu.Size = new System.Drawing.Size(46, 20);
            this.rbtn_Nu.TabIndex = 12;
            this.rbtn_Nu.TabStop = true;
            this.rbtn_Nu.Text = "Nữ";
            this.rbtn_Nu.UseVisualStyleBackColor = true;
            // 
            // rbtn_Nam
            // 
            this.rbtn_Nam.AutoSize = true;
            this.rbtn_Nam.Location = new System.Drawing.Point(392, 63);
            this.rbtn_Nam.Name = "rbtn_Nam";
            this.rbtn_Nam.Size = new System.Drawing.Size(55, 20);
            this.rbtn_Nam.TabIndex = 4;
            this.rbtn_Nam.TabStop = true;
            this.rbtn_Nam.Text = "Nam";
            this.rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Giới tính";
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.Location = new System.Drawing.Point(392, 135);
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(274, 23);
            this.txt_CCCD.TabIndex = 6;
            this.txt_CCCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CCCD_KeyPress_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "CCCD*";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(392, 214);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(274, 23);
            this.txt_Email.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email*";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Location = new System.Drawing.Point(23, 214);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(274, 23);
            this.dtp_NgaySinh.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh*";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(23, 135);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(274, 23);
            this.txt_HoTen.TabIndex = 2;
            // 
            // txt_MaGiaoVien
            // 
            this.txt_MaGiaoVien.Location = new System.Drawing.Point(23, 60);
            this.txt_MaGiaoVien.Name = "txt_MaGiaoVien";
            this.txt_MaGiaoVien.Size = new System.Drawing.Size(274, 23);
            this.txt_MaGiaoVien.TabIndex = 1;
            this.txt_MaGiaoVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaGiaoVien_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã giáo viên*";
            // 
            // uc_QLGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_DanhSach);
            this.Font = new System.Drawing.Font("Times New Roman", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uc_QLGV";
            this.Size = new System.Drawing.Size(1240, 681);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_DanhSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_NamGD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtn_Nu;
        private System.Windows.Forms.RadioButton rbtn_Nam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_MaGiaoVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_TaiLai;
    }
}
