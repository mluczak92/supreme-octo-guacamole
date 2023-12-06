namespace adventofcode2022._2023;

public class _6
{
    public static string args = @"Time:        46828479
Distance:   347152214061471";
    
    public static void Run()
    {
        var parsed = args.Split("\n", StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Split(":", StringSplitOptions.RemoveEmptyEntries)[1])
            .Select(x => x.Split(" ", StringSplitOptions.RemoveEmptyEntries))
            .ToList();

        var races = parsed.First()
            .Select((x, idx) => (long.Parse(x), long.Parse(parsed.Last().ElementAt(idx))))
            .ToList();

        var result = 1l;
        foreach (var race in races)
        {
            var first = FindFirstElement(race, 1, race.Item1 / 2);
            var last = FindLastElement(race, race.Item1 / 2, race.Item1 - 1);
            result *= last - first + 1l;
        }
        
        Console.WriteLine(result);
    }

    public static long FindFirstElement((long Time, long Distance) race, long rangeStart, long rangeEnd)
    {
        while (true)
        {
            var result = FitFunction(rangeStart, race.Time);
            var previous = FitFunction(rangeStart - 1, race.Time);

            // break condition
            if (result > race.Distance && previous <= race.Distance)
            {
                return rangeStart;
            }

            // go lower
            if (result > race.Distance && previous > race.Distance)
            {
                return FindFirstElement(race, rangeStart / 2, (rangeStart + rangeEnd) / 2);
            }
            
            // go bigger
            if (result <= race.Distance && previous <= race.Distance)
            {
                return FindFirstElement(race, (rangeStart + rangeEnd) / 2 , rangeEnd);
            }

            throw new Exception();
        }
    }

    public static long FindLastElement((long Time, long Distance) race, long rangeStart, long rangeEnd)
    {
        while (true)
        {
            var result = FitFunction(rangeStart, race.Time);
            var next = FitFunction(rangeStart + 1, race.Time);

            // break condition
            if (result > race.Distance && next <= race.Distance)
            {
                return rangeStart;
            }

            // go bigger
            if (result > race.Distance && next > race.Distance)
            {
                return FindLastElement(race, (rangeStart + rangeEnd) / 2, rangeEnd);
            }
            
            // go lower
            if (result <= race.Distance && next <= race.Distance)
            {
                return FindLastElement(race, rangeStart / 2, (rangeStart + rangeEnd) / 2);
            }

            throw new Exception();
        }
    }

    public static long FitFunction(long holdingTime, long raceTime)
    {
        var remainingTime = raceTime - holdingTime;
        return remainingTime * holdingTime;
    }
}