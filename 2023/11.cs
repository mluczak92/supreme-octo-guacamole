namespace adventofcode2022._2023;

public class _11
{
    public static void Run()
    {
        var galaxies = File.ReadAllLines("input.txt")
            .ToList();

        var rows = new List<int>();
        var columns = new List<int>();

        for (int i = galaxies.Count - 1; i >= 0; i--)
        {
            if (galaxies[i].All(x => x == '.'))
            {
                rows.Add(i);
            }
        }

        for (int i = galaxies[0].Length - 1; i >= 0; i--)
        {
            if (galaxies.All(x => x[i] == '.'))
            {
                columns.Add(i);
            }
        }

        List<(int, int)> coords = new List<(int, int)>();
        for (int i = 0; i < galaxies.Count; i++)
        {
            for (int j = 0; j < galaxies[0].Length; j++)
            {
                if (galaxies[i][j] == '#')
                {
                    coords.Add((i, j));
                }
            }
        }

        long counter = 0l;
        foreach (var coord1 in coords)
        {
            foreach (var coord2 in coords.Where(x => x != coord1))
            {
                var rowLower = Math.Min(coord1.Item1, coord2.Item1);
                var rowBigger = Math.Max(coord1.Item1, coord2.Item1);
                var rowCount = rows.Count(x => x > rowLower && x <= rowBigger);
                var rowDiff = Math.Abs(coord1.Item1 - coord2.Item1);
                var rowResult = rowDiff + (rowCount * 1000000) - rowCount;
                
                var colLower = Math.Min(coord1.Item2, coord2.Item2);
                var colBigger = Math.Max(coord1.Item2, coord2.Item2);
                var colCount = columns.Count(x => x > colLower && x <= colBigger);
                var colDiff = Math.Abs(coord1.Item2 - coord2.Item2);
                var colResult = colDiff + (colCount * 1000000) - colCount;
                
                counter += rowResult + colResult;
            }
        }
        
        Console.WriteLine(counter / 2);
    }
}