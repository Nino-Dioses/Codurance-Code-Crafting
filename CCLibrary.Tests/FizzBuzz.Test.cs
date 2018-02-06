using CCLibrary;
using Xunit;

namespace CCLibrary.Test
{

    public class FizzBuzz
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        [InlineData(7, "7")]
        [InlineData(8, "8")]
        [InlineData(11, "11")]
        public void InformFizzBuzzResultForPlainNumber(int number, string expected)
        {
            var fizzBuzzer = new FizzBuzzer();
            var fizzBuzzed = fizzBuzzer.FizzBuzz(number);
            Assert.Equal(fizzBuzzed, expected);
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        [InlineData(9, "Fizz")]
        public void InformFizzBuzzResultForMultipleOfThree(int number, string expected)
        {
            var fizzBuzzer = new FizzBuzzer();
            var fizzBuzzed = fizzBuzzer.FizzBuzz(number);
            Assert.Equal(fizzBuzzed, expected);
        }

        [Theory]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        [InlineData(20, "Buzz")]
        public void InformFizzBuzzResultForMultipleOfFive(int number, string expected)
        {
            var fizzBuzzer = new FizzBuzzer();
            var fizzBuzzed = fizzBuzzer.FizzBuzz(number);
            Assert.Equal(fizzBuzzed, expected);
        }

        [Theory]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(45, "FizzBuzz")]
        public void InformFizzBuzzResultForMultipleOfTheeOrFive(int number, string expected)
        {
            var fizzBuzzer = new FizzBuzzer();
            var fizzBuzzed = fizzBuzzer.FizzBuzz(number);
            Assert.Equal(fizzBuzzed, expected);
        }

    }
}

