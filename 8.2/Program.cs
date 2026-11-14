using System;

class Program
{
    // Метод с ref (передается по ссылке)
    public static void SearchMail(ref string s)
    {
        int index = s.IndexOf('#'); // Ищем решетку
        if (index != -1)
        {
            string email = s.Substring(index + 1).Trim(); // Берем всё, что после решетки, и убираем пробелы
            s = email; // Заменяем исходную строку на найденный email
        }
    }

    static void Main()
    {
        string text = "Иванов Иван Иванович # iviviv@mail.ru";
        Console.WriteLine("Было: " + text);

        SearchMail(ref text); // Передаем с ключевым словом ref

        Console.WriteLine("Стало: " + text);
    }
}