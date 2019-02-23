using System;

namespace MovieApp.NewDb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MovieContext())
            {
                Console.WriteLine("enter the movie title");
                string title = Console.ReadLine();
                Console.WriteLine("enter the movie year");
                string year = Console.ReadLine();
                Console.WriteLine("enter the movie category_name");
                string category_name = Console.ReadLine();
                db.Movies.Add(new Movietbl { title =title });
                db.Movies.Add(new Movietbl { year = year });
                db.Movies.Add(new Movietbl { category_name = category_name });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var Movietbl in db.Movies)
                {
                    Console.WriteLine(" - {0}{1}{2}", Movietbl.title, Movietbl.year, Movietbl.category_name);
                }
            }
        }
    }
}