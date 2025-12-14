using System;
class Program
{
    unsafe static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        fixed (int* p = numbers)
        {
            Console.WriteLine("До:");
            foreach (var num in numbers)
                Console.Write(num + " ");
            for (int i = 0; i < numbers.Length; i++)
            {
                *(p + i) += 10;
            }
            Console.WriteLine("\nПосле:");
            foreach (var num in numbers)
                Console.Write(num + " ");
        }
    }
}
