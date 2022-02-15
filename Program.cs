using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            // 1 den başlayarak consoledan girilen sayı kadar (sayı dahil) ortalama hesaplama 
            Console.WriteLine("Bir sayı giriniz");
            int sayı = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while(sayac <= sayı)
            {
                toplam += sayac;
                sayac ++;
            }
            Console.WriteLine(toplam/sayı);

            // 'a' dan 'z' ye kadar tüm harfleri console yazdır
            char karakter = 'a';
            while (karakter <= 'z')
            {
               Console.Write(karakter);
               karakter ++; 
            }
            Console.WriteLine("***Foreach***");
            string[] arabalar = {"BMW","FORD","TOYATA","NİSSAN"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
