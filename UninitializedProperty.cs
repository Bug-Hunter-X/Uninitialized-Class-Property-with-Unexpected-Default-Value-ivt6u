public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that hasn't been initialized will result in a default value (0 for int).
        // However, if you expect a specific initial value, you should initialize it in the constructor.
        Console.WriteLine(MyProperty); // Output: 0
    }
}