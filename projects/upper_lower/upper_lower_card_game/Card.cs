namespace upper_lower_card_game;

public class Card
{
    private Suits _Suit;
    private Values _Value;

    public Suits Suit { get { return _Suit; } }
    public Values Value { get { return _Value; } }


    public Card(Suits suit = Suits.Hearts, Values value = Values.unassigned)
    {
        _Suit = suit;
        _Value = value;
    }
    public enum Suits
    {
        Hearts,
        Diamonds,
        Spades,
        Clubs
    }

    public enum Values
    {
        unassigned,
        Ace,
        Two,
        Theee,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public override string ToString()
    {
        return $"{_Value} of {_Suit}";
    }
}
