using System.Collections.Specialized;

namespace adventofcode2022._2023;

public class _15 {
    public static void Run()
    {
        var sequence = File.ReadAllText("input.txt")
            .Split(",")
            .ToArray();

        Dictionary<int, OrderedDictionary> HASHMAP = new Dictionary<int, OrderedDictionary>();
        foreach (var step in sequence)
        {
            var split = step.Split('=', '-');
            var label = split[0];
            
            var key = Hash(label);
            if (!HASHMAP.ContainsKey(key) && step.Contains('='))
            {
                HASHMAP.Add(key, new OrderedDictionary{ { label, int.Parse(split[1]) } });
            }
            else
            {
                if (step.Contains('-'))
                {
                    if (HASHMAP.TryGetValue(key, out var value))
                    {
                        value.Remove(label);
                    }
                }
                else if (step.Contains('='))
                {
                    if (HASHMAP.TryGetValue(key, out var value))
                    {
                        value[label] = int.Parse(split[1]);
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
        }

        var focusingPower = 0;
        for (int i = 0; i < 256; i++)
        {
            if (!HASHMAP.ContainsKey(i))
                continue;
            
            var innerDic = HASHMAP[i];
            for (int j = 0; j < innerDic.Count; j++)
            {
                // Console.WriteLine($"{i + 1} * {j + 1} * {(int)innerDic[j]}");
                focusingPower += (i + 1) * (j + 1) * (int)innerDic[j];
            }
        }
        
        Console.WriteLine(focusingPower);
    }

    static int Hash(string input)
    {
        var current = 0;
        foreach (var @char in input)
        {
            current += @char;
            current *= 17;
            current %= 256;
        }

        return current;
    }
}