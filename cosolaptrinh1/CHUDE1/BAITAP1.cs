using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== MENU =====");
        Console.WriteLine("1. Add / Sum Two Numbers");
        Console.WriteLine("2. Swap Values of Two Variables");
        Console.WriteLine("3. Multiply Two Floating Point Numbers");
        Console.WriteLine("4. Convert Feet to Meter");
        Console.WriteLine("5. Convert Celsius to Fahrenheit and Vice Versa");
        Console.WriteLine("6. Find Size of Data Types");
        Console.WriteLine("7. Print ASCII Value");
        Console.WriteLine("8. Calculate Area of Circle");
        Console.WriteLine("9. Calculate Area of Square");
        Console.WriteLine("10. Convert Days to Years, Weeks and Days");

        Console.Write("\nChoose (1-10): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                {
                    Console.Write("Enter first number: ");
                    double a = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Sum = " + (a + b));
                    break;
                }

            case 2:
                {
                    Console.Write("Enter a: ");
                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter b: ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Before swap: a = {a}, b = {b}");

                    int temp = a;
                    a = b;
                    b = temp;

                    Console.WriteLine($"After swap: a = {a}, b = {b}");
                    break;
                }

            case 3:
                {
                    Console.Write("Enter first float: ");
                    float a = float.Parse(Console.ReadLine());

                    Console.Write("Enter second float: ");
                    float b = float.Parse(Console.ReadLine());

                    Console.WriteLine("Product = " + (a * b));
                    break;
                }

            case 4:
                {
                    Console.Write("Enter feet: ");
                    double feet = Convert.ToDouble(Console.ReadLine());

                    double meter = feet * 0.3048;

                    Console.WriteLine($"{feet} feet = {meter} meters");
                    break;
                }

            case 5:
                {
                    Console.Write("Enter Celsius: ");
                    double c = Convert.ToDouble(Console.ReadLine());

                    double f = (c * 9 / 5) + 32;
                    Console.WriteLine($"Fahrenheit = {f}");

                    Console.Write("Enter Fahrenheit: ");
                    f = Convert.ToDouble(Console.ReadLine());

                    c = (f - 32) * 5 / 9;
                    Console.WriteLine($"Celsius = {c}");
                    break;
                }

            case 6:
                {
                    Console.WriteLine("byte   : " + sizeof(byte) + " bytes");
                    Console.WriteLine("short  : " + sizeof(short) + " bytes");
                    Console.WriteLine("int    : " + sizeof(int) + " bytes");
                    Console.WriteLine("long   : " + sizeof(long) + " bytes");
                    Console.WriteLine("float  : " + sizeof(float) + " bytes");
                    Console.WriteLine("double : " + sizeof(double) + " bytes");
                    Console.WriteLine("char   : " + sizeof(char) + " bytes");
                    Console.WriteLine("bool   : " + sizeof(bool) + " bytes");
                    break;
                }

            case 7:
                {
                    Console.Write("Enter a character: ");
                    char ch = Console.ReadKey().KeyChar;

                    Console.WriteLine();
                    Console.WriteLine("ASCII Value = " + (int)ch);
                    break;
                }

            case 8:
                {
                    Console.Write("Enter radius: ");
                    double r = Convert.ToDouble(Console.ReadLine());

                    double area = Math.PI * r * r;

                    Console.WriteLine("Area of Circle = " + area);
                    break;
                }

            case 9:
                {
                    Console.Write("Enter side length: ");
                    double side = Convert.ToDouble(Console.ReadLine());

                    double area = side * side;

                    Console.WriteLine("Area of Square = " + area);
                    break;
                }

            case 10:
                {
                    Console.Write("Enter number of days: ");
                    int totalDays = Convert.ToInt32(Console.ReadLine());

                    int years = totalDays / 365;
                    int remainingDays = totalDays % 365;

                    int weeks = remainingDays / 7;
                    int days = remainingDays % 7;

                    Console.WriteLine($"Years = {years}");
                    Console.WriteLine($"Weeks = {weeks}");
                    Console.WriteLine($"Days = {days}");
                    break;
                }

            default:
                Console.WriteLine("Invalid choice!");
                break;
        }

        Console.ReadKey();
    }
}