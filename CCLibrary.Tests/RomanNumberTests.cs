
using Xunit;
using CCLibrary;

namespace CCLibrary.Tests
{
    public class RomanNumberTests
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(11, "XI")]
        [InlineData(11, "XII")]
        [InlineData(11, "XIII")]
        [InlineData(11, "XIV")]
        [InlineData(11, "XV")]
        public void TranslateNumberOne(int arabic, string expected)
        {
            var romanNumbers = new RomanNumbers();
            string roman = romanNumbers.Translate(arabic);

            Assert.Equal(expected, roman);
        
        }
    }
}
