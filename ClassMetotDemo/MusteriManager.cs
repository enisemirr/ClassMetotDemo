using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Id +" ID'li "+ musteri.FirstName + " " + musteri.LastName + " başarıyla sisteme eklenmiştir.");
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " ID'li " + musteri.FirstName + " " + musteri.LastName + " başarıyla sistemden silinmiştir.");
        }
        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id +" "+ musteri.FirstName + " " + musteri.LastName);
            }
        }
    }
}
