namespace SUKIEN
{
    public class SuKienData
    {
        public int So_SK { get; set; }
        public string ID_SK { get; set; }
        public string Ten_SK { get; set; }
        public string Ngay_SK { get; set; }
        public string DiaDiem_SK { get; set; }
        public string MoTa_SK { get; set; }
        public string NgTao_SK { get; set; }

        public SuKienData(string id, string ten, string ngay, string diaDiem, string moTa, string ngTao, int so_SK)
        {
            this.ID_SK = id;
            this.Ten_SK = ten;
            this.Ngay_SK = ngay;
            this.DiaDiem_SK = diaDiem;
            this.MoTa_SK = moTa;
            this.NgTao_SK = ngTao;
            this.So_SK = so_SK;
        }

        public SuKienData(string ten, string ngay, string diaDiem, string moTa, string ngTao)
        {
            this.Ten_SK = ten;
            this.Ngay_SK = ngay;
            this.DiaDiem_SK = diaDiem;
            this.MoTa_SK = moTa;
            this.NgTao_SK = ngTao;
        }
    }

    public class YCTH
    {
        public string Ten_user { get; set; }
        public string Ten_SK { get; set; }
        public string TrangThai { get; set; }

        public YCTH(string ten_user, string ten_SK, string trangThai)
        {
            this.Ten_user = ten_user;
            this.Ten_SK = ten_SK;
            this.TrangThai = trangThai;
        }
    }

    public class SLND
    {
        public string Ten_user { get; set; }

        public SLND(string ten_user)
        {
            this.Ten_user = ten_user;
        }
    }
}