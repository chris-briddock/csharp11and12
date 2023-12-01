namespace csharp11and12.CSharp12;

public static class RefReadOnly 
{
    public static int myString(ref readonly int value) {
        return value;
    }
}