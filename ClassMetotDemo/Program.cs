using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.FirstName = "Enis";
            musteri1.LastName = "Emir";
            musteri1.TcNo = "12345678910";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.FirstName = "Okan";
            musteri2.LastName = "Kaylan";
            musteri2.TcNo = "12345678911";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.FirstName = "Ahmet";
            musteri3.LastName = "Efe";
            musteri3.TcNo = "12345678912";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.FirstName = "Muzaffer";
            musteri4.LastName = "Deniz";
            musteri4.TcNo = "12345678913";

            Musteri[] musteriler = { musteri1, musteri2, musteri3, musteri4};

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkleme(musteri1);
            musteriManager.MusteriSilme(musteri2);
            musteriManager.MusteriListele(musteriler);
        }
    }
}
