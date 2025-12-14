using System;
class Program
{
    static void SwapWithoutRef(int a, int b)
    {
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"Внутри SwapWithoutRef: a = {a}, b = {b}");
    }
    static void SwapWithRef(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"Внутри SwapWithRef: a = {a}, b = {b}");
    }
    static void Main()
    {
        int x = 5, y = 10;
        Console.WriteLine($"Исходные значения: x = {x}, y = {y}");
        SwapWithoutRef(x, y);
        Console.WriteLine($"После SwapWithoutRef: x = {x}, y = {y}");
        SwapWithRef(ref x, ref y);
        Console.WriteLine($"После SwapWithRef: x = {x}, y = {y}");
    }
}
