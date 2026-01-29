using System;

public class bai8
{
    public static void Run8()
    {
        //Họ và tên: Tạ Minh Đạt
        //MSV 2415053122107
        Console.WriteLine("Bai 8");
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
