namespace csharp11and12;

public class ExtendedNameOf 
{
    // you can use a nameof expression with a method parameter 
    // inside an attribute on a method or its parameter.
    [Name(nameof(test))]
    public void MyMethod(string test) 
    {

    }
}

public class NameAttribute(string v) : Attribute
{
    private string v = v;
}