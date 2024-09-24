
using System;
namespace paramsex;

internal class Program
{
    static void Main(string[] args)
    {
        double total = CheckOut(3.25, 34, 5423, 243);
        Console.WriteLine(total);
    }
    static double CheckOut(params double[] prices)
    {
        double total = 0;
        foreach (double price in prices)
        {
            total += price;
        }
        return total;
    }

}


