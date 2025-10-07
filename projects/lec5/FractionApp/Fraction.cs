using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FractionApp
{
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator = 0, int denominator = 1)
        {
            Numerator = numerator;
            Denominator = denominator;
        }


        public override string ToString()
        {
            return $"{Numerator / Denominator}";
        }

        public Fraction Add(Fraction other)
        {
            int newNumerator = Numerator * other.Denominator + Denominator * other.Numerator;
            int newDenominator = Denominator * other.Denominator;
            return new(newNumerator, newDenominator);

            //return new(Numerator * other.Denominator + Denominator * other.Numerator, Denominator * other.Denominator);
        }

        public static Fraction operator +(Fraction left, Fraction right)
        {
            return left.Add(right);
        }

        public bool Equals(Fraction other)
        {
            //return Numerator == other.Numerator && Denominator == other.Denominator;
            return Numerator * other.Denominator == Denominator * other.Numerator;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Fraction other)
            {
                return Equals(other);
            }
            else
            {
                return false;
            }
        }
    }
}

