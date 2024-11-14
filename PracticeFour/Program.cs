using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFour
{
    class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
    }
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; } // Yazarla ilişkiyi sağlamak için yabancı anahtar
    }
    public class Program
    {
        static void Main(string[] args)
        {
            // Yazarlar tablosuna örnek veriler ekleme
            var authors = new List<Author>
            {
                new Author {AuthorId = 1, Name = "Orhan Pamuk"},
                new Author {AuthorId = 2, Name = "Elif Şafak"},
                new Author {AuthorId = 3, Name = "Ahmet Ümit"}
            };
            // Kitaplar tablosuna örnek veriler ekleme
            var books = new List<Book>
            {
                new Book {BookId = 1, Title = "Kar", AuthorId = 1},
                new Book {BookId = 2, Title ="İstanbul", AuthorId = 1},
                new Book {BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId = 2},
                new Book {BookId = 4, Title = "BeyOğlu Rapsodisi", AuthorId = 3},
            };
            // LINQ join sorgusu ile kitapları ve yazarları birleştirme
            var bookAuthors = from book in books
                              join author in authors on book.AuthorId equals author.AuthorId
                              select new
                              {
                                  BookTitle = book.Title,
                                  AuthorName = author.Name
                              };
            // Sonuçları ekrana yazdırma
            Console.WriteLine("Kitaplar ve Yazarları:");
            foreach (var bookAuthor in bookAuthors)
            {
                Console.WriteLine($"Kitap Başlığı: {bookAuthor.BookTitle} - Yazar: {bookAuthor.AuthorName}");
            }

            Console.ReadKey();
        }
    }
}
