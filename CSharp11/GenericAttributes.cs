namespace csharp11and12.CSharp11
{
    internal class GenericAttributes
    {
        public class CustomGenericAttribute<T> : Attribute { }

        [CustomGeneric<int>]
        public class UseGenericAttribute { }
    }
}
