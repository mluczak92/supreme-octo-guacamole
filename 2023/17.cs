using System.Diagnostics.CodeAnalysis;

namespace adventofcode2022._2023;

public class _17 {
    public record Node(int Row, int Col, int G, int H, int F, Node? Parent)
    {
        public int G { get; set; } = G;
        public int H { get; set; } = H;
        public int F { get; set; } = F;
        public char Direction { get; set; }
        public int SameDirectionCounter { get; set; }
    }

    private static string[] _map = Array.Empty<string>();

    public static void Run()
    {
        _map = File.ReadAllLines("input.txt");
        
        //https://www.geeksforgeeks.org/a-search-algorithm/
        var openPq = new PriorityQueue<Node, int>();
        var openHs = new HashSet<Node>();
        var closedHs = new HashSet<(int r, int c, int f)>();

        var firstNode = new Node(0, 0, 0, 0, 0, null);
        openPq.Enqueue(firstNode, 0);
        openHs.Add(firstNode);

        var counter = 1;
        while (true)
        {
            if (counter++ % 10000 == 0)
            {
                Console.WriteLine($"{counter}: {openHs.Count}, {closedHs.Count}, {openHs.Select(x => x.Row).Max()}, {openHs.Select(x => x.Col).Max()}");
            }
            
            var q = openPq.Dequeue();
            openHs.Remove(q);
            
            var successors = GetSuccessors(q!);
            foreach (var suc in successors)
            {
                if (suc.Row == _map.Length - 1 &&
                    suc.Col == _map[0].Length - 1)
                {
                    Print(suc);
                    return;
                }

                if (openHs.Any(x =>
                        x.Row == suc.Row &&
                        x.Col == suc.Col &&
                        x.Parent?.Row == suc.Parent?.Row &&
                        x.Parent?.Col == suc.Parent?.Col &&
                        x.Parent?.Parent?.Row == suc.Parent?.Parent?.Row &&
                        x.Parent?.Parent?.Col == suc.Parent?.Parent?.Col &&
                        x.Parent?.Parent?.Parent?.Row == suc.Parent?.Parent?.Parent?.Row &&
                        x.Parent?.Parent?.Parent?.Col == suc.Parent?.Parent?.Parent?.Col &&
                        x.F < suc.F))
                {
                    continue;
                }
                
                if (closedHs.Any(x =>
                        x.r == suc.Row &&
                        x.c == suc.Col &&
                        x.f < suc.F))
                {
                    continue;
                }

                openPq.Enqueue(suc, suc.F);
                openHs.Add(suc);
            }
            
            closedHs.Add((q.Row, q.Col, q.F));
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
            // no backtracking
            (node.Parent == null ||
             node.Parent.Row != node.Row + rOffset ||
             node.Parent.Col != node.Col + cOffset))
        {
            if (node.SameDirectionCounter == 3 && node.Direction == direction)
            {
                return false;
            }
            
            suc = new Node(node.Row + rOffset, node.Col + cOffset, 0, 0, 0, node);
            suc.G = node.G + int.Parse(_map[suc.Row][suc.Col].ToString());
            suc.H = CalcH(suc);
            suc.F = suc.G + suc.H;
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
    
    private static int CalcH(Node node)
    {
        return Math.Abs(node.Row - _map.Length - 1) +
               Math.Abs(node.Col - _map[0].Length - 1);
    }

    private static void Print(Node node)
    {
        while (true)
        {
            Console.WriteLine($"{node.Row}, {node.Col} : {node.G}");
            if (node.Parent == null)
            {
                return;
            }

            node = node.Parent;
        }
    }
}