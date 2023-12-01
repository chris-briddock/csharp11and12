namespace csharp11and12.CSharp12;

public class OptionalParamForLambdasAndMethodGroups
{
    public void MyMethod() {
        var addWithDefault = (int addTo = 2) => addTo + 1;
        addWithDefault (); // 3
        addWithDefault (5); // 6

        var counter = (params int[] xs) => xs.Length;
        counter (); // 0
        counter (1, 2, 3); // 3

    }
}