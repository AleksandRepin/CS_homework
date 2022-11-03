
void arrayFill(int[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        arg[i] = new Random().Next(100, 999);
        Console.WriteLine(arg[i]);
    }
}
 void arrayFind(int[] arg1)
 {
    for (int j =0; j < arg1.Length; j++)
    {
        if (arg1[j] % 2 == 0)
        {
            Console.WriteLine(1);
        }
    }
 }

int[] array = new int[10];
arrayFill(array);
arrayFind(array);




