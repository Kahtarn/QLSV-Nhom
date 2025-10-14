namespace Project_QuanLiSinhVien_DoAn.DTO
{
    class Users
    {
        public int MaUser { get; set; }
        public string HoTen { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string Roles { get; set; }
        public Users()
        {
            MaUser = 0;
            HoTen = string.Empty;
            TenDangNhap = string.Empty;
            MatKhau = string.Empty;
            Roles = string.Empty;
        }
    }
}
