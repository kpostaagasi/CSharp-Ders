using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(12345, "Kamil Postaağası", "Erkek", 16);
            musteriManager.Ekle(12346, "Mehmet Çetin", "Erkek", 18);
            musteriManager.Ekle(12347, "Ahmet Öksüz", "Erkek", 54);
            musteriManager.Ekle(12348, "Yaren Kurtulan", "Kadın", 36);
            musteriManager.Ekle(12349, "Tülin Özer", "Kadın", 42);

            musteriManager.Sil(12349);
            musteriManager.Listele();
        }
    }
}
