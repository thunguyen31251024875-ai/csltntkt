using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== MENU =====");
        Console.WriteLine("1. Calculator (+, -, *, /)");
        Console.WriteLine("2. Function x = y² + 2y + 1");
        Console.WriteLine("3. Calculate Speed");
        Console.WriteLine("4. Sphere Surface Area and Volume");
        Console.WriteLine("5. Check Vowel, Digit or Symbol");

        Console.Write("\nChoose (1-5): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                {
                    Console.Write("Enter first number: ");
                    double a = double.Parse(Console.ReadLine());

                    Console.Write("Enter operator (+,-,*,/): ");
                    char op = Convert.ToChar(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    double b = double.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case '+':
                            Console.WriteLine($"Result = {a + b}");
                            break;
                        case '-':
                            Console.WriteLine($"Result = {a - b}");
                            break;
                        case '*':
                        case 'x':
                        case 'X':
                            Console.WriteLine($"Result = {a * b}");
                            break;
                        case '/':
                            if (b != 0)
                                Console.WriteLine($"Result = {a / b}");
                            else
                                Console.WriteLine("Cannot divide by zero!");
                            break;
                        default:
                            Console.WriteLine("Invalid operator!");
                            break;
                    }
                    break;
                }

            case 2:
                {
                    Console.WriteLine("y\t x=y²+2y+1");

                    for (int y = -5; y <= 5; y++)
                    {
                        int x = y * y + 2 * y + 1;
                        Console.WriteLine($"{y}\t{x}");
                    }
                    break;
                }

            case 3:
                {
                    Console.Write("Distance (km): ");
                    double distance = double.Parse(Console.ReadLine());

                    Console.Write("Hours: ");
                    int h = int.Parse(Console.ReadLine());

                    Console.Write("Minutes: ");
                    int m = int.Parse(Console.ReadLine());

                    Console.Write("Seconds: ");
                    int s = int.Parse(Console.ReadLine());

                    double totalHours =
                        h + m / 60.0 + s / 3600.0;

                    double kmh = distance / totalHours;
                    double mph = kmh * 0.621371;

                    Console.WriteLine($"Speed = {kmh:F2} km/h");
                    Console.WriteLine($"Speed = {mph:F2} miles/h");
                    break;
                }

            case 4:
                {
                    Console.Write("Enter radius: ");
                    double r = double.Parse(Console.ReadLine());

                    double surface = 4 * Math.PI * r * r;
                    double volume = (4.0 / 3.0) * Math.PI * r * r * r;

                    Console.WriteLine($"Surface Area = {surface:F2}");
                    Console.WriteLine($"Volume = {volume:F2}");
                    break;
                }

            case 5:
                {
                    Console.Write("Enter a character: ");
                    char ch = Convert.ToChar(Console.ReadLine());

                    ch = Char.ToLower(ch);

                    if ("aeiou".Contains(ch))
                    {
                        Console.WriteLine("Vowel");
                    }
                    else if (Char.IsDigit(ch))
                    {
                        Console.WriteLine("Digit");
                    }
                    else
                    {
                        Console.WriteLine("Other Symbol");
                    }
                    break;
                }

            default:
                Console.WriteLine("Invalid choice!");
                break;
        }

        Console.ReadKey();
    }
}