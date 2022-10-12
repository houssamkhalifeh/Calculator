using System;
using System.Collections.Generic;

namespace Calculator
{
class BadMultipleIteration
{
    private static int count = 1;

    private static IEnumerable<int> NonRepeatable()
    {
        for (; count <= 3; count++)
        {
            yield return count;
        }
    }

    public static void Test(string[] args)
    {
        IEnumerable<int> nr = NonRepeatable();
        foreach (int i in nr)
            Console.WriteLine(i);

        foreach (int i in nr)
            Console.WriteLine(i);
    }
}
class Bad
{
    void M()
    {
        GC.Collect();
    }
}
}