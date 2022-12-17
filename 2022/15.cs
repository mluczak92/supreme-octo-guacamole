using System;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace adventofcode2022._2022
{
    internal static class _15
    {
        //static string args = "Sensor at x=2, y=18: closest beacon is at x=-2, y=15\r\nSensor at x=9, y=16: closest beacon is at x=10, y=16\r\nSensor at x=13, y=2: closest beacon is at x=15, y=3\r\nSensor at x=12, y=14: closest beacon is at x=10, y=16\r\nSensor at x=10, y=20: closest beacon is at x=10, y=16\r\nSensor at x=14, y=17: closest beacon is at x=10, y=16\r\nSensor at x=8, y=7: closest beacon is at x=2, y=10\r\nSensor at x=2, y=0: closest beacon is at x=2, y=10\r\nSensor at x=0, y=11: closest beacon is at x=2, y=10\r\nSensor at x=20, y=14: closest beacon is at x=25, y=17\r\nSensor at x=17, y=20: closest beacon is at x=21, y=22\r\nSensor at x=16, y=7: closest beacon is at x=15, y=3\r\nSensor at x=14, y=3: closest beacon is at x=15, y=3\r\nSensor at x=20, y=1: closest beacon is at x=15, y=3";
        static string args = "Sensor at x=407069, y=1770807: closest beacon is at x=105942, y=2000000\r\nSensor at x=2968955, y=2961853: closest beacon is at x=2700669, y=3091664\r\nSensor at x=3069788, y=2289672: closest beacon is at x=3072064, y=2287523\r\nSensor at x=2206, y=1896380: closest beacon is at x=105942, y=2000000\r\nSensor at x=3010408, y=2580417: closest beacon is at x=2966207, y=2275132\r\nSensor at x=2511130, y=2230361: closest beacon is at x=2966207, y=2275132\r\nSensor at x=65435, y=2285654: closest beacon is at x=105942, y=2000000\r\nSensor at x=2811709, y=3379959: closest beacon is at x=2801189, y=3200444\r\nSensor at x=168413, y=3989039: closest beacon is at x=-631655, y=3592291\r\nSensor at x=165506, y=2154294: closest beacon is at x=105942, y=2000000\r\nSensor at x=2720578, y=3116882: closest beacon is at x=2700669, y=3091664\r\nSensor at x=786521, y=1485720: closest beacon is at x=105942, y=2000000\r\nSensor at x=82364, y=2011850: closest beacon is at x=105942, y=2000000\r\nSensor at x=2764729, y=3156203: closest beacon is at x=2801189, y=3200444\r\nSensor at x=1795379, y=1766882: closest beacon is at x=1616322, y=907350\r\nSensor at x=2708986, y=3105910: closest beacon is at x=2700669, y=3091664\r\nSensor at x=579597, y=439: closest beacon is at x=1616322, y=907350\r\nSensor at x=2671201, y=2736834: closest beacon is at x=2700669, y=3091664\r\nSensor at x=3901, y=2089464: closest beacon is at x=105942, y=2000000\r\nSensor at x=144449, y=813212: closest beacon is at x=105942, y=2000000\r\nSensor at x=3619265, y=3169784: closest beacon is at x=2801189, y=3200444\r\nSensor at x=2239333, y=3878605: closest beacon is at x=2801189, y=3200444\r\nSensor at x=2220630, y=2493371: closest beacon is at x=2966207, y=2275132\r\nSensor at x=1148022, y=403837: closest beacon is at x=1616322, y=907350\r\nSensor at x=996105, y=3077490: closest beacon is at x=2700669, y=3091664\r\nSensor at x=3763069, y=3875159: closest beacon is at x=2801189, y=3200444\r\nSensor at x=3994575, y=2268273: closest beacon is at x=3072064, y=2287523\r\nSensor at x=3025257, y=2244500: closest beacon is at x=2966207, y=2275132\r\nSensor at x=2721366, y=1657084: closest beacon is at x=2966207, y=2275132\r\nSensor at x=3783491, y=1332930: closest beacon is at x=3072064, y=2287523\r\nSensor at x=52706, y=2020407: closest beacon is at x=105942, y=2000000\r\nSensor at x=2543090, y=47584: closest beacon is at x=3450858, y=-772833\r\nSensor at x=3499766, y=2477193: closest beacon is at x=3072064, y=2287523";
        static int len = 20;

        public struct Diamond
        {
            public Diamond(Vector2 right, Vector2 up, Vector2 left, Vector2 down)
            {
                Right = right;
                Top = up;
                Left = left;
                Bot = down;
            }

            public Vector2 Right { get; }
            public Vector2 Top { get; }
            public Vector2 Left { get; }
            public Vector2 Bot { get; }

            public override string ToString()
            {
                return $"{Right,20}\t{Top,20}\t{Left,20}\t{Bot,20}";
            }
        }

        static Diamond[] _ranges = new Diamond[] { };
        public static void Run()
        {
            var logs = args.Split("\r\n")
                .Select(x =>
                {
                    var numbers = Regex.Matches(x, "-?\\d+");
                    return (Sensor: (X: int.Parse(numbers[0].Value), Y: int.Parse(numbers[1].Value)),
                            Beacon: (X: int.Parse(numbers[2].Value), Y: int.Parse(numbers[3].Value)));
                }).ToArray();

            var coords = logs.Select(x => x.Sensor)
                .Union(logs.Select(x => x.Beacon))
                .ToArray();

            var xmin = coords.Min(x => x.X);
            var xmax = coords.Max(x => x.X);
            var xdiff = xmax - xmin;
            var ymax = coords.Max(x => x.Y);

            var row = Enumerable.Range(0, xdiff + 1)
                .Select(x => ".")
                .ToList();

            //var taken = coords.Where(x => x.Y == targetRow).Select(x => (x.X, x.X + 1));
            var rangesList = new List<Diamond>();
            foreach (var log in logs)
            {
                var horizontalDiff = Math.Abs(log.Sensor.Y - log.Beacon.Y);
                var verticalDiff = Math.Abs(log.Sensor.X - log.Beacon.X);
                var diamondHeight = horizontalDiff + verticalDiff;

                //target row in diamond
                if (diamondHeight > 0)
                {
                    var fromX = log.Sensor.X - diamondHeight;
                    var toX = log.Sensor.X + diamondHeight;

                    var fromY = log.Sensor.Y - diamondHeight;
                    var toY = log.Sensor.Y + diamondHeight;

                    rangesList.Add(new Diamond(
                        new Vector2(fromX, log.Sensor.Y),
                        new Vector2(log.Sensor.X, toY),
                        new Vector2(toX, log.Sensor.Y),
                        new Vector2(log.Sensor.X, fromY)));
                }
            }

            _ranges = rangesList.ToArray();
            foreach (var range in _ranges)
            {
                Console.WriteLine(range);
            }

            var start = new Vector2(1, 2);
            var end = new Vector2(11, 12);
            var point = new Vector2(3, 2);

            var result = CheckIfPointInLine(point, (start, end));

            Console.WriteLine();
            foreach (var range in _ranges)
            {
                var candidates = _ranges.Where(x => CheckIfPointInDiamond(range.Right, x)).ToArray();
                if (candidates.Length > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"RIGHT {range}");
                    foreach (var c in candidates)
                    {
                        Console.WriteLine($"\t{c}");
                    }
                }

                candidates = _ranges.Where(x => CheckIfPointInDiamond(range.Top, x)).ToArray();
                if (candidates.Length > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"TOP {range} ");
                    foreach (var c in candidates)
                    {
                        Console.WriteLine($"\t{c}");
                    }
                }

                candidates = _ranges.Where(x => CheckIfPointInDiamond(range.Left, x)).ToArray();
                if (candidates.Length > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"LEFT {range} ");
                    foreach (var c in candidates)
                    {
                        Console.WriteLine($"\t{c}");
                    }
                }

                candidates = _ranges.Where(x => CheckIfPointInDiamond(range.Bot, x)).ToArray();
                if (candidates.Length > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"BOT {range} ");
                    foreach (var c in candidates)
                    {
                        Console.WriteLine($"\t{c}");
                    }
                }
            }
        }

        static bool CheckIfPointInDiamond(Vector2 point, Diamond diamond)
        {
            var a = CheckIfPointInLine(point, (diamond.Right, diamond.Top));
            if (a)
            {
                Console.Write("RIGHT TOP");
                return true;
            }

            var b = CheckIfPointInLine(point, (diamond.Top, diamond.Left));
            if (b)
            {
                Console.Write("TOP LEFT");
                return true;
            }
            var c = CheckIfPointInLine(point, (diamond.Left, diamond.Bot));
            if (c)
            {
                Console.Write("LEFT BOT");
                return true;
            }
            var d = CheckIfPointInLine(point, (diamond.Bot, diamond.Right));
            if (d)
            {
                Console.Write("BOT RIGHT");
                return true;
            }

            return false;
        }

        static bool CheckIfPointInLine(Vector2 point, (Vector2 start, Vector2 end) line)
        {
            var diff = 2;
            var a = new Vector2(point.X, point.Y + diff);
            var b = new Vector2(point.X, point.Y - diff);
            var c = new Vector2(point.X + diff, point.Y);
            var d = new Vector2(point.X - diff, point.Y);

            var aResult = IsBetween(a, line);
            var bResult = IsBetween(b, line);
            var cResult = IsBetween(a, line);
            var dResult = IsBetween(b, line);

            return aResult || bResult || cResult || dResult;
        }

        static bool IsBetween(Vector2 point, (Vector2 start, Vector2 end) line)
        {
            return Math.Abs((point.X - line.start.X) * (line.end.Y - line.start.Y) - (line.end.X - line.start.X) * (point.Y - line.start.Y)) < 0.1;
        }

        static bool InsideAnyRange(Vector2 p)
        {
            //return false;
            return _ranges.Any(dia => PointToEdgeRelation(p, dia.Right, dia.Top) <= 0 &&
                PointToEdgeRelation(p, dia.Top, dia.Left) <= 0 &&
                PointToEdgeRelation(p, dia.Left, dia.Bot) <= 0 &&
                PointToEdgeRelation(p, dia.Bot, dia.Right) <= 0);
        }

        static float PointToEdgeRelation(Vector2 p, Vector2 start, Vector2 end)
        {
            return (end.X - start.X) * (p.Y - start.Y) - (p.X - start.X) * (end.Y - start.Y);
        }

        static bool InsideAnyRange(List<Diamond> ranges, Diamond d)
        {
            return ranges.Any(dia => PointToEdgeRelation(d.Right, dia.Right, dia.Top) <= 0 &&
                PointToEdgeRelation(d.Right, dia.Top, dia.Left) <= 0 &&
                PointToEdgeRelation(d.Right, dia.Left, dia.Bot) <= 0 &&
                PointToEdgeRelation(d.Right, dia.Bot, dia.Right) <= 0
                &&

                PointToEdgeRelation(d.Top, dia.Right, dia.Top) <= 0 &&
                PointToEdgeRelation(d.Top, dia.Top, dia.Left) <= 0 &&
                PointToEdgeRelation(d.Top, dia.Left, dia.Bot) <= 0 &&
                PointToEdgeRelation(d.Top, dia.Bot, dia.Right) <= 0
                &&

                PointToEdgeRelation(d.Left, dia.Right, dia.Top) <= 0 &&
                PointToEdgeRelation(d.Left, dia.Top, dia.Left) <= 0 &&
                PointToEdgeRelation(d.Left, dia.Left, dia.Bot) <= 0 &&
                PointToEdgeRelation(d.Left, dia.Bot, dia.Right) <= 0
                &&

                PointToEdgeRelation(d.Bot, dia.Right, dia.Top) <= 0 &&
                PointToEdgeRelation(d.Bot, dia.Top, dia.Left) <= 0 &&
                PointToEdgeRelation(d.Bot, dia.Left, dia.Bot) <= 0 &&
                PointToEdgeRelation(d.Bot, dia.Bot, dia.Right) <= 0);
        }
    }
}
