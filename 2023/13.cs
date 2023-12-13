namespace adventofcode2022._2023;

public class _13 {
    public static void Run()
    {
        var input = File.ReadAllText("input.txt")
            .Split("\r\n\r\n")
            .Select(x => x.Split("\r\n")
                .ToArray())
            .ToArray();

        var rowsCounter = 0;
        var columnsCounter = 0;
        
        foreach (var pattern in input)
        {
            // ROWS
            var result = RowsAboveMirror(pattern);
            if (result > 0)
            {
                rowsCounter += result;
                continue;
            }
            
            // COLUMNS
            var transposed = Transpose(pattern);
            result = RowsAboveMirror(transposed);
            columnsCounter += result;
        }
        
        Console.WriteLine($"{rowsCounter}, {columnsCounter} = {rowsCounter * 100 + columnsCounter}");
    }

    static int RowsAboveMirror(string[] pattern)
    {
        var result = 0;
        for (var i = 0.5; i < pattern.Length - 1; i++)
        {
            var howFar = 0;
            var smudgesCounter = 0;
            while (true)
            {
                var previous = (int)Math.Floor(i) - howFar;
                var next = (int)Math.Ceiling(i) + howFar;
                    
                if (previous < 0 || next == pattern.Length)
                {
                    if (smudgesCounter == 1)
                    {
                        result += (int)Math.Ceiling(i);
                    }

                    break;
                }

                if (pattern[previous] != pattern[next])
                {
                    for (int j = 0; j < pattern[previous].Length; j++)
                    {
                        if (pattern[previous][j] != pattern[next][j])
                        {
                            smudgesCounter++;
                        }
                    }
                }
                    
                howFar++;
            }
        }

        return result;
    }
    
    static string[] Transpose(string[] matrix)  
    {  
        var rows = matrix.GetLength(0);
        var columns = matrix[0].Length;

        var result = new string[columns]; 
        for (var c = 0; c < columns; c++)  
        {  
            for (var r = 0; r < rows; r++)  
            {  
                result[c] += matrix[r][c];  
            }  
        }
        
        return result;  
    }  
}