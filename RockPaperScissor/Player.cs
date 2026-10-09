namespace RockPaperScissor;

internal class Player
{
    public string Name { get; private set; } = string.Empty;
    public Choice Choice { get; private set; }

    public Player(string name)
    {
        Name = name;
    }

    public void MakeChoice(Choice choice)
    {
        Choice = choice;
    }
}

public enum Choice
{
    Rock,
    Paper,
    Scissor
}