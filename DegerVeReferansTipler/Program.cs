﻿using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            //sayi1=30
            sayi2 = 65;

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;
            //sayilar1 = 999;
            sayilar2[0] = 999;

            //int değer tip bellekte stackte gerçekleşir
            //array referans tip heapte gerçekleşir

        } 
    }
}
