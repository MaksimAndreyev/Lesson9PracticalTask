int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n+1;
    }
    if (n == 0)
    {
        return Ackermann(m-1, 1);
    }
    return Ackermann(m-1, Ackermann(m, n-1));
}


Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Ackermann(m, n));