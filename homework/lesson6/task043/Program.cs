
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter b1 = ");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter k1 = ");
        double k1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter b2 = ");
        double b2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter k2 = ");
        double k2 = Convert.ToDouble(Console.ReadLine());

        double x = (b2 - b1) / (k1 - k2);
        Console.WriteLine($"({x}; {x})");
    }
}