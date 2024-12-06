namespace adventofcode2022._2024._6;

public static class _6
{
    private static Dictionary<char, (int x, int y)> moveVectors = new()
    {
        { '^', (-1, 0) },
        { '>', (0, 1) },
        { 'v', (1, 0) },
        { '<', (0, -1) }
    };
    
    static Dictionary<char, char> rotationMap = new()
    {
        { '^', '>' },
        { '>', 'v' },
        { 'v', '<' },
        { '<', '^' }
    };
    
    public static void Run_1()
    {
        var input = File.ReadAllLines(Path.Combine("2024", "6", "input.txt")).Select(x => x.ToCharArray()).ToArray();
        var start = '^';
        
        for (var i = 0; i < input.Length; i++)
            for (var j = 0; j < input[i].Length; j++)
                if (input[i][j] == start)
                {
                    HashSet<(int, int, char)> uniqueSteps = new();
                    FindCycle(input, (i, j), start, uniqueSteps);
                    var uniquePositions = uniqueSteps.Select(x => (x.Item1, x.Item2)).Distinct().Count();
                    Console.WriteLine(uniquePositions);
                    return;
                }
        
    }

    static bool FindCycle(char[][] map, (int x, int y) pos, char dir, HashSet<(int, int, char)> history)
    {
        var move = moveVectors[dir];

        try
        {
            if (map[pos.x][pos.y] == '#')
            {
                pos.x += -1 * move.x;
                pos.y += -1 * move.y;
                return FindCycle(map, pos, rotationMap[dir], history);
            }
        }
        catch (IndexOutOfRangeException)
        {
            return false;
        }

        if (!history.Add((pos.x, pos.y, dir)))
            return true;
        
        return FindCycle(map, (pos.x + move.x, pos.y + move.y), dir, history);
    }
    
    public static void Run_2()
    {
        var input = File.ReadAllLines(Path.Combine("2024", "6", "input.txt")).Select(x => x.ToCharArray()).ToArray();
        var start = '^';
        
        HashSet<(int, int, char)> uniqueSteps = new();
        var startPos = (0, 0);
        
        for (var i = 0; i < input.Length; i++)
        for (var j = 0; j < input[i].Length; j++)
            if (input[i][j] == start)
            {
                startPos = (i, j);
                FindCycle(input, (i, j), start, uniqueSteps);
                break;
            }

        var counter = 0;
        uniqueSteps.Remove(uniqueSteps.First());
        var uniquePositions = uniqueSteps.Select(x => (x.Item1, x.Item2)).Distinct();
        foreach (var pos in uniquePositions)
        {
            var newInput = File.ReadAllLines(Path.Combine("2024", "6", "input.txt")).Select(x => x.ToCharArray()).ToArray();
                
            newInput[pos.Item1][pos.Item2] = '#';
            if (FindCycle(newInput, startPos, start, new HashSet<(int, int, char)>()))
                counter++;
        }
        
        Console.WriteLine($"{counter}");
    }
}