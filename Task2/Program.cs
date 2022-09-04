int Sum(int M, int N, int sum)
{
    if (M == N)
    {
        return M;
    }
    sum += N + Sum(M, N-1, sum);
    return sum;
}


Console.WriteLine("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(M, N, 0));