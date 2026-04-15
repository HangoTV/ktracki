//Bài 1:
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
}
//Bài 2:
Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
//Bài 3:
Console.Write("Input n: ");
int m = Convert.ToInt32(Console.ReadLine());
int S = 0;
for (int i = 1; i <= m; i++)
{
    S += i;
}
Console.WriteLine("S = " + S);
//Bài 4:
Console.Write("Input n: ");
int k= Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Bảng cửa chương của {k}");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(k*i);
}
//Bài 5:
Console.Write("Input n: ");
int t = Convert.ToInt32(Console.ReadLine());
int giaithua=1;
for (int i = 1; i <= t; i++)
{
    giaithua*=i;
}
Console.WriteLine(giaithua);
//Bài 6:
Console.Write("Input n: ");
int h=Convert.ToInt32(Console.ReadLine());
double total=0;
for (double i = 1; i < h; i++)
{
    total+=1/i;
}
Console.WriteLine(total);
//Bài 7:
Console.Write("Input n: ");
int z = Convert.ToInt32(Console.ReadLine());
 static int Fibonacci(int z)
{
    if (z == 1) return 1;
    if (z == 2) return 1;
    return Fibonacci(z - 1) + Fibonacci(z - 2);
}
Fibonacci(z);
for (int i = 1; i <= z; i++)
{
    Console.WriteLine(Fibonacci(i));
}
//Bài 8:
Console.Write("Input m: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int b=Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= a; i++)
{
    for (int j = 1; j <= b; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}
//Bài 9:
Console.Write("Input h: ");
int tall=Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= tall; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
//Bài 10:
Console.Write("Input h: ");
int tall1=Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= tall1; i++)
{
    for (int j = 1; j <= tall1 - i; j++)
    {
        Console.Write(" ");
    }

    for (int l = 1; l <= i * 2 - 1; l++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}