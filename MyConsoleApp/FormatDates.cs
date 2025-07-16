using System;
using System.Globalization;

public class DateFormattingDemo
{
    public void Run()
    {
        // Define a date
        DateTime AprFools = new DateTime(2025, 4, 1, 13, 23, 30);

        Console.WriteLine("=== Standard Format Strings ===");

        // 'd' Short date: mm/dd/yyyy or dd/mm/yyyy depending on locale
        Console.WriteLine($"Short date (d): {AprFools:d}");

        // 'D' Full date: Day, Month dd, yyyy
        Console.WriteLine($"Long date (D): {AprFools:D}");

        // 'f' Full date, short time
        Console.WriteLine($"Full date, short time (f): {AprFools:f}");

        // 'F' Full date, long time
        Console.WriteLine($"Full date, long time (F): {AprFools:F}");

        // 'g' General date/time, short
        Console.WriteLine($"General date/time short (g): {AprFools:g}");

        // 'G' General date/time, long
        Console.WriteLine($"General date/time long (G): {AprFools:G}");

        Console.WriteLine("\n=== Culture-Specific Formatting ===");

        // Format using a specific CultureInfo (e.g., German)
        Console.WriteLine("German short date format (de-DE): " +
            AprFools.ToString("d", CultureInfo.CreateSpecificCulture("de-DE")));

        Console.WriteLine("\n=== Custom Date and Time Formats ===");

        // Custom formats
        Console.WriteLine($"Custom 1: {AprFools:dddd, MMMM d yyyy}");   // Tuesday, April 1 2025
        Console.WriteLine($"Custom 2: {AprFools:ddd, h:mm:ss tt}");    // Tue, 1:23:30 PM
        Console.WriteLine($"Custom 3: {AprFools:MMM d, yyyy}");        // Apr 1, 2025
    }
}
