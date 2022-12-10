﻿using System.Text.RegularExpressions;

namespace adventofcode2022._2022
{
    internal static class _05
    {
        //static Stack<string>[] stacks = new[] {
        //    new Stack<string>(new[] { "Z", "N" }),
        //    new Stack<string>(new[] { "M", "C", "D" }),
        //    new Stack<string>(new[] { "P" })
        //};

        //static string args = "move 1 from 2 to 1\r\nmove 3 from 1 to 3\r\nmove 2 from 2 to 1\r\nmove 1 from 1 to 2";

        static Stack<string>[] stacks = new[]
        {
            new Stack<string>(new[] { "N", "S", "D", "C", "V", "Q", "T" }),
            new Stack<string>(new[] { "M", "F", "V" }),
            new Stack<string>(new[] { "F", "Q", "W", "D", "P", "N", "H", "M" }),
            new Stack<string>(new[] { "D", "Q", "R", "T", "F" }),
            new Stack<string>(new[] { "R", "F", "M", "N", "Q", "H", "V", "B" }),
            new Stack<string>(new[] { "C", "F", "G", "N", "P", "W", "Q" }),
            new Stack<string>(new[] { "W", "F", "R", "L", "C", "T" }),
            new Stack<string>(new[] { "T", "Z", "N", "S" }),
            new Stack<string>(new[] { "M", "S", "D", "J", "R", "Q", "H", "N" }),
        };

        static string args = "move 1 from 8 to 7\r\nmove 1 from 2 to 7\r\nmove 6 from 9 to 8\r\nmove 1 from 9 to 1\r\nmove 1 from 9 to 1\r\nmove 3 from 3 to 6\r\nmove 3 from 3 to 9\r\nmove 1 from 9 to 2\r\nmove 5 from 7 to 9\r\nmove 9 from 1 to 6\r\nmove 3 from 4 to 9\r\nmove 2 from 9 to 2\r\nmove 1 from 4 to 2\r\nmove 1 from 3 to 9\r\nmove 8 from 9 to 4\r\nmove 14 from 6 to 7\r\nmove 1 from 3 to 2\r\nmove 5 from 4 to 2\r\nmove 5 from 5 to 7\r\nmove 4 from 2 to 1\r\nmove 2 from 4 to 9\r\nmove 1 from 4 to 3\r\nmove 3 from 5 to 7\r\nmove 1 from 8 to 6\r\nmove 2 from 8 to 7\r\nmove 2 from 1 to 2\r\nmove 1 from 9 to 7\r\nmove 2 from 1 to 3\r\nmove 5 from 6 to 5\r\nmove 4 from 5 to 7\r\nmove 3 from 8 to 4\r\nmove 20 from 7 to 1\r\nmove 11 from 7 to 5\r\nmove 1 from 6 to 9\r\nmove 3 from 9 to 2\r\nmove 12 from 1 to 9\r\nmove 2 from 8 to 3\r\nmove 4 from 2 to 8\r\nmove 8 from 2 to 1\r\nmove 4 from 8 to 9\r\nmove 1 from 2 to 5\r\nmove 12 from 9 to 7\r\nmove 4 from 4 to 9\r\nmove 4 from 9 to 5\r\nmove 13 from 5 to 4\r\nmove 4 from 4 to 7\r\nmove 1 from 7 to 9\r\nmove 2 from 9 to 5\r\nmove 9 from 1 to 2\r\nmove 1 from 8 to 3\r\nmove 5 from 4 to 2\r\nmove 1 from 3 to 6\r\nmove 7 from 2 to 8\r\nmove 6 from 1 to 6\r\nmove 6 from 8 to 7\r\nmove 6 from 2 to 1\r\nmove 3 from 9 to 3\r\nmove 7 from 3 to 7\r\nmove 4 from 4 to 9\r\nmove 1 from 8 to 9\r\nmove 1 from 3 to 9\r\nmove 1 from 2 to 4\r\nmove 1 from 9 to 6\r\nmove 5 from 1 to 9\r\nmove 1 from 4 to 9\r\nmove 2 from 9 to 1\r\nmove 8 from 6 to 7\r\nmove 4 from 9 to 7\r\nmove 2 from 5 to 2\r\nmove 2 from 1 to 9\r\nmove 14 from 7 to 4\r\nmove 22 from 7 to 2\r\nmove 2 from 7 to 4\r\nmove 3 from 7 to 5\r\nmove 9 from 4 to 7\r\nmove 6 from 2 to 4\r\nmove 8 from 4 to 3\r\nmove 14 from 2 to 9\r\nmove 2 from 3 to 9\r\nmove 3 from 2 to 9\r\nmove 4 from 4 to 2\r\nmove 1 from 4 to 5\r\nmove 1 from 1 to 4\r\nmove 5 from 7 to 8\r\nmove 1 from 1 to 3\r\nmove 4 from 5 to 2\r\nmove 6 from 3 to 9\r\nmove 1 from 3 to 4\r\nmove 4 from 8 to 9\r\nmove 2 from 4 to 6\r\nmove 4 from 5 to 3\r\nmove 1 from 7 to 6\r\nmove 1 from 8 to 5\r\nmove 3 from 3 to 1\r\nmove 33 from 9 to 5\r\nmove 5 from 2 to 1\r\nmove 1 from 3 to 5\r\nmove 1 from 7 to 6\r\nmove 18 from 5 to 1\r\nmove 1 from 2 to 8\r\nmove 6 from 5 to 4\r\nmove 1 from 8 to 7\r\nmove 2 from 4 to 1\r\nmove 4 from 1 to 2\r\nmove 19 from 1 to 2\r\nmove 4 from 6 to 8\r\nmove 4 from 1 to 8\r\nmove 14 from 2 to 9\r\nmove 5 from 2 to 4\r\nmove 1 from 8 to 2\r\nmove 8 from 2 to 5\r\nmove 5 from 8 to 4\r\nmove 4 from 9 to 7\r\nmove 1 from 8 to 1\r\nmove 16 from 5 to 4\r\nmove 15 from 4 to 5\r\nmove 1 from 9 to 5\r\nmove 5 from 7 to 6\r\nmove 2 from 7 to 6\r\nmove 1 from 1 to 9\r\nmove 7 from 6 to 7\r\nmove 1 from 8 to 5\r\nmove 1 from 1 to 9\r\nmove 12 from 5 to 7\r\nmove 7 from 5 to 9\r\nmove 12 from 7 to 2\r\nmove 1 from 7 to 4\r\nmove 7 from 4 to 7\r\nmove 2 from 9 to 4\r\nmove 5 from 4 to 9\r\nmove 8 from 2 to 3\r\nmove 4 from 2 to 4\r\nmove 9 from 4 to 8\r\nmove 6 from 3 to 5\r\nmove 8 from 7 to 3\r\nmove 1 from 4 to 3\r\nmove 7 from 8 to 9\r\nmove 4 from 5 to 4\r\nmove 6 from 3 to 1\r\nmove 4 from 3 to 4\r\nmove 1 from 3 to 6\r\nmove 6 from 4 to 9\r\nmove 1 from 6 to 5\r\nmove 17 from 9 to 4\r\nmove 3 from 7 to 3\r\nmove 1 from 7 to 9\r\nmove 2 from 5 to 3\r\nmove 2 from 1 to 3\r\nmove 2 from 8 to 9\r\nmove 1 from 5 to 1\r\nmove 14 from 4 to 5\r\nmove 2 from 3 to 2\r\nmove 1 from 7 to 6\r\nmove 10 from 9 to 4\r\nmove 12 from 9 to 4\r\nmove 9 from 4 to 5\r\nmove 1 from 2 to 9\r\nmove 13 from 5 to 9\r\nmove 2 from 5 to 1\r\nmove 1 from 2 to 9\r\nmove 3 from 4 to 2\r\nmove 12 from 4 to 7\r\nmove 8 from 5 to 7\r\nmove 1 from 1 to 9\r\nmove 1 from 6 to 4\r\nmove 1 from 5 to 4\r\nmove 1 from 4 to 8\r\nmove 5 from 3 to 4\r\nmove 10 from 9 to 6\r\nmove 3 from 6 to 2\r\nmove 7 from 6 to 5\r\nmove 6 from 5 to 4\r\nmove 1 from 8 to 5\r\nmove 1 from 1 to 4\r\nmove 2 from 7 to 2\r\nmove 5 from 4 to 9\r\nmove 2 from 5 to 8\r\nmove 1 from 1 to 3\r\nmove 2 from 1 to 7\r\nmove 6 from 7 to 9\r\nmove 9 from 9 to 8\r\nmove 1 from 1 to 3\r\nmove 4 from 2 to 7\r\nmove 11 from 7 to 3\r\nmove 11 from 8 to 6\r\nmove 7 from 3 to 1\r\nmove 4 from 7 to 2\r\nmove 3 from 2 to 9\r\nmove 8 from 1 to 5\r\nmove 2 from 7 to 5\r\nmove 2 from 2 to 9\r\nmove 2 from 3 to 9\r\nmove 11 from 4 to 7\r\nmove 7 from 9 to 5\r\nmove 6 from 6 to 5\r\nmove 2 from 2 to 9\r\nmove 1 from 2 to 3\r\nmove 6 from 9 to 4\r\nmove 3 from 9 to 1\r\nmove 4 from 3 to 5\r\nmove 6 from 7 to 1\r\nmove 2 from 6 to 3\r\nmove 2 from 9 to 2\r\nmove 3 from 3 to 2\r\nmove 3 from 6 to 8\r\nmove 2 from 7 to 5\r\nmove 20 from 5 to 6\r\nmove 8 from 5 to 1\r\nmove 1 from 5 to 9\r\nmove 2 from 8 to 4\r\nmove 1 from 8 to 7\r\nmove 16 from 1 to 8\r\nmove 8 from 8 to 9\r\nmove 4 from 2 to 4\r\nmove 1 from 1 to 5\r\nmove 1 from 5 to 4\r\nmove 3 from 8 to 4\r\nmove 14 from 4 to 6\r\nmove 5 from 8 to 7\r\nmove 6 from 7 to 8\r\nmove 29 from 6 to 2\r\nmove 3 from 9 to 8\r\nmove 21 from 2 to 3\r\nmove 1 from 8 to 3\r\nmove 6 from 9 to 4\r\nmove 8 from 3 to 5\r\nmove 7 from 8 to 4\r\nmove 7 from 3 to 9\r\nmove 3 from 7 to 2\r\nmove 12 from 4 to 8\r\nmove 2 from 3 to 1\r\nmove 2 from 9 to 1\r\nmove 1 from 6 to 7\r\nmove 1 from 7 to 6\r\nmove 1 from 6 to 3\r\nmove 3 from 1 to 8\r\nmove 2 from 4 to 1\r\nmove 4 from 6 to 1\r\nmove 5 from 2 to 7\r\nmove 1 from 1 to 2\r\nmove 5 from 1 to 2\r\nmove 2 from 8 to 1\r\nmove 1 from 4 to 5\r\nmove 9 from 8 to 4\r\nmove 3 from 7 to 9\r\nmove 7 from 5 to 7\r\nmove 2 from 5 to 9\r\nmove 4 from 9 to 2\r\nmove 3 from 3 to 2\r\nmove 5 from 2 to 7\r\nmove 2 from 8 to 2\r\nmove 2 from 7 to 3\r\nmove 1 from 8 to 6\r\nmove 2 from 1 to 2\r\nmove 1 from 6 to 7\r\nmove 1 from 8 to 1\r\nmove 12 from 7 to 1\r\nmove 5 from 2 to 7\r\nmove 7 from 4 to 2\r\nmove 2 from 4 to 1\r\nmove 5 from 3 to 8\r\nmove 7 from 1 to 9\r\nmove 4 from 7 to 1\r\nmove 7 from 1 to 5\r\nmove 12 from 9 to 2\r\nmove 27 from 2 to 4\r\nmove 3 from 8 to 9\r\nmove 6 from 2 to 5\r\nmove 6 from 1 to 8\r\nmove 1 from 7 to 6\r\nmove 9 from 5 to 2\r\nmove 3 from 9 to 2\r\nmove 13 from 4 to 5\r\nmove 10 from 2 to 7\r\nmove 1 from 9 to 8\r\nmove 11 from 5 to 7\r\nmove 1 from 8 to 7\r\nmove 1 from 2 to 6\r\nmove 13 from 4 to 3\r\nmove 23 from 7 to 4\r\nmove 1 from 6 to 9\r\nmove 1 from 2 to 4\r\nmove 7 from 3 to 5\r\nmove 1 from 9 to 8\r\nmove 19 from 4 to 1\r\nmove 2 from 4 to 1\r\nmove 1 from 7 to 6\r\nmove 1 from 4 to 5\r\nmove 1 from 5 to 7\r\nmove 11 from 5 to 1\r\nmove 2 from 5 to 4\r\nmove 2 from 6 to 9\r\nmove 3 from 8 to 2\r\nmove 2 from 8 to 1\r\nmove 3 from 2 to 1\r\nmove 1 from 9 to 5\r\nmove 6 from 1 to 3\r\nmove 1 from 9 to 7\r\nmove 2 from 7 to 5\r\nmove 2 from 8 to 6\r\nmove 1 from 3 to 2\r\nmove 2 from 8 to 5\r\nmove 1 from 2 to 1\r\nmove 3 from 4 to 1\r\nmove 3 from 5 to 1\r\nmove 2 from 5 to 1\r\nmove 2 from 6 to 9\r\nmove 1 from 9 to 6\r\nmove 1 from 4 to 5\r\nmove 1 from 9 to 8\r\nmove 1 from 8 to 6\r\nmove 8 from 1 to 6\r\nmove 7 from 1 to 8\r\nmove 9 from 1 to 6\r\nmove 1 from 5 to 3\r\nmove 3 from 8 to 4\r\nmove 11 from 3 to 4\r\nmove 1 from 3 to 6\r\nmove 10 from 6 to 8\r\nmove 13 from 1 to 6\r\nmove 3 from 4 to 5\r\nmove 7 from 8 to 6\r\nmove 3 from 8 to 5\r\nmove 6 from 5 to 3\r\nmove 22 from 6 to 9\r\nmove 4 from 3 to 6\r\nmove 4 from 9 to 5\r\nmove 1 from 1 to 5\r\nmove 2 from 3 to 4\r\nmove 2 from 1 to 5\r\nmove 1 from 9 to 2\r\nmove 5 from 8 to 3\r\nmove 2 from 9 to 2\r\nmove 11 from 6 to 9\r\nmove 3 from 2 to 7\r\nmove 1 from 6 to 7\r\nmove 12 from 9 to 8\r\nmove 4 from 7 to 1\r\nmove 12 from 4 to 8\r\nmove 2 from 4 to 7\r\nmove 1 from 1 to 8\r\nmove 1 from 5 to 1\r\nmove 19 from 8 to 4\r\nmove 4 from 5 to 1\r\nmove 1 from 7 to 4\r\nmove 1 from 7 to 1\r\nmove 3 from 3 to 4\r\nmove 2 from 8 to 4\r\nmove 1 from 5 to 7\r\nmove 1 from 7 to 9\r\nmove 8 from 1 to 8\r\nmove 1 from 1 to 4\r\nmove 1 from 3 to 9\r\nmove 1 from 3 to 5\r\nmove 1 from 5 to 2\r\nmove 7 from 8 to 7\r\nmove 16 from 4 to 7\r\nmove 1 from 7 to 4\r\nmove 3 from 8 to 2\r\nmove 14 from 7 to 4\r\nmove 1 from 5 to 8\r\nmove 5 from 7 to 5\r\nmove 16 from 4 to 5\r\nmove 3 from 5 to 4\r\nmove 3 from 2 to 1\r\nmove 1 from 7 to 9\r\nmove 11 from 4 to 2\r\nmove 3 from 8 to 6\r\nmove 2 from 1 to 8\r\nmove 1 from 4 to 9\r\nmove 18 from 5 to 1\r\nmove 1 from 8 to 7\r\nmove 3 from 7 to 9\r\nmove 18 from 9 to 3\r\nmove 3 from 6 to 9\r\nmove 7 from 1 to 6\r\nmove 1 from 8 to 4\r\nmove 1 from 4 to 9\r\nmove 3 from 6 to 4\r\nmove 5 from 9 to 2\r\nmove 2 from 4 to 7\r\nmove 7 from 2 to 8\r\nmove 1 from 7 to 3\r\nmove 2 from 6 to 8\r\nmove 1 from 9 to 5\r\nmove 1 from 6 to 8\r\nmove 1 from 4 to 8\r\nmove 1 from 5 to 3\r\nmove 1 from 7 to 5\r\nmove 8 from 8 to 7\r\nmove 10 from 2 to 6\r\nmove 1 from 9 to 3\r\nmove 6 from 6 to 2\r\nmove 5 from 6 to 2\r\nmove 7 from 2 to 7\r\nmove 12 from 1 to 6\r\nmove 2 from 2 to 1\r\nmove 1 from 2 to 5\r\nmove 4 from 7 to 6\r\nmove 12 from 3 to 1\r\nmove 2 from 7 to 2\r\nmove 9 from 3 to 8\r\nmove 1 from 2 to 6\r\nmove 1 from 5 to 4\r\nmove 9 from 6 to 5\r\nmove 1 from 7 to 6\r\nmove 1 from 4 to 9\r\nmove 9 from 6 to 7\r\nmove 7 from 8 to 3\r\nmove 6 from 3 to 1\r\nmove 4 from 8 to 3\r\nmove 5 from 3 to 1\r\nmove 1 from 9 to 8\r\nmove 2 from 8 to 9\r\nmove 5 from 5 to 7\r\nmove 14 from 7 to 8\r\nmove 1 from 9 to 4\r\nmove 2 from 2 to 1\r\nmove 3 from 5 to 3\r\nmove 2 from 3 to 1\r\nmove 1 from 4 to 6\r\nmove 6 from 8 to 6\r\nmove 6 from 8 to 3\r\nmove 3 from 6 to 1\r\nmove 2 from 8 to 9\r\nmove 19 from 1 to 6\r\nmove 3 from 9 to 3\r\nmove 6 from 3 to 4\r\nmove 6 from 6 to 2\r\nmove 4 from 3 to 9\r\nmove 1 from 7 to 9\r\nmove 2 from 5 to 7\r\nmove 5 from 9 to 6\r\nmove 6 from 7 to 2\r\nmove 11 from 2 to 5\r\nmove 2 from 7 to 4\r\nmove 4 from 4 to 3\r\nmove 2 from 4 to 8\r\nmove 12 from 1 to 2\r\nmove 1 from 8 to 2\r\nmove 8 from 5 to 7\r\nmove 2 from 4 to 9\r\nmove 2 from 7 to 1\r\nmove 4 from 2 to 3\r\nmove 1 from 8 to 6\r\nmove 1 from 1 to 5\r\nmove 2 from 9 to 1\r\nmove 2 from 7 to 3\r\nmove 2 from 5 to 2\r\nmove 1 from 5 to 7\r\nmove 2 from 7 to 8\r\nmove 1 from 5 to 7\r\nmove 5 from 3 to 4\r\nmove 3 from 1 to 7\r\nmove 1 from 2 to 4\r\nmove 15 from 6 to 1\r\nmove 4 from 4 to 1\r\nmove 4 from 2 to 3\r\nmove 8 from 3 to 2\r\nmove 5 from 2 to 4\r\nmove 1 from 8 to 6\r\nmove 1 from 8 to 9\r\nmove 1 from 3 to 1\r\nmove 3 from 7 to 3\r\nmove 5 from 7 to 6\r\nmove 4 from 2 to 9\r\nmove 6 from 2 to 6\r\nmove 4 from 9 to 6\r\nmove 12 from 1 to 5\r\nmove 6 from 4 to 1\r\nmove 1 from 3 to 6\r\nmove 4 from 5 to 8\r\nmove 7 from 5 to 3\r\nmove 3 from 8 to 2\r\nmove 1 from 2 to 3\r\nmove 1 from 9 to 5\r\nmove 1 from 4 to 5\r\nmove 1 from 8 to 5\r\nmove 8 from 6 to 9\r\nmove 10 from 1 to 4\r\nmove 3 from 6 to 1\r\nmove 9 from 3 to 6\r\nmove 1 from 3 to 8\r\nmove 1 from 2 to 4\r\nmove 6 from 9 to 1\r\nmove 1 from 1 to 4\r\nmove 10 from 1 to 6\r\nmove 1 from 8 to 6\r\nmove 13 from 6 to 7\r\nmove 1 from 2 to 1\r\nmove 1 from 9 to 6\r\nmove 9 from 7 to 5\r\nmove 1 from 9 to 4\r\nmove 3 from 7 to 1\r\nmove 3 from 5 to 6\r\nmove 10 from 4 to 7\r\nmove 5 from 6 to 5\r\nmove 3 from 4 to 5\r\nmove 13 from 6 to 9\r\nmove 7 from 5 to 3\r\nmove 6 from 3 to 2\r\nmove 5 from 6 to 4\r\nmove 4 from 2 to 8";

        public static void Run()
        {
            var steps = args.Split("\r\n")
                .Select(x => Regex.Matches(x, "\\d+")
                    .Select(x => int.Parse(x.Value))
                    .ToArray())
                .ToArray();

            foreach (var step in steps)
            {
                var toMove = new List<string>();
                for (int i = 0; i < step[0]; i++)
                {
                    toMove.Add(stacks[step[1] - 1].Pop());
                }

                toMove.Reverse();
                foreach (var elem in toMove)
                {
                    stacks[step[2] - 1].Push(elem);
                }
            }

            var result = "";
            foreach(var stack in stacks)
            {
                result += stack.Pop();
            }

            Console.WriteLine(result);
        }
    }
}
