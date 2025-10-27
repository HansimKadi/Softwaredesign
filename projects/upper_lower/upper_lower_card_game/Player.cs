namespace upper_lower_card_game;

public class Player
{
    int _id;
    string _name;

    public Player(int id, string name)
    {
        _id = id;
        _name = name;
    }

    public int id { get { return _id; } }
    public string name { get { return _name; } }


    public string guess()
    {
        string? Guess = null; // the "?" allows null temporaliy
        while (string.IsNullOrWhiteSpace(Guess)) // Will loop until condition is satisfied
        {
            Console.WriteLine("Enter your guess:");
            Guess = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(Guess))
            {
                Console.WriteLine("You must make a guess!");
            }

        }
        return Guess;
    }

}
