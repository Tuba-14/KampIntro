using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety-tip güvenliği
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOanı = 1.45;
            bool sistemeGirisYapmişMi = false;
            double dolarDun = 7.35;
            double dolarBugün = 7.45;

            if (dolarDun>dolarBugün)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugün)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
            if (sistemeGirisYapmişMi==true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
