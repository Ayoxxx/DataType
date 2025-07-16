using System;

public class ParseDemo
{
    public void Run()
    {
        string[] NumStrs = { " 1 ", " 1.45 ", "-100", "5e+04 " };
        int testint;
        float testfloat;
        bool result;

        Console.WriteLine("=== Using Parse (throws on error) ===");
        foreach (string str in NumStrs)
        {
            try
            {
                testfloat = float.Parse(str);
                Console.WriteLine($"Parsed float: {testfloat}");

                testint = int.Parse(str);
                Console.WriteLine($"Parsed int: {testint}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Could not parse '{str}': {e.Message}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Overflow parsing '{str}': {e.Message}");
            }
        }

        Console.WriteLine("\n=== Using TryParse (safe) ===");

        result = int.TryParse(NumStrs[0], out testint);
        Console.WriteLine($"{result} -- '{NumStrs[0]}' as int: {testint}");

        result = float.TryParse(NumStrs[1], out testfloat);
        Console.WriteLine($"{result} -- '{NumStrs[1]}' as float: {testfloat}");

        result = int.TryParse(NumStrs[2], out testint);
        Console.WriteLine($"{result} -- '{NumStrs[2]}' as int: {testint}");

        result = float.TryParse(NumStrs[3], out testfloat);
        Console.WriteLine($"{result} -- '{NumStrs[3]}' as float: {testfloat}");
    }
}
