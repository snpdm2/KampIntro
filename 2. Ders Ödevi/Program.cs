using System;

namespace _2._Ders_Ödevi
{
    class Program
    {
        static void Main(string[] args)
        {


            Product urun1 = new Product();

            urun1.MalzemeAdi = "Bileklik";
            urun1.MalzemeFiyatı = 20;
            urun1.MalzemePuani = 5;

            Product urun2 = new Product();

            urun2.MalzemeAdi = "Ayakkabı";
            urun2.MalzemeFiyatı = 200;
            urun2.MalzemePuani = 4;
            
            Product urun3 = new Product();

            urun3.MalzemeAdi = "Kolye";
            urun3.MalzemeFiyatı = 3;
            urun3.MalzemePuani = 3;

            Product urun4 = new Product();

            urun4.MalzemeAdi = "Zeynep yazılı kolye";
            urun4.MalzemeFiyatı = 999999999;
            urun4.MalzemePuani = 5;




            Product[] Malzemeler = new Product[] {urun1, urun2, urun3, urun4 };

            //foreach (var malzo in Malzemeler)
            //{
            //Console.WriteLine(malzo.MalzemeAdi + "(" + malzo.MalzemePuani + ")" + " : " + malzo.MalzemeFiyatı+ " tl ");

            //}


            for (int i = 0; i < Malzemeler.Length; i++)
            {
                Console.WriteLine(Malzemeler[i]);
            }







        }


    }


    class Product
    {
        public string MalzemeAdi { get; set; }
        public int MalzemeFiyatı { get; set; }
        public int MalzemePuani { get; set; }


    }
}