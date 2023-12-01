namespace csharp11and12.CSharp11;

internal class AutoDefaultStructs
{
    struct MyStruct
    {
        public int N;

        public MyStruct()
        {
            N = default;
        }
    }
}
