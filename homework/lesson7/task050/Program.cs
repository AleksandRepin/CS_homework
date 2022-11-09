
internal class Program
{
    private static void Main(string[] args)
    {
        static void FindElementOrNot()
        {
            int[,] Matrix = new int[3, 4];


            void FillMatrix(int[,] arg)
            {
                for (int i = 0; i < arg.GetLength(0); i++)
                {
                    for (int j = 0; j < arg.GetLength(1); j++)
                    {
                        arg[i, j] = new Random().Next(-2147483468, 2147483647);
                        Console.Write($"{arg[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
            FillMatrix(Matrix);

            Console.Write("Please enter element x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter element y = ");
            int y = Convert.ToInt32(Console.ReadLine());

            void NoElement(int[,] arg2)
            {
                if (x > 3 || y > 4)
                {
                    Console.WriteLine("No element [x, y]");
                }
            }
            NoElement(Matrix);

            void FindElement(int[,] arg1)
            {
                if (x <= 3 || y <= 4)
                {
                    Console.WriteLine($"Element[x, y] = {arg1[x, y]}");
                    return;
                }
            }
            FindElement(Matrix);
        }
        FindElementOrNot();
    }
}