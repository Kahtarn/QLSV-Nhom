using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Project_QuanLiSinhVien_DoAn.BUS;
using Project_QuanLiSinhVien_DoAn.DTO;

namespace Project_QuanLiSinhVien_DoAn.GUI
{
    public partial class frm_inAnGVien : Form
    {
        private int receive_maUser;
        public frm_inAnGVien(int maUser)
        {
            receive_maUser = maUser;
            InitializeComponent();
        }
        private void frm_inAnGVien_Load(object sender, EventArgs e)
        {
            User_GiaoVienBUS gv = new User_GiaoVienBUS();
            Users usr = new Users();

            usr.MaUser = receive_maUser;

            this.rpt_inAnGV.LocalReport.ReportEmbeddedResource = "Project_QuanLiSinhVien_DoAn.GUI.RptforGiaoVien.rdlc";

            //Do du lieu
            DataTable sinhVien = gv.load_tableReportGV(usr);
            DataTable giaoVien = gv.loadThongTinGiaoVien(usr);

            string tenGiaoVien = giaoVien.Rows[0]["HoTen"].ToString();

            this.rpt_inAnGV.LocalReport.DataSources.Add(new ReportDataSource("ds_giaoVien", sinhVien));
            rpt_inAnGV.LocalReport.SetParameters(new ReportParameter("tenGV", tenGiaoVien));
            this.rpt_inAnGV.RefreshReport();
        }
    }
}
