namespace CommonLib;

public static class Helpers
{
    public static string UpperEverySecond(string input)
    {
        var chars = input.ToCharArray();
        for (int i = 0; i < input.Length; i+= 2)
        {
            chars[i] = char.ToUpper(chars[i]);
        }
        return string.Join("", chars);
    }

    public static int ToNumeric(string input)
    {
        return input.ToCharArray().Sum(x => x);
    }
}
