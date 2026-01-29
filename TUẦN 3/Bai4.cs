
public class bai4
{
    public static void Run4()
    {
        //Họ và tên: Tạ Minh Đạt
        //MSV 2415053122107
        Console.WriteLine("Bai 4");
        int[] arr = null; // mảng CHƯA khởi tạo

        Console.Write("Nhập số phần tử n: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Số phần tử không hợp lệ!");
            return;
        }

        // Khởi tạo mảng
        arr = new int[n];

        // Nhập mảng
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Check null
        if (arr == null)
        {
            Console.WriteLine("Lỗi: Mảng chưa được khởi tạo!");
            return;
        }

        // Tính tổng
        int sum = 0;
        foreach (int x in arr)
        {
            sum += x;
        }

        Console.WriteLine("Tổng các phần tử trong mảng = " + sum);
    }
}
