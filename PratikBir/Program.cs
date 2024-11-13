using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratikBir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rastgele 10 sayıdan oluşan bir liste oluşturma
            Random rnd = new Random();
            List<int> sayilar = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                sayilar.Add(rnd.Next(0,100)); // 0 ile 100 arasında rastgele sayılar ekleniyor
            }

            // Listeyi ekrana yazdırma
            Console.WriteLine("Orijinal Liste:");
            sayilar.ForEach(s => Console.WriteLine(s));

            // Çift olan sayılar
            var ciftSayilar = sayilar.Where(s => s % 2 == 0).ToList();
            Console.WriteLine("\nÇift Olan Sayılar:");
            foreach (var s in ciftSayilar)
            {
                Console.WriteLine(s);
            }

            // Tek olan sayılar
            var tekSayilar = sayilar.Where(s => s % 2 != 0).ToList();
            Console.WriteLine("\nTek Olan Sayılar:");
            tekSayilar.ForEach(s => Console.WriteLine(s));

            // Negatif sayılar
            var negatifSayilar = sayilar.Where(s => s < 0).ToList();
            Console.WriteLine("\nNegatif Sayılar:");
            foreach (var s in negatifSayilar)
            {
                Console.WriteLine(s);
            }

            // Pozitif sayılar
            var pozitifSayilar = sayilar.Where(s => s > 0).ToList();
            Console.WriteLine("\nPozitif Sayılar:");
            pozitifSayilar.ForEach(s => Console.WriteLine(s));  

            // 15'ten büyük ve 22'den küçük sayılar
            var aralikSayilar = sayilar.Where(s => s > 15 && s < 22).ToList();
            Console.WriteLine("\n15'ten Büyük ve 22'den Küçük Sayılar:");
            foreach (var s in aralikSayilar)
            {
                Console.WriteLine(s);
            }

            // Listedeki her bir sayının karesi (Yeni liste)
            var kareler = sayilar.Select(s => s * s).ToList();
            Console.WriteLine("\nListedeki Her Bir Sayının Karesi:");
            kareler.ForEach(s => Console.WriteLine(s));

            Console.ReadKey();
        }
    }
}
