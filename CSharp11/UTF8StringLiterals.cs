namespace csharp11and12.CSharp11;

internal class UTF8StringLiterals
{
    public void UTF8()
    {
        ReadOnlySpan<byte> s3 = "hello"u8;

        Console.WriteLine(s3.ToString());
    }
}
