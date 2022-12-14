using System.Drawing;

namespace adventofcode2022._2022
{
    internal static class _12
    {
        //static string args = "Sabqponm\r\nabcryxxl\r\naccszExk\r\nacctuvwj\r\nabdefghi";
        static string args = "abacccaaaacccccccccccaaaaaacccccaaaaaaccccaaacccccccccccccccccccccccccccccccccccccccccccaaaaa\r\nabaaccaaaacccccccccccaaaaaaccccccaaaaaaaaaaaaaccccccccccccccccccccccccccccccccccccccccccaaaaa\r\nabaaccaaaacccccccccccaaaaacccccaaaaaaaaaaaaaaaccccccccccccccccccccccccccccccccccccccccccaaaaa\r\nabccccccccccccccccccccaaaaacccaaaaaaaaaaaaaaaacccccccccccccccccccccccccccaaaccccccccccccaaaaa\r\nabccccccccccccccccccccaacaacccaaaaaaaaccaaaaaccccccccccccccccccccccccccccaaaccccccccccccaccaa\r\nabcccccccccccccaacccaaaccccccaaaaaaaaaccaaaaaccccccccccccccccccccccccccccccacccccccccccccccca\r\nabcccccccccccaaaaaaccaaaccacccccaaaaaaacccccccccccccccccccccccccciiiicccccccddddddccccccccccc\r\nabcccccccccccaaaaaaccaaaaaaaccccaaaaaacccccaacccccccaaaccccccccciiiiiiiicccdddddddddacaaccccc\r\nabccccccccccccaaaaaaaaaaaaacccccaaaaaaacaaaacccccccaaaacccccccchhiiiiiiiiicddddddddddaaaccccc\r\nabcccccccccccaaaaaaaaaaaaaacccccccaaacccaaaaaacccccaaaaccccccchhhipppppiiiijjjjjjjddddaaccccc\r\nabcccccccccccaaaaaaaaaaaaaaccccccccccccccaaaaaccccccaaaccccccchhhpppppppiijjjjjjjjjddeeaccccc\r\nabcccccccccccccccccaaaaaaaacccccccccccccaaaaaccccccccccccccccchhppppppppppjjqqqjjjjjeeeaacccc\r\nabccccccccccccccccccaaaaaaaacccccccccccccccaacccccccccccccccchhhpppuuuupppqqqqqqqjjjeeeaacccc\r\nabcccccccccccccccccccaacccacccccccccccccccccccccccccccccccccchhhopuuuuuuppqqqqqqqjjjeeecccccc\r\nabacccccccccccccaaacaaaccccccccccccccccccccccccccccaaccccccchhhhoouuuuuuuqvvvvvqqqjkeeecccccc\r\nabaccccccccccccaaaaaacccccaaccccccccccccccccccccccaaaccccccchhhooouuuxxxuvvvvvvqqqkkeeecccccc\r\nabaccccccccccccaaaaaacccaaaaaaccccccccccccccccccaaaaaaaaccchhhhooouuxxxxuvyyyvvqqqkkeeecccccc\r\nabcccccccccccccaaaaacccaaaaaaaccccccccccccccccccaaaaaaaaccjjhooooouuxxxxyyyyyvvqqqkkeeecccccc\r\nabccccccccccccccaaaaaacaaaaaaaccccccccaaaccccccccaaaaaaccjjjooootuuuxxxxyyyyyvvqqkkkeeecccccc\r\nabccccccccccccccaaaaaaaaaaaaacccccccccaaaacccccccaaaaaacjjjooootttuxxxxxyyyyvvrrrkkkeeecccccc\r\nSbccccccccccccccccccaaaaaaaaacccccccccaaaacccccccaaaaaacjjjoootttxxxEzzzzyyvvvrrrkkkfffcccccc\r\nabcccccccccccaaacccccaaaaaaacaaaccccccaaaccccccccaaccaacjjjoootttxxxxxyyyyyyvvvrrkkkfffcccccc\r\nabcccccccccaaaaaacccaaaaaacccaaacacccaacccccccccccccccccjjjoootttxxxxyxyyyyyywvvrrkkkfffccccc\r\nabcccccccccaaaaaacccaaaaaaaaaaaaaaaccaaacaaacccccaacccccjjjnnnttttxxxxyyyyyyywwwrrkkkfffccccc\r\nabcaacacccccaaaaacccaaacaaaaaaaaaaaccaaaaaaacccccaacaaacjjjnnnntttttxxyywwwwwwwwrrrlkfffccccc\r\nabcaaaaccccaaaaacccccccccaacaaaaaaccccaaaaaacccccaaaaacccjjjnnnnnttttwwywwwwwwwrrrrllfffccccc\r\nabaaaaaccccaaaaaccccccaaaaaccaaaaacaaaaaaaaccccaaaaaaccccjjjjinnnntttwwwwwsssrrrrrllllffccccc\r\nabaaaaaaccccccccccccccaaaaacaaaaaacaaaaaaaaacccaaaaaaacccciiiiinnnntswwwwssssrrrrrlllfffccccc\r\nabacaaaaccccccccccccccaaaaaacaaccccaaaaaaaaaaccccaaaaaaccccciiiinnnssswwsssssllllllllfffccccc\r\nabccaaccccccccccccccccaaaaaaccccccccccaaacaaaccccaaccaacccccciiiinnsssssssmmllllllllfffaacccc\r\nabccccccccccccccccccccaaaaaaccccccccccaaaccccccccaaccccccccccciiinnmsssssmmmmlllllgggffaacccc\r\nabcccccccccccccccaccccccaaacccccccccccaaccccccccccccccccccccccciiimmmsssmmmmmgggggggggaaacccc\r\nabcccccccccaaaaaaaaccccccccccccccccccccccccccccaaaaaccccccccccciiimmmmmmmmmgggggggggaaacccccc\r\nabccccccccccaaaaaaccccccccccccccccccaacccccccccaaaaacccccccccccciiimmmmmmmhhggggcaaaaaaaccccc\r\nabccccccccccaaaaaacccccccccccccccccaacccccccccaaaaaacccccccccccciihhmmmmhhhhgccccccccaacccccc\r\nabccccaacaaaaaaaaaaccccccccccccccccaaaccccccccaaaaaaccccccccccccchhhhhhhhhhhaaccccccccccccccc\r\nabccccaaaaaaaaaaaaaaccccccccccaaccaaaaccccccccaaaaaacccaaacccccccchhhhhhhhaaaaccccccccccccccc\r\nabcccaaaaaaaaaaaaaaaccccccccaaaaaacaaaacacaccccaaaccccaaaacccccccccchhhhccccaaccccccccccaaaca\r\nabcccaaaaaacacaaacccccccccccaaaaaaaaaaaaaaacccccccccccaaaacccccccccccaaaccccccccccccccccaaaaa\r\nabcccccaaaacccaaaccccccccccaaaaaaaaaaaaaaaaccccccccccccaaacccccccccccaaacccccccccccccccccaaaa\r\nabcccccaacccccaacccccccccccaaaaaaaaaaaaaccccccccccccccccccccccccccccccccccccccccccccccccaaaaa";
        static string _char = "█";
        static string _backChar = "█";
        static string _empty = ".";
        public async static Task Run()
        {
            var map = args.Split("\r\n")
                .Select(x => x.ToArray())
                .ToArray();

            var start = (0, 0, 0, (0, 0));
            var end = (0, 0, 0, (0, 0));
            for (int i = 0; i < map.Length; i++)
            {
                for (int j = 0; j < map[i].Length; j++)
                {
                    if (map[i][j] == 'S')
                    {
                        start = (i, j, 0, (0, 0));
                        map[i][j] = 'a';
                    }
                    else if (map[i][j] == 'E')
                    {
                        end = (i, j, 0, (0, 0));
                        map[i][j] = 'z';
                    }
                }
            }

            List<(int, int, int, (int, int))> steps = new List<(int, int, int, (int, int))>
            {
                end
            };

            await CounterDown();
            Display(map, steps);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(end.Item2, end.Item1 + 1);
            Console.Write(_char);

            for (int i = 0; i < steps.Count; i++)
            {
                var current = steps[i];

                var x = current.Item1 - 1;
                var y = current.Item2;
                if (Move(map, start, steps, current, x, y)) break;

                x = current.Item1 + 1;
                y = current.Item2;
                if (Move(map, start, steps, current, x, y)) break;

                x = current.Item1;
                y = current.Item2 - 1;
                if (Move(map, start, steps, current, x, y)) break;

                x = current.Item1;
                y = current.Item2 + 1;
                if (Move(map, start, steps, current, x, y)) break;

                if (i % 10 == 0)
                    await Task.Delay(1);
            }

            backCounter = 0;
            Console.ResetColor();
            await GoBack(steps, (steps.Last().Item1, steps.Last().Item2));

            Console.SetCursorPosition(0, map.Length + 2);
            Console.WriteLine(steps.Last().Item3);
        }

        static async Task CounterDown()
        {
            for (int i = 3; i >= 0; i--)
            {
                Console.Clear();
                Console.Write(i);
                await Task.Delay(1000);
            }

            Console.Clear();
        }

        static int backCounter = 0;
        static async Task GoBack(List<(int, int, int, (int, int))> steps, (int, int) current)
        {
            backCounter++;
            if (backCounter % 5 == 0)
                await Task.Delay(3);

            if (current.Item1 == 0 && current.Item2 == 0)
            {
                return;
            }

            Console.SetCursorPosition(current.Item2, current.Item1 + 1);
            Console.Write(_backChar);

            var next = steps.Single(x => x.Item1 == current.Item1 && x.Item2 == current.Item2);
            await GoBack(steps, next.Item4);
        }

        static bool Move(char[][] map,
            (int, int, int, (int, int)) start,
            List<(int, int, int, (int, int))> steps,
            (int, int, int, (int, int)) current,
            int x, int y)
        {
            //up down boundries
            if (x < 0 || x >= map.Length)
            {
                return false;
            }

            //right left
            if (y < 0 || y >= map[0].Length)
            {
                return false;
            }

            //same, 1 lower or bigger
            if (map[x][y] == map[current.Item1][current.Item2] ||
                map[x][y] + 1 == map[current.Item1][current.Item2] ||
                map[x][y] > map[current.Item1][current.Item2])
            {
                //already exists
                if (steps.Any(p => p.Item1 == x && p.Item2 == y))
                {
                    return false;
                }

                Console.SetCursorPosition(y, x + 1);
                Console.Write(_char);

                steps.Add((x, y, current.Item3 + 1, (current.Item1, current.Item2)));
                if (map[x][y] == 97)
                {
                    return true;
                }
            }

            return false;
        }

        static void Display(char[][] map, List<(int, int, int, (int, int))> steps)
        {
            for (int i = 0; i < map.Length; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < map[i].Length; j++)
                {
                    Console.Write(_empty);
                }
            }
        }
    }
}
