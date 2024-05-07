using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        CharSet set1 = new CharSet(new char[] { 'a', 'b', 'c' });
        CharSet set2 = new CharSet(new char[] { 'b', 'c', 'd' });

        Console.WriteLine("Set1: " + set1);
        Console.WriteLine("Set2: " + set2);

        CharSet union = set1 + set2;
        Console.WriteLine("Union: " + union);

        CharSet difference = set1 - set2;
        Console.WriteLine("Difference: " + difference);

        CharSet intersection = set1 * set2;
        Console.WriteLine("Intersection: " + intersection);

        Console.WriteLine("Set1 == Set2: " + (set1 == set2));
        Console.WriteLine("Set1 != Set2: " + (set1 != set2));

        string set1AsString = set1;
        Console.WriteLine("Set1 as string: " + set1AsString);

        CharSet set3 = (CharSet)"efg";
        Console.WriteLine("Set3: " + set3);
    }
}
