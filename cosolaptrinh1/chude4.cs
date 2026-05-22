
using System;

class chude4
{
    // Bài 1: Tính tổng hai số nguyên
    static int TinhTong(int a, int b)
    {
        return a + b;
    }

    // Bài 2: Kiểm tra số chẵn lẻ
    static bool KiemTraChan(int n)
    {
        return n % 2 == 0;
    }

    // Bài 3: Tìm số lớn nhất trong ba số
    static int TimMax(int a, int b, int c)
    {
        return Math.Max(Math.Max(a, b), c);
    }

    // Bài 4: Tính giai thừa
    static long TinhGiaiThua(int n)
    {
        long ketQua = 1;

        for (int i = 1; i <= n; i++)
        {
            ketQua *= i;
        }

        return ketQua;
    }

    // Bài 5: Đảo ngược chuỗi
    static string DaoNguocChuoi(string input)
    {
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    // Bài 6: Kiểm tra số nguyên tố
    static bool KiemTraNguyenTo(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    // Bài 7: In dãy Fibonacci
    static void InFibonacci(int n)
    {
        int a = 0, b = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");

            int temp = a + b;
            a = b;
            b = temp;
        }

        Console.WriteLine();
    }

    // Bài 8: Đếm số nguyên âm
    static int DemNguyenAm(string s)
    {
        int dem = 0;
        string nguyenAm = "aeiouAEIOU";

        foreach (char c in s)
        {
            if (nguyenAm.Contains(c))
            {
                dem++;
            }
        }

        return dem;
    }

    // Bài 9: Tính lũy thừa
    static double TinhLuyThua(double x, int y)
    {
        double ketQua = 1;

        for (int i = 0; i < y; i++)
        {
            ketQua *= x;
        }

        return ketQua;
    }

    // Bài 10: Tính trung bình mảng
    static double TinhTrungBinh(int[] arr)
    {
        int tong = 0;

        foreach (int num in arr)
        {
            tong += num;
        }

        return (double)tong / arr.Length;
    }

    public static void Main(string[] args)
    // Renamed to avoid multiple entry points in the project.
    // Call chude4.Run(args) from the single intended Program.Main if needed.
    

    {
        // Bài 1
        Console.WriteLine("Bài 1:");
        Console.WriteLine(TinhTong(5, 3));

        // Bài 2
        Console.WriteLine("\nBài 2:");
        Console.WriteLine(KiemTraChan(4));

        // Bài 3
        Console.WriteLine("\nBài 3:");
        Console.WriteLine(TimMax(10, 25, 15));

        // Bài 4
        Console.WriteLine("\nBài 4:");
        Console.WriteLine(TinhGiaiThua(5));

        // Bài 5
        Console.WriteLine("\nBài 5:");
        Console.WriteLine(DaoNguocChuoi("Hello"));

        // Bài 6
        Console.WriteLine("\nBài 6:");
        Console.WriteLine(KiemTraNguyenTo(7));
        Console.WriteLine(KiemTraNguyenTo(10));

        // Bài 7
        Console.WriteLine("\nBài 7:");
        InFibonacci(6);

        // Bài 8
        Console.WriteLine("\nBài 8:");
        Console.WriteLine(DemNguyenAm("Hello World"));

        // Bài 9
        Console.WriteLine("\nBài 9:");
        Console.WriteLine(TinhLuyThua(2, 3));

        // Bài 10
        Console.WriteLine("\nBài 10:");
        int[] arr = { 4, 5, 6, 7 };
        Console.WriteLine(TinhTrungBinh(arr));
    }
}


