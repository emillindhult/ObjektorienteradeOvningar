using RockPaperScissor;

var player1 = new Player("Emil");
var player2 = new Player("Computer");

var game = new Game(player1, player2);

Random random = new Random();
var choiceLoop = true;
var gameLoop = true;

while (gameLoop)
{
    while (choiceLoop)
    {
        Console.WriteLine("=== ROCK PAPER SCISSOR ===");
        Console.WriteLine("1. Rock");
        Console.WriteLine("2. Paper");
        Console.WriteLine("3. Scissor");
        Console.WriteLine("0. Exit");
        Console.WriteLine();
        Console.Write("-> ");

        string? input = Console.ReadLine();

        switch (input)
        {
            case "1":
                player1.MakeChoice(Choice.Rock);
                choiceLoop = false;
                break;
            case "2":
                player1.MakeChoice(Choice.Paper);
                choiceLoop = false;
                break;
            case "3":
                player1.MakeChoice(Choice.Scissor);
                choiceLoop = false;
                break;
            case "0":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine();
                Console.WriteLine("Invalid Choice.");
                Console.WriteLine();
                break;
        }
    }

    int cpuNum = random.Next(1, 4);

    switch (cpuNum)
    {
        case 1:
            player2.MakeChoice(Choice.Rock);
            break;
        case 2:
            player2.MakeChoice(Choice.Paper);
            break;
        case 3:
            player2.MakeChoice(Choice.Scissor);
            break;
        default:
            break;
    }

    game.DetermineWinner();

    var playAgainLoop = true;

    while (playAgainLoop)
    {
        Console.WriteLine();
        Console.WriteLine("Play again (y/n)?");
        Console.WriteLine();
        Console.Write("-> ");

        string? playAgain = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(playAgain))
            continue;

        if (playAgain.ToLower() == "n")
        {
            Console.WriteLine("Thanks for playing.");
            Environment.Exit(0);
        }
        else if (playAgain.ToLower() == "y")
        {
            choiceLoop = true;
            playAgainLoop = false;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Invalid Choice.");
        }
    }
}