namespace adventofcode2022._2024._8;

public static class _8
{
    public static void Run_1()
    {
        var antennas = new Dictionary<char, List<(int x, int y)>>();
        
        var input = File.ReadAllLines(Path.Combine("2024", "8", "input.txt")).Select(x => x.ToCharArray()).ToArray();
        // var antinodes = new HashSet<(int x, int y)>();
        var antinodesMap = input.Select(x => x.Select(_ => '.').ToArray()).ToArray(); 
            
        for (var i = 0; i < input.Length; i++)
            for (var j = 0; j < input[0].Length; j++)
                if (input[i][j] != '.')
                {
                    if (antennas.ContainsKey(input[i][j]))
                        antennas[input[i][j]].Add((i, j));
                    else
                        antennas.Add(input[i][j], new List<(int x, int y)> { (i, j) });
                }

        foreach (var a in antennas.Where(x => x.Value.Count > 1))
            for (var i = 0; i < a.Value.Count; i++)
                for (var j = i + 1; j < a.Value.Count; j++)
                {
                    var first = a.Value[i];
                    var second = a.Value[j];

                    var xDiff = second.x - first.x;
                    var yDiff = second.y - first.y;

                    // antinodes.Add((first.x - xDiff, first.y - yDiff));
                    // antinodes.Add((second.x + xDiff, second.y + yDiff));

                    for (var k = 0;; k++)
                    {
                        try { antinodesMap[first.x - xDiff * k][first.y - yDiff * k] = '#'; }
                        catch (IndexOutOfRangeException) { break; }
                    }
                    
                    for (var k = 0;; k++)
                    {
                        try { antinodesMap[second.x + xDiff * k][second.y + yDiff * k] = '#'; }
                        catch (IndexOutOfRangeException) { break; }
                    }
                }
        
        // Console.WriteLine(antinodes.Count(a =>
        //     a is { x: >= 0, y: >= 0 } && 
        //     a.y < input[0].Length && a.x < input.Length));
        
        Console.WriteLine(antinodesMap.Sum(x => x.Sum(y => y == '#' ? 1 : 0)));
    }
}