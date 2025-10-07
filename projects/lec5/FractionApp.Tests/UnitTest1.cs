using NUnit.Framework;
using FractionApp;


namespace FractionApp.Tests
{
    public class FractionTests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void Constructor_NoParameters_CreatesEmptyFraction()
        {
            // Arrange

            // Act
            Fraction empty = new();

            // Assert
            Assert.That(empty.Numerator, Is.EqualTo(0));
            Assert.That(empty.Denominator, Is.EqualTo(1));
        }

        [TestCase(1, 2)]
        [TestCase(0, 2)]
        [TestCase(-1, 2)]
        [TestCase(2, 3)]
        [TestCase(10, 13)]
        public void Constructor_WithParameters_CreatesCorrectFraction(int numerator, int denominator)
        {
            // Arrange

            // Act
            Fraction actual = new(numerator, denominator);

            // Assert
            Assert.That(actual.Numerator, Is.EqualTo(numerator));
            Assert.That(actual.Denominator, Is.EqualTo(denominator));
        }

        [Test]
        public void Add_TwoValues_ReturnsCorrectSum()
        {
            // Arrange
            Fraction oneHalf = new(1, 2);
            Fraction oneThird = new(1, 3);
            Fraction expected = new(5, 6);

            // Act
            Fraction actual = oneHalf.Add(oneThird);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}

