using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTwo
{
    class Singer
    {
        //Şarkıcıların özellikleri
        public string FullName { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public int RecordSales { get; set; }
        //Şarkıcıların özelliklerini yazdırma
        public override string ToString()
        {
            return $"FullName: {FullName}, Genre: {Genre}, ReleaseYear: {ReleaseYear},RecordsSale: {RecordSales}";
        }
    }
  
    public class Program
    {
        static void Main(string[] args)
        {
            //Şarkıcılar listesi
            var singer = new List<Singer>
            {

            new Singer { FullName = "Ajda Pekkan", Genre = "Pop", ReleaseYear = 1968, RecordSales = 20000000 },
            new Singer { FullName = "Sezen Aksu", Genre = "Türk Halk Müziği / Pop", ReleaseYear = 1971, RecordSales = 10000000 },
            new Singer { FullName = "Funda Arar", Genre = "Pop", ReleaseYear = 1999, RecordSales = 3000000 },
            new Singer { FullName = "Sertab Erener", Genre = "Pop", ReleaseYear = 1994, RecordSales = 5000000 },
            new Singer { FullName = "Sıla", Genre = "Pop", ReleaseYear = 2009, RecordSales = 3000000 },
            new Singer { FullName = "Serdar Ortaç", Genre = "Pop", ReleaseYear = 1994, RecordSales = 10000000 },
            new Singer { FullName = "Tarkan", Genre = "Pop", ReleaseYear = 1992, RecordSales = 40000000 },
            new Singer { FullName = "Hande Yener", Genre = "Pop", ReleaseYear = 1999, RecordSales = 7000000 },
            new Singer { FullName = "Hadise", Genre = "Pop", ReleaseYear = 2005, RecordSales = 5000000 },
            new Singer { FullName = "Gülben Ergen", Genre = "Pop / Türk Halk Müziği", ReleaseYear = 1997, RecordSales = 10000000 },
            new Singer { FullName = "Neşet Ertaş", Genre = "Türk Halk Müziği / Türk Sanat Müziği", ReleaseYear = 1960, RecordSales = 2000000 }

            };
            // Adı 'S' ile başlayan şarkıcılar
            Console.WriteLine("Adı 'S' ile başlıyan şarkıcılar: ");
            var sSinger = singer.Where(s => s.FullName.StartsWith("S")).ToList();
            sSinger.ForEach(s => Console.WriteLine(s.FullName));
            // Albüm satışları 10 milyonun üzerinde olan şarkıcılar
            Console.WriteLine("\nAlbüm satışları 10 milyon'un üzerinde olan şarkıcılar");
            var recordSales = singer.Where(s => s.RecordSales > 10000000).ToList();
            recordSales.ForEach(s => Console.WriteLine($"{s.FullName} , {s.RecordSales}"));
            // 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar (Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırma)
            Console.WriteLine("\n2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. ( Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırınız.");
            var popSinger = singer.Where(s => s.ReleaseYear < 2000 && s.Genre == "Pop").OrderBy(s => s.FullName).ToList();
            popSinger.ForEach(s => Console.WriteLine($"{s.FullName} , {s.Genre} , {s.ReleaseYear}"));
            // En çok albüm satan şarkıcı
            Console.WriteLine("\nEn çok albüm satan şarkıcı");
            var mostRecordSales = singer.OrderByDescending(s => s.RecordSales).First();
            Console.WriteLine($"{mostRecordSales.FullName} , {mostRecordSales.RecordSales}");
            // En yeni çıkış yapan ve en eski çıkış yapan şarkıcılar
            Console.WriteLine("\nEn yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı");
            var newestSinger = singer.OrderByDescending(s => s.ReleaseYear).First();
            var oldestSinger = singer.OrderBy(s => s.ReleaseYear).First();
            Console.WriteLine("En yeni çıkış yapan şarkıcı: " + newestSinger.FullName);
            Console.WriteLine("En eski çıkış yapan şarkıcı: " + oldestSinger.FullName);

            Console.ReadKey();
        }
    }
}
