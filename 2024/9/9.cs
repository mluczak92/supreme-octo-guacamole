namespace adventofcode2022._2024._9;

public static class _9
{
    public static void Run_1()
    {
        var input = File.ReadAllText(Path.Combine("2024", "9", "testInput.txt"))
            .Select(x => int.Parse(x.ToString()))
            .Select((x, i) => i % 2 == 0
                ? (block: string.Join("", Enumerable.Repeat($"{i / 2}", x)), size: (i / 2).ToString().Length, hasData: true)
                : (block: string.Join("", Enumerable.Repeat(".", x)), size: (i / 2).ToString().Length, hasData: false))
            .ToArray();

        var digits = 0;
        for (var i = 0; i < input.Length; i++)
        {
            if (input[i].hasData) continue;
            for (var j = input.Length - 1; j >= i; j--)
            {
                if (!input[j].hasData) continue;
                (input[i], input[j]) = (input[j], input[i]);
                break;
            }
        }
        
        
        var result = 0L;
        var inputString = string.Join("", Enumerable.Repeat("0", input.Length));
        for (var i = 0; i < inputString.Length; i++)
        {
            var t = inputString[i];
            if (t == '.') break;
            result += int.Parse(t.ToString()) * i;
        }
        
        Console.WriteLine(result);
    }
    
    // 89514618001 too low
    // 5597065249
}