namespace CommonLib.Tests;

public class CommonLibTests
{
    [Fact]
    public void EverySecondShouldWork()
    {
        Assert.Equal("ThIs iS ThE InPuT!", CommonLib.Helpers.UpperEverySecond("this is the input!"));
    }

    [Fact]
    public void ToNumericShouldWork()
    {
        Assert.Equal(1670, CommonLib.Helpers.ToNumeric("this is the input!"));
    }
}