public class Operators
{
    public void Add(int a, int b)
    {
        Console.WriteLine($"Sum: {a + b}");
    }

    public void Subtract(int a, int b)
    {
        Console.WriteLine($"Difference: {a - b}");
    }

    public void Multiply(int a, int b)
    {
        Console.WriteLine($"Multiplication: {a * b}");
    }


    public void Divide(int a, int b)
    {
        if (b != 0)
            Console.WriteLine($"Division: {a / b}");
        else
            Console.WriteLine("Cannot be divided by zero");
    }

    public void OddEvenFinder(int number)
    {
        string result = (number % 2 == 0) ? "Even Number" : "Odd Number";
        Console.WriteLine($"The number {number} is an {result}");
    }
}