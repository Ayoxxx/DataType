// Exercise file for LinkedIn Learning Course .NET Programming with C# by Abdullahi Tijjani
// Example file for .NET Data Types

using System;

// Declare some types with values
int a = 1;
char c = 'A';
float f = 123.45f;
decimal d = 400.85m;
int b = default;
bool tf = default;

Console.WriteLine($"{a}, {b}, {tf}, {c}, {f}, {d}");

// Implicit type conversion
Console.WriteLine($"{c + a}");               // 'A' + 1 => ASCII math
Console.WriteLine($"{(char)(c + a)}");       // Convert result to char
Console.WriteLine($"{f + a}");
Console.WriteLine($"{f + c}");

// Create and use a struct (value type)
s s1;
s1.a = 5;
s1.b = false;

Console.WriteLine("Structs are passed by copy, since they are value types:");
Console.WriteLine($"{s1.a}, {s1.b}");
StructOp(s1);
Console.WriteLine($"{s1.a}, {s1.b}");

// Create and use a class (reference type)
MyClass cl = new MyClass { a = 5, b = false };

Console.WriteLine("Objects are passed by reference, since they are reference types:");
Console.WriteLine($"{cl.a}, {cl.b}");
ClassOp(cl);
Console.WriteLine($"{cl.a}, {cl.b}");

// Function to operate on a struct
void StructOp(s theStruct)
{
    theStruct.a = 10;
    theStruct.b = true;
    Console.WriteLine($"{theStruct.a}, {theStruct.b}");
}

// Function to operate on a class
void ClassOp(MyClass theClass)
{
    theClass.a = 10;
    theClass.b = true;
    Console.WriteLine($"{theClass.a}, {theClass.b}");
}

// Class and struct declarations (must be below top-level statements)
class MyClass
{
    public int a;
    public bool b;
}

struct s
{
    public int a;
    public bool b;
}
