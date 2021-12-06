string path = @"D:\C#\Julekalender\Julekalender\FirstOfDecember\measurements.txt";

if (File.Exists(path))
{
    var lines = File.ReadAllLines(path);

    var numbers = lines.Select(x => int.Parse(x));

    var measurements = Enumerable
        .Zip(numbers, numbers.Skip(1))
        .Where(x => x.First < x.Second)
        .Count();

    var numbersThreeMeasurements = Enumerable
        .Zip(numbers, numbers.Skip(1), numbers.Skip(2))
        .Select(x => x.First + x.Second + x.Third);

    var threeMeasurements = Enumerable
        .Zip(numbersThreeMeasurements, numbersThreeMeasurements.Skip(1))
        .Where(x => x.First < x.Second)
        .Count();

    var outputString = $@"Day 1 - Advent of Code 2021
Part 1 - How many measurements are larger than the previous measurement? Answer: {measurements}
Part 2 - How many measurements are larger than the previous sum of measurements? Answer: {threeMeasurements}";

    Console.WriteLine(outputString);
}