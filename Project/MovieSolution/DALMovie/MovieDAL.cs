using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace DALMovie
{
    public class MovieDAL
    {
        string constr = @"server=.\sqlexpress;initial catalog=dbsep06;integrated security =true";
        public static List<Movie> movies = new List<Movie>()
        {
            new Movie{Id=1,Name="Vikram",Year=2022,Rating=4},
            new Movie{Id=2,Name="War",Year=2019,Rating=4},
            new Movie{Id=3,Name="Heropanti",Year=2022,Rating=1},
            new Movie{Id=4,Name="Ludo",Year=2020,Rating=3},
            new Movie{Id=5,Name="Bhuj",Year=2021,Rating=2},
            new Movie{Id=6,Name="Toofan",Year=2021,Rating=2},
            new Movie{Id=7,Name="Rashmi Rocket",Year=2022,Rating=3}
        };
        public bool EditMovie(Movie movie)  // id=3,name=Hero,year=2019,rating=3
        {
            bool editmovie = false;
            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].Id == movie.Id)
                {
                    movies[i].Name = movie.Name;
                    movies[i].Year = movie.Year;
                    movies[i].Rating = movie.Rating;
                    editmovie = true;
                    break;

                }
            }
            return editmovie;
        }
        public bool AddMovie(Movie movie)
        {
            bool movieadd = false;
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("insert into movies values (@id,@name,@year,@rating)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", movie.Id);
                cmd.Parameters.AddWithValue("@name", movie.Name);
                cmd.Parameters.AddWithValue("@year", movie.Year);
                cmd.Parameters.AddWithValue("@rating", movie.Rating);
                int x = cmd.ExecuteNonQuery();
                movieadd = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return movieadd;
            #region using database

            #endregion
            #region using static data
            /*
            bool movieadd = false;
            try
            {
                movies.Add(movie);
                movieadd = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return movieadd;
            */
            #endregion
        }
        public Movie FindMovie(int id)
        {
            #region using database
            Movie movie = new Movie();
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("select * from movies where id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    movie.Id = Convert.ToInt32(reader["id"]);
                    movie.Name = reader["name"].ToString();
                    movie.Year = Convert.ToInt32(reader["year"]);
                    movie.Rating = Convert.ToInt32(reader["rating"]);
                }
                else
                    throw new Exception($"Movie with {id} not present");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return movie;
            #endregion
            #region  using static collection
            /* 
            Movie movie = null;
            try
            {
                movie = movies.Where(m => m.Id == id).FirstOrDefault();
                if (movie == null)
                {
                    throw new Exception($"Movie with {id} is not present");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return movie;
            */
            #endregion
        }
        public List<Movie> GetMovies()
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from movies", con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Movie> movies = new List<Movie>();
            while (reader.Read())
            {
                Movie movie = new Movie();
                movie.Id = Convert.ToInt32(reader["id"]);
                movie.Name = reader["name"].ToString();
                movie.Year = Convert.ToInt32(reader["year"]);
                movie.Rating = Convert.ToInt32(reader["rating"]);
                movies.Add(movie);
            }

            return movies;
        }
        public bool DeleteMovie(int id)
        {
            bool moviedeleted = false;
            try
            {
                Movie movie = movies.Where(m => m.Id == id).FirstOrDefault();
                if (movie != null)
                {
                    movies.Remove(movie);
                    moviedeleted = true;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return moviedeleted;
        }
    }

}
