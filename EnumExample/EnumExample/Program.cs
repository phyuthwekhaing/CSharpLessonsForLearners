public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}

public class EnumExample
{
    public static void Main()
    {
        Season currentSeason = Season.Summer;
        Console.WriteLine($"Current season is {currentSeason}.");
        Season nextSeason = currentSeason + 1;
        Console.WriteLine($"Next Season is {nextSeason}.");
    }
}