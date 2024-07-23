namespace PrintNumbersLib.Tests;

public class FormatSequenceTests
{
    [Fact]
    public void Test_Default_Bounds()
    {
        var actual = PrintNumbers.FormatSequence().ToArray();
        Assert.Equal(100, actual.Length);
    }

    [Theory]
    [InlineData(5, 5)]
    [InlineData(1000, 1000)]
    public void Test_Bounds(int upperBound, int expected)
    {
        var actual = PrintNumbers.FormatSequence(upperBound).ToArray();
        Assert.Equal(expected, actual.Length);
    }

    [Fact]
    public void Test_First_Fifteen_With_Default_Rules()
    {
        var expected = new[] { "1", "2", "Ryan", "4", "Riley", "Ryan", "7", "8", "Ryan", "Riley", "11", "Ryan", "13", "14", "RyanRiley" };
        var actual = PrintNumbers.FormatSequence(15).ToArray();
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test_First_Fifteen_With_Empty_Rules()
    {
        var expected = Enumerable.Range(1, 15).Select(n => n.ToString()).ToArray();
        var rules = new Dictionary<int, string>();
        var actual = PrintNumbers.FormatSequence(15, rules).ToArray();
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test_First_Fifteen_With_Custom_Rules_2_Buddy_7_Holly()
    {
        var expected = new[] { "1", "Buddy", "3", "Buddy", "5", "Buddy", "Holly", "Buddy", "9", "Buddy", "11", "Buddy", "13", "BuddyHolly", "15" };
        var rules = new Dictionary<int, string>
        {
            { 2, "Buddy" },
            { 7, "Holly" },
        };
        var actual = PrintNumbers.FormatSequence(15, rules).ToArray();
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test_First_Fifteen_With_Custom_Rules_7_Holly_2_Buddy()
    {
        var expected = new[] { "1", "Buddy", "3", "Buddy", "5", "Buddy", "Holly", "Buddy", "9", "Buddy", "11", "Buddy", "13", "HollyBuddy", "15" };
        var rules = new Dictionary<int, string>
        {
            { 7, "Holly" },
            { 2, "Buddy" },
        };
        var actual = PrintNumbers.FormatSequence(15, rules).ToArray();
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test_First_Fifteen_With_Custom_Rules_2_Buddy_4_Holly()
    {
        var expected = new[] { "1", "Buddy", "3", "BuddyHolly", "5", "Buddy", "7", "BuddyHolly", "9", "Buddy", "11", "BuddyHolly", "13", "Buddy", "15" };
        var rules = new Dictionary<int, string>
        {
            { 2, "Buddy" },
            { 4, "Holly" },
        };
        var actual = PrintNumbers.FormatSequence(15, rules).ToArray();
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test_First_Fifteen_With_Custom_Rules_2_Buddy_4_Holly_7_Peggy()
    {
        var expected = new[] { "1", "Buddy", "3", "BuddyHolly", "5", "Buddy", "Peggy", "BuddyHolly", "9", "Buddy", "11", "BuddyHolly", "13", "BuddyPeggy", "15" };
        var rules = new Dictionary<int, string>
        {
            { 2, "Buddy" },
            { 4, "Holly" },
            { 7, "Peggy" },
        };
        var actual = PrintNumbers.FormatSequence(15, rules).ToArray();
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test_First_Twenty_With_Custom_Rules_2_Buddy_3_Holly_5_Peggy_7_Sue()
    {
        var expected = new[] { "1", "Buddy", "Holly", "Buddy", "Peggy", "BuddyHolly", "Sue", "Buddy", "Holly", "BuddyPeggy", "11", "BuddyHolly", "13", "BuddySue", "HollyPeggy" };
        var rules = new Dictionary<int, string>
        {
            { 2, "Buddy" },
            { 3, "Holly" },
            { 5, "Peggy" },
            { 7, "Sue" },
        };
        var actual = PrintNumbers.FormatSequence(15, rules).ToArray();
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test_Can_Iterate_To_Int16_MaxValue()
    {
        var expected = short.MaxValue;
        var actual = PrintNumbers.FormatSequence(short.MaxValue).Count();
        Assert.Equal(expected, actual);
    }

    [Fact(Skip = "This can take a really long time to run; uncomment to run test")]
    public void Test_Can_Iterate_To_Int32_MaxValue()
    {
        var expected = int.MaxValue;
        var actual = PrintNumbers.FormatSequence(int.MaxValue).Count();
        Assert.Equal(expected, actual);
    }
}

