using System.Text.RegularExpressions;

namespace adventofcode2022._2023;

public class _12 {
    public static void Run()
    {
        var input = File.ReadAllLines("example.txt")
            .Select(x => new
            {
                Row = string.Join("u", Enumerable.Range(0, 5).Select(_ => new string(x.Split(" ")[0].ToArray())))
                    .Replace("#", "d")
                    .Replace(".", "o")
                    .Replace("?", "u"),
                BrokenList = string.Join(",", Enumerable.Range(0, 5).Select(_ => x.Split(" ")[1]))
                    .Split(",")
                    .Select(y => int.Parse(y))
                    .ToList()
            }).ToArray();

        var c = 0;
        foreach (var entry in input)
        {
            Console.WriteLine(c++);
            Replace(entry.Row, entry.BrokenList, -1);
        }
        
        Console.WriteLine($"RESULT: {results.Sum()}");
        Console.ReadKey();
        
        // 10154 - too high
    }

    private static List<int> results = new();

    static int Replace(string row, List<int> brokenList, int previousGroupIdx)
    {
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
            var validGroupsCounter = 0;
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
            return validGroupsCounter;
        }
        
        for (int i = 0; i < groups.Length; i++)
        {
            var group = groups.ElementAt(i);
            if (group.Index - 1 >= 0 && row[group.Index - 1] == 'd')
            {
                return 0;
            }
            
            var newStart = group.Index + group.Length;
            if (newStart >= row.Length)
            {
                return 0;
            }

            var newRow = row.Remove(group.Index, group.Length);
            newRow = newRow.Insert(group.Index, string.Join("", Enumerable.Range(0, group.Length).Select(_ => '.').ToArray()));

            if (newRow.IndexOf("d") > -1 && newRow.IndexOf("d") < group.Index)
            {
                return 0;
            }
                
            var count = newRow.Count(x => x == 'u' || x == 'd');
            if (count < newList.Sum(x => x))
            {
                return 0;
            }
            
            var result = Replace(newRow, newList, group.Index);
            if (result > 0)
            {
                results.Add(result);
                // Console.WriteLine(result);
            }
        }

        return 0;
    }
}