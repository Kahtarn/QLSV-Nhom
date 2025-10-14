using System;

namespace Project_QuanLiSinhVien_DoAn.DTO
{
    class SinhVien
    {
        public string MaSinhVien { get; set; }
        public int MaLop { get; set; }
        public string HoTen { get; set; }
        public int MaUser { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Email { get; set; }
        public string CCCD { get; set; }
        public SinhVien()
        {
            MaSinhVien = string.Empty;
            MaLop = 0;
            MaUser = 0;
            HoTen = string.Empty;
            NgaySinh = DateTime.Now;
            GioiTinh = string.Empty;
            Email = string.Empty;
            CCCD = string.Empty;
        }
    }
}
