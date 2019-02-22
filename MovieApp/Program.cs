using System;

namespace MovieApp.NewDb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MovieContext())
            {
                db.Movies.Add(new Movietbl { title = "Vimpire diaries" });
                db.Movies.Add(new Movietbl { year = "2019" });
                db.Movies.Add(new Movietbl { category_name = "horror Movie" });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var Movietbl in db.Movies)
                {
                    Console.WriteLine(" - {0}", Movietbl.title, Movietbl.year, Movietbl.category_name);
                }
            }
        }
    }
}