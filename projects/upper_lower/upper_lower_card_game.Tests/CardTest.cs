using FluentAssertions;
using NUnit.Framework;
using upper_lower_card_game;

namespace upper_lower_card_game.Tests;

public class CardTest
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void Card_suit_should_return_a_suit()
    {
        // arange
        Card card = new Card();


        // Act
        Card.Suits suit = card.Suit;
        Card.Values value = card.Value;



        // Assert
        suit.Should().BeDefined();
        value.Should().BeDefined();
    }
}
