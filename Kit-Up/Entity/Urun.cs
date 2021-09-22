namespace Kit_Up.Models
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string UrunImg { get; set; }
        public string UrunAdi { get; set; }
        public string UrunAciklama { get; set; }
        public string UrunYazar { get; set; }
        public double UrunFiyat { get; set; }
        public int UrunStok { get; set; }
        public string UrunKategori { get; set; }
        public bool UrunSatistami { get; set; }
    }
}