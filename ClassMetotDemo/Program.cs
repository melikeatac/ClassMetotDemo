using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Name = "Melike";
            musteri1.Surname = "Ataç";
            Musteri musteri2 = new Musteri();
            musteri2.Name = "Beyza";
            musteri2.Surname = "Yanar";
            Musteri[] musteriListesi = new Musteri[] { musteri1, musteri2 };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteriListesi);

        
        }

    }
}
