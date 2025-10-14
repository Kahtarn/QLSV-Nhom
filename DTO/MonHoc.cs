namespace Project_QuanLiSinhVien_DoAn.DTO
{
    class MonHoc
    {
        public int MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        public int SoTinChi { get; set; }
        public MonHoc()
        {
            MaMonHoc = 0;
            TenMonHoc = string.Empty;
            SoTinChi = 0;
        }
    }
}
