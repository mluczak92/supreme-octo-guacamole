using System.Collections.Generic;
using System.Globalization;

namespace adventofcode2022._2022
{
    internal static class _10
    {
        //static string args = "addx 15\r\naddx -11\r\naddx 6\r\naddx -3\r\naddx 5\r\naddx -1\r\naddx -8\r\naddx 13\r\naddx 4\r\nnoop\r\naddx -1\r\naddx 5\r\naddx -1\r\naddx 5\r\naddx -1\r\naddx 5\r\naddx -1\r\naddx 5\r\naddx -1\r\naddx -35\r\naddx 1\r\naddx 24\r\naddx -19\r\naddx 1\r\naddx 16\r\naddx -11\r\nnoop\r\nnoop\r\naddx 21\r\naddx -15\r\nnoop\r\nnoop\r\naddx -3\r\naddx 9\r\naddx 1\r\naddx -3\r\naddx 8\r\naddx 1\r\naddx 5\r\nnoop\r\nnoop\r\nnoop\r\nnoop\r\nnoop\r\naddx -36\r\nnoop\r\naddx 1\r\naddx 7\r\nnoop\r\nnoop\r\nnoop\r\naddx 2\r\naddx 6\r\nnoop\r\nnoop\r\nnoop\r\nnoop\r\nnoop\r\naddx 1\r\nnoop\r\nnoop\r\naddx 7\r\naddx 1\r\nnoop\r\naddx -13\r\naddx 13\r\naddx 7\r\nnoop\r\naddx 1\r\naddx -33\r\nnoop\r\nnoop\r\nnoop\r\naddx 2\r\nnoop\r\nnoop\r\nnoop\r\naddx 8\r\nnoop\r\naddx -1\r\naddx 2\r\naddx 1\r\nnoop\r\naddx 17\r\naddx -9\r\naddx 1\r\naddx 1\r\naddx -3\r\naddx 11\r\nnoop\r\nnoop\r\naddx 1\r\nnoop\r\naddx 1\r\nnoop\r\nnoop\r\naddx -13\r\naddx -19\r\naddx 1\r\naddx 3\r\naddx 26\r\naddx -30\r\naddx 12\r\naddx -1\r\naddx 3\r\naddx 1\r\nnoop\r\nnoop\r\nnoop\r\naddx -9\r\naddx 18\r\naddx 1\r\naddx 2\r\nnoop\r\nnoop\r\naddx 9\r\nnoop\r\nnoop\r\nnoop\r\naddx -1\r\naddx 2\r\naddx -37\r\naddx 1\r\naddx 3\r\nnoop\r\naddx 15\r\naddx -21\r\naddx 22\r\naddx -6\r\naddx 1\r\nnoop\r\naddx 2\r\naddx 1\r\nnoop\r\naddx -10\r\nnoop\r\nnoop\r\naddx 20\r\naddx 1\r\naddx 2\r\naddx 2\r\naddx -6\r\naddx -11\r\nnoop\r\nnoop\r\nnoop";
        static string args = "addx 1\r\naddx 4\r\nnoop\r\nnoop\r\nnoop\r\nnoop\r\naddx 6\r\naddx -1\r\nnoop\r\naddx 5\r\nnoop\r\naddx 5\r\nnoop\r\nnoop\r\nnoop\r\naddx 1\r\naddx 3\r\naddx 1\r\naddx 6\r\naddx -1\r\nnoop\r\nnoop\r\nnoop\r\naddx 7\r\nnoop\r\naddx -39\r\nnoop\r\nnoop\r\nnoop\r\naddx 7\r\naddx 3\r\naddx -2\r\naddx 2\r\nnoop\r\naddx 3\r\naddx 2\r\naddx 5\r\naddx 2\r\naddx -8\r\naddx 13\r\nnoop\r\naddx 3\r\naddx -2\r\naddx 2\r\naddx 5\r\naddx -31\r\naddx 36\r\naddx -2\r\naddx -36\r\nnoop\r\nnoop\r\nnoop\r\naddx 3\r\naddx 5\r\naddx 2\r\naddx -7\r\naddx 15\r\naddx -5\r\naddx 5\r\naddx 2\r\naddx 1\r\naddx 4\r\nnoop\r\naddx 3\r\nnoop\r\naddx 2\r\naddx -13\r\naddx -16\r\naddx 2\r\naddx 35\r\naddx -40\r\nnoop\r\nnoop\r\naddx 7\r\nnoop\r\nnoop\r\nnoop\r\naddx 5\r\nnoop\r\naddx 5\r\naddx 10\r\naddx -10\r\nnoop\r\nnoop\r\nnoop\r\naddx 3\r\nnoop\r\naddx 16\r\naddx -9\r\nnoop\r\nnoop\r\nnoop\r\naddx 3\r\nnoop\r\naddx 7\r\naddx -32\r\naddx 35\r\naddx -38\r\naddx 22\r\naddx 10\r\naddx -29\r\naddx 2\r\nnoop\r\naddx 3\r\naddx 5\r\naddx 2\r\naddx 2\r\naddx -12\r\naddx 13\r\nnoop\r\nnoop\r\naddx 7\r\naddx 5\r\nnoop\r\nnoop\r\nnoop\r\naddx 7\r\naddx -6\r\naddx 2\r\naddx 5\r\naddx -38\r\naddx 1\r\nnoop\r\nnoop\r\naddx 2\r\nnoop\r\naddx 3\r\naddx 5\r\nnoop\r\naddx 4\r\naddx -2\r\naddx 5\r\naddx 2\r\naddx 1\r\nnoop\r\naddx 4\r\naddx 4\r\naddx -14\r\naddx 16\r\nnoop\r\naddx -13\r\naddx 18\r\naddx -1\r\nnoop\r\nnoop\r\nnoop";

        public static void Run()
        {
            var cmds = args
                .Split("\r\n")
                .Select(x => x == "noop" ? ("noop", 0) : (x.Split(" ")[0], int.Parse(x.Split(" ")[1])))
                .ToArray();

            //int x = 1;
            //int cycle = 0;
            //List<(int, int)> history = new List<(int, int)>();
            //foreach (var cmd in cmds)
            //{
            //    if (cmd.Item1 == "addx")
            //    {
            //        cycle += 2;
            //        x += cmd.Item2;
            //        history.Add((cycle, x));
            //        Console.WriteLine($"{cycle}: {x}");
            //    }
            //    else
            //    {
            //        cycle += 1;
            //    }
            //}

            //var toCheck = Enumerable
            //    .Range(0, history.Last().Item1)
            //    .Where(x => x == 20 || (x - 20) % 40 == 0)
            //    .ToArray();

            //List<int> sums = new List<int>();
            //foreach (var elem in toCheck)
            //{
            //    var lastBeforeCheck = history.Last(x => x.Item1 < elem);
            //    sums.Add(lastBeforeCheck.Item2 * elem);
            //}

            //Console.WriteLine(sums.Sum());

            var cmdsQueue = new Queue<(string, int)>(cmds);
            var cmd = ("", 0);
            var cmdCyclesRemaining = 0;
            var spriteMidIdx = 1;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 40; j++)
                {
                    if (cmdCyclesRemaining == 0)
                    {
                        if (cmd.Item1 == "addx")
                        {
                            spriteMidIdx += cmd.Item2;
                        }

                        cmd = cmdsQueue.Dequeue();
                        if (cmd.Item1 == "addx")
                        {
                            cmdCyclesRemaining = 2;
                        } 
                        else
                        {
                            cmdCyclesRemaining = 1;
                        }
                    }

                    Console.Write(j >= spriteMidIdx - 1 && j <= spriteMidIdx + 1 ? "█" : " ");
                    cmdCyclesRemaining--;
                }
            }
        }
    }
}
