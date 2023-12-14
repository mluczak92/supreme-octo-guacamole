namespace adventofcode2022._2023;

public class _14 {
    public static void Run()
    {
        var history = new List<string>();
        var input = File.ReadAllLines("input.txt");
        var cycles = 1000000000;
        var firstDuplicateIdx = 0;

        for (int i = 0; i < cycles; i++)
        {
            var stringInput = string.Join("", input);
            var index = history.IndexOf(stringInput);
            if (index > -1)
            {
                firstDuplicateIdx = index;
                history.RemoveRange(0, index);
                break;
            }
            
            history.Add(stringInput);
            Cycle(input);
        }

        var remaining = (cycles - firstDuplicateIdx) % history.Count;
        for (int i = 0; i < remaining; i++)
        {
            Cycle(input);
        }

        var result = input
            .Select((x, idx) =>
            {
                return (input.Length - idx) * x.Count(y => y == 'O');
            })
            .Sum();
        
        Console.WriteLine($"RESULT: {result}");
    }

    static void Cycle(string[] input)
    {
        // NORTH
        for (var i = 0; i < input.Length; i++)
        {
            var row = input[i];
            for (var j = 0; j < row.Length; j++)
            {
                if (row[j] != 'O')
                    continue;
                
                var newI = i;
                var k = i - 1;
                while (k >= 0)
                {
                    if (input[k][j] != '.')
                        break;
                        
                    newI = k;
                    k--;
                }

                if (newI == i)
                    continue;
                
                input[i] = input[i].Remove(j, 1).Insert(j, ".");
                input[newI] = input[newI].Remove(j, 1).Insert(j, "O");
            }
        }
        
        // WEST
        for (var i = 0; i < input.Length; i++)
        {
            var row = input[i];
            for (var j = 0; j < row.Length; j++)
            {
                if (row[j] != 'O')
                    continue;
                
                var newJ = j;
                var k = j - 1;
                while (k >= 0)
                {
                    if (input[i][k] != '.')
                        break;
                        
                    newJ = k;
                    k--;
                }

                if (newJ == j)
                    continue;
                
                input[i] = input[i].Remove(j, 1).Insert(j, ".");
                input[i] = input[i].Remove(newJ, 1).Insert(newJ, "O");
            }
        }
        
        // SOUTH
        for (var i = input.Length - 1; i >= 0; i--)
        {
            var row = input[i];
            for (var j = 0; j < row.Length; j++)
            {
                if (row[j] != 'O')
                    continue;
                
                var newI = i;
                var k = i + 1;
                while (k < input.Length)
                {
                    if (input[k][j] != '.')
                        break;
                        
                    newI = k;
                    k++;
                }
        
                if (newI == i)
                    continue;
                
                input[i] = input[i].Remove(j, 1).Insert(j, ".");
                input[newI] = input[newI].Remove(j, 1).Insert(j, "O");
            }
        }
        
        // EAST
        for (var i = 0; i < input.Length; i++)
        {
            var row = input[i];
            for (var j = row.Length - 1; j >= 0; j--)
            {
                if (row[j] != 'O')
                    continue;
                
                var newJ = j;
                var k = j + 1;
                while (k < row.Length)
                {
                    if (input[i][k] != '.')
                        break;
                        
                    newJ = k;
                    k++;
                }

                if (newJ == j)
                    continue;
                
                input[i] = input[i].Remove(j, 1).Insert(j, ".");
                input[i] = input[i].Remove(newJ, 1).Insert(newJ, "O");
            }
        }
    }
}