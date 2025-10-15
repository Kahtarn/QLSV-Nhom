namespace Project_QuanLiSinhVien_DoAn.DTO
{
    class Diem
    {
        public string MaSinhVien { get; set; }
        public int MaMonHoc { get; set; }
        public float DiemChuyenCan { get; set; }
        public float DiemTrungBinhKT { get; set; }
        public float DiemThiLan1 { get; set; }
        public float? DiemThiLan2 { get; set; }
        public float DiemTongKet { get; set; }
        public Diem()
        {
            MaSinhVien = string.Empty;
            MaMonHoc = 0;
            DiemChuyenCan = 0;
            DiemTrungBinhKT = 0;
            DiemThiLan1 = 0;
            DiemThiLan2 = 0;
            DiemTongKet = 0;
        }
    }
}
