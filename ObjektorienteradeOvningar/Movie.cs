namespace ObjektorienteradeOvningar;

public class Movie
{
    private readonly string title;
    private readonly string genre;
    private readonly int lengthInMinutes;
    private int rating;

    public Movie(string title, string genre, int lengthInMinutes, int rating)
    {
        this.title = title;
        this.genre = genre;

        if (lengthInMinutes <= 0)
            throw new ArgumentNullException(nameof(lengthInMinutes));
        this.lengthInMinutes = lengthInMinutes;

        if (rating < 1 || rating > 5)
            throw new ArgumentOutOfRangeException(nameof(rating));
        this.rating = rating;
    }

    public void Information()
    {
        Console.WriteLine("========= MOVIE =========");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Genre: {genre}");
        Console.WriteLine($"Length: {lengthInMinutes} minutes.");
        Console.WriteLine($"Rating: {rating}");
        Console.WriteLine("=======================");
    }

    public void ChangeRating(int newRating)
    {
        if (newRating < 1 || newRating > 5)
        {
            Console.WriteLine("Rating cannot be less than one or greater than 5.");
            return;
        }

        rating = newRating;
    }

    public void IsLongerThanTwoHours()
    {
        if (lengthInMinutes > 120)
            Console.WriteLine($"{title} is longer than 2 hours.");
        else
            Console.WriteLine($"{title} is less than 2 hours.");
    }
}