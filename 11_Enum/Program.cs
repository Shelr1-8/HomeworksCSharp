using System;
using System.Collections;
using System.Collections.Generic;

namespace _11_Enum
{
    public enum Genre
    {
        Action,
        Comedy,
        Drama,
        Horror,
        Documentary
    }

    public class Director : ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }

        public Director(string firstName, string lastName, string country)
        {
            FirstName = firstName;
            LastName = lastName;
            Country = country;
        }

        public object Clone()
        {
            return new Director(this.FirstName, this.LastName, this.Country);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Country})";
        }
    }

    public class Movie : ICloneable
    {
        public string Title { get; set; }
        public Director Director { get; set; }
        public string Country { get; set; }
        public Genre Genre { get; set; }
        public int Year { get; set; }
        public double Rating { get; set; }

        public Movie(string title, Director director, string country, Genre genre, int year, double rating)
        {
            Title = title;
            Director = director;
            Country = country;
            Genre = genre;
            Year = year;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"{Title} ({Year}), {Genre}, directed by {Director}, Rating: {Rating}";
        }

        public object Clone()
        {
            return new Movie(this.Title, (Director)this.Director.Clone(), this.Country, this.Genre, this.Year, this.Rating);
        }
    }

    public class Cinema : IEnumerable<Movie>
    {
        private List<Movie> movies = new List<Movie>();

        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public void Sort(IComparer<Movie> comparer)
        {
            movies.Sort(comparer);
        }

        public IEnumerator<Movie> GetEnumerator()
        {
            return movies.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class CompareByRating : IComparer<Movie>
    {
        public int Compare(Movie x, Movie y) => y.Rating.CompareTo(x.Rating);
    }

    public class CompareByYear : IComparer<Movie>
    {
        public int Compare(Movie x, Movie y) => x.Year.CompareTo(y.Year);
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var cinema = new Cinema();
            cinema.AddMovie(new Movie("ITSTEP", new Director("Sergiy", "AAAAAAA", "Ukraine"), "USA", Genre.Drama, 2022, 10.0));
            cinema.AddMovie(new Movie("Intro to CSharp", new Director("Nikita","CCCCCCC", "Ukraine"), "USA", Genre.Horror, 2024, 8.0));
            cinema.AddMovie(new Movie("PV311", new Director("Sasha", "BBBBBBB", "Ukraine"), "USA", Genre.Action, 2023, 9.0));

            Console.WriteLine("Movies sorted by rating:");
            cinema.Sort(new CompareByRating());
            foreach (var movie in cinema)
            {
                Console.WriteLine(movie);
            }

            Console.WriteLine();

            Console.WriteLine("Movies sorted by year:");
            cinema.Sort(new CompareByYear());
            foreach (var movie in cinema)
            {
                Console.WriteLine(movie);
            }
        }
    }
}
