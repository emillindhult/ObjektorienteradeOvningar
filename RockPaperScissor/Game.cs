namespace RockPaperScissor;

internal class Game
{
    private Player player1;
    private Player player2;

    public Game(Player player1, Player player2)
    {
        this.player1 = player1;
        this.player2 = player2;
    }

    public void DetermineWinner()
    {
        Console.WriteLine($"{player1.Name}: {player1.Choice}");
        Console.WriteLine($"{player2.Name}: {player2.Choice}");
        Console.WriteLine();

        if (player1.Choice == player2.Choice)
        {
            Console.WriteLine("The game was a tie.");
        }
        else if (player1.Choice == Choice.Rock && player2.Choice == Choice.Paper)
        {
            Console.WriteLine($"{player2.Name} wins!");
        }
        else if (player1.Choice == Choice.Rock && player2.Choice == Choice.Scissor)
        {
            Console.WriteLine($"{player1.Name} wins!");
        }
        else if (player1.Choice == Choice.Paper && player2.Choice == Choice.Rock)
        {
            Console.WriteLine($"{player1.Name} wins!");
        }
        else if (player1.Choice == Choice.Paper && player2.Choice == Choice.Scissor)
        {
            Console.WriteLine($"{player2.Name} wins!");
        }
        else if (player1.Choice == Choice.Scissor && player2.Choice == Choice.Paper)
        {
            Console.WriteLine($"{player1.Name} wins!");
        }
        else if (player1.Choice == Choice.Scissor && player2.Choice == Choice.Rock)
        {
            Console.WriteLine($"{player2.Name} wins!");
        }
    }
}
