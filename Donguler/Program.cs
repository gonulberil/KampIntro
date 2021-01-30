using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım";
            string kurs2 = "Programlama";
            string kurs3 = "Java";

            //array=dizi

            string[] kurslar = new string[] { kurs1, kurs2, kurs3};

            for (int i = 0; i < kurslar.Length; i++)//i=i+2)
            {
                Console.WriteLine(kurslar[i]);


                //    foreach (string kurs in kurslar)
                //    {
                //        Console.WriteLine(kurs);
                //    }
                //    Console.WriteLine("sayfa sonu-footer");
            }
        }
    }
}
