using System;

public class NumberFormattingDemo
{
    public void Run()
    {
        int[] quarters = { 1, 2, 3, 4 };
        int[] sales = { 100000, 150000, 200000, 225000 };
        double[] intlMixPct = { 0.386, 0.413, 0.421, 0.457 };
        int val1 = 1234;
        decimal val2 = 1234.5678m;

        // Specifying Numerical Formatting
        Console.WriteLine("Basic Formats:");
        Console.WriteLine($"{val1:D}, {val1:N}, {val1:F}, {val1:G}");
        Console.WriteLine($"{val2:E}, {val2:N}, {val2:F}, {val2:G}");

        // Format with precision
        Console.WriteLine("\nWith Precision:");
        Console.WriteLine($"{val1:D6}, {val1:N2}, {val1:F1}, {val1:G3}");

        // Formatting with alignment and spacing
        Console.WriteLine("\nSales by Quarter:");
        Console.WriteLine($"{quarters[0],12} {quarters[1],12} {quarters[2],12} {quarters[3],12}");
        Console.WriteLine($"{sales[0],12:C0} {sales[1],12:C0} {sales[2],12:C0} {sales[3],12:C0}");

        Console.WriteLine("\nInternational Sales (%):");
        Console.WriteLine($"{intlMixPct[0],12:P0} {intlMixPct[1],12:P0} {intlMixPct[2],12:P1} {intlMixPct[3],12:P1}");
    }
}
