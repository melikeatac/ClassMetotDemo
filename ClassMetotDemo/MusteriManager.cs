using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi..  "+musteri.Name+" "+musteri.Surname);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi..  " + musteri.Name + " " + musteri.Surname);
        }
        public void Listele(Musteri[]musteriler)
        {
            Console.WriteLine("Musteri Listesi");
            foreach(var kisi in musteriler)
            {
                Console.WriteLine(kisi.Name+" "+kisi.Surname);
            }
        }
    }
}
