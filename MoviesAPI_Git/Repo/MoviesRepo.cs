using MoviesAPI_Git.DTO;

namespace MoviesAPI_Git.Repo
{
    /// <summary>
    /// Simple repo for some starter movies.
    /// </summary>
    public class MoviesRepo
    {
        public static ICollection<Movie> movies = new HashSet<Movie>() {
            new Movie("Inception",2010,"Christopher Nolan",new List<string>(){"Action","Adventure","Sci-Fi"},new List<string>(){ "Leonardo DiCaprio", "Joseph Gordon-Levitt", "Ellen Page"},"A thief who enters the dreams of others to steal secrets from their subconscious gets a chance to redeem himself by planting an idea into the mind of a CEO.",8.8),
            new Movie("The Shawshank Redemption",1994,"Frank Darabont",new List<string>(){"Drama"},new List<string>(){"Tim Robbins","Morgan Freeman", "Bob Gunton"},"Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",9.3),
            new Movie("The Dark Knight",2008,"Christopher Nolan",new List<string>(){"Action", "Crime", "Drama"},new List<string>(){"Christian Bale", "Heath Ledger", "Aaron Eckhart"},"When the menace known as The Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",10.0),
            new Movie( "Forrest Gump",1994,"Robert Zemeckis",new List<string>(){"Drama", "Romance"},new List<string>(){"Tom Hanks", "Robin Wright", "Gary Sinise"},"The presidencies of Kennedy and Johnson, the events of Vietnam, Watergate, and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",10.0)
        };

        public static Movie secretMovie = new Movie("Memento", 2000, "Christopher Nolan", new List<string>() { "Mystery" }, new List<string>() { "Carrie-Anne Moss", "Joe Pantoliano", "Guy Pearce" }, "Memento chronicles two separate stories of Leonard, an ex-insurance investigator who can no longer build new memories, as he attempts to find the murderer of his wife, which is the last thing he remembers.", 8.8);
    }
}
