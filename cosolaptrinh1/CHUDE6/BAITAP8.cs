using System;
using System.Text;

class Program
{
    // 1. Input & print string
    static void InputAndPrint(string s)
    {
        Console.WriteLine(s);
    }

    // 2. Length without library
    static int GetLength(string s)
    {
        int count = 0;
        foreach (char c in s)
            count++;
        return count;
    }

    // 3. Separate characters
    static void PrintCharacters(string s)
    {
        foreach (char c in s)
            Console.Write(c + " ");
        Console.WriteLine();
    }

    // 4. Reverse characters
    static void PrintReverse(string s)
    {
        for (int i = s.Length - 1; i >= 0; i--)
            Console.Write(s[i] + " ");
        Console.WriteLine();
    }

    // 5. Count words
    static int CountWords(string s)
    {
        string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    // 6. Compare strings without library
    static bool CompareStrings(string a, string b)
    {
        if (GetLength(a) != GetLength(b))
            return false;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
                return false;
        }
        return true;
    }

    // 7. Count alphabets, digits, special characters
    static void CountTypes(string s)
    {
        int alpha = 0, digit = 0, special = 0;

        foreach (char c in s) 
        {
            if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                alpha++;
            else if (c >= '0' && c <= '9')
                digit++;
            else
                special++;
        }

        Console.WriteLine($"Letters={alpha}, Digits={digit}, Special={special}");
    }

    // 8. Vowels or consonants
    static void CountVowelsConsonants(string s)
    {
        int vowels = 0, consonants = 0;
        string v = "aeiouAEIOU";

        foreach (char c in s)
        {
            if (char.IsLetter(c))
            {
                if (v.Contains(c))
                    vowels++;
                else
                    consonants++;
            }
        }

        Console.WriteLine($"Vowels={vowels}, Consonants={consonants}");
    }

    // 9. Check substring exists
    static bool ContainsSubstring(string s, string sub)
    {
        return s.Contains(sub);
    }

    // 10. Position of substring
    static int SubstringPosition(string s, string sub)
    {
        return s.IndexOf(sub);
    }

    // 11. Check char type + case
    static void CheckChar(char c)
    {
        if (char.IsLetter(c))
        {
            if (char.IsUpper(c))
                Console.WriteLine("Alphabet - Uppercase");
            else
                Console.WriteLine("Alphabet - Lowercase");
        }
        else
        {
            Console.WriteLine("Not an alphabet");
        }
    }

    // 12. Count substring occurrences
    static int CountSubstring(string s, string sub)
    {
        int count = 0;
        for (int i = 0; i <= s.Length - sub.Length; i++)
        {
            if (s.Substring(i, sub.Length) == sub)
                count++;
        }
        return count;
    }

    // 13. Insert substring before first occurrence
    static string InsertSubstring(string s, string sub, string insert)
    {
        int pos = s.IndexOf(sub);
        if (pos == -1) return s;

        return s.Substring(0, pos) + insert + s.Substring(pos);
    }

    // MAIN
    static void Main()
    {
        string text = "Hello CSharp 123! Hello";

        Console.WriteLine("1. Print string:");
        InputAndPrint(text);

        Console.WriteLine("\n2. Length:");
        Console.WriteLine(GetLength(text));

        Console.WriteLine("\n3. Characters:");
        PrintCharacters(text);

        Console.WriteLine("\n4. Reverse:");
        PrintReverse(text);

        Console.WriteLine("\n5. Word count:");
        Console.WriteLine(CountWords(text));

        Console.WriteLine("\n6. Compare strings:");
        Console.WriteLine(CompareStrings("abc", "abc"));

        Console.WriteLine("\n7. Count types:");
        CountTypes(text);

        Console.WriteLine("\n8. Vowels & Consonants:");
        CountVowelsConsonants(text);

        Console.WriteLine("\n9. Contains 'Hello':");
        Console.WriteLine(ContainsSubstring(text, "Hello"));

        Console.WriteLine("\n10. Position of 'CSharp':");
        Console.WriteLine(SubstringPosition(text, "CSharp"));

        Console.WriteLine("\n11. Char check:");
        CheckChar('A');
        CheckChar('a');
        CheckChar('1');

        Console.WriteLine("\n12. Count substring 'Hello':");
        Console.WriteLine(CountSubstring(text, "Hello"));

        Console.WriteLine("\n13. Insert substring:");
        Console.WriteLine(InsertSubstring(text, "CSharp", " [INSERTED] "));
    }
}