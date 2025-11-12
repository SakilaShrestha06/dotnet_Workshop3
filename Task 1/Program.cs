namespace Task_1;

class Program
{
    static void Main(string[] args)
    {
        Operators op = new Operators();
        op.Add(10, 5);
        op.Subtract(20, 15);
        op.Multiply(9, 4);
        op.Divide(25, 5);
        op.OddEvenFinder(17);
    }

}

