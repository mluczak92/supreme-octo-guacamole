using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace adventofcode2022._2022
{
    internal class _16
    {
        //sample 1651
        //static string args = "Valve AA has flow rate=0; tunnels lead to valves DD, II, BB\r\nValve BB has flow rate=13; tunnels lead to valves CC, AA\r\nValve CC has flow rate=2; tunnels lead to valves DD, BB\r\nValve DD has flow rate=20; tunnels lead to valves CC, AA, EE\r\nValve EE has flow rate=3; tunnels lead to valves FF, DD\r\nValve FF has flow rate=0; tunnels lead to valves EE, GG\r\nValve GG has flow rate=0; tunnels lead to valves FF, HH\r\nValve HH has flow rate=22; tunnel leads to valve GG\r\nValve II has flow rate=0; tunnels lead to valves AA, JJ\r\nValve JJ has flow rate=21; tunnel leads to valve II";

        //REAL INPUT
        static string args = "Valve MO has flow rate=0; tunnels lead to valves QM, ED\r\nValve JB has flow rate=0; tunnels lead to valves MH, ZU\r\nValve BA has flow rate=0; tunnels lead to valves XY, FF\r\nValve UW has flow rate=0; tunnels lead to valves EU, SX\r\nValve VS has flow rate=0; tunnels lead to valves MH, QW\r\nValve IK has flow rate=0; tunnels lead to valves KF, SK\r\nValve EU has flow rate=10; tunnels lead to valves DX, UW, RY, NC\r\nValve OA has flow rate=0; tunnels lead to valves SX, FF\r\nValve NC has flow rate=0; tunnels lead to valves ZZ, EU\r\nValve YB has flow rate=0; tunnels lead to valves EO, KF\r\nValve VI has flow rate=0; tunnels lead to valves FF, KF\r\nValve KQ has flow rate=0; tunnels lead to valves TZ, QL\r\nValve WU has flow rate=0; tunnels lead to valves NT, NW\r\nValve IE has flow rate=0; tunnels lead to valves UQ, ZU\r\nValve UQ has flow rate=0; tunnels lead to valves IE, VC\r\nValve KF has flow rate=7; tunnels lead to valves YB, RZ, IK, PG, VI\r\nValve XY has flow rate=18; tunnels lead to valves WZ, DG, BA, ZZ, PN\r\nValve MJ has flow rate=0; tunnels lead to valves SX, PN\r\nValve KJ has flow rate=0; tunnels lead to valves QW, ZU\r\nValve VC has flow rate=16; tunnels lead to valves UQ, HN\r\nValve SO has flow rate=0; tunnels lead to valves NW, PW\r\nValve NW has flow rate=3; tunnels lead to valves TY, WI, ED, SO, WU\r\nValve SZ has flow rate=0; tunnels lead to valves YQ, FF\r\nValve KU has flow rate=0; tunnels lead to valves WI, MH\r\nValve QL has flow rate=9; tunnels lead to valves KQ, DW, DX\r\nValve JF has flow rate=0; tunnels lead to valves NK, NT\r\nValve KD has flow rate=0; tunnels lead to valves JK, NQ\r\nValve ED has flow rate=0; tunnels lead to valves NW, MO\r\nValve SX has flow rate=21; tunnels lead to valves JK, MJ, OA, UW\r\nValve GD has flow rate=0; tunnels lead to valves ZT, NT\r\nValve ZU has flow rate=19; tunnels lead to valves KJ, JB, DN, IE\r\nValve HN has flow rate=0; tunnels lead to valves QW, VC\r\nValve DN has flow rate=0; tunnels lead to valves UX, ZU\r\nValve TZ has flow rate=17; tunnel leads to valve KQ\r\nValve RY has flow rate=0; tunnels lead to valves EU, UL\r\nValve MH has flow rate=15; tunnels lead to valves KU, JB, VS, NK, GA\r\nValve FF has flow rate=12; tunnels lead to valves UL, SZ, OA, VI, BA\r\nValve NK has flow rate=0; tunnels lead to valves MH, JF\r\nValve HR has flow rate=0; tunnels lead to valves AA, SA\r\nValve PG has flow rate=0; tunnels lead to valves KF, TY\r\nValve PN has flow rate=0; tunnels lead to valves XY, MJ\r\nValve UX has flow rate=0; tunnels lead to valves DN, NT\r\nValve WZ has flow rate=0; tunnels lead to valves NQ, XY\r\nValve DG has flow rate=0; tunnels lead to valves SL, XY\r\nValve XM has flow rate=0; tunnels lead to valves AA, GA\r\nValve UL has flow rate=0; tunnels lead to valves FF, RY\r\nValve AA has flow rate=0; tunnels lead to valves PW, ZT, XM, SK, HR\r\nValve GA has flow rate=0; tunnels lead to valves MH, XM\r\nValve PW has flow rate=0; tunnels lead to valves SO, AA\r\nValve NQ has flow rate=25; tunnels lead to valves YQ, WZ, KD\r\nValve SA has flow rate=0; tunnels lead to valves HR, QM\r\nValve QW has flow rate=23; tunnels lead to valves KJ, HN, VS\r\nValve SK has flow rate=0; tunnels lead to valves IK, AA\r\nValve YQ has flow rate=0; tunnels lead to valves SZ, NQ\r\nValve ZT has flow rate=0; tunnels lead to valves GD, AA\r\nValve QM has flow rate=8; tunnels lead to valves SL, SA, EO, DW, MO\r\nValve NT has flow rate=13; tunnels lead to valves WU, UX, RZ, JF, GD\r\nValve JK has flow rate=0; tunnels lead to valves SX, KD\r\nValve SL has flow rate=0; tunnels lead to valves DG, QM\r\nValve WI has flow rate=0; tunnels lead to valves KU, NW\r\nValve EO has flow rate=0; tunnels lead to valves QM, YB\r\nValve DW has flow rate=0; tunnels lead to valves QM, QL\r\nValve DX has flow rate=0; tunnels lead to valves EU, QL\r\nValve RZ has flow rate=0; tunnels lead to valves NT, KF\r\nValve TY has flow rate=0; tunnels lead to valves NW, PG\r\nValve ZZ has flow rate=0; tunnels lead to valves XY, NC";

        //correct 2640
        //static string args = "Valve AA has flow rate=0; tunnels lead to valves BA\r\nValve BA has flow rate=2; tunnels lead to valves AA, CA\r\nValve CA has flow rate=4; tunnels lead to valves BA, DA\r\nValve DA has flow rate=6; tunnels lead to valves CA, EA\r\nValve EA has flow rate=8; tunnels lead to valves DA, FA\r\nValve FA has flow rate=10; tunnels lead to valves EA, GA\r\nValve GA has flow rate=12; tunnels lead to valves FA, HA\r\nValve HA has flow rate=14; tunnels lead to valves GA, IA\r\nValve IA has flow rate=16; tunnels lead to valves HA, JA\r\nValve JA has flow rate=18; tunnels lead to valves IA, KA\r\nValve KA has flow rate=20; tunnels lead to valves JA, LA\r\nValve LA has flow rate=22; tunnels lead to valves KA, MA\r\nValve MA has flow rate=24; tunnels lead to valves LA, NA\r\nValve NA has flow rate=26; tunnels lead to valves MA, OA\r\nValve OA has flow rate=28; tunnels lead to valves NA, PA\r\nValve PA has flow rate=30; tunnels lead to valves OA";

        //correct 13468
        //static string args = "Valve AA has flow rate=0; tunnels lead to valves BA\r\nValve BA has flow rate=1; tunnels lead to valves AA, CA\r\nValve CA has flow rate=4; tunnels lead to valves BA, DA\r\nValve DA has flow rate=9; tunnels lead to valves CA, EA\r\nValve EA has flow rate=16; tunnels lead to valves DA, FA\r\nValve FA has flow rate=25; tunnels lead to valves EA, GA\r\nValve GA has flow rate=36; tunnels lead to valves FA, HA\r\nValve HA has flow rate=49; tunnels lead to valves GA, IA\r\nValve IA has flow rate=64; tunnels lead to valves HA, JA\r\nValve JA has flow rate=81; tunnels lead to valves IA, KA\r\nValve KA has flow rate=100; tunnels lead to valves JA, LA\r\nValve LA has flow rate=121; tunnels lead to valves KA, MA\r\nValve MA has flow rate=144; tunnels lead to valves LA, NA\r\nValve NA has flow rate=169; tunnels lead to valves MA, OA\r\nValve OA has flow rate=196; tunnels lead to valves NA, PA\r\nValve PA has flow rate=225; tunnels lead to valves OA";

        //??
        //static string args = "Valve BA has flow rate=2; tunnels lead to valves AA, CA\r\nValve CA has flow rate=10; tunnels lead to valves BA, DA\r\nValve DA has flow rate=2; tunnels lead to valves CA, EA\r\nValve EA has flow rate=10; tunnels lead to valves DA, FA\r\nValve FA has flow rate=2; tunnels lead to valves EA, GA\r\nValve GA has flow rate=10; tunnels lead to valves FA, HA\r\nValve HA has flow rate=2; tunnels lead to valves GA, IA\r\nValve IA has flow rate=10; tunnels lead to valves HA, JA\r\nValve JA has flow rate=2; tunnels lead to valves IA, KA\r\nValve KA has flow rate=10; tunnels lead to valves JA, LA\r\nValve LA has flow rate=2; tunnels lead to valves KA, MA\r\nValve MA has flow rate=10; tunnels lead to valves LA, NA\r\nValve NA has flow rate=2; tunnels lead to valves MA, OA\r\nValve OA has flow rate=10; tunnels lead to valves NA, PA\r\nValve PA has flow rate=2; tunnels lead to valves OA, AA\r\nValve AA has flow rate=0; tunnels lead to valves BA, PA";

        //correct 2400
        //static string args = "Valve AA has flow rate=0; tunnels lead to valves AB, BB, CB\r\nValve AB has flow rate=0; tunnels lead to valves AA, AC\r\nValve AC has flow rate=0; tunnels lead to valves AB, AD\r\nValve AD has flow rate=0; tunnels lead to valves AC, AE\r\nValve AE has flow rate=0; tunnels lead to valves AD, AF\r\nValve AF has flow rate=0; tunnels lead to valves AE, AG\r\nValve AG has flow rate=0; tunnels lead to valves AF, AH\r\nValve AH has flow rate=0; tunnels lead to valves AG, AI\r\nValve AI has flow rate=0; tunnels lead to valves AH, AJ\r\nValve AJ has flow rate=0; tunnels lead to valves AI, AK\r\nValve AK has flow rate=100; tunnels lead to valves AJ, AW, AX, AY, AZ\r\nValve AW has flow rate=10; tunnels lead to valves AK\r\nValve AX has flow rate=10; tunnels lead to valves AK\r\nValve AY has flow rate=10; tunnels lead to valves AK\r\nValve AZ has flow rate=10; tunnels lead to valves AK\r\nValve BB has flow rate=0; tunnels lead to valves AA, BC\r\nValve BC has flow rate=0; tunnels lead to valves BB, BD\r\nValve BD has flow rate=0; tunnels lead to valves BC, BE\r\nValve BE has flow rate=0; tunnels lead to valves BD, BF\r\nValve BF has flow rate=0; tunnels lead to valves BE, BG\r\nValve BG has flow rate=0; tunnels lead to valves BF, BH\r\nValve BH has flow rate=0; tunnels lead to valves BG, BI\r\nValve BI has flow rate=0; tunnels lead to valves BH, BJ\r\nValve BJ has flow rate=0; tunnels lead to valves BI, BK\r\nValve BK has flow rate=100; tunnels lead to valves BJ, BW, BX, BY, BZ\r\nValve BW has flow rate=10; tunnels lead to valves BK\r\nValve BX has flow rate=10; tunnels lead to valves BK\r\nValve BY has flow rate=10; tunnels lead to valves BK\r\nValve BZ has flow rate=10; tunnels lead to valves BK\r\nValve CB has flow rate=0; tunnels lead to valves AA, CC\r\nValve CC has flow rate=0; tunnels lead to valves CB, CD\r\nValve CD has flow rate=0; tunnels lead to valves CC, CE\r\nValve CE has flow rate=0; tunnels lead to valves CD, CF\r\nValve CF has flow rate=0; tunnels lead to valves CE, CG\r\nValve CG has flow rate=0; tunnels lead to valves CF, CH\r\nValve CH has flow rate=0; tunnels lead to valves CG, CI\r\nValve CI has flow rate=0; tunnels lead to valves CH, CJ\r\nValve CJ has flow rate=0; tunnels lead to valves CI, CK\r\nValve CK has flow rate=100; tunnels lead to valves CJ, CW, CX, CY, CZ\r\nValve CW has flow rate=10; tunnels lead to valves CK\r\nValve CX has flow rate=10; tunnels lead to valves CK\r\nValve CY has flow rate=10; tunnels lead to valves CK\r\nValve CZ has flow rate=10; tunnels lead to valves CK";

        static int _maxMinutes = 26;
        static Room[] rooms = new Room[] { };
        static Dictionary<(Room Room, Room Neighbor), int> paths = new Dictionary<(Room, Room), int>();
        static Stopwatch sw = new Stopwatch();

        //static Dictionary<int, SimulationStep> bestForStep = Enumerable.Range(2, 20).ToDictionary(x => x,
        //    x => new SimulationStep(null, 0, null, 0, 0));
        //static int cutAnotherBranches = 8;

        public static void Run()
        {
            sw.Start();
            ParseInput();
            FindShortestPathsBetweenRooms();
            rooms = rooms.Where((x, idx) => idx == 0 || x.FlowRate > 0).ToArray();

            var minPressure = 1250;
            var results = FindMostEfficientSimulation(8).Where(x => x.ExpectedPressure >= minPressure).ToArray();
            var otherResults = FindMostEfficientSimulation(9).Where(x => x.ExpectedPressure >= minPressure).ToArray();

            var ordered = results
                .SelectMany(left => otherResults, (x, y) => (FirstHalf: x, SecondHalf: y))
                .Where(x => !x.FirstHalf.OpenedNames.Intersect(x.SecondHalf.OpenedNames).Any())
                .OrderByDescending(x => x.FirstHalf.ExpectedPressure + x.SecondHalf.ExpectedPressure);

            var first = ordered.First();
            Console.WriteLine($"{first} = {first.FirstHalf.ExpectedPressure + first.SecondHalf.ExpectedPressure}");
            Console.WriteLine(sw.Elapsed);
        }

        static List<SimulationStep> FindMostEfficientSimulation(int maxLen)
        {
            List<SimulationStep> results = new List<SimulationStep>();
            Queue<SimulationStep> q = new Queue<SimulationStep>();

            var preOpened = rooms.Where(x => x.FlowRate == 0).Select(x => (Room: x, 0)).ToList();
            var simulationStep = new SimulationStep(rooms[0], _maxMinutes, preOpened, 0);

            q.Enqueue(simulationStep);
            while (q.Count > 0)
            {
                var currentQItem = q.Dequeue();
                if (currentQItem.Left <= 0 || currentQItem.Opened.Count == maxLen)
                {
                    results.Add(currentQItem);
                    continue;
                }

                //if (currentQItem.Opened.Count == cutAnotherBranches && bestForStep[currentQItem.Opened.Count].ExpectedPressure > currentQItem.ExpectedPressure)
                //{
                //    continue;
                //}

                var closedNeighbors = paths
                    .Where(x => x.Key.Room == currentQItem.Room)
                    .Where(x => !currentQItem.Opened.Any(y => y.Room == x.Key.Neighbor))
                    .ToArray();

                foreach (var n in closedNeighbors)
                {
                    var toSub = n.Value + 1;
                    var newOpened = new List<(Room Room, int Minutes)>(currentQItem.Opened);
                    for (int i = 0; i < newOpened.Count; i++)
                    {
                        newOpened[i] = (newOpened[i].Room, newOpened[i].Minutes + toSub);
                    }

                    newOpened.Add((n.Key.Neighbor, 0));
                    var expectedSum = newOpened.Sum(x =>
                    {
                        var expectedMinsLeft = Math.Max(0, x.Minutes + currentQItem.Left - toSub);
                        return x.Room.FlowRate * expectedMinsLeft;
                    });
                    var newStep = new SimulationStep(n.Key.Neighbor, currentQItem.Left - toSub, newOpened, expectedSum);

                    //if (bestForStep[newOpened.Count].ExpectedPressure < expectedSum)
                    //{
                    //    bestForStep[newOpened.Count] = newStep;
                    //}

                    q.Enqueue(newStep);
                }
            }

            return results;
        }

        class SimulationStep
        {
            public SimulationStep(Room room, int left, List<(Room Room, int Minutes)> opened, int expectedPressure)
            {
                Room = room;
                Left = left;
                Opened = opened;
                ExpectedPressure = expectedPressure;
                OpenedNames = opened.Skip(1).Select(x => x.Room.Name);
            }

            public Room Room { get; }
            public int Left { get; }
            public List<(Room Room, int Minutes)> Opened { get; }
            public IEnumerable<string> OpenedNames { get; }
            public int ExpectedPressure { get; }

            public override string ToString()
            {
                return $"{ExpectedPressure}: {string.Join("-", Opened.Select(x => x.Room))}";
            }
        }

        static void FindShortestPathsBetweenRooms()
        {
            foreach (var room in rooms.Where((x, idx) => idx == 0 || x.FlowRate > 0))
            {
                foreach (var neighbor in rooms.Where(x => x != room && x.FlowRate > 0))
                {
                    Queue<(Room, int)> q = new Queue<(Room, int)>();
                    q.Enqueue((room, 0));
                    while (q.Count > 0)
                    {
                        var current = q.Dequeue();
                        foreach (var c in current.Item1.Connections)
                        {
                            q.Enqueue((c, current.Item2 + 1));
                            if (c == neighbor)
                            {
                                goto Found;
                            }
                        }
                    }

                    Found:
                    var result = q.LastOrDefault();
                    paths.Add((room, neighbor), result.Item2);
                }
            }
        }

        static void ParseInput()
        {
            rooms = args.Split("\r\n")
                .Select(x => new Room(x.Substring(6, 2), int.Parse(Regex.Match(x, "\\d+").Value)))
                .ToArray();

            var splitted = args.Split("\r\n");
            for (int i = 0; i < rooms.Length; i++)
            {
                var connected = new string[] { };
                var values = Regex.Match(splitted[i], "valve (.*)").Groups;
                if (values.Count == 2)
                {
                    connected = values[1].Value.Split(", ");
                }
                else if (values.Count == 1)
                {
                    values = Regex.Match(splitted[i], "valves (.*)").Groups;
                    connected = values[1].Value.Split(", ");
                }

                rooms[i].Connections.AddRange(rooms.Where(x => connected.Contains(x.Name)));
            }

            rooms = rooms.OrderBy(x => x.Name).ToArray();
        }

        class Room
        {
            public Room(string name, int flowRate)
            {
                Name = name;
                FlowRate = flowRate;
            }

            public string Name { get; }
            public int FlowRate { get; }
            public List<Room> Connections { get; } = new List<Room>();

            public override string ToString()
            {
                return Name;
            }
        }
    }
}
