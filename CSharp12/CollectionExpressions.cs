namespace csharp11and12.CSharp12;

public class CollectionExpressions 
{
    // you can now write collections with values in the same way across 
    // all collections
    private readonly int[] intArray = [1,2,3,4,5,6];
    private readonly List<int> ints = [1,2,3,4,5,6];
    private readonly int[][] twoD = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
    private readonly int[] row0 = [1, 2, 3];
    private readonly int[] row1 = [4, 5, 6];
    private readonly int[] row2 = [7, 8, 9];

    public void MyMethod() 
    {
        int[][] twoDFromVariables = [row0, row1, row2];
        // spread operator
        int[] single = [..row0, ..row1, ..row2];
    }
    
}

ref struct RefStruct() {
    private ReadOnlySpan<char> c  = ['a', 'b', 'c', 'd', 'e', 'f', 'h', 'i'];
}