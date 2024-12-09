using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLMovie;
using EntityLayer;
namespace MovieApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                DisplayMenu();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: GetAllMovies(); break;
                    case 2: FindMovie(); break;
                    case 3: AddMovie(); break;
                    case 4: EditMovie(); break;
                    case 5: DeleteMovie(); break;
                    default: break;
                }

            } while (choice != 0);
        }

        private static void DeleteMovie()
        {
            try
            {
                Console.WriteLine("Enter Movie to Delete");
                int id = Convert.ToInt32(Console.ReadLine());
                MovieBL movieBL = new MovieBL();
                Movie movie = movieBL.FindMovieBL(id);
                if (movie != null)
                {
                    Console.WriteLine($"{movie.Id} {movie.Name} {movie.Year} {movie.Rating}");
                    Console.WriteLine("Do U want to delete this movie ?");
                    string ch=Console.ReadLine();
                    if(ch.CompareTo("y")==0)
                    {
                        bool deletedmovie=movieBL.DeleteMovieBL(id);
                        if(deletedmovie)
                            Console.WriteLine("Movie Deleted");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void EditMovie()
        {
            int id;
            try
            {
                Console.WriteLine("Enter Movie id to edit :");
                id = Convert.ToInt32(Console.ReadLine());
                MovieBL movieBL = new MovieBL();
                Movie movie = movieBL.FindMovieBL(id);
                if (movie != null)
                {
                    Console.WriteLine($"Movie Name is {movie.Name}");
                    movie.Name = Console.ReadLine();
                    Console.WriteLine($"Year is {movie.Year}");
                    movie.Year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Rating is {movie.Rating}");
                    movie.Rating = Convert.ToInt32(Console.ReadLine());
                    bool movieedit = movieBL.EdMovieBl(movie);
                    if (movieedit)
                        Console.WriteLine("Movie Updated");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void AddMovie()
        {
            Console.Clear();
            Movie movie = new Movie();
            try
            {
                Console.WriteLine("Enter Movie Id");
                movie.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Movie Name");
                movie.Name = Console.ReadLine();
                Console.WriteLine("Enter Year");
                movie.Year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Rating 1 to 5");
                movie.Rating = Convert.ToInt32(Console.ReadLine());
                MovieBL movieBL = new MovieBL();
                bool movieadded = movieBL.AddMovieBL(movie);
                if (movieadded)
                    Console.WriteLine("Movie Added");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        private static void FindMovie()
        {
            Console.WriteLine("Enter Movie Id :");
            int id = Convert.ToInt32(Console.ReadLine());
            try
            {
                MovieBL movieBL = new MovieBL();
                Movie movie = movieBL.FindMovieBL(id);
                if (movie != null)
                {
                    Console.WriteLine("===================================");
                    Console.WriteLine($"{movie.Id}  {movie.Name}  {movie.Year}  {movie.Rating}");
                    Console.WriteLine("===================================");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        private static void GetAllMovies()
        {
            Console.Clear();
            MovieBL movieBL = new MovieBL();
            List<Movie> movies = movieBL.GetMoviesBL();
            if (movies != null)
            {
                foreach (Movie m in movies)
                {
                    Console.WriteLine($"{m.Id}\t {m.Name,-20} {m.Year,10} {m.Rating,10}");
                }
            }
            else
            { Console.WriteLine("No Movies Present"); }
            Console.ReadLine();
        }

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("************ Movie Application **********");
            Console.WriteLine("\t\t1. List All Movies");
            Console.WriteLine("\t\t2. Search for Movie");
            Console.WriteLine("\t\t3. Add Movie");
            Console.WriteLine("\t\t4. Edit Movie");
            Console.WriteLine("\t\t5. Delete Movie");
            Console.WriteLine("\t\t0. Exit");
        }
    }
}
