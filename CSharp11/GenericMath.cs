using System.Numerics;

namespace csharp11and12.CSharp11
{
    internal class GenericMath
    {
        private static T Add<T>(T left, T right) where T : INumber<T>
        {
            return left + right;
        }

        public static void CallAdd()
        {
            var result = Add(2, 2);
            Console.WriteLine(result);
        }

    }
}
