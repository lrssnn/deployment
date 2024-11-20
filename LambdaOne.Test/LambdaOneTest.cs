namespace LambdaOne.Test;

public class LambdaOneTests
{
    private readonly Function _function = new();

    [Fact]
    public void ShouldCall()
    {
        Assert.Equal("ThIs iS ThE InPuT!", _function.FunctionHandler("this is the input!", null));
    }
}