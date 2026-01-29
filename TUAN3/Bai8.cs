using System;

class Bai8
{
    static void Main()
    {
        Console.Write("Nhập câu: ");
        string sentence = Console.ReadLine();

        if (sentence == null)
        {
            Console.WriteLine("Chuỗi null, không xử lý.");
            return;
        }

        string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (words.Length == 0)
            return;

        string longest = words[0];
        foreach (string w in words)
        {
            if (w.Length > longest.Length)
                longest = w;
        }

        Console.WriteLine("Từ dài nhất: " + longest);
    }
}
