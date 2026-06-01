using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Part 1

    // 1. Calculate average
    static double Average(int[] arr)
    {
        return arr.Average();
    }

    // 2. Check if array contains value
    static bool ContainsValue(int[] arr, int value)
    {
        return arr.Contains(value);
    }

    // 3. Find index of element
    static int FindIndex(int[] arr, int value)
    {
        return Array.IndexOf(arr, value);
    }

    // 4. Remove specific element
    static int[] RemoveElement(int[] arr, int value)
    {
        return arr.Where(x => x != value).ToArray();
    }

    // 5. Find max and min
    static void FindMaxMin(int[] arr, out int max, out int min)
    {
        max = arr.Max();
        min = arr.Min();
    }

    // 6. Reverse array
    static int[] ReverseArray(int[] arr)
    {
        int[] result = (int[])arr.Clone();
        Array.Reverse(result);
        return result;
    }

    // 7. Find duplicate values
    static List<int> FindDuplicates(int[] arr)
    {
        return arr.GroupBy(x => x)
                  .Where(g => g.Count() > 1)
                  .Select(g => g.Key)
                  .ToList();
    }

    // 8. Remove duplicate values
    static int[] RemoveDuplicates(int[] arr)
    {
        return arr.Distinct().ToArray();
    }

    // Bubble Sort
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Linear Search
    static bool LinearSearch(string[] words, string target)
    {
        foreach (string word in words)
        {
            if (word.Equals(target, StringComparison.OrdinalIgnoreCase))
                return true;
        }
        return false;
    }

    static void Main()
    {
        Random random = new Random();

        int[] arr = new int[15];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(1, 20);
        }

        Console.WriteLine("Random Array:");
        Console.WriteLine(string.Join(" ", arr));

        // 1
        Console.WriteLine("\n1. Average = " + Average(arr));

        // 2
        Console.WriteLine("2. Contains 10? " + ContainsValue(arr, 10));

        // 3
        Console.WriteLine("3. Index of 10 = " + FindIndex(arr, 10));

        // 4
        Console.WriteLine("4. Remove 10:");
        Console.WriteLine(string.Join(" ", RemoveElement(arr, 10)));

        // 5
        FindMaxMin(arr, out int max, out int min);
        Console.WriteLine($"5. Max = {max}, Min = {min}");

        // 6
        Console.WriteLine("6. Reversed Array:");
        Console.WriteLine(string.Join(" ", ReverseArray(arr)));

        // 7
        Console.WriteLine("7. Duplicate Values:");
        List<int> duplicates = FindDuplicates(arr);

        if (duplicates.Count > 0)
            Console.WriteLine(string.Join(" ", duplicates));
        else
            Console.WriteLine("No duplicates");

        // 8
        Console.WriteLine("8. Array without duplicates:");
        Console.WriteLine(string.Join(" ", RemoveDuplicates(arr)));

        // =============================
        // Part 2 - Bubble Sort
        // =============================
        Console.WriteLine("\nPART 2 - BUBBLE SORT");

        int[] numbers = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter integer {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        BubbleSort(numbers);

        Console.WriteLine("Sorted Numbers:");
        Console.WriteLine(string.Join(" ", numbers));

        // =============================
        // Linear Search
        // =============================
        Console.WriteLine("\nLINEAR SEARCH");

        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        Console.Write("Enter a word to search: ");
        string searchWord = Console.ReadLine();

        string[] words = sentence.Split(
            new char[] { ' ', ',', '.', '!', '?', ';', ':' },
            StringSplitOptions.RemoveEmptyEntries);

        bool found = LinearSearch(words, searchWord);

        if (found)
            Console.WriteLine("Word found in sentence.");
        else
            Console.WriteLine("Word not found.");
    }
}