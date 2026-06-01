using System;

class Program
{
    // Bài 1
    static int TinhTong(int a, int b)
    {
        return a + b;
    }

    // Bài 2
    static bool KiemTraChan(int n)
    {
        return n % 2 == 0;
    }

    // Bài 3
    static int TimMax(int a, int b, int c)
    {
        return Math.Max(Math.Max(a, b), c);
    }

    // Bài 4
    static long TinhGiaiThua(int n)
    {
        long ketQua = 1;
        for (int i = 1; i <= n; i++)
        {
            ketQua *= i;
        }
        return ketQua;
    }

    // Bài 5
    static string DaoNguocChuoi(string input)
    {
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    // Bài 6
    static bool KiemTraNguyenTo(int n)
    {
        if (n < 2) return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    // Bài 7
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

    // Bài 8
    static int DemNguyenAm(string s)
    {
        int dem = 0;

        foreach (char c in s.ToLower())
        {
            if ("aeiou".Contains(c))
                dem++;
        }

        return dem;
    }

    // Bài 9
    static double TinhLuyThua(double x, int y)
    {
        double ketQua = 1;

        for (int i = 0; i < y; i++)
        {
            ketQua *= x;
        }

        return ketQua;
    }

    // Bài 10
    static double TinhTrungBinh(int[] arr)
    {
        int tong = 0;

        foreach (int x in arr)
        {
            tong += x;
        }

        return (double)tong / arr.Length;
    }

    // Bài 11
    static bool KiemTraDoiXung(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
                return false;

            left++;
            right--;
        }

        return true;
    }

    // Bài 12
    static double CelsiusToFahrenheit(double c)
    {
        return c * 9 / 5 + 32;
    }

    // Bài 13
    static int TimMin(int[] arr)
    {
        int min = arr[0];

        foreach (int x in arr)
        {
            if (x < min)
                min = x;
        }

        return min;
    }

    // Bài 14
    static int TongCacChuSo(int n)
    {
        int tong = 0;

        while (n > 0)
        {
            tong += n % 10;
            n /= 10;
        }

        return tong;
    }

    // Bài 15
    static void SapXepMang(int[] arr)
    {
        Array.Sort(arr);

        foreach (int x in arr)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
    }

    // Bài 16
    static string XoaTrungLap(string s)
    {
        string ketQua = "";

        foreach (char c in s)
        {
            if (!ketQua.Contains(c))
            {
                ketQua += c;
            }
        }

        return ketQua;
    }

    // Bài 17
    static int UCLN(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }

    // Bài 18
    static string DecimalToBinary(int n)
    {
        if (n == 0)
            return "0";

        string binary = "";

        while (n > 0)
        {
            binary = (n % 2) + binary;
            n /= 2;
        }

        return binary;
    }

    // Bài 19
    static bool KiemTraNamNhuan(int year)
    {
        return (year % 400 == 0) ||
               (year % 4 == 0 && year % 100 != 0);
    }

    // Bài 20
    static int DemSoTu(string sentence)
    {
        string[] words = sentence.Split(
            new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);

        return words.Length;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Bài 1: " + TinhTong(5, 3));

        Console.WriteLine("Bài 2: " + KiemTraChan(8));

        Console.WriteLine("Bài 3: " + TimMax(10, 20, 15));

        Console.WriteLine("Bài 4: " + TinhGiaiThua(5));

        Console.WriteLine("Bài 5: " + DaoNguocChuoi("Hello"));

        Console.WriteLine("Bài 6: " + KiemTraNguyenTo(7));

        Console.Write("Bài 7: ");
        InFibonacci(6);

        Console.WriteLine("Bài 8: " + DemNguyenAm("Hello World"));

        Console.WriteLine("Bài 9: " + TinhLuyThua(2, 3));

        int[] arr1 = { 4, 5, 6, 7 };
        Console.WriteLine("Bài 10: " + TinhTrungBinh(arr1));

        Console.WriteLine("Bài 11: " + KiemTraDoiXung("radar"));

        Console.WriteLine("Bài 12: " + CelsiusToFahrenheit(25));

        int[] arr2 = { 10, 5, 8, 2, 9 };
        Console.WriteLine("Bài 13: " + TimMin(arr2));

        Console.WriteLine("Bài 14: " + TongCacChuSo(1234));

        int[] arr3 = { 3, 1, 4, 2 };
        Console.Write("Bài 15: ");
        SapXepMang(arr3);

        Console.WriteLine("Bài 16: " + XoaTrungLap("programming"));

        Console.WriteLine("Bài 17: " + UCLN(12, 18));

        Console.WriteLine("Bài 18: " + DecimalToBinary(10));

        Console.WriteLine("Bài 19: " + KiemTraNamNhuan(2024));

        Console.WriteLine("Bài 20: " + DemSoTu("Học lập trình C# rất thú vị"));
    }
}