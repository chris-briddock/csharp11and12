using Point = (int x, int y);

namespace csharp11and12.CSharp12
{
    public class AliasAnyTypes
    {
        public Point MyMethod() {
            var myPoint = new Point(2,3);
            return myPoint;
        }
        
    }
}