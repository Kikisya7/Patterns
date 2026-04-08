using System.Collections.Generic;
using System.Linq;

public class Task11
{
    public static bool AllStartWithUpper(List<string> list)
    {
        return list.Where(x => !string.IsNullOrEmpty(x))
            .All(x => char.IsUpper(x[0]));
    }
}