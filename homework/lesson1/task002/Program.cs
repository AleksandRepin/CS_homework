int a = new Random().Next(-2147483648, 2147483647);
Console.WriteLine(a);
int b = new Random().Next(-2147483648, 2147483647);
Console.WriteLine(b);
int max = 0;
int min = 0;
if (a > b) { max = a;
min = b;
}
else { max = b;
min = a;
}

Console.Write("Наибольшее -> ");
Console.WriteLine(max);
Console.Write("Наименьшее -> ");
Console.WriteLine(min);
