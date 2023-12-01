using System.Diagnostics.CodeAnalysis;

namespace csharp11and12.CSharp12;

public class ExperimentalAttributes 
{
    [Experimental(Feature.MyFeature)]
    public void MyMethod() 
    {
        
    }

    
}

public static class Feature 
{
    public const string MyFeature = "MyFeature";
}
