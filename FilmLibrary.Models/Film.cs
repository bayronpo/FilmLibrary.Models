namespace FilmLibrary.Models
{
    public class Film
    {
        public Film(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public string? Synopsis { get; set; }
        public int? Year { get; set; }
        public TimeSpan? Duration { get; set; }
        public string? Director { get; set; }
    }
}