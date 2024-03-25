namespace MoviesAPI_Git.DTO
{
    public class MovieDTO
    {
        public string? Title { get; set; }
        public int Year { get; set; }
        public string? Director { get; set; }
        public List<string>? Genre { get; set; }
        public List<string>? Cast { get; set; }
        public string? Plot { get; set; }
        public double Rating { get; set; }
    }
}
