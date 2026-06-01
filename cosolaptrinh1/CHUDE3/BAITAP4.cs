using System;

class Program
{
    static void Main()
    {
        Console.Write("Choose exercise (1-15): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            // 1. Calculator
            case 1:
                {
                    Console.Write("Number 1: ");
                    double a = double.Parse(Console.ReadLine());

                    Console.Write("Operator (+,-,*,/): ");
                    char op = Convert.ToChar(Console.ReadLine());

                    Console.Write("Number 2: ");
                    double b = double.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case '+': Console.WriteLine(a + b); break;
                        case '-': Console.WriteLine(a - b); break;
                        case '*':
                        case 'x':
                        case 'X':
                            Console.WriteLine(a * b); break;
                        case '/':
                            Console.WriteLine(a / b); break;
                    }
                    break;
                }

            // 2. x = y² + 2y + 1
            case 2:
                {
                    for (int y = -5; y <= 5; y++)
                    {
                        int x = y * y + 2 * y + 1;
                        Console.WriteLine($"y={y}, x={x}");
                    }
                    break;
                }

            // 3. Speed
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

                    double totalHours = h + m / 60.0 + s / 3600.0;

                    double kmh = distance / totalHours;
                    double mph = kmh * 0.621371;

                    Console.WriteLine($"Km/h = {kmh:F2}");
                    Console.WriteLine($"Miles/h = {mph:F2}");
                    break;
                }

            // 4. Sphere
            case 4:
                {
                    Console.Write("Radius: ");
                    double r = double.Parse(Console.ReadLine());

                    double surface = 4 * Math.PI * r * r;
                    double volume = (4.0 / 3.0) * Math.PI * r * r * r;

                    Console.WriteLine($"Surface = {surface:F2}");
                    Console.WriteLine($"Volume = {volume:F2}");
                    break;
                }

            // 5. Vowel Digit Symbol
            case 5:
                {
                    Console.Write("Character: ");
                    char ch = Convert.ToChar(Console.ReadLine());

                    if ("aeiouAEIOU".Contains(ch))
                        Console.WriteLine("Vowel");
                    else if (char.IsDigit(ch))
                        Console.WriteLine("Digit");
                    else
                        Console.WriteLine("Other Symbol");

                    break;
                }

            // 6. Even Odd
            case 6:
                {
                    Console.Write("Number: ");
                    int n = int.Parse(Console.ReadLine());

                    Console.WriteLine(n % 2 == 0 ? "Even" : "Odd");
                    break;
                }

            // 7. Largest of three
            case 7:
                {
                    Console.Write("A: ");
                    int a = int.Parse(Console.ReadLine());

                    Console.Write("B: ");
                    int b = int.Parse(Console.ReadLine());

                    Console.Write("C: ");
                    int c = int.Parse(Console.ReadLine());

                    Console.WriteLine("Largest = " +
                        Math.Max(a, Math.Max(b, c)));

                    break;
                }

            // 8. Coordinate Quadrant
            case 8:
                {
                    Console.Write("X = ");
                    int x = int.Parse(Console.ReadLine());

                    Console.Write("Y = ");
                    int y = int.Parse(Console.ReadLine());

                    if (x > 0 && y > 0)
                        Console.WriteLine("Quadrant I");
                    else if (x < 0 && y > 0)
                        Console.WriteLine("Quadrant II");
                    else if (x < 0 && y < 0)
                        Console.WriteLine("Quadrant III");
                    else if (x > 0 && y < 0)
                        Console.WriteLine("Quadrant IV");
                    else
                        Console.WriteLine("On Axis");

                    break;
                }

            // 9. Triangle Type
            case 9:
                {
                    Console.Write("Side a: ");
                    int a = int.Parse(Console.ReadLine());

                    Console.Write("Side b: ");
                    int b = int.Parse(Console.ReadLine());

                    Console.Write("Side c: ");
                    int c = int.Parse(Console.ReadLine());

                    if (a == b && b == c)
                        Console.WriteLine("Equilateral");
                    else if (a == b || b == c || a == c)
                        Console.WriteLine("Isosceles");
                    else
                        Console.WriteLine("Scalene");

                    break;
                }

            // 10. Sum and Average of 10 numbers
            case 10:
                {
                    int sum = 0;

                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write($"Number {i}: ");
                        sum += int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Sum = " + sum);
                    Console.WriteLine("Average = " + (sum / 10.0));

                    break;
                }

            // 11. Multiplication Table
            case 11:
                {
                    Console.Write("Number: ");
                    int n = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= 10; i++)
                        Console.WriteLine($"{n} x {i} = {n * i}");

                    break;
                }

            // 12. Triangle Pattern
            case 12:
                {
                    Console.Write("Rows: ");
                    int rows = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= rows; i++)
                    {
                        for (int j = 1; j <= i; j++)
                            Console.Write(j);

                        Console.WriteLine();
                    }

                    break;
                }

            // 13. Harmonic Series
            case 13:
                {
                    Console.Write("n = ");
                    int n = int.Parse(Console.ReadLine());

                    double sum = 0;

                    for (int i = 1; i <= n; i++)
                    {
                        sum += 1.0 / i;
                    }

                    Console.WriteLine("Sum = " + sum);
                    break;
                }

            // 14. Perfect Numbers
            case 14:
                {
                    Console.Write("Limit = ");
                    int limit = int.Parse(Console.ReadLine());

                    Console.WriteLine("Perfect numbers:");

                    for (int n = 1; n <= limit; n++)
                    {
                        int sum = 0;

                        for (int i = 1; i < n; i++)
                        {
                            if (n % i == 0)
                                sum += i;
                        }

                        if (sum == n)
                            Console.WriteLine(n);
                    }

                    break;
                }

            // 15. Prime Number
            case 15:
                {
                    Console.Write("Number: ");
                    int n = int.Parse(Console.ReadLine());

                    bool prime = n > 1;

                    for (int i = 2; i <= Math.Sqrt(n); i++)
                    {
                        if (n % i == 0)
                        {
                            prime = false;
                            break;
                        }
                    }

                    Console.WriteLine(prime ? "Prime" : "Not Prime");
                    break;
                }

            default:
                Console.WriteLine("Invalid choice!");
                break;
        }

        Console.ReadKey();
    }
}