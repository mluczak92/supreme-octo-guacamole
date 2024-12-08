using System.Security.Cryptography;

namespace adventofcode2022._2024._7;

public static class _7
{
    static List<char[]> chars = new() { new[] { '+' }, new[] { '*' }, new[] { '|' } };
    static Dictionary<char, Func<long, long, long>> funcs = new()
    {
        ['+'] = (i, j) => i + j,
        ['*'] = (i, j) => i * j,
        ['|'] = (i, j) => long.Parse($"{i}{j}")
    };
    
    public static void Run()
    {
        var input = File.ReadAllLines(Path.Combine("2024", "7", "input.txt"))
            .Select(x => (
                    result: long.Parse(x.Split(":")[0]),
                    data: x.Split(":")[1]
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(long.Parse)
                        .ToArray()))
            .ToArray();

        var counter = 0L;
        foreach (var line in input)
        {
            var permutations = GetPermutations(line.data.Length - 1);
            if (permutations.Any(p => line.data
                    .Select((data, index) => (data, index))
                    .Aggregate((a, b) => b with { data = funcs[p[a.index]](a.data, b.data) }).data == line.result))
            {
                counter += line.result;
            }
        }
        
        Console.WriteLine(counter);
    }
    
    static Dictionary<long, List<char[]>> cache = new();
    static List<char[]> GetPermutations(long len)
    {
        if (cache.TryGetValue(len, out var permutations))
            return permutations;
        
        if (len == 1)
            return chars;
        
        var result = new List<char[]>();
        var perms = GetPermutations(len - 1);
        foreach (var c in chars)
            foreach (var p in perms)
                result.Add(c.Concat(p).ToArray());
        
        cache.Add(len, result);
        return result;
    }
}