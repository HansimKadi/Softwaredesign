namespace upper_lower_card_game;

public class Game
{
    private string? DrunkYet = null;
    int sentinel = 1;


    public void start()
    {
        Card_Deck current_deck = new Card_Deck();
        current_deck.load_cards();

        Console.WriteLine("Saddle up, Cowboy. Time to play. You in?");

        Round current_round = new Round();
        Console.WriteLine("How many souls will i collect for this game?");

        string? input = Console.ReadLine();
        current_round.set_playerCount = int.Parse(input);
        current_round.process_players();

        Console.Clear();
        Dealer kingpin = new Dealer();
        kingpin.say_hi();

        //while(DrunkYet == null)
        //{

        //}
    }

}
