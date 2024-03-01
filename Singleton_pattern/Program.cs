/*
 The Singleton pattern is a creational design pattern that ensures a class has only one instance 
and provides a global point of access to that instance throughout the application. 
It’s particularly useful when you want to coordinate actions across the system using a single instance of a class.

Here are the key points about the Singleton Design Pattern:

Private Constructor: We declare a private and parameterless constructor to prevent external instantiation of the class. 
This ensures that the class can only be instantiated from within itself.
Sealed Class: We declare the class as sealed to prevent inheritance. This is especially important when dealing with nested classes.
Static Instance Variable: We create a private static variable that holds the singleton instance of the class.
Public Static Property/Method: We provide a public static property or method that returns the singleton instance. 
If an instance already exists, it returns that instance; otherwise, it creates a new instance and returns it.

 */
// Usage or call
var singletonInstance = Singleton.Instance;
singletonInstance.DoSingletonOperation();

public sealed class Singleton
{
    private static Singleton _instance;

    // Private constructor
    private Singleton()
    {
        // Initialization code (if needed)
    }

    // Public static property to get the singleton instance
    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }

    // Other methods and properties of the Singleton class
    public void DoSingletonOperation()
    {
        // Perform some operation
    }
}

