using System.Linq;

public class Task9
{
    public static int CountWords(string text)
    {
        return text.Split(' ', System.StringSplitOptions.RemoveEmptyEntries).Count();
    }
}