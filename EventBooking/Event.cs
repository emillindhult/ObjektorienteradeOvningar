namespace EventBooking;

internal class Event
{
    private int capacity;
    private int attendees;
    public int FreeSpots
    {
        get
        {
            return capacity - attendees;
        }
    }

    public void BookTicket(int amount)
    {
        if (amount > FreeSpots)
        {
            Console.WriteLine("There isn't enough free spots available.");
            return;
        }

        attendees += amount;
        Console.WriteLine("Thank you for your order. Your tickets will arrive shortly.");
    }
}
