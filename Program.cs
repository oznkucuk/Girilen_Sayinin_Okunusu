using System;

namespace girilen_sayinin_okunusu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Girilen Sayının Okunuşu");
            // Kullanıcının girdiği sayıyı yazıya çeviren programı yazınız.
            // Girilen sayı 0 ile 1000 (dahil) arasında olması istenecek. Daha büyük sayı girilirse uyarı verilecek ve
            // program sonlandıracak.

            // Örnek giriş-çıkış'lar:
            // giriş: 123
            // çıkış: Yüz Yirmi Üç

            // giriş: 2111
            // çıkış: 0-1000 arası değer giriniz

            // Not: Kullanıcın sayı değeri girdiği varsayılacak.

           Console.WriteLine("Girdiğiniz sayı yazıya çevirilecek..");


            Console.Write("Sayı giriniz:");
            int girdi = Convert.ToInt32(Console.ReadLine());
            if (girdi>1000) {
                Console.WriteLine("1000'den küçük bir sayı giriniz");
                Console.Write("Programı yenileyin..");
    
                }
            else
            {
    

            string [] birler = {"","bir","iki","üç","dört","beş","altı","yedi","sekiz","dokuz"};
            string [] onlar = {"","on","yirmi","otuz","kırk","elli","altmış","yetmiş","seksen","doksan"};
            string [] yuzler = {"","yüz","ikiyüz","üçyüz","dörtyüz","beşyüz","altıyüz","yediyüz","sekizyüz","dokuzyüz"};

            int birbas; // == ((girdi / 100) % 10);
            int onbas; // == 
            int yuzbas;

            birbas = (girdi%10);
            onbas = ((girdi/10)%10);
            yuzbas = (girdi/100);

            Console.Write(yuzler[yuzbas] );
            Console.Write(onlar[onbas] );
            Console.Write(birler[birbas]);


            }

          
        }
        
    }
}
