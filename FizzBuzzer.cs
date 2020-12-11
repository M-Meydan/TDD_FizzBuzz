using System;

namespace FizzBuzz
{
    internal class FizzBuzzer
    {
        const string Buzz = "Buzz";
        const string Fizz = "Fizz";
        public FizzBuzzer() { }

        internal bool IsFizz(float input)
        {
            return (input % 3)==0;
        }

        internal bool IsBuzz(float input)
        {
            return (input % 5) == 0;
        }

        internal string Print(float input)
        {
            if (IsBuzz(input) && IsFizz(input)) return $"{Fizz}{Buzz}";
            else if (IsBuzz(input)) return Buzz;
            else if (IsFizz(input)) return Fizz;
            else return input.ToString();
        }
    }
}