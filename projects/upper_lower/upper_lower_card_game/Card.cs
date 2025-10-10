namespace upper_lower_card_game;

public class Card
{
    private suits _Suit;
    private values _Value;

    public suits Suit { get { return _Suit; } }
    public values Value { get { return _Value; } }


    public Card(suits suit, values value)
    {
        _Suit = suit;
        _Value = value;
    }
    public enum suits
    {
        Hearts,
        Diamonds,
        Spades,
        Clubs
    }

    public enum values
    {
        not_in_use,
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
}
