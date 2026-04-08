using System.Collections.Generic;
using System.Linq;

public class Task12
{
    public static int SecondLargest(List<int> list)
    {
        return list.Distinct()
            .OrderByDescending(x => x)
            .Skip(1)
            .First();
    }
}