namespace upper_lower_card_game;

public class Card_Deck
{
    // Elements
    private List<Card> _Cards = new List<Card>();
    private List<Card> _Table = new List<Card>();
    private List<Card> _DiscardPile = new List<Card>();


    // Cards
    private Card drawn = new Card();
    private Card prev = new Card();



    public IReadOnlyList<Card> Cards { get { return _Cards; } }
    public IReadOnlyList<Card> Table { get { return _Table; } }



    public void load_cards()
    {
        foreach (Card.Suits suit in Enum.GetValues<Card.Suits>())
        {
            foreach (Card.Values value in Enum.GetValues<Card.Values>())
            {
                if (value == Card.Values.unassigned) // Skip this value
                    continue;

                _Cards.Add(new Card(suit, value));
            }
        }
    }

    public void shuffle_cards()
    {
        Random random = new Random();
        for (int i = _Cards.Count - 1; i > 0; i--)
        {
            int number = random.Next(0, i + 1);// Yates fischer is max inclusive
            Card temp = _Cards[i];
            _Cards[i] = _Cards[number];
            _Cards[number] = temp;

        }
    }

    public void draw_card()
    {
        drawn = _Cards[0];
        _Cards.RemoveAt(0);

    }

    public void place_card_on_table()
    {
        _Table.Add(drawn);
        prev = drawn;

    }

    public void show_table()
    {
        foreach (Card card in _Table)
        { Console.WriteLine(card); }
    }

    public void clean_table()
    {
        foreach (Card card in _Table)
        {
            _DiscardPile.Add(card);
        }
        _Table.Clear();
    }


}
