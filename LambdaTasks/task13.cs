using System.Collections.Generic;
using System.Linq;

public class Task13
{
    public static int MaxEven(List<int> list)
    {
        return list.Where(x => x % 2 == 0).Max();
    }
}