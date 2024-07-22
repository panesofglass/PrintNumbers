namespace PrintNumbersLib.Tests;

public class AllTests
{
    [Fact]
    public void Test_Default_Bounds()
    {
        var actual = PrintNumbers.All().ToArray();
        Assert.Equal(100, actual.Length);
    }

    [Theory]
    [InlineData(5, 5)]
    [InlineData(1000, 1000)]
    public void Test_Bounds(int upperBound, int expected)
    {
        var actual = PrintNumbers.All(upperBound).ToArray();
        Assert.Equal(expected, actual.Length);
    }

    [Fact]
    public void Test_First_Fifteen()
    {
        var expected = new[] { "1", "2", "Ryan", "4", "Riley", "Ryan", "7", "8", "Ryan", "Riley", "11", "Ryan", "13", "14", "RyanRiley" };
        var actual = PrintNumbers.All(15).ToArray();
        Assert.Equal(expected, actual);
    }
}
