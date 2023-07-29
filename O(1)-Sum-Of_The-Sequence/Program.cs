using System.Diagnostics;
using System.Numerics;


//We need to calculate the sum of all numbers through 1 to N inclusively
//As we can see for number 6
//1+2+3+4+5+6 = 21
//Equal to:
//(1+6)+(2+5)+(3+4)= 7×3 = 21
//And for
//1+2+3+4+5+6+7 = 28
//(1+6)+(2+5)+(3+4)+7 = 7*4 = 28
//Based on this information, we can write a method that quickly sums a sequence of numbers.
//The code presents a regular loop for comparison and a method that calculates the sum of
//the entire sequence of digits from 1 to N in three operations (bitwise shift, incrementation,
//multiplication).


class Program
{
    /// <summary>
    /// The method sums all values from 1 to N inclusively in three operations. 
    /// It is efficient for working with large numbers.
    /// </summary>
    /// <param name="n">Number</param>
    /// <returns>The sum of all numbers 1 through N</returns>
    public static BigInteger SumTheSequence(long n)
    {
        BigInteger result = BigInteger.Zero;
        if (n % 2 == 0)
        {
            result = BigInteger.Multiply((n >> 1), (n + 1));
        }
        else
        {
            result = BigInteger.Multiply(((n >> 1) + 1), n);
        }
        return result;
    }
    /// <summary>
    /// The method sums all values from 1 to N inclusively via simple cycle 
    /// </summary>
    /// <param name="n">Number</param>
    /// <returns>The sum of all numbers 1 through N</returns>
    public static BigInteger Proof(long n)
    {
        BigInteger result = BigInteger.Zero;
        for (int i = 1; i <= n; i++)
        {
            result += i;
        }
        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine($"Max value: {long.MaxValue}");
        Console.Write($"Input positive value: ");
        if (long.TryParse(Console.ReadLine(), out long input) && input >= 0)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine($"Calculated via 3 operations: {SumTheSequence(input)}");
            stopwatch.Stop();
            Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();
            Console.WriteLine($"Calculated via cycle: {Proof(input)}");
            stopwatch.Stop();
            Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds} ms");
        }
        else Console.WriteLine("Invalid value");
    }
}