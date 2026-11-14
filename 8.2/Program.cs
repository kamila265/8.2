using System;

class Program
{
    static void CheckIFormattable(object obj)
    {
        Console.WriteLine("--- Проверка оператором is ---");
        if (obj is IFormattable)
            Console.WriteLine("Объект реализует IFormattable");
        else
            Console.WriteLine("Объект НЕ реализует IFormattable");

        Console.WriteLine("--- Проверка оператором as ---");
        IFormattable formattable = obj as IFormattable;
        if (formattable != null)
            Console.WriteLine("Объект реализует IFormattable");
        else
            Console.WriteLine("Объект НЕ реализует IFormattable");
    }

    static void Main()
    {
        int number = 5;
        string text = "hello";
        
        CheckIFormattable(number);
        CheckIFormattable(text);
    }
}