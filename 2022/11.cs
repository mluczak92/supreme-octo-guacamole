using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace adventofcode2022._2022
{
    internal static class _11
    {
        //static string args = $"Monkey 0:\r\n  Starting items: 79, 98\r\n  Operation: new = old * 19\r\n  Test: divisible by 23\r\n    If true: throw to monkey 2\r\n    If false: throw to monkey 3\r\n\r\nMonkey 1:\r\n  Starting items: 54, 65, 75, 74\r\n  Operation: new = old + 6\r\n  Test: divisible by 19\r\n    If true: throw to monkey 2\r\n    If false: throw to monkey 0\r\n\r\nMonkey 2:\r\n  Starting items: 79, 60, 97\r\n  Operation: new = old * old\r\n  Test: divisible by 13\r\n    If true: throw to monkey 1\r\n    If false: throw to monkey 3\r\n\r\nMonkey 3:\r\n  Starting items: 74\r\n  Operation: new = old + 3\r\n  Test: divisible by 17\r\n    If true: throw to monkey 0\r\n    If false: throw to monkey 1";
        static string args = "Monkey 0:\r\n  Starting items: 97, 81, 57, 57, 91, 61\r\n  Operation: new = old * 7\r\n  Test: divisible by 11\r\n    If true: throw to monkey 5\r\n    If false: throw to monkey 6\r\n\r\nMonkey 1:\r\n  Starting items: 88, 62, 68, 90\r\n  Operation: new = old * 17\r\n  Test: divisible by 19\r\n    If true: throw to monkey 4\r\n    If false: throw to monkey 2\r\n\r\nMonkey 2:\r\n  Starting items: 74, 87\r\n  Operation: new = old + 2\r\n  Test: divisible by 5\r\n    If true: throw to monkey 7\r\n    If false: throw to monkey 4\r\n\r\nMonkey 3:\r\n  Starting items: 53, 81, 60, 87, 90, 99, 75\r\n  Operation: new = old + 1\r\n  Test: divisible by 2\r\n    If true: throw to monkey 2\r\n    If false: throw to monkey 1\r\n\r\nMonkey 4:\r\n  Starting items: 57\r\n  Operation: new = old + 6\r\n  Test: divisible by 13\r\n    If true: throw to monkey 7\r\n    If false: throw to monkey 0\r\n\r\nMonkey 5:\r\n  Starting items: 54, 84, 91, 55, 59, 72, 75, 70\r\n  Operation: new = old * old\r\n  Test: divisible by 7\r\n    If true: throw to monkey 6\r\n    If false: throw to monkey 3\r\n\r\nMonkey 6:\r\n  Starting items: 95, 79, 79, 68, 78\r\n  Operation: new = old + 3\r\n  Test: divisible by 3\r\n    If true: throw to monkey 1\r\n    If false: throw to monkey 3\r\n\r\nMonkey 7:\r\n  Starting items: 61, 97, 67\r\n  Operation: new = old + 4\r\n  Test: divisible by 17\r\n    If true: throw to monkey 0\r\n    If false: throw to monkey 5";

        public static void Run()
        {
            var monkeys = args.Split("\r\n\r\n")
                .ToDictionary(x => x.Split("\r\n")[0].Replace(":", "").ToLower(),
                    x =>
                    {
                        var raw = x.Split("\r\n").Skip(1).ToArray();
                        var expression = Regex.Match(raw[1], "Operation: new = (.*)").Groups[1].Value;
                        return new
                        {
                            Items = Regex.Match(raw[0], "Starting items: (.*)").Groups[1].Value
                                .Split(", ")
                                .Select(x => ulong.Parse(x))
                                .ToList(),
                            Operation = DynamicExpressionParser.ParseLambda(new[] { Expression.Parameter(typeof(ulong), "old") }, typeof(ulong), expression).Compile(),
                            Test = ulong.Parse(Regex.Match(raw[2], "divisible by (.*)").Groups[1].Value),
                            TestTrue = Regex.Match(raw[3], "If true: throw to (.*)").Groups[1].Value,
                            TestFalse = Regex.Match(raw[4], "If false: throw to (.*)").Groups[1].Value,
                        };
                    });

            var leastCommonMulti = monkeys.Aggregate(1UL, (x, y) => x * y.Value.Test);
            var inspections = monkeys.ToDictionary(x => x.Key, _ => 0UL);
            for (int i = 0; i < 10000; i++)
            {
                foreach (var monkey in monkeys)
                {
                    foreach (var item in monkey.Value.Items)
                    {
                        inspections[monkey.Key]++;
                        ulong worryLvl = (ulong)monkey.Value.Operation.DynamicInvoke(item) % leastCommonMulti;
                        if (worryLvl % monkey.Value.Test == 0)
                        {
                            monkeys[monkey.Value.TestTrue].Items.Add(worryLvl);
                        }
                        else
                        {
                            monkeys[monkey.Value.TestFalse].Items.Add(worryLvl);
                        }
                    }

                    monkey.Value.Items.Clear();
                }
            }

            Console.WriteLine(inspections.OrderByDescending(x => x.Value)
                .Take(2)
                .Aggregate(1UL, (x, y) => x * y.Value));
        }
    }
}