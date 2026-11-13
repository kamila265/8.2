using System;

class Program
{
    static string ReverseString(string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    static void Main()
    {
        string text = "Привет мир";
        string reversed = ReverseString(text);
        Console.WriteLine(reversed);
    }
}