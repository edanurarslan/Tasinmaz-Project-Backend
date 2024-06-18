namespace tasinmaz.Models
{
    public class Log
    {
        public int Id { get; set; }
        public string Durum { get; set; }
    
        public int KullaniciId { get; set; }
        public string IslemTipi { get; set; }

        public string Ip { get; set; }

        public string Aciklama { get; set; }

        public string TarihSaat { get; set; }

    }
}
