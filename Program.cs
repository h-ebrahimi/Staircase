using System;
using System.Linq;

class Result
{

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        for (var i = 1; i <= n; i++)
        {
            Console.WriteLine($"{string.Concat(Enumerable.Repeat(" ", n-i))}{string.Concat(Enumerable.Repeat("#", i))}");
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
