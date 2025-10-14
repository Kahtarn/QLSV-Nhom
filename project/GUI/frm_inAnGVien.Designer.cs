namespace Project_QuanLiSinhVien_DoAn.GUI
{
    partial class frm_inAnGVien
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
            this.rpt_inAnGV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpt_inAnGV
            // 
            this.rpt_inAnGV.Location = new System.Drawing.Point(4, 4);
            this.rpt_inAnGV.Name = "rpt_inAnGV";
            this.rpt_inAnGV.ServerReport.BearerToken = null;
            this.rpt_inAnGV.Size = new System.Drawing.Size(1185, 779);
            this.rpt_inAnGV.TabIndex = 0;
            // 
            // frm_inAnGVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 795);
            this.Controls.Add(this.rpt_inAnGV);
            this.Name = "frm_inAnGVien";
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.frm_inAnGVien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpt_inAnGV;
    }
}