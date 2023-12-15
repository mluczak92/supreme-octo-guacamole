using System.Linq.Dynamic.Core;

namespace adventofcode2022._2023;

public class _15 {
    public static void Run()
    {
        var sequence = File.ReadAllText("example.txt")
            .Split(",")
            .ToArray();
        
        var sum = 0ul;
        foreach (var step in sequence)
        {
            sum += Hash(step);
        }
        
        Console.WriteLine(sum);
    }

    public static ulong Hash(string input)
    {
        var current = 0ul;
        foreach (var @char in input)
        {
            current += @char;
            current *= 17;
            current %= 256;
        }

        return current;
    }
}