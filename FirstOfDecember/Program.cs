using FirstOfDecember;

string path = @"D:\C#\Julekalender\Julekalender\FirstOfDecember\measurements.txt";

if (File.Exists(path))
{
    var measurements = File.ReadLines(path)
        .Where(m => !string.IsNullOrWhiteSpace(m))
        .Select(m => int.Parse(m))
        .CountMeasurements();

    Console.WriteLine(measurements);
}