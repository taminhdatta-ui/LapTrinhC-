using System;

public class bai7
{
    public static void Run7()
    {
        //Họ và tên: Tạ Minh Đạt
        //MSV 2415053122107
        Console.WriteLine("Bai 7");
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
