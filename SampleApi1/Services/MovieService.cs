using SampleApi1.Models;
using SampleApi1.Repositories;

namespace SampleApi1.Services
{
    public class MovieService : IMovieService
    {
        public Movie Create(Movie movie)
        {
            movie.Id = MovieRepository.Movies.Count + 1;
            MovieRepository.Movies.Add(movie);
            return movie;
        }

        public bool Delete(int id)
        {
            var oldMovie = MovieRepository.Movies.FirstOrDefault(x => x.Id == id);

            if (oldMovie != null)  return false;

            MovieRepository.Movies.Remove(oldMovie);
            return true;
        }

        public Movie Get(int id)
        {
            var movie = MovieRepository.Movies.FirstOrDefault(x => x.Id == id);
            
            if (movie is null) return null;
            
            return movie;
        }

        public List<Movie> List()
        {
            var movies = MovieRepository.Movies;
            return movies;
        }

        public Movie Update(Movie movie)
        {
            var oldMovie = MovieRepository.Movies.FirstOrDefault(x => x.Id == movie.Id);

            if (oldMovie is null) return null;

            oldMovie.Title = movie.Title;
            oldMovie.Description = movie.Description;
            oldMovie.Rating = movie.Rating;

            return movie;
        }
    }
}
