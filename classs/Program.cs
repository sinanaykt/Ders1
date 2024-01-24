namespace classs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            kurs kurs1 = new kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "sinan aykut";
            kurs1.İzlenmeOrani = 72;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "sinan aykut";
            kurs2.İzlenmeOrani = 80;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "html";
            kurs3.Egitmen = "sinan aykut";
            kurs3.İzlenmeOrani = 90;


            // Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ": " + kurs.Egitmen);
                Console.WriteLine(kurs.İzlenmeOrani);
            }



        }
    }

    class kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }

    }



}
