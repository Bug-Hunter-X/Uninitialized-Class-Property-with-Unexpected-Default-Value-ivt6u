# Uninitialized Class Property in C#

This example demonstrates the behavior of uninitialized properties in C# classes.  Uninitialized properties will have default values based on their type, which might not be the value you expect.

**Problem:**

The `MyProperty` in `UninitializedProperty.cs` is not explicitly initialized.  When `MyMethod` is called, it will output the default value for an integer (0).  If the developer expected a different default value, this will cause unexpected behavior. 

**Solution:**

The `InitializedProperty.cs` shows the correct solution by explicitly initializing `MyProperty` in the constructor. This ensures the property has the intended default value from the start.

This is a common and subtle error that often leads to unexpected results in larger programs. Always carefully consider your class property initialization to avoid such issues.