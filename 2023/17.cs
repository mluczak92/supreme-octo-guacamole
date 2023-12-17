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
        // 948 - too high
        // 944 - too high
        
        _map = File.ReadAllLines("input.txt");
        
        //https://www.geeksforgeeks.org/a-search-algorithm/
        var openPq = new PriorityQueue<Node, int>();
        var openDic = new Dictionary<(int r, int c, int pR, int pC, int gpR, int gpC, int ggpR, int ggpC), int>();
        var closedDic = new Dictionary<(int r, int c, int pR, int pC, int gpR, int gpC, int ggpR, int ggpC), int>();

        var firstNode = new Node(0, 0, 0, 0, 0, null);
        openPq.Enqueue(firstNode, 0);
        openDic.Add((0, 0, -1, -1, -1, -1, -1, -1), 0);

        var counter = 0;
        while (true)
        {
            if (counter++ % 100000 == 0)
            {
                Console.WriteLine($"{counter}: {openDic.Count}, {closedDic.Count}");
            }
            
            var q = openPq.Dequeue();
            openDic.Remove((q.Row, q.Col,
                q.Parent?.Row ?? -1, q.Parent?.Col ?? -1,
                q.Parent?.Parent?.Row ?? -1, q.Parent?.Parent?.Col ?? -1,
                q.Parent?.Parent?.Parent?.Row ?? -1, q.Parent?.Parent?.Parent?.Col ?? -1));
            
            var successors = GetSuccessors(q!);
            foreach (var suc in successors)
            {
                if (suc.Row == _map.Length - 1 &&
                    suc.Col == _map[0].Length - 1)
                {
                    Print(suc);
                    return;
                }

                if (openDic.TryGetValue((suc.Row, suc.Col,
                        suc.Parent?.Row ?? -1, suc.Parent?.Col ?? -1,
                        suc.Parent?.Parent?.Row ?? -1, suc.Parent?.Parent?.Col ?? -1,
                        suc.Parent?.Parent?.Parent?.Row ?? -1, suc.Parent?.Parent?.Parent?.Col ?? -1), out var value))
                {
                    if (value < suc.F)
                    {
                        continue;
                    }
                }
                
                if (closedDic.TryGetValue((suc.Row, suc.Col,
                        suc.Parent?.Row ?? -1, suc.Parent?.Col ?? -1,
                        suc.Parent?.Parent?.Row ?? -1, suc.Parent?.Parent?.Col ?? -1,
                        suc.Parent?.Parent?.Parent?.Row ?? -1, suc.Parent?.Parent?.Parent?.Col ?? -1), out var valueClosed))
                {
                    if (valueClosed < suc.F)
                    {
                        continue;
                    }
                }

                openPq.Enqueue(suc, suc.F);
                openDic[(suc.Row, suc.Col,
                    suc.Parent?.Row ?? -1, suc.Parent?.Col ?? -1,
                    suc.Parent?.Parent?.Row ?? -1, suc.Parent?.Parent?.Col ?? -1,
                    suc.Parent?.Parent?.Parent?.Row ?? -1, suc.Parent?.Parent?.Parent?.Col ?? -1)] = suc.F;
            }

            closedDic[(q.Row, q.Col,
                q.Parent?.Row ?? -1, q.Parent?.Col ?? -1,
                q.Parent?.Parent?.Row ?? -1, q.Parent?.Parent?.Col ?? -1,
                q.Parent?.Parent?.Parent?.Row ?? -1, q.Parent?.Parent?.Parent?.Col ?? -1)] = q.F;
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
        return 0;
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