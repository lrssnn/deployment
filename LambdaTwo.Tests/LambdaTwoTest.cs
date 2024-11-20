namespace LambdaTwo.Tests;

public class LambdaTwoTests
{
    private readonly Function _function = new();

    [Fact]
    public void ShouldReturnMessageAboutNumeric()
    {
        var result = _function.FunctionHandler("this is the input!", null);
        Assert.Contains("1670", result);
    }
}