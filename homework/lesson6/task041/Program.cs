


Console.Write("Enter M (number of numbers) = ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];

void getSumPositiveNumbers(int[] arg)
{
    int sum = 0;
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write("Enter number = ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n > 0)
        {
        sum++;
        }
    }
    Console.WriteLine($"Sum Positive numbers = {sum}");
}

getSumPositiveNumbers(array);


