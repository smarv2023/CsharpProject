//Fibonacci O(n2)

using System.Reflection.Emit;

int n = 50;
double[] memo = new double[n + 1];
/* 
for (int i = 0; i <= n; i++)
{
    memo[i] = fib(i, memo);
    Console.WriteLine($"index {i} :: {memo[i]}");
}
 */

 Console.WriteLine(fib(n, memo));

double fib(int n, double[] memo)
{
    Console.WriteLine($"New cycle {n}");
    if (n <= 1)
    {
        Console.WriteLine($"if return {n}");
        return n;
    }
    else if (memo[n] != 0)
        {
            Console.WriteLine($"else if {n} :: {memo[n]}");
            return memo[n]; // Return memoized value if available
        }
    else
    {
        Console.WriteLine($"else {n} :: {memo[n]}");
        memo[n] = fib(n - 1, memo) + fib(n - 2, memo);
        return memo[n];
    }

}