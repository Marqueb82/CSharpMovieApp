using System;
using System.Collections.Generic;

namespace MovieApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserGo;

            do
            {
                List<Movie> movies = new List<Movie>();

                for (int i = 0; i < 101; i++)
                {
                    movies.Add(MovieIO.GetMovie(i));
                }

                Console.WriteLine("What type of film are you looking for???");
                string choice = Console.ReadLine();

                foreach (Movie movie in movies.FindAll(e => (e.Category == choice)))
                {
                    Console.WriteLine(movie.Title);
                }


                Console.WriteLine("\nWhat film do you want???");
                choice = Console.ReadLine();

                if (movies.Exists(e => e.Title == choice))
                {
                    Console.WriteLine("Yes, it is in the list");
                }
                else
                {
                    Console.WriteLine("Sorry, film not in list");
                }

                Console.WriteLine("\nContinue....yes or no");
                UserGo = Console.ReadLine();

            } while (UserGo.Equals("yes"));


            Console.ReadKey();
        }
    }
}
