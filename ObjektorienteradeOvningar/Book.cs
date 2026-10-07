class Book
{
    private readonly string title;
    private readonly string author;
    private readonly int pages;
    private bool isLoaned;

    public Book(string title, string author, int pages)
    {
        this.title = title;
        this.author = author;
        this.pages = pages;
    }

    public void PrintInformation()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Pages: {pages}");
        //var available = !isLoaned ? "Yes" : "No";
        Console.WriteLine($"Available: {(!isLoaned ? "Yes" : "No")}");
    }

    public void LoanBook()
    {
        if (isLoaned)
        {
            Console.WriteLine("This book is not available at this moment.");
            return;
        }

        isLoaned = !isLoaned;
        Console.WriteLine("You have loaned the book.");
    }

    public void ReturnBook()
    {
        if (!isLoaned)
        {
            Console.WriteLine("Can't return a book that is not loaned.");
            return;
        }

        isLoaned = !isLoaned;
        Console.WriteLine("You have returned the book.");
    }
}