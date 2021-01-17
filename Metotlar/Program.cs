using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            //type-safe -- tip güvenliği
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("------metotlar--------");
            //instance - örnek 
            //encapsulation

            SepetManager sepetmanager = new SepetManager(); //metodu çağır ve tanımla
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);
            
            //sepetManager.Ekle2("armut", "yeşil armut", 12, 10);
            //sepetManager.Ekle2("muz", "çikita", 20, 7);
            
        }
    }
}

//do not repeat yourself - DRY - Clean Code - Best Practice
