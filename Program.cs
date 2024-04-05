// Program.cs

// Include necessary namespaces
using System;

// Define a namespace for the program
namespace MyProgram
{
    // Define a class called Program
    class Program
    {
        // Main method, the entry point of the program
        static void Main(string[] args)
        {
            // Create an instance of the Greetings class
            GreetingNamespace.Greetings greetings = new GreetingNamespace.Greetings();

            // Call the Welcome method from the Greetings class
            greetings.Welcome();

            // Call the Hello method from the Greetings class with a string argument
            greetings.Hello("John");
        }
    }
}