namespace PrintNumbersLib.Tests
{
    public class FormatTests
    {
        [Theory]
        [InlineData(3, "Ryan")]
        [InlineData(5, "Riley")]
        [InlineData(15, "RyanRiley")]
        [InlineData(2, "2")]
        [InlineData(97, "97")]
        [InlineData(1010101, "1010101")]
        public void Test_Format(int number, string expected)
        {
            var actual = PrintNumbersLib.PrintNumbers.Format(number);
            Assert.Equal(expected, actual);
        }
    }
}