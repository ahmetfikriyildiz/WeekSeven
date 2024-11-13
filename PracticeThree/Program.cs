using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeThree
{
    class Show
    {
        public string ShowName { get; set; }
        public string ShowType { get; set; }
        public int ShowYear { get; set; }
        public int ShowReleaseYear { get; set; }
        public string Director { get; set; }
        public string PublishedPlatform { get; set; }
    }

    // Yeni listede yalnızca Dizi Adı, Dizi Türü ve Yönetmen bilgilerini tutacak olan ComedyShow sınıfı
    class ComedyShow : Show
    {

        public ComedyShow(string showName, string showType, string director)
        {
            ShowName = showName;
            ShowType = showType;
            Director = director;
        }

        public override string ToString()
        {
            return $"Dizi Adı: {ShowName}, Tür: {ShowType}, Yönetmen: {Director}";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var shows = new List<Show>();
            string addAnother;

            // Kullanıcıdan dizi bilgilerini alma ve listeye ekleme
            do
            {
                Console.WriteLine("Yeni bir dizi eklemek için aşağıdaki bilgileri giriniz.");

                Console.Write("Dizi Adı: ");
                string showName = Console.ReadLine();

                Console.Write("Dizi Türü: ");
                string showType = Console.ReadLine();

                Console.Write("Dizi Çıkış Yılı: ");
                int showYear = int.Parse(Console.ReadLine());

                Console.Write("Yayın Yılı: ");
                int showReleaseYear = int.Parse(Console.ReadLine());

                Console.Write("Yönetmen: ");
                string director = Console.ReadLine();

                Console.Write("Yayın Platformu: ");
                string publishedPlatform = Console.ReadLine();

                // Dizi nesnesini listeye ekle
                shows.Add(new Show
                {
                    ShowName = showName,
                    ShowType = showType,
                    ShowYear = showYear,
                    ShowReleaseYear = showReleaseYear,
                    Director = director,
                    PublishedPlatform = publishedPlatform
                });

                // Kullanıcıya başka bir dizi ekleyip eklemeyeceğini sorma
                Console.Write("Başka bir dizi eklemek istiyor musunuz? (e/h): ");
                addAnother = Console.ReadLine()?.ToLower();

            } while (addAnother == "e");

            // Komedi türündeki dizilerden yeni bir liste oluşturma ve sıralı yazdırma
            Console.WriteLine("\nKomedi türündeki diziler: ");
            var comedyShows = shows
                .Where(s => s.ShowType.ToLower().Contains("komedi")) 
                .Select(s => new ComedyShow(s.ShowName, s.ShowType, s.Director))
                .OrderBy(s => s.ShowName)
                .ThenBy(s => s.Director)
                .ToList();

            // Yeni listenin elemanlarını ekrana yazdırma
            comedyShows.ForEach(s => Console.WriteLine(s));

            Console.ReadKey();
        }
    }
}
