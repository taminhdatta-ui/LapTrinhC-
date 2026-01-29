using System;

class Bai9
{
    static void Main()
    {
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
