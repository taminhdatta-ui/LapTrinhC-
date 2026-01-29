using System;

class Bai3
{
    static void Main()
    {
        Console.Write("Bai 3");
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(s))
        {
            Console.WriteLine("Chuoi khong doi xung");
            return;
        }

        // Xoa khoang trang
        s = s.Replace(" ", "").ToLower();

        bool isPalindrome = true;
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
            {
                isPalindrome = false;
                break;
            }
            left++;
            right--;
        }

        if (isPalindrome)
            Console.WriteLine("Chuoi doi xung");
        else
            Console.WriteLine("Chuoi khong doi xung");
    }
}