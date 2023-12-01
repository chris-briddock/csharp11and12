namespace csharp11and12.CSharp11;

internal class ListPatterns
{
    public void Patterns()
    {
        // Discard Pattern
        var ints = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        if (ints is [1, 2, 3, 4, 5, 6, 7, 8, 9, 10])
        {
            Console.WriteLine("matched");
        }

        // Range Pattern
        if (ints  is [1, ..])
        {
            Console.WriteLine("matched");
        }

        if (ints is [var indexZero, var indexOne, ..])
        {
            Console.WriteLine($"{indexZero}, {indexOne}");
        }
    }

}
