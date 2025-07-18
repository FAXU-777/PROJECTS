

class Program
{
    static void Main(string[] args)
    {
        List<Movie> movies = new List<Movie>();
        
        movies.Add(Movie.Add("Inception", "Christopher Nolan", 9.0));
        movies.Add(Movie.Add("Interstellar", "Christopher Nolan", 8.6));
        movies.Add(Movie.Add("The Matrix", "Wachowski Sisters", 8.7));
        movies.Add(Movie.Add("The Godfather", "Francis Ford Coppola", 9.2));
        movies.Add(Movie.Add("Joker", "Todd Phillips", 8.4));
        
        Movie.View(movies);


        Console.WriteLine( Movie.SeeTheHighestRatingMovie(movies));

        Console.WriteLine(Movie.RemoveByTitle(movies, "Joker"));
        Movie.View(movies);



    }
    
}