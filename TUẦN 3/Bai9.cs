using System;

public class bai9
{
    public static void Run9()
    {
        //Họ và tên: Tạ Minh Đạt
        //MSV 2415053122107
        Console.WriteLine("Bai 9");
        string[] arr = { "C#", null, "", "Console", "App", " " };

        int count = 0;
        foreach (string s in arr)
        {
            if (!string.IsNullOrEmpty(s))
                count++;
        }

        Console.WriteLine("Số chuỗi khác null và khác rỗng = " + count);
    }
}
