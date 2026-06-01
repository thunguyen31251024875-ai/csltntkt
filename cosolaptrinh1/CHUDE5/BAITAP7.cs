using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    // Bài 2
    static double TinhTong(double[] arr)
    {
        return arr.Sum();
    }

    static double TinhTrungBinh(double[] arr)
    {
        return arr.Average();
    }

    // Bài 3
    static int TimMax(int[] arr)
    {
        return arr.Max();
    }

    static int TimMin(int[] arr)
    {
        return arr.Min();
    }

    // Bài 4
    static void DemChanLe(int[] arr, out int chan, out int le)
    {
        chan = 0;
        le = 0;

        foreach (int x in arr)
        {
            if (x % 2 == 0)
                chan++;
            else
                le++;
        }
    }

    // Bài 5
    static int TimKiem(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
                return i;
        }

        return -1;
    }

    // Bài 8
    static bool LaSoNguyenTo(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    static List<int> LietKeSoNguyenTo(int[] arr)
    {
        List<int> primes = new List<int>();

        foreach (int x in arr)
        {
            if (LaSoNguyenTo(x))
                primes.Add(x);
        }

        return primes;
    }

    // Bài 9
    static void TachChanLe(int[] arr, out List<int> chan, out List<int> le)
    {
        chan = new List<int>();
        le = new List<int>();

        foreach (int x in arr)
        {
            if (x % 2 == 0)
                chan.Add(x);
            else
                le.Add(x);
        }
    }

    // Bài 15
    static int[] TronHaiMang(int[] A, int[] B)
    {
        List<int> C = new List<int>();

        int i = 0;
        int j = 0;

        while (i < A.Length && j < B.Length)
        {
            if (A[i] <= B[j])
            {
                C.Add(A[i]);
                i++;
            }
            else
            {
                C.Add(B[j]);
                j++;
            }
        }

        while (i < A.Length)
        {
            C.Add(A[i]);
            i++;
        }

        while (j < B.Length)
        {
            C.Add(B[j]);
            j++;
        }

        return C.ToArray();
    }

    static void Main()
    {
        // Bài 1
        Console.WriteLine("===== BAI 1 =====");
        int[] arr1 = { 1, 2, 3, 4, 5 };
        Console.WriteLine(string.Join(" ", arr1));

        // Bài 2
        Console.WriteLine("\n===== BAI 2 =====");
        double[] arr2 = { 1.5, 2.5, 3.5, 4.5 };
        Console.WriteLine("Tong = " + TinhTong(arr2));
        Console.WriteLine("Trung binh = " + TinhTrungBinh(arr2).ToString("F2"));

        // Bài 3
        Console.WriteLine("\n===== BAI 3 =====");
        int[] arr3 = { 10, 5, 20, 8, 3 };
        Console.WriteLine("Max = " + TimMax(arr3));
        Console.WriteLine("Min = " + TimMin(arr3));

        // Bài 4
        Console.WriteLine("\n===== BAI 4 =====");
        DemChanLe(arr3, out int chan, out int le);
        Console.WriteLine($"Chan = {chan}, Le = {le}");

        // Bài 5
        Console.WriteLine("\n===== BAI 5 =====");
        Console.WriteLine("Vi tri cua 20: " + TimKiem(arr3, 20));

        // Bài 8
        Console.WriteLine("\n===== BAI 8 =====");
        int[] arr8 = { 2, 4, 5, 8, 11, 15, 17 };
        List<int> primes = LietKeSoNguyenTo(arr8);

        if (primes.Count == 0)
            Console.WriteLine("EMPTY");
        else
            Console.WriteLine(string.Join(" ", primes));

        // Bài 9
        Console.WriteLine("\n===== BAI 9 =====");
        TachChanLe(arr8, out List<int> dsChan, out List<int> dsLe);

        Console.WriteLine("Mang chan:");
        Console.WriteLine(string.Join(" ", dsChan));

        Console.WriteLine("Mang le:");
        Console.WriteLine(string.Join(" ", dsLe));

        // Bài 15
        Console.WriteLine("\n===== BAI 15 =====");

        int[] A = { 1, 3, 5, 7, 9 };
        int[] B = { 2, 4, 6, 8 };

        int[] C = TronHaiMang(A, B);

        Console.WriteLine("Mang sau khi tron:");
        Console.WriteLine(string.Join(" ", C));
    }
}