namespace NSwagRepro;

public class NestedData
{
    public InnerDetails Details => new();

    public class InnerDetails
    {
        public int SomeValue { get; set; }
    }
}
