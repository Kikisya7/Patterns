using System.Collections.Generic;
using System.Linq;

public class Task10
{
    public static string FirstNonEmpty(List<string> list)
    {
        return list.FirstOrDefault(x => !string.IsNullOrWhiteSpace(x));
    }
}