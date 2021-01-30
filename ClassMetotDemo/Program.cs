using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.FirstName = "Beril";
            musteri1.LastName = "Aksu";
            musteri1.MusteriNo = "24";
            musteri1.Id = 244;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri1);
            musteriManager.Guncelle(musteri1);
        }
    }
}
