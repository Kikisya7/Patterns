using System.Collections.Generic;
using System.Linq;

public class Task8
{
    public static List<string> SortByLength(List<string> list)
    {
        return list.OrderBy(x => x.Length).ToList();
    }
}