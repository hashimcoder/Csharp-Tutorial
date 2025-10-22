using System;
using System.Collections.Generic;
using System.Linq;

public static class LinqExample
{
    public static void Run()
    {
        var people = new List<(string Name, int Age)>
        {
            ("Alice", 30),
            ("Bob", 25),
            ("Charlie", 35),
            ("Anna", 28)
        };

        var query = people
            .Where(p => p.Name.StartsWith("A"))
            .OrderBy(p => p.Age)
            .Select(p => new { p.Name, p.Age });

        Console.WriteLine("People whose name starts with A (sorted by age):");
        foreach (var p in query) Console.WriteLine($"{p.Name} ({p.Age})");
    }
}
