namespace FractionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction empty = new();
            Console.WriteLine(empty);

            Fraction oneHalf = new(1, 2);
            Console.WriteLine(oneHalf);

            Fraction oneThird = new(1, 3);
            Console.WriteLine(oneThird);

            Fraction twoSixths = new(2, 6);
            Console.WriteLine(twoSixths);

            // Fraction sum = oneHalf.Add(oneThird);
            Fraction sum = oneHalf + oneThird;
            Console.WriteLine(sum);

            bool equal = oneThird.Equals(oneHalf);
            Console.WriteLine($"oneThird = oneHalf?: {equal}");

            equal = oneThird.Equals(twoSixths);
            Console.WriteLine($"oneThird = twoSixths?: {equal}");

        }
    }
}
