﻿namespace MoviesAPI_Git.DTO
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public List<string> Genre { get; set; }
        public List<string> Cast { get; set; }
        public string Plot { get; set; }
        public double Rating { get; set; }


        public Movie(string title, int year, string director, List<string>? genre, List<string>? cast, string? plot, double rating)
        {
            Id = Guid.NewGuid();
            Title = title;
            Year = year;
            Director = director;
            Genre = genre;
            Cast = cast;
            Plot = plot;
            Rating = rating;
        }
    }
}
