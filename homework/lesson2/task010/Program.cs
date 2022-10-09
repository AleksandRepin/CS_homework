// ввести число abc
// вычисление 
// показ 

//double res(int N);
//int N = new Random().Next(100,999);
//Console.writeLine(N);
//res = N / 10 % 10;

void task010(int N = new Random().Next(100,999));
{
    Console.WriteLine(N);
    int res = N / 10 % 10;
}
Console.WriteLine(res);