using System;

class Program
{
    // ================= PART 1 =================

    static double Average(int[] arr)
    {
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return (double)sum / arr.Length;
    }

    static bool Contains(int[] arr, int value)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == value)
                return true;
        }
        return false;
    }

    static int FindIndex(int[] arr, int value)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == value)
                return i;
        }
        return -1;
    }

    static int[] RemoveElement(int[] arr, int value)
    {
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != value)
                count++;
        }

        int[] result = new int[count];
        int index = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != value)
            {
                result[index] = arr[i];
                index++;
            }
        }

        return result;
    }

    static void FindMaxMin(int[] arr)
    {
        int max = arr[0];
        int min = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];

            if (arr[i] < min)
                min = arr[i];
        }

        Console.WriteLine("Max: " + max);
        Console.WriteLine("Min: " + min);
    }

    static void ReverseArray(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    static void FindDuplicates(int[] arr)
    {
        Console.WriteLine("Duplicates:");

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    Console.WriteLine(arr[i]);
                    break;
                }
            }
        }
    }

    static int[] RemoveDuplicates(int[] arr)
    {
        int[] temp = new int[arr.Length];
        int index = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            bool exists = false;

            for (int j = 0; j < index; j++)
            {
                if (temp[j] == arr[i])
                {
                    exists = true;
                    break;
                }
            }

            if (!exists)
            {
                temp[index] = arr[i];
                index++;
            }
        }

        int[] result = new int[index];

        for (int i = 0; i < index; i++)
        {
            result[i] = temp[i];
        }

        return result;
    }

    // ================= PART 2 =================

    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 3, 4, 5, 5, 6 };

        Console.WriteLine("=== PART 1 ===");

        Console.WriteLine("Average: " + Average(arr));
        Console.WriteLine("Contains 3: " + Contains(arr, 3));
        Console.WriteLine("Index of 4: " + FindIndex(arr, 4));

        Console.WriteLine("\nRemove element 3:");
        int[] removed = RemoveElement(arr, 3);

        for (int i = 0; i < removed.Length; i++)
            Console.Write(removed[i] + " ");

        Console.WriteLine();

        Console.WriteLine("\nMax & Min:");
        FindMaxMin(arr);

        Console.WriteLine("\nReverse:");
        ReverseArray(arr);

        Console.WriteLine("\nDuplicates:");
        FindDuplicates(arr);

        Console.WriteLine("\nRemove duplicates:");
        int[] unique = RemoveDuplicates(arr);

        for (int i = 0; i < unique.Length; i++)
            Console.Write(unique[i] + " ");

        Console.WriteLine("\n\n=== PART 2 ===");

        // Bubble Sort
        int[] numbers = new int[10];

        Console.WriteLine("Enter 10 numbers:");

        for (int i = 0; i < 10; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 0; j < numbers.Length - 1 - i; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted array:");
        for (int i = 0; i < numbers.Length; i++)
            Console.Write(numbers[i] + " ");

        Console.WriteLine();

        // Linear Search
        Console.WriteLine("\nEnter a sentence:");
        string sentence = Console.ReadLine();

        Console.WriteLine("Enter a word:");
        string word = Console.ReadLine();

        string[] words = sentence.Split(' ');
        bool found = false;

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == word)
            {
                found = true;
                break;
            }
        }

        Console.WriteLine(found ? "Found" : "Not Found");
    }
}