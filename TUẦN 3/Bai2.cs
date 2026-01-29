using System;

public class bai2
{
    public static void Run2()
    {
        //Họ và tên: Tạ Minh Đạt
        //MSV 2415053122107
        Console.WriteLine("Bai 2");
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(s))
        {
            Console.WriteLine("So tu: 0");
            return;
        }

        s = s.Trim();
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("So tu: " + words.Length);
    }
}