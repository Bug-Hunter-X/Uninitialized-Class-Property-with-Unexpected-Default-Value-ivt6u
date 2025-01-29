public class InitializedProperty
{
    public int MyProperty { get; set; }

    public InitializedProperty()
    {
        // Initialize MyProperty to a specific value in the constructor.
        MyProperty = 10;
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Output: 10
    }
}