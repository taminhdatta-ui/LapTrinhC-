using System;

class Bai7
{
    static void Main()
    {
        Console.Write("Nhập họ tên: ");
        string hoten = Console.ReadLine();

        if (hoten == null)
        {
            Console.WriteLine("Chuỗi null, không tách.");
            return;
        }

        string[] words = hoten.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (words == null)
        {
            Console.WriteLine("Mảng kết quả null.");
            return;
        }

        foreach (string w in words)
        {
            Console.WriteLine(w);
        }
    }
}
