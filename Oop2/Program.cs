using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //engin demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "engin";
            musteri1.Soyadi = "demiroğ";
            musteri1.TcNo = "1234567890";

            //kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "kodlamaio";
            musteri2.VergiNo = "987654321";

            //gerçek müşteri - tüzel müşteri (birbirinin yerine kullanılamazlar)
            //solid prensiplerine göre bu kural vardır.

            Musteri musteri3 = new GercekMusteri(); //new görürsen referans numarasında tutulur demek
            Musteri musteri4 = new TuzelMusteri();  //musteri hem gerçek hem de tüzel müsteri referansını tutar

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);



        }
    }
}
