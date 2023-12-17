using System.Diagnostics.CodeAnalysis;

namespace adventofcode2022._2023;

public class _17_2 {
    private record Node(int Row, int Col)
    {
        public int Distance { get; set; }
        public char Direction { get; set; }
        public int SameDirectionCounter { get; set; }
        public HashSet<(int, int)> History { get; set; } = new();
    }

    private static string[] _map = Array.Empty<string>();
    private static int shortestFound = int.MaxValue;

    public static void Run()
    {
        _map = File.ReadAllLines("example.txt");
        GoTo(new Node(0, 0));
    }

    private static void GoTo(Node node)
    {
        var successors = GetSuccessors(node);
        foreach (var suc in successors)
        {
            if (suc.Distance > shortestFound)
            {
                continue;
            }
            
            if (suc.Row == _map.Length - 1 && suc.Col == _map[0].Length - 1)
            {
                if (suc.Distance < shortestFound)
                {
                    shortestFound = suc.Distance;
                    Console.WriteLine(shortestFound);
                }
                
                return;
            }

            GoTo(suc);
        }
    }

    private static IEnumerable<Node> GetSuccessors(Node node)
    {
        var result = new List<Node>();
        if (TryGetSuccessor(node, -1, 0, 'd', out var successor)) result.Add(successor);
        if (TryGetSuccessor(node, 0, -1, 'l', out successor)) result.Add(successor);
        if (TryGetSuccessor(node, 0, 1, 'r', out successor)) result.Add(successor);
        if (TryGetSuccessor(node, 1, 0, 'u', out successor)) result.Add(successor);
        return result;
    }

    private static bool TryGetSuccessor(Node node, int rOffset, int cOffset, char direction, [NotNullWhen(true)] out Node? suc)
    {
        suc = null;
        
            // row boundaries
        if (node.Row + rOffset >= 0 &&
            node.Row + rOffset < _map.Length &&
            // col boundaries
            node.Col + cOffset >= 0 &&
            node.Col + cOffset < _map[0].Length &&
            // no loops
            !node.History.Contains((node.Row + rOffset, node.Col + cOffset)))
        {
            if (node.SameDirectionCounter == 3 && node.Direction == direction)
            {
                return false;
            }
            
            suc = new Node(node.Row + rOffset, node.Col + cOffset);
            suc.History = node.History.ToHashSet();
            suc.History.Add((node.Row, node.Col));
            
            suc.Distance = node.Distance + int.Parse(_map[suc.Row][suc.Col].ToString());
            suc.Direction = direction;
            
            suc.SameDirectionCounter = node.SameDirectionCounter;
            if (node.Direction == suc.Direction)
            {
                suc.SameDirectionCounter++;
            }
            else
            {
                suc.SameDirectionCounter = 1;
            }
            
            return true;
        }
        
        return false;
    }
    
    // private static int CalcH(Node node)
    // {
    //     return 0;
    // }
    //
    // private static void Print(Node node)
    // {
    //     while (true)
    //     {
    //         Console.Write($"{node.Row},{node.Col}: {node.Distance} ->");
    //         if (node.Parent == null)
    //         {
    //             Console.WriteLine();
    //             return;
    //         }
    //
    //         node = node.Parent;
    //     }
    // }
    //
    // private static bool IsLoop(Node node, Node suc)
    // {
    //     if (node.Row == suc.Row &&
    //         node.Col == suc.Col)
    //     {
    //         return true;
    //     }
    //
    //     if (node.Parent == null)
    //     {
    //         return false;
    //     }
    //
    //     return IsLoop(node.Parent, suc);
    // }
}