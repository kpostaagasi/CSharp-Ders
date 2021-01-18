using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 10567;
            musteri1.AD = "Ahmet";
            musteri1.SOYAD = "Hanoğlu";

            Musteri musteri2 = new Musteri();
            musteri2.ID = 12543;
            musteri2.AD = "Buğra";
            musteri2.SOYAD = "Tandoğan";

            Musteri musteri3 = new Musteri();
            musteri3.ID = 12456;
            musteri3.AD = "Mehmet";
            musteri3.SOYAD = "Çetin";

            MusteriManager.MusteriEkle(musteri1);
            MusteriManager.MusteriListele(musteri2);
            MusteriManager.MusteriSil(musteri3);
        }
    }
    class Musteri
    {
        public int ID { get; set; }
        public string AD { get; set; }
        public string SOYAD { get; set; }
    }
    class MusteriManager
    {
        public static void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.AD + " " + musteri.SOYAD + " sisteme eklendi.");
        }
        public static void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi: " + musteri.ID + " " + musteri.AD + " " + musteri.SOYAD);
        }
        public static void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.AD + " " + musteri.SOYAD + " sistemden silindi.");
        }
    }
}
