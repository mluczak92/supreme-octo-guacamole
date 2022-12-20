using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace adventofcode2022._2022
{
    internal class _16_2
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
        static List<SimulationStep> results = new List<SimulationStep>();
        static Stopwatch sw = new Stopwatch();

        //static Dictionary<int, List<(string start, int value)>> starts = Enumerable.Range(0, 20).ToDictionary(x => x, _ => new List<(string start, int value)> { ("-", 0) });
        //static int counter = 0;
        //static int startCheckingIdx = 8;
        //static int checkBack = 3;
        //static int howManyBests = 50;
        static int cutLow = 0;
        static int cutMid = 0;
        static int cutHigh = 0;

        public static void Run()
        {
            sw.Start();
            ParseInput();
            FindShortestPathsBetweenRooms();
            rooms = rooms.Where((x, idx) => idx == 0 || x.FlowRate > 0).ToArray();

            FindMostEfficientSimulation();
        }

        static void FindMostEfficientSimulation()
        {
            Queue<SimulationStep> queue = new Queue<SimulationStep>();

            var preOpened = rooms.Where(x => x.FlowRate == 0).Select(x => (Room: x, -1)).ToList();
            var simulationStep = new SimulationStep(_maxMinutes, preOpened, 0);

            queue.Enqueue(simulationStep);
            while (queue.Count > 0)
            {
                //counter++;
                var currentQItem = queue.Dequeue();

                if (currentQItem.RealLeft < 12 && currentQItem.ExpectedPressure < 1350)
                {
                    cutLow++;
                    continue;
                }
                else if (currentQItem.RealLeft < 8 && currentQItem.ExpectedPressure < 1500)
                {
                    cutMid++;
                    continue;
                }
                else if (currentQItem.RealLeft < 6 && currentQItem.ExpectedPressure < 2000)
                {
                    cutHigh++;
                    continue;
                }
                else if (currentQItem.Opened.Count == rooms.Length || currentQItem.RealLeft <= 0)
                {
                    if (currentQItem.ExpectedPressure <= 2500)
                    {
                        continue;
                    }

                    results.Add(currentQItem);
                    Console.WriteLine($"{currentQItem} [{cutLow}, {cutMid}, {cutHigh}]");
                    continue;
                }

                //var count = currentQItem.Opened.Count;
                //if (starts[count].Last().value < currentQItem.ExpectedPressure)
                //{
                //    var newElem = (currentQItem.ToString().Substring(0, currentQItem.Opened.Count * 2 + currentQItem.Opened.Count - 1), currentQItem.ExpectedPressure);
                //    starts[count].Add(newElem);

                //    Console.WriteLine($"NEW\t[{count}]:\t{newElem}\tcounter: {counter}\tleft {currentQItem.Left + currentQItem.Opened.Min(x => x.Minutes)}");
                //}
                //else if (count == startCheckingIdx)
                //{
                //    if (!starts[count - checkBack]
                //        .OrderByDescending(x => x.value)
                //        .Take(howManyBests)
                //        .Any(x => currentQItem.ToString().StartsWith(x.start)))
                //    {
                //        continue;
                //    }
                //}

                //1ST ONLY
                if (currentQItem.Opened.Count == 1)
                {
                    var closedNeighbors = paths
                        .Where(x => x.Key.Room == currentQItem.Opened[0].Room)
                        .Where(x => !currentQItem.Opened.Any(y => y.Room == x.Key.Neighbor));

                    var cartesianProduct = closedNeighbors.SelectMany(left => closedNeighbors, (x, y) => (You: x, Elephant: y))
                        .Where(x => x.You.Key.Neighbor != x.Elephant.Key.Neighbor)
                        .OrderBy(x => x.You.Key.Neighbor.FlowRate + x.Elephant.Key.Neighbor.FlowRate);

                    foreach (var cart in cartesianProduct)
                    {
                        //2 at same time
                        if (cart.You.Value == cart.Elephant.Value)
                        {
                            BothAreSame(queue, currentQItem, cart.You, cart.Elephant);
                        }
                        //1 higher
                        else
                        {
                            var lower = cart.You.Value < cart.Elephant.Value ? cart.You : cart.Elephant;
                            var higher = cart.You.Value > cart.Elephant.Value ? cart.You : cart.Elephant;
                            OneIsHigher(queue, currentQItem, lower, higher);
                        }
                    }
                }
                else
                {
                    var tmp = currentQItem.Opened.OrderBy(x => x.Minutes).ToArray();

                    var smaller = tmp[0];
                    var bigger = tmp[1];

                    if (bigger.Minutes < -1)
                    {
                        var diff = Math.Abs(bigger.Minutes - -1);
                        var newOpened = new List<(Room Room, int Minutes)>(currentQItem.Opened.Select(x => (x.Room, x.Minutes + diff)));
                        queue.Enqueue(new SimulationStep(currentQItem.Left - diff, newOpened, currentQItem.ExpectedPressure));
                    }
                    else if (bigger.Minutes == -1 && smaller.Minutes < -1)
                    {
                        var closedNeighbors = paths
                            .Where(x => x.Key.Room == bigger.Room)
                            .Where(x => !currentQItem.Opened.Any(y => y.Room == x.Key.Neighbor))
                            .OrderBy(x => x.Key.Neighbor.FlowRate);

                        foreach (var cart in closedNeighbors)
                        {
                            var newOpened = new List<(Room Room, int Minutes)>(currentQItem.Opened.Select(x => (x.Room, x.Minutes + 1)))
                            {
                                (cart.Key.Neighbor, -cart.Value - 1)
                            };

                            var expectedSum = newOpened.Sum(x =>
                            {
                                var expectedMinsLeft = Math.Max(0, x.Minutes + currentQItem.Left);
                                return x.Room.FlowRate * expectedMinsLeft;
                            });

                            var newStep = new SimulationStep(currentQItem.Left - 1, newOpened, expectedSum);
                            queue.Enqueue(newStep);
                        }
                    }
                    else if (bigger.Minutes == -1 && smaller.Minutes == -1)
                    {
                        var closedNeighbors = paths
                            .Where(x => x.Key.Room == bigger.Room)
                            .Where(x => !currentQItem.Opened.Any(y => y.Room == x.Key.Neighbor));

                        var closedNeighbors2nd = paths
                            .Where(x => x.Key.Room == smaller.Room)
                            .Where(x => !currentQItem.Opened.Any(y => y.Room == x.Key.Neighbor));

                        var cartesianProduct = closedNeighbors.SelectMany(left => closedNeighbors, (x, y) => (You: x, Elephant: y))
                            .Where(x => x.You.Key.Neighbor != x.Elephant.Key.Neighbor)
                            .OrderBy(x => x.You.Key.Neighbor.FlowRate + x.Elephant.Key.Neighbor.FlowRate);

                        foreach (var cart in cartesianProduct)
                        {
                            //2 at same time
                            if (cart.You.Value == cart.Elephant.Value)
                            {
                                BothAreSame(queue, currentQItem, cart.You, cart.Elephant);
                            }
                            //1 higher
                            else
                            {
                                var lower = cart.You.Value < cart.Elephant.Value ? cart.You : cart.Elephant;
                                var higher = cart.You.Value > cart.Elephant.Value ? cart.You : cart.Elephant;
                                OneIsHigher(queue, currentQItem, lower, higher);
                            }
                        }
                    }
                    else
                    {

                    }
                }
            }

            var result = results.OrderByDescending(x => x.ExpectedPressure);
            Console.WriteLine($"{result.First()} ({result.Count()}) [{cutLow}, {cutMid}, {cutHigh}]");
            Console.WriteLine($"{sw.Elapsed}");
        }

        static void BothAreSame(Queue<SimulationStep> q, SimulationStep currentQItem,
                KeyValuePair<(Room Room, Room Neighbor), int> you, KeyValuePair<(Room Room, Room Neighbor), int> elephant)
        {
            var diff = Math.Abs(you.Value - -1);
            var newOpened = new List<(Room Room, int Minutes)>(currentQItem.Opened);
            for (int i = 0; i < newOpened.Count; i++)
            {
                newOpened[i] = (newOpened[i].Room, newOpened[i].Minutes + 1);
            }

            newOpened.Add((you.Key.Neighbor, -diff - 1));
            newOpened.Add((elephant.Key.Neighbor, -diff - 1));

            var expectedSum = newOpened.Sum(x =>
            {
                var expectedMinsLeft = Math.Max(0, x.Minutes + currentQItem.Left);
                return x.Room.FlowRate * expectedMinsLeft;
            });

            var newStep = new SimulationStep(currentQItem.Left - diff, newOpened, expectedSum);
            q.Enqueue(newStep);
        }

        static void OneIsHigher(Queue<SimulationStep> q, SimulationStep currentQItem,
            KeyValuePair<(Room Room, Room Neighbor), int> lower, KeyValuePair<(Room Room, Room Neighbor), int> higher)
        {
            var newOpened = new List<(Room Room, int Minutes)>(currentQItem.Opened);
            for (int i = 0; i < newOpened.Count; i++)
            {
                newOpened[i] = (newOpened[i].Room, newOpened[i].Minutes + 1);
            }

            newOpened.Add((lower.Key.Neighbor, -lower.Value - 1));
            newOpened.Add((higher.Key.Neighbor, -higher.Value - 1));

            var expectedSum = newOpened.Sum(x =>
            {
                var expectedMinsLeft = Math.Max(0, x.Minutes + currentQItem.Left);
                return x.Room.FlowRate * expectedMinsLeft;
            });

            var newStep = new SimulationStep(currentQItem.Left - 1, newOpened, expectedSum);
            q.Enqueue(newStep);
        }

        class SimulationStep
        {
            public SimulationStep(int left, List<(Room Room, int Minutes)> opened, int expectedPressure)
            {
                Left = left;
                Opened = opened;
                ExpectedPressure = expectedPressure;
                RealLeft = left + opened.OrderBy(x => x.Minutes).Skip(1).FirstOrDefault().Minutes;
            }

            public int Left { get; }
            public List<(Room Room, int Minutes)> Opened { get; }
            public int ExpectedPressure { get; }
            public int RealLeft { get; }

            public override string ToString()
            {
                return $"{string.Join("-", Opened.Select(x => x.Room))} {ExpectedPressure}";
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
