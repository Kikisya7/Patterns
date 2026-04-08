using System.Collections.Generic;
using System.Linq;

public class Task7
{
    public static List<int> Squares(List<int> list)
    {
        return list.Select(x => x * x).ToList();
    }
}