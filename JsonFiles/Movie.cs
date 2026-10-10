namespace JsonFiles;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string ReleaseYear { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public double Rating { get; set; }
    public string Director { get; set; } = string.Empty;
}
