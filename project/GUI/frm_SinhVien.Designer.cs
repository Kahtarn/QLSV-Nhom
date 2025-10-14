using System.Drawing;

namespace Project_QuanLiSinhVien_DoAn.GUI
{
    partial class frm_SinhVien
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
            this.dgv_sinhvien = new System.Windows.Forms.DataGridView();
            this.lbl_hoten = new System.Windows.Forms.Label();
            this.lbl_lop = new System.Windows.Forms.Label();
            this.lbl_hoten_value = new System.Windows.Forms.Label();
            this.lbl_lop_value = new System.Windows.Forms.Label();
            this.lbl_mssv = new System.Windows.Forms.Label();
            this.lbl_MSSV_value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_sinhvien
            // 
            this.dgv_sinhvien.AllowUserToAddRows = false;
            this.dgv_sinhvien.AllowUserToDeleteRows = false;
            this.dgv_sinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sinhvien.Location = new System.Drawing.Point(24, 174);
            this.dgv_sinhvien.Name = "dgv_sinhvien";
            this.dgv_sinhvien.RowHeadersWidth = 51;
            this.dgv_sinhvien.RowTemplate.Height = 24;
            this.dgv_sinhvien.Size = new System.Drawing.Size(1054, 308);
            this.dgv_sinhvien.TabIndex = 2;
            // 
            // lbl_hoten
            // 
            this.lbl_hoten.AutoSize = true;
            this.lbl_hoten.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoten.Location = new System.Drawing.Point(53, 84);
            this.lbl_hoten.Name = "lbl_hoten";
            this.lbl_hoten.Size = new System.Drawing.Size(62, 20);
            this.lbl_hoten.TabIndex = 5;
            this.lbl_hoten.Text = "Họ tên:";
            // 
            // lbl_lop
            // 
            this.lbl_lop.AutoSize = true;
            this.lbl_lop.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lop.Location = new System.Drawing.Point(56, 128);
            this.lbl_lop.Name = "lbl_lop";
            this.lbl_lop.Size = new System.Drawing.Size(43, 20);
            this.lbl_lop.TabIndex = 6;
            this.lbl_lop.Text = "Lớp:";
            // 
            // lbl_hoten_value
            // 
            this.lbl_hoten_value.AutoSize = true;
            this.lbl_hoten_value.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoten_value.Location = new System.Drawing.Point(143, 84);
            this.lbl_hoten_value.Name = "lbl_hoten_value";
            this.lbl_hoten_value.Size = new System.Drawing.Size(63, 20);
            this.lbl_hoten_value.TabIndex = 7;
            this.lbl_hoten_value.Text = "Họ tên ";
            // 
            // lbl_lop_value
            // 
            this.lbl_lop_value.AutoSize = true;
            this.lbl_lop_value.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lop_value.Location = new System.Drawing.Point(144, 131);
            this.lbl_lop_value.Name = "lbl_lop_value";
            this.lbl_lop_value.Size = new System.Drawing.Size(39, 20);
            this.lbl_lop_value.TabIndex = 8;
            this.lbl_lop_value.Text = "Lớp";
            // 
            // lbl_mssv
            // 
            this.lbl_mssv.AutoSize = true;
            this.lbl_mssv.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mssv.Location = new System.Drawing.Point(56, 37);
            this.lbl_mssv.Name = "lbl_mssv";
            this.lbl_mssv.Size = new System.Drawing.Size(60, 20);
            this.lbl_mssv.TabIndex = 10;
            this.lbl_mssv.Text = "MSSV:";
            // 
            // lbl_MSSV_value
            // 
            this.lbl_MSSV_value.AutoSize = true;
            this.lbl_MSSV_value.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MSSV_value.Location = new System.Drawing.Point(143, 37);
            this.lbl_MSSV_value.Name = "lbl_MSSV_value";
            this.lbl_MSSV_value.Size = new System.Drawing.Size(128, 20);
            this.lbl_MSSV_value.TabIndex = 11;
            this.lbl_MSSV_value.Text = "Mã số Sinh Viên";
            // 
            // frm_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 525);
            this.Controls.Add(this.lbl_MSSV_value);
            this.Controls.Add(this.lbl_mssv);
            this.Controls.Add(this.lbl_lop_value);
            this.Controls.Add(this.lbl_hoten_value);
            this.Controls.Add(this.lbl_lop);
            this.Controls.Add(this.lbl_hoten);
            this.Controls.Add(this.dgv_sinhvien);
            this.Name = "frm_SinhVien";
            this.Text = "Sinh viên";
            this.Load += new System.EventHandler(this.frm_SinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_sinhvien;
        private System.Windows.Forms.Label lbl_hoten;
        private System.Windows.Forms.Label lbl_lop;
        private System.Windows.Forms.Label lbl_hoten_value;
        private System.Windows.Forms.Label lbl_lop_value;
        private System.Windows.Forms.Label lbl_mssv;
        private System.Windows.Forms.Label lbl_MSSV_value;
    }
}