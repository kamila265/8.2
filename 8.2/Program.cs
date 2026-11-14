using System;
using System.Collections.Generic;

class Song
{
    string name;
    string author;
    Song prev;

    public void SetName(string n) { name = n; }
    public void SetAuthor(string a) { author = a; }
    public void SetPrev(Song p) { prev = p; }
    
    public void PrintInfo() { Console.WriteLine(Title()); }
    public string Title() { return name + " - " + author; }

    // Переопределяем метод сравнения
    public override bool Equals(object d)
    {
        if (d is Song other) // Если d — это песня
        {
            return this.name == other.name && this.author == other.author;
        }
        return false;
    }
    public override int GetHashCode() { return HashCode.Combine(name, author); }
}

class Program
{
    static void Main()
    {
        List<Song> songs = new List<Song>();

        Song s1 = new Song();
        s1.SetName("Песня 1");
        s1.SetAuthor("Автор 1");
        Song s2 = new Song();
        s2.SetName("Песня 2");
        s2.SetAuthor("Автор 2");
        Song s3 = new Song();
        s3.SetName("Песня 3");
        s3.SetAuthor("Автор 3");
        Song s4 = new Song();
        s4.SetName("Песня 4");
        s4.SetAuthor("Автор 4");

        // Связываем (по заданию)
        s2.SetPrev(s1);
        s3.SetPrev(s2);
        s4.SetPrev(s3);

        songs.Add(s1);
        songs.Add(s2);
        songs.Add(s3);
        songs.Add(s4);

        // Вывод в цикле
        foreach (Song s in songs)
        {
            s.PrintInfo();
        }

        // Сравнение первых двух
        if (songs[0].Equals(songs[1])) Console.WriteLine("Одинаковые");
        else Console.WriteLine("Разные");
    }
}