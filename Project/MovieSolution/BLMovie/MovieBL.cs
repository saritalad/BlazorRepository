using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DALMovie;
namespace BLMovie
{
    public class MovieBL
    {
        public List<Movie> GetMoviesBL()
        {
            MovieDAL movieDAL = new MovieDAL();
            return movieDAL.GetMovies();
        }
        public Movie FindMovieBL(int id)
        {
            Movie movie = null;
            try
            {
                if (id < 0)
                {
                    throw new Exception($"{id} is negative");
                }
                MovieDAL movieDAL = new MovieDAL();
                movie = movieDAL.FindMovie(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return movie;
        }
        public bool ValidateMovie(Movie movie)
        {
            bool validmovie = true;
            StringBuilder sb = new StringBuilder();
            if (movie.Id < 0)
            {
                validmovie = false;
                sb.Append(Environment.NewLine + "Id cannot be -ve");
            }
            if (movie.Name.Length == 0)
            {
                validmovie = false;
                sb.Append(Environment.NewLine + "Name cannot be blank");
            }
            if (movie.Year > DateTime.Now.Year)
            {
                validmovie = false;
                sb.Append(Environment.NewLine + $"Year should be <= {DateTime.Now.Year}");
            }
            if (movie.Rating < 1 || movie.Rating > 5)
            {
                validmovie = false;
                sb.Append(Environment.NewLine + "Rating should be 1 and 5");
            }
            if (validmovie == false)
            {
                throw new Exception(sb.ToString());
            }
            return validmovie;
        }
        public bool AddMovieBL(Movie movie)
        {
            bool movieadd = false;
            try
            {
                if (ValidateMovie(movie))
                {
                    MovieDAL movieDAL = new MovieDAL();
                    movieadd = movieDAL.AddMovie(movie);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return movieadd;
        }
        public bool EdMovieBl(Movie movie)
        {
            bool editmovie = false;
            try
            {
                if (ValidateMovie(movie))
                {
                    MovieDAL movieDAL = new MovieDAL();
                    editmovie = movieDAL.EditMovie(movie);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return editmovie;
        }
        public bool DeleteMovieBL(int id)
        {
            bool deletedmovie = false; ;
            try
            {
                if (id > 0)
                {
                    MovieDAL movie = new MovieDAL();
                    deletedmovie = movie.DeleteMovie(id);

                }
                else
                {
                    throw new Exception("Invalid Id");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return deletedmovie;
        }
    }
}
