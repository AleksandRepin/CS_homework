
internal class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[3];
        Console.Write("ax: ");
        a[0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("ay: ");
        a[1] = Convert.ToInt32(Console.ReadLine());
        Console.Write("az: ");
        a[2] = Convert.ToInt32(Console.ReadLine());

        int[] b = new int[3];
        Console.Write("bx: ");
        b[0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("by: ");
        b[1] = Convert.ToInt32(Console.ReadLine());
        Console.Write("bz: ");
        b[2] = Convert.ToInt32(Console.ReadLine());

        int A = (a[0] - b[0]) * (a[0] - b[0]);
        int B = (a[1] - b[1]) * (a[1] - b[1]);
        int C = (a[2] - b[2]) * (a[2] - b[2]);
        var result = Math.Sqrt(A + B + C);
        Console.WriteLine(result);
    }
}