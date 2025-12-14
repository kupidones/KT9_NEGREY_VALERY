using System;
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
class Program
{
    static void ResetPersonWithoutRef(Person person)
    {
        person = null;
        Console.WriteLine($"Внутри ResetPersonWithoutRef: person установлен в null.");
    }
    static void ResetPersonWithRef(ref Person person)
    {
        person = null;
        Console.WriteLine($"Внутри ResetPersonWithRef: person установлен в null.");
    }
    static void Main()
    {
        Person person1 = new Person { Name = "Алексей", Age = 30 };
        Person person2 = new Person { Name = "Мария", Age = 25 };
        Console.WriteLine("Исходные данные:");
        Console.WriteLine($"Name: {person1.Name}, Age: {person1.Age}");
        Console.WriteLine($"Name: {person2.Name}, Age: {person2.Age}");
        Console.WriteLine("\n--- Попытка сброса БЕЗ ref ---");
        ResetPersonWithoutRef(person1);
        Console.WriteLine($"person1 не null: Name: {person1.Name}, Age: {person1.Age}");
        Console.WriteLine("\n--- Попытка сброса С ref ---");
        ResetPersonWithRef(ref person2);
        Console.WriteLine($"person2 is null : Name: {(person2?.Name ?? "null")}, Age: {(person2?.Age.ToString() ?? "null")}");
        Console.WriteLine("\n--- Изменение состояния объекта (без ref) ---");
        person1.Name = "Петр";
        Console.WriteLine($"Name: {person1.Name}, Age: {person1.Age}");
    }
}
