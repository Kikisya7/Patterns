using System.Collections.Generic;
using System.Linq;

public class Task1
{
    public static List<int> FilterOdd(List<int> list)
    {
        return list.Where(x => x % 2 != 0).ToList();
    }
}