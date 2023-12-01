namespace csharp11and12.CSharp11;

internal class PatternMatchSpan
{
    static bool Is123(ReadOnlySpan<char> s)
    {
        return s is "123";
    }

    static bool IsABC(Span<char> s)
    {
        return s switch { "ABC" => true, _ => false };
    }
}
