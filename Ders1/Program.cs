using System.Reflection;

namespace Ders1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string KategoriEtiketi = "kategori";
             int sayi = 2300;
             double rakam= 9.39;
             bool SistemeGirişYapmışMı = true;
             double DolarDun = 29.45;
             double DolarBugun = 29.85;

             if(DolarBugun > DolarDun) 
             {
                 Console.WriteLine("artış butonu");
             }
             else if(DolarBugun < DolarDun)
             {
                 Console.WriteLine("azalış butonu");
             }
             else
             {
                 Console.WriteLine("sabit butonu");
             }

             if (SistemeGirişYapmışMı == true)
             {
                 Console.WriteLine("kullanıcı ayarları butonu");
             }
             else
             {
                 Console.WriteLine("giriş yap butonu");
             }

            Console.WriteLine(KategoriEtiketi);
             Console.WriteLine(sayi);
             Console.WriteLine(rakam);*/

            // int yas = 20; string sonuc = (yas >= 18) ? "Ergenlik döneminin sonuna geldiniz!" : "Ergenlik dönemine henüz ulaşmadınız."; Console.WriteLine(sonuc);


            int sayi;

            Console.WriteLine("sayi gir");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayi);

            switch (sayi) 
            {
                case 1:
                    Console.WriteLine("pazartesi"); break;
                    case 2:
                    Console.WriteLine("salı"); break;
                    case 3:
                    Console.WriteLine("çarşamba"); break;
                    case 4:
                    Console.WriteLine("perşembe"); break;
                    case 5:
                    Console.WriteLine("cuma"); break;
                    case 6:
                    Console.WriteLine("cumartesi"); break;
                    case 7:
                    Console.WriteLine("pazar"); break;
                    default: Console.WriteLine("yanlış giriş"); break;
            }

           

        }
    }
}
