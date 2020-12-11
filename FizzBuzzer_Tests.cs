using NUnit.Framework;

namespace FizzBuzz
{
    public class FizzBuzzer_Tests
    {
        FizzBuzzer _fizzbuzzer;

        [SetUp]
        public void Setup()
        {
            _fizzbuzzer = new FizzBuzzer();

        }

        [TestCase(1, ExpectedResult = "1")]
        [TestCase(3, ExpectedResult = "Fizz")]
        [TestCase(5, ExpectedResult = "Buzz")]
        [TestCase(7, ExpectedResult = "7")]
        [TestCase(6, ExpectedResult = "Fizz")]
        [TestCase(10, ExpectedResult = "Buzz")]
        [TestCase(11, ExpectedResult = "11")]
        [TestCase(15, ExpectedResult = "FizzBuzz")]
        [TestCase(45, ExpectedResult = "FizzBuzz")]
        [TestCase(98, ExpectedResult = "98")]
        [TestCase(100, ExpectedResult = "Buzz")]
        public string FizzBuzzTest(float input)
        {
            var result = _fizzbuzzer.Print(input);
            return result;
        }
    }
}