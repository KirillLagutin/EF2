using System;
using System.Linq;
using EF2.DB_Lib;

namespace EF2.TestApp
{
    class Program
    {
        static void Main()
        {
            var db = new BookStoreDb();

            foreach (var a in db.TabAuthors.ToList())
            {
                Console.WriteLine($"#{a.Id}: {a.LastName} {a.FirstName}");

                foreach (var book in a.TabBooks.ToList())
                {
                    Console.WriteLine($"\t#{book.Id}: {book.Title} {book.YearOfCreation}");
                }
            }
        }
    }
}