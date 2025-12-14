using System;
class Program
{
    unsafe static void Main()
    {
        int x = 50;
        int* p = &x;
        int** pp = &p;
        Console.WriteLine($"Адрес x: {(ulong)&x:X}");
        Console.WriteLine($"Адрес p: {(ulong)p:X}");
        Console.WriteLine($"Значение x до: {x}");
        **pp = 999;
        Console.WriteLine($"Значение x после изменения через **pp: {x}");
    }
}
