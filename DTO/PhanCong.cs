namespace Project_QuanLiSinhVien_DoAn.DTO
{
    class PhanCong
    {
        public int MaGiaoVien { get; set; }
        public int MaMonHoc { get; set; }
        public int MaLop { get; set; }
        public PhanCong()
        {
            MaGiaoVien = 0;
            MaMonHoc = 0;
            MaLop = 0;
        }
    }
}
