using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Greetings.cs

// Declare a namespace to organize code
namespace GreetingNamespace
{
    // Define a class called Greetings
    public class Greetings
    {
        // Define a public method that prints a welcome message
        public void Welcome()
        {
            Console.WriteLine("Welcome! Have a great day!");
        }

        // Define another public method that takes a string parameter and prints a personalized message
        public void Hello(string name)
        {
            // Print a personalized message using the provided name parameter
            Console.WriteLine($"{name}, thank you for joining us today!");
        }
    }
}