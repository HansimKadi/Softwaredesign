namespace upper_lower_card_game;

public class Round
{
    private int _id = 0;
    private int _playerCount = 0;

    private List<Player> Players = new();


    public int set_playerCount
    {
        set { _playerCount = value; }

    }

    public int id
    {
        set { _id += 1; }
        get { return _id; }
    }

    public void register_player(int id, string name)
    {
        Player newplayer = new Player(id, name);
        Players.Add(newplayer);
    }

    public void process_players()
    {
        for (int i = 1; i <= _playerCount; i++)
        {
            Console.WriteLine($"Enter the {i} player's name");
            string? name = Console.ReadLine();
            register_player(i, name!); // The ! operator is used to assert that name is not null and to suppress any nullable warnings. remember to validate user input later"" 
        }
    }


}
