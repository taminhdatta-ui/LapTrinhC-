using System;

public class bai1
{
    public static void Run1()
    {
        //Họ và tên: Tạ Minh Đạt
        //MSV 2415053122107
        Console.WriteLine("Bai 1");
        Console.Write("Nhap ho ten: ");
        string? name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Chuoi rong hoac null!");
            return;
        }

        // Xoa khoang trang dau/cuoi
        name = name.Trim();

        // Tach cac tu
        string[] words = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // Chuan hoa tung tu
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            words[i] = char.ToUpper(word[0]) + word.Substring(1).ToLower();
        }

        // Noi lai thanh chuoi
        string result = string.Join(" ", words);
        Console.WriteLine("Ho ten sau chuan hoa: " + result);
    }
}