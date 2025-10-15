using System;

namespace Project_QuanLiSinhVien_DoAn.DTO
{
    class GiaoVien
    {
        public int MaGiaoVien { get; set; }
        public int MaUser { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string CCCD { get; set; }
        public string Email { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NamBatDauGiangDay { get; set; }
        public GiaoVien()
        {
            MaGiaoVien = 0;
            MaUser = 0;
            HoTen = string.Empty;
            NgaySinh = DateTime.Now;
            CCCD = string.Empty;
            Email = string.Empty;
            GioiTinh = string.Empty;
            NamBatDauGiangDay = DateTime.Now;
        }
    }
}
