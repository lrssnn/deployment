using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LambdaOne;

public class Function
{
    public string FunctionHandler(string input, ILambdaContext _context)
    {
        return CommonLib.Helpers.UpperEverySecond(input);
    }
}
