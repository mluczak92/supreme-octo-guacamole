namespace adventofcode2022._2023;

public class _16
{
    private static string[] input;
    private static HashSet<(int row, int col)> visited = new();
    private static HashSet<(int row, int col, string direction)> history = new();
    
    public static void Run()
    {
        input = File.ReadAllLines("input.txt");
        
        var nextPositions = NextPositions((0, 0), "r");
        foreach (var pos in nextPositions)
        {
            Visit((0, 0), pos.dir, (pos.row, pos.col));
        }

        Console.WriteLine(visited.Count);
    }

    static IEnumerable<(int row, int col, string dir)> NextPositions((int row, int col) curr, string direction)
    {
        var elem = input[curr.row][curr.col];
        switch (direction)
        {
            case "r":
                return elem switch
                {
                    '.' => new[] { (curr.row, curr.col + 1, direction) },
                    '-' => new[] { (curr.row, curr.col + 1, direction) },
                    '\\' => new[] { (curr.row + 1, curr.col, "d") },
                    '|' => new[] { (curr.row - 1, curr.col, "u"), (curr.row + 1, curr.col, "d") },
                    '/' => new[] { (curr.row - 1, curr.col, "u") },
                    _ => throw new Exception()
                };
            case "d":
                return elem switch
                {
                    '.' => new[] { (curr.row + 1, curr.col, direction) },
                    '-' => new[] { (curr.row, curr.col + 1, "r"), (curr.row, curr.col - 1, "l") },
                    '\\' => new[] { (curr.row, curr.col + 1, "r") },
                    '|' => new[] { (curr.row + 1, curr.col, direction) },
                    '/' => new[] { (curr.row, curr.col - 1, "l") },
                    _ => throw new Exception()
                };
            case "l":
                return elem switch
                {
                    '.' => new[] { (curr.row, curr.col - 1, direction) },
                    '-' => new[] { (curr.row, curr.col - 1, direction) },
                    '\\' => new[] { (curr.row - 1, curr.col, "u") },
                    '|' => new[] { (curr.row - 1, curr.col, "u"), (curr.row + 1, curr.col, "d") },
                    '/' => new[] { (curr.row + 1, curr.col, "d") },
                    _ => throw new Exception()
                };
            case "u":
                return elem switch
                {
                    '.' => new[] { (curr.row - 1, curr.col, direction) },
                    '-' => new[] { (curr.row, curr.col + 1, "r"), (curr.row, curr.col - 1, "l") },
                    '\\' => new[] { (curr.row, curr.col - 1, "l") },
                    '|' => new[] { (curr.row - 1, curr.col, direction) },
                    '/' => new[] { (curr.row, curr.col + 1, "r") },
                    _ => throw new Exception()
                };
            default: throw new Exception(); 
        }
    }

    static void Visit((int row, int col) curr, string direction, (int row, int col) next)
    {
        // been there, done that
        if (history.Contains((curr.row, curr.col, direction)))
        {
            return;
        }

        visited.Add((curr.row, curr.col));
        // Console.WriteLine($"{curr.row}, {curr.col}");
        history.Add((curr.row, curr.col, direction));
        
        // out of boundaries
        if (next.col < 0 || next.col == input[0].Length ||
            next.row < 0 || next.row == input.Length)
        {
            return;
        }
        
        var nextPositions = NextPositions(next, direction);
        foreach (var pos in nextPositions)
        {
            Visit(next, pos.dir, (pos.row, pos.col));
        }
    }
}