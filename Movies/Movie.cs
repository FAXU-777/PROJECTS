

public class Movie
{
    public string Title;
    public string Director;
    public double Rating;

    public Movie(string title, string director, double rating)
    {
        this.Title = title;
        this.Director = director;
        this.Rating = rating;
    }

    public static Movie Add(string title, string director, double rating)
    {
        Movie movie = new Movie(title, director, rating);
        return movie;
        
    }

    public static Movie RemoveByTitle(List<Movie> movies, string title)
    {
        for (int i = 0; i < movies.Count; i++)
        {
            if (movies[i].Title == title)
            {
                Movie removedMovie = movies[i];
                movies.RemoveAt(i);
                return removedMovie;
            }
        }

        return null;
    }

    public static void View(List<Movie> movies)
    {
        for (int i = 0; i < movies.Count; i++)
        {
            Console.WriteLine(movies[i]);
        }
        
    }

    public override string ToString()
    {
        return $"Title: {Title}, Director: {Director}, Rating: {Rating}";
    }

    public static double SeeTheHighestRatingMovie(List<Movie> movies)
    {
        double highestRating = 0;
        
        for (int i = 0; i < movies.Count; i++)
        {
            if (highestRating < movies[i].Rating)
            {
                highestRating = movies[i].Rating;
            }
        }

        return highestRating;
    }



   
    
    

}