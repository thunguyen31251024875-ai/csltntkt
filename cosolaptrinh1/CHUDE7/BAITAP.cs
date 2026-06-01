using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {

            Console.WriteLine("\n===== FILE HANDLING MENU =====");
            Console.WriteLine("1. Create blank file");
            Console.WriteLine("2. Delete file");
            Console.WriteLine("3. Create file and write text");
            Console.WriteLine("4. Create and read text file");
            Console.WriteLine("5. Write array of strings to file");
            Console.WriteLine("6. Append text to file");
            Console.WriteLine("7. Copy file and display content");
            Console.WriteLine("8. Move/Rename file");
            Console.WriteLine("9. Read first line");
            Console.WriteLine("10. Read last line");
            Console.WriteLine("11. Read last N lines");
            Console.WriteLine("12. Read specific line");
            Console.WriteLine("13. Count number of lines");
            Console.WriteLine("14. Print folder structure");
            Console.WriteLine("15. Count letters and digits");
            Console.WriteLine("0. Exit");

            Console.Write("Choose: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: CreateBlankFile(); break;
                case 2: DeleteFile(); break;
                case 3: WriteTextFile(); break;
                case 4: CreateAndReadFile(); break;
                case 5: WriteArrayToFile(); break;
                case 6: AppendText(); break;
                case 7: CopyFile(); break;
                case 8: MoveFile(); break;
                case 9: ReadFirstLine(); break;
                case 10: ReadLastLine(); break;
                case 11: ReadLastNLines(); break;
                case 12: ReadSpecificLine(); break;
                case 13: CountLines(); break;
                case 14: PrintFolderStructure(); break;
                case 15: CountLettersAndDigits(); break;
                case 0: return;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }
    }

    // 1
    static void CreateBlankFile()
    {
        File.Create("blank.txt").Close();
        Console.WriteLine("Blank file created.");
    }

    // 2
    static void DeleteFile()
    {
        string file = "blank.txt";

        if (File.Exists(file))
        {
            File.Delete(file);
            Console.WriteLine("File deleted.");
        }
        else
            Console.WriteLine("File not found.");
    }

    // 3
    static void WriteTextFile()
    {
        File.WriteAllText("text.txt", "Hello C# File Handling");
        Console.WriteLine("Text written.");
    }

    // 4
    static void CreateAndReadFile()
    {
        string file = "read.txt";
        File.WriteAllText(file, "This is a sample file.");

        Console.WriteLine("Content:");
        Console.WriteLine(File.ReadAllText(file));
    }

    // 5
    static void WriteArrayToFile()
    {
        string[] fruits =
        {
            "Apple",
            "Banana",
            "Orange",
            "Mango"
        };

        File.WriteAllLines("array.txt", fruits);
        Console.WriteLine("Array written.");
    }

    // 6
    static void AppendText()
    {
        File.AppendAllText("text.txt",
            "\nThis line is appended.");

        Console.WriteLine("Text appended.");
    }

    // 7
    static void CopyFile()
    {
        File.WriteAllText("source.txt",
            "This is original file.");

        File.Copy("source.txt",
            "copy.txt", true);

        Console.WriteLine("Copied content:");
        Console.WriteLine(
            File.ReadAllText("copy.txt"));
    }

    // 8
    static void MoveFile()
    {
        File.WriteAllText("old.txt",
            "Move example");

        if (File.Exists("new.txt"))
            File.Delete("new.txt");

        File.Move("old.txt", "new.txt");

        Console.WriteLine("File renamed.");
    }

    // 9
    static void ReadFirstLine()
    {
        string file = "array.txt";

        if (File.Exists(file))
        {
            Console.WriteLine(
                File.ReadLines(file).First());
        }
    }

    // 10
    static void ReadLastLine()
    {
        string file = "array.txt";

        if (File.Exists(file))
        {
            string[] lines =
                File.ReadAllLines(file);

            Console.WriteLine(
                lines[lines.Length - 1]);
        }
    }

    // 11
    static void ReadLastNLines()
    {
        string file = "array.txt";

        Console.Write("Enter N: ");
        int n = Convert.ToInt32(
            Console.ReadLine());

        var lines =
            File.ReadLines(file).TakeLast(n);

        foreach (string line in lines)
            Console.WriteLine(line);
    }

    // 12
    static void ReadSpecificLine()
    {
        string file = "array.txt";

        Console.Write("Line number: ");
        int lineNum =
            Convert.ToInt32(Console.ReadLine());

        string[] lines =
            File.ReadAllLines(file);

        if (lineNum > 0 &&
            lineNum <= lines.Length)
        {
            Console.WriteLine(
                lines[lineNum - 1]);
        }
        else
        {
            Console.WriteLine(
                "Line does not exist.");
        }
    }

    // 13
    static void CountLines()
    {
        string file = "array.txt";

        int count =
            File.ReadAllLines(file).Length;

        Console.WriteLine(
            "Total lines: " + count);
    }

    // 14
    static void PrintFolderStructure()
    {
        Console.Write("Folder path: ");
        string path = Console.ReadLine();

        DisplayDirectory(path, 0);
    }

    static void DisplayDirectory(
        string path, int level)
    {
        string indent =
            new string(' ', level * 2);

        foreach (string dir in
            Directory.GetDirectories(path))
        {
            Console.WriteLine(indent +
                "[DIR] " +
                Path.GetFileName(dir));

            DisplayDirectory(
                dir, level + 1);
        }

        foreach (string file in
            Directory.GetFiles(path))
        {
            Console.WriteLine(indent +
                Path.GetFileName(file));
        }
    }

    // 15
    static void CountLettersAndDigits()
    {
        Console.Write("File path: ");
        string file = Console.ReadLine();

        if (!File.Exists(file))
        {
            Console.WriteLine(
                "File not found.");
            return;
        }

        string text =
            File.ReadAllText(file);

        int letters = 0;
        int digits = 0;

        foreach (char c in text)
        {
            if (char.IsLetter(c))
                letters++;

            if (char.IsDigit(c))
                digits++;
        }

        Console.WriteLine(
            "Letters: " + letters);
        Console.WriteLine(
            "Digits : " + digits);
    }
}