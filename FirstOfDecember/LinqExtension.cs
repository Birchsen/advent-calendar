namespace FirstOfDecember;
public static class LinqExtension
{
    public static int CountMeasurements(this IEnumerable<int> source)
    {
        int measurements = 0;
        int previousMeasurement = int.MaxValue;
        foreach (var item in source)
        {
            if (item > previousMeasurement)
            {
                measurements++;
            }
            previousMeasurement = item;
        }

        return measurements;
    }
}
