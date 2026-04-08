using System.Collections.Generic;
using System.Linq;

public class Task4
{
    public static int SumEven(List<int> list)
    {
        return list.Where(x => x % 2 == 0).Sum();
    }
}