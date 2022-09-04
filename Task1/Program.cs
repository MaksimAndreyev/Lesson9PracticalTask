int Numbers(int N)
{
    if (N == 1)
    {
        return N;
    }
    Console.Write(N+", ");
    N = Numbers(N-1);
    return N;
}

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Numbers(N));