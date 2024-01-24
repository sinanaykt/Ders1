using System;

namespace ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            urun urun1 = new urun();

            urun1.urunAdi = "yazici";
            urun1.urunFiyati = 2000;
            urun1.urunMarkasi = "hp";
            urun1.urunkategori = "teknoloji";

            urun urun2 = new urun();

            urun2.urunAdi = "laptop";
            urun2.urunFiyati = 19000;
            urun2.urunMarkasi = "acer";
            urun2.urunkategori = "teknoloji";

            urun urun3 = new urun();

            urun3.urunAdi = "telefon";
            urun3.urunFiyati = 81000;
            urun3.urunMarkasi = "iphone";
            urun3.urunkategori = "teknoloji";

            urun[] urunler = new urun[] { urun1, urun2, urun3 };

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].urunAdi);
                Console.WriteLine(urunler[i].urunFiyati);
                Console.WriteLine(urunler[i].urunkategori);
                Console.WriteLine(urunler[i].urunMarkasi);
            }

            int a = 0;
            while(a < urunler.Length)
            {
                Console.WriteLine(urunler[a].urunAdi);
                Console.WriteLine(urunler[a].urunFiyati);
                Console.WriteLine(urunler[a].urunkategori);
                Console.WriteLine(urunler[a].urunMarkasi);
                a++;
            }

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.urunAdi);
                Console.WriteLine(urun.urunFiyati);
                Console.WriteLine(urun.urunkategori);
                Console.WriteLine(urun.urunMarkasi);
            }




        }
    }
    class urun
    {
        public string urunAdi { get; set; }
        public int urunFiyati { get; set; }
        public string urunkategori { get; set; }
        public string urunMarkasi { get; set; }
    }





}
