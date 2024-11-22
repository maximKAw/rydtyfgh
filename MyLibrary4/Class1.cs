using System;

namespace MyLibrary
{
    public class MathOperations
    {
        // Метод с типом void
        public void PrintHello()
        {
            Console.WriteLine("Hello from MyLibrary!");
        }

        // Метод с типом void
        public void PrintSum(int a, int b)
        {
            Console.WriteLine($"Sum: {a + b}");
        }

        // Метод с возвращаемым значением (int)
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Метод с возвращаемым значением (string)
        public string GetGreeting(string name)
        {
            return $"Hello, {name}!";
        }

        // Метод с возвращаемым значением (double)
        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return (double)a / b;
        }
    }
}