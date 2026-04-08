using System.Collections.Generic;
using System.Linq;

public class Task3
{
    public static List<string> SortAlphabet(List<string> list)
    {
        return list.OrderBy(x => x).ToList();
    }
}