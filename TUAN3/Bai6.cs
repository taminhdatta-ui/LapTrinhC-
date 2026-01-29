using System;

class Bai6
{
    static void Main()
    {
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
