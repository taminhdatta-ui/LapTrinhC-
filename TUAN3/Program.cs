using System;

while (true)
{
    Console.Clear();
    Console.WriteLine("===== MENU BAI TAP =====");
    Console.WriteLine("1. Bai 1");
    Console.WriteLine("2. Bai 2");
    Console.WriteLine("3. Bai 3");
    Console.WriteLine("4. Bai 4");
    Console.WriteLine("5. Bai 5");
    Console.WriteLine("6. Bai 6");
    Console.WriteLine("7. Bai 7");
    Console.WriteLine("8. Bai 8");
    Console.WriteLine("9. Bai 9");
    Console.WriteLine("0. Thoat");
    Console.Write("========================");
    Console.Write("\nChon bai: ");

    string? choice = Console.ReadLine();

    Console.Clear();

    switch (choice)
    {
        case "1":
            bai1.Run1();
            break;
        case "2":
            bai2.Run2();
            break;
        case "3":
            bai3.Run3();
            break;
        case "4":
            bai4.Run4();
            break;
        case "5":
            bai5.Run5();
            break;
        case "6":
            bai6.Run6();
            break;
        case "7":
            bai7.Run7();
            break;
        case "8":
            bai8.Run8();
            break;
        case "9":
            bai9.Run9();
            break;
        case "0":
            Console.WriteLine("Thoat chuong trinh!");
            return;
        default:
            Console.WriteLine("Lua chon khong hop le!");
            break;
    }

    Console.WriteLine("\nNhan phim bat ky de quay lai menu...");
    Console.ReadKey();
}
