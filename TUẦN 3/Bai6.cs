using System;

public class bai6
{
    public static void Run6()
    {
        //Họ và tên: Tạ Minh Đạt
        //MSV 2415053122107
        Console.WriteLine("Bai 6");
        int[] arr = { 1, 2, 4, 7, 10 };

        int count = DemSoChan(arr);
        Console.WriteLine("Số phần tử chẵn = " + count);
    }

    static int DemSoChan(int[] arr)
    {
        if (arr == null)
            return 0;

        int count = 0;
        foreach (int x in arr)
        {
            if (x % 2 == 0)
                count++;
        }
        return count;
    }
}
