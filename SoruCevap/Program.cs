using System;
namespace Milyoner
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogruCevapSayisi = 0;

            // Birinci Soru
            Console.WriteLine("1 -> Hangi üklenin 3 başkenti vardır ?");
            Console.WriteLine("a) Güney afrika   b) Senegal");
            Console.Write("Cevabınızı giriniz (A veya B): ");
            string cevap1 = Console.ReadLine().ToLower();

            // Verilen cevaba göre doğruluğu kontrol ediyoruz.
            if (cevap1 == "a")
            {
                Console.WriteLine("Doğru!");
                dogruCevapSayisi++;
            }
            else
            {
                Console.WriteLine("Yanlış!");
            }

            // İkinci Soru
            Console.WriteLine("\n2 -> Samanyolu galaksisine en yakın galaksi hangisidir ?");
            Console.WriteLine("a) Andromeda   b) M33");
            Console.Write("Cevabınızı giriniz (A veya B): ");
            string cevap2 = Console.ReadLine().ToLower();

            // Verilen cevaba göre doğruluğu kontrol ediyoruz.
            if (cevap2 == "a")
            {
                Console.WriteLine("Doğru!");
                dogruCevapSayisi++;
            }
            else
            {
                Console.WriteLine("Yanlış!");
            }

            // Kullanıcı ilk 2 soruyu doğru cevaplarsa, 3. soruyu sormuyoruz.
            if (dogruCevapSayisi < 2)
            {
                // Üçüncü Soru
                Console.WriteLine("\nBir yıl kaç saattir ?");
                Console.WriteLine("a) 87,6581,271   b) 87,6581,277");
                Console.Write("Cevabınızı giriniz (A veya B): ");
                string cevap3 = Console.ReadLine().ToLower();

                // Verilen cevaba göre doğruluğu kontrol ediyoruz.
                if (cevap3 == "b")
                {
                    Console.WriteLine("Doğru!");
                    dogruCevapSayisi++;
                }
                else
                {
                    Console.WriteLine("Yanlış!");
                }
            }

            // Final Kontrolü
            if (dogruCevapSayisi >= 2)
            {
                Console.WriteLine($"\nTebrikler! {dogruCevapSayisi} soruyu doğru cevapladınız, 1 Milyon TL'lik büyük ödülü kazandınız!");
            }
            else
            {
                Console.WriteLine($"\nÜzgünüz, yeterli sayıda doğru cevap veremediniz. Büyük ödülü kazanamadınız.");
            }

            Console.ReadLine(); // Konsolun kapanmaması için bekletme
        }


    }
}

