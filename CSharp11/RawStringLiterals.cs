namespace csharp11and12.CSharp11;

internal class RawStringLiterals
{
    public IEnumerable<string> Example()
    {
        // Raw String Literals

        // Single Line
        var singleLine = """This is a "raw string literal". It can contain characters like \, ' and ".""";

        // Multi Line
        var json = """
                 {
                    "ConnectionStrings": {
                        "DefaultConnection": "Server=.;Database=;Trusted_Connection=True;"
                    }
                 }
                """;
        yield return singleLine;
        yield return json;
    }
}
