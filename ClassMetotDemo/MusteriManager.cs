using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.FirstName + "" + musteri.LastName + "" + "başarıyla eklendi");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.FirstName + "" + musteri.LastName + "" + "başarıyla silindi");

        }

        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine(musteri.FirstName+""+ musteri.LastName+""+ "başarıyla güncellendi");
        }
    }
}
