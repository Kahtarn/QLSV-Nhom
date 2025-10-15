namespace Project_QuanLiSinhVien_DoAn.DTO
{
    class Lop
    {
        public int MaLop { get; set; }
        public string TenLop { get; set; }
        public int MaKhoa { get; set; }
        public int SiSo { get; set; }
        public int GiaoVienCN { get; set; }
        public Lop()
        {
            MaLop = 0;
            TenLop = string.Empty;
            MaKhoa = 0;
            SiSo = 0;
            GiaoVienCN = 0;
        }
    }
}
