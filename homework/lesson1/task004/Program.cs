int a = new Random().Next(-2147483648, 2147483647);
int b = new Random().Next(-2147483648, 2147483647);
int c = new Random().Next(-2147483648, 2147483647);

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write("Наибольшее -> ");
Console.WriteLine(max);
