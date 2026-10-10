using JsonFiles;
using System.Text.Json;

const string PATH = "C:\\Users\\Emil\\source\\repos\\ObjektorienteradeOvningar\\JsonFiles\\movies.json";

string json = File.ReadAllText(PATH);

var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true,
    WriteIndented = true,
    
};

List<Movie> movies = JsonSerializer.Deserialize<List<Movie>>(json, options)!;

bool programLoop = true;

while (programLoop)
{
    bool userInputLoop = true;

    while (userInputLoop)
    {
        Console.Clear();
        Console.WriteLine("==== MOVIE DATABASE ====");
        Console.WriteLine();
        Console.WriteLine("1. Show alla movies");
        Console.WriteLine("2. Filter movies");
        Console.WriteLine("0. Exit");
        Console.WriteLine();
        Console.Write("-> ");

        string? userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                PrintMovies();
                break;
            case "2":
                FilterMoviesMenu();
                break;
            case "0":
                programLoop = false;
                userInputLoop = false;
                break;
            default:
                break;
        }
    }
}

void PrintMovies()
{
    Console.Clear();

    foreach (var movie in movies)
    {
        Console.WriteLine("===== MOVIE ====");
        Console.WriteLine($"Title: {movie.Title}");
        Console.WriteLine($"Genre: {movie.Genre}");
        Console.WriteLine($"Year: {movie.ReleaseYear}");
        Console.WriteLine($"Rating: {movie.Rating}");
        Console.WriteLine($"Director: {movie.Director}");
        Console.WriteLine();
    }

    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

void FilterMoviesMenu()
{
    bool filterMenuLoop = true;

    while (filterMenuLoop)
    {
        Console.Clear();
        Console.WriteLine("===== Filter Movies =====");
        Console.WriteLine();
        Console.WriteLine("1. Filter by title");
        Console.WriteLine("2. Filter by genre");
        Console.WriteLine("0. Back");
        Console.WriteLine();
        Console.Write("-> ");

        string? userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                FilterByTitle();
                break;
            case "2":
                FilterByGenre();
                break;
            case "0":
                filterMenuLoop = false;
                break;
            default:
                break;
        }
    }
}

void FilterByGenre()
{
    Console.Clear();
    Console.WriteLine("Choose Genre");
    Console.Write("-> ");

    string? userInput = Console.ReadLine();

    List<Movie> filteredMovies = JsonSerializer.Deserialize<List<Movie>>(json, options)!;

    Console.Clear();
    foreach (var movie in filteredMovies
        .Where(x => x.Genre
        .Contains(userInput!, StringComparison.CurrentCultureIgnoreCase)))
    {
        Console.WriteLine("===== MOVIE ====");
        Console.WriteLine($"Title: {movie.Title}");
        Console.WriteLine($"Genre: {movie.Genre}");
        Console.WriteLine($"Year: {movie.ReleaseYear}");
        Console.WriteLine($"Rating: {movie.Rating}");
        Console.WriteLine($"Director: {movie.Director}");
        Console.WriteLine();
    }

    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

void FilterByTitle()
{
    Console.Clear();
    Console.WriteLine("Choose Title");
    Console.Write("-> ");

    string? userInput = Console.ReadLine();

    List<Movie> filteredMovies = JsonSerializer.Deserialize<List<Movie>>(json, options)!;

    Console.Clear();
    foreach (var movie in filteredMovies
        .Where(x => x.Title
        .Contains(userInput!, StringComparison.CurrentCultureIgnoreCase)))
    {
        Console.WriteLine("===== MOVIE ====");
        Console.WriteLine($"Title: {movie.Title}");
        Console.WriteLine($"Genre: {movie.Genre}");
        Console.WriteLine($"Year: {movie.ReleaseYear}");
        Console.WriteLine($"Rating: {movie.Rating}");
        Console.WriteLine($"Director: {movie.Director}");
        Console.WriteLine();
    }

    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}