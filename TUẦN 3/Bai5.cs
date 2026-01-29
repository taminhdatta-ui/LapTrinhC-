using System;

public class bai5
{
    public static void Run5()
    {
        //Họ và tên: Tạ Minh Đạt
        //MSV 2415053122107
        Console.WriteLine("Bai 5");
        int[] arr = { 3, 7, 2, 9, 5 };

        if (arr == null || arr.Length == 0)
        {
            Console.WriteLine("Mảng rỗng hoặc null, không xử lý.");
            return;
        }

        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }

        Console.WriteLine("Giá trị lớn nhất = " + max);
    }
}
