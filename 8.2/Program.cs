using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Введите имя файла: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("Файл не существует.");
            return;
        }

        string content = File.ReadAllText(fileName);
        string upperContent = content.ToUpper();
        
        File.WriteAllText("output.txt", upperContent);
        Console.WriteLine("Данные записаны в output.txt");
    }
}