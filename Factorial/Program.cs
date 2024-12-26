static long FactorialIteration(long n)
{
    var result = 1;
    for (int i = 1; i <= n; i++)
    {
        result = result * i;
    }
    return result;
}

static long FactorialRecursion(long n)
{
    if (n <= 1) return 1;
    return FactorialRecursion(n - 1) * n;

}

var res = FactorialIteration(8);
var res1 = FactorialRecursion(8);

Console.WriteLine(res);
Console.WriteLine(res1);

Console.ReadKey();