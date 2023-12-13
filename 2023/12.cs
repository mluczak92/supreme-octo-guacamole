using System.Text.RegularExpressions;

namespace adventofcode2022._2023;

public class _12 {
    public static void Run()
    {
        var input = File.ReadAllLines("input.txt")
            .Select(x => new
            {
                Row = string.Join("u", Enumerable.Repeat(0, 5).Select(_ => new string(x.Split(" ")[0].ToArray())))
                    .Replace("#", "d")
                    .Replace(".", "o")
                    .Replace("?", "u"),
                BrokenList = string.Join(",", Enumerable.Repeat(0, 5).Select(_ => string.Join(",", x.Split(" ")[1])))
                    .Split(",")
                    .Select(y => int.Parse(y))
                    .ToList()
            }).ToArray();

        var c = 0;
        ulong sum = 0UL;
        foreach (var entry in input)
        {
            // Console.WriteLine(c++);
            var cache = new Dictionary<(string, string), ulong>();
            sum += Replace(entry.Row, entry.BrokenList, -1, cache);
        }
        
        Console.WriteLine($"RESULT: {sum}");
        Console.ReadKey();
        
        // 10154 - too high
        
        // part 2
        // 2416287867 - too low
        // 29826669191291
    }

    private static List<int> results = new();

    static ulong Replace(string row, List<int> brokenList, int previousGroupIdx, Dictionary<(string, string), ulong> cache)
    {
        // CACHE
        var key1 = row;
        var lastDotIdx = row.LastIndexOf(".");
        if (lastDotIdx > -1)
        {
            key1 = row.Substring(lastDotIdx + 1);
        }

        var key2 = string.Join(",", brokenList);
        if (cache.TryGetValue((key1, key2), out var val))
        {
            // Console.WriteLine("CACHE HIT");
            return val;
        }
        
        var number = brokenList.First();
        var pattern = $"(?=([d*u*d*u*]{{{number}}}[uo]))";
        
        if (brokenList.Count == 1)
        {
            pattern = $"(?=([d*u*d*u*]{{{number}}}))";
        }

        var matches = Regex.Matches(row, pattern);
        var groups = matches.Select(x => x.Groups.Values.Skip(1).First()).Where(x => x.Index > previousGroupIdx).ToArray();
        // Console.WriteLine($"trying to match: {new string(Enumerable.Range(0, number).Select(_ => 'd').ToArray())} in: {row}, matches: {groups.Length}");
        
        var newList = new List<int>(brokenList.Skip(1));
        if (newList.Count == 0)
        {
            ulong validGroupsCounter = 0;
            foreach (var g in groups)
            {
                var newRow = row.Remove(g.Index, g.Length);
                newRow = newRow.Insert(g.Index, string.Join("", Enumerable.Range(0, g.Length).Select(_ => '.').ToArray()));
                if (newRow.Contains("d"))
                {
                    continue;
                }
                
                validGroupsCounter++;
            }

            // Console.WriteLine($"{row}: {validGroupsCounter}");
            cache[(key1, key2)] = validGroupsCounter;
            return validGroupsCounter;
        }

        ulong ways = 0;
        for (int i = 0; i < groups.Length; i++)
        {
            var group = groups.ElementAt(i);
            if (group.Index - 1 >= 0 && row[group.Index - 1] == 'd')
            {
                cache[(key1, key2)] = ways;
                return ways;
            }
            
            var newStart = group.Index + group.Length;
            if (newStart >= row.Length)
            {
                cache[(key1, key2)] = ways;
                return ways;
            }

            var newRow = row.Remove(group.Index, group.Length);
            newRow = newRow.Insert(group.Index, string.Join("", Enumerable.Range(0, group.Length).Select(_ => '.').ToArray()));

            if (newRow.IndexOf("d") > -1 && newRow.IndexOf("d") < group.Index)
            {
                cache[(key1, key2)] = ways;
                return ways;
            }
                
            var count = newRow.Count(x => x == 'u' || x == 'd');
            if (count < newList.Sum(x => x))
            {
                cache[(key1, key2)] = ways;
                return ways;
            }
            
            ways += Replace(newRow, newList, group.Index, cache);
        }

        cache[(key1, key2)] = ways;
        return ways;
    }
}