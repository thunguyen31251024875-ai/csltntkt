using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== C# EXERCISES =====");
        for (int i = 1; i <= 21; i++)
        {
            Console.WriteLine($"{i}. Exercise {i}");
        }

        Console.Write("\nChoose (1-21): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                // Hello and Name
                Console.WriteLine("Hello: Alexandra Abramov");
                break;

            case 2:
                // Sum of Two Numbers
                Console.Write("Enter first number: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Sum = " + (a + b));
                break;

            case 3:
                // Divide Two Numbers
                Console.Write("Enter first number: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine("Result = " + (x / y));
                break;

            case 4:
                Console.WriteLine("-1 + 4 * 6 = " + (-1 + 4 * 6));
                Console.WriteLine("(35 + 5) % 7 = " + ((35 + 5) % 7));
                Console.WriteLine("14 + -4 * 6 / 11 = " + (14 + (-4 * 6) / 11));
                break;

            case 5:
                Console.Write("First Number: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Second Number: ");
                int n2 = int.Parse(Console.ReadLine());

                int temp = n1;
                n1 = n2;
                n2 = temp;

                Console.WriteLine($"First Number: {n1}");
                Console.WriteLine($"Second Number: {n2}");
                break;

            case 6:
                Console.Write("First number: ");
                int m1 = int.Parse(Console.ReadLine());

                Console.Write("Second number: ");
                int m2 = int.Parse(Console.ReadLine());

                Console.Write("Third number: ");
                int m3 = int.Parse(Console.ReadLine());

                Console.WriteLine($"{m1} x {m2} x {m3} = {m1 * m2 * m3}");
                break;

            case 7:
                Console.Write("First number: ");
                int p = int.Parse(Console.ReadLine());

                Console.Write("Second number: ");
                int q = int.Parse(Console.ReadLine());

                Console.WriteLine($"{p}+{q}={p + q}");
                Console.WriteLine($"{p}-{q}={p - q}");
                Console.WriteLine($"{p}*{q}={p * q}");
                Console.WriteLine($"{p}/{q}={p / q}");
                Console.WriteLine($"{p}%{q}={p % q}");
                break;

            case 8:
                Console.Write("Enter number: ");
                int table = int.Parse(Console.ReadLine());

                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{table} * {i} = {table * i}");
                }
                break;

            case 9:
                Console.Write("Number 1: ");
                int a1 = int.Parse(Console.ReadLine());

                Console.Write("Number 2: ");
                int a2 = int.Parse(Console.ReadLine());

                Console.Write("Number 3: ");
                int a3 = int.Parse(Console.ReadLine());

                Console.Write("Number 4: ");
                int a4 = int.Parse(Console.ReadLine());

                Console.WriteLine("Average = " + ((a1 + a2 + a3 + a4) / 4));
                break;

            case 10:
                Console.Write("x = ");
                int xx = int.Parse(Console.ReadLine());

                Console.Write("y = ");
                int yy = int.Parse(Console.ReadLine());

                Console.Write("z = ");
                int zz = int.Parse(Console.ReadLine());

                Console.WriteLine("(x+y)*z = " + ((xx + yy) * zz));
                Console.WriteLine("x*y + y*z = " + ((xx * yy) + (yy * zz)));
                break;

            case 11:
                Console.Write("Enter age: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("You look older than " + age);
                break;

            case 12:
                Console.Write("Enter digit: ");
                int d = int.Parse(Console.ReadLine());

                Console.WriteLine("{0} {0} {0} {0}", d);
                Console.WriteLine("{0}{0}{0}{0}", d);
                Console.WriteLine("{0} {0} {0} {0}", d);
                Console.WriteLine("{0}{0}{0}{0}", d);
                break;

            case 13:
                Console.Write("Enter number: ");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine($"{num}{num}{num}");
                Console.WriteLine($"{num} {num}");
                Console.WriteLine($"{num} {num}");
                Console.WriteLine($"{num} {num}");
                Console.WriteLine($"{num}{num}{num}");
                break;

            case 14:
                Console.Write("Enter Celsius: ");
                double c = double.Parse(Console.ReadLine());

                Console.WriteLine("Kelvin = " + (c + 273));
                Console.WriteLine("Fahrenheit = " + (c * 9 / 5 + 32));
                break;

            case 15:
                string s = "w3resource";

                Console.WriteLine(s.Remove(1, 1));
                Console.WriteLine(s.Remove(9, 1));
                Console.WriteLine(s.Remove(0, 1));
                break;

            case 16:
                string str = Console.ReadLine();

                if (str.Length > 1)
                {
                    char first = str[0];
                    char last = str[str.Length - 1];

                    string result = last +
                                    str.Substring(1, str.Length - 2)
                                    + first;

                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine(str);
                }
                break;

            case 17:
                Console.Write("Input string: ");
                string text = Console.ReadLine();

                Console.WriteLine(text[0] + text + text[0].ToString());
                break;

            case 18:
                Console.Write("First integer: ");
                int i1 = int.Parse(Console.ReadLine());

                Console.Write("Second integer: ");
                int i2 = int.Parse(Console.ReadLine());

                Console.WriteLine((i1 < 0 && i2 > 0) ||
                                  (i1 > 0 && i2 < 0));
                break;

            case 19:
                Console.Write("First integer: ");
                int s1 = int.Parse(Console.ReadLine());

                Console.Write("Second integer: ");
                int s2 = int.Parse(Console.ReadLine());

                Console.WriteLine(s1 == s2
                    ? (s1 + s2) * 3
                    : s1 + s2);
                break;

            case 20:
                Console.Write("First number: ");
                int f1 = int.Parse(Console.ReadLine());

                Console.Write("Second number: ");
                int f2 = int.Parse(Console.ReadLine());

                int diff = Math.Abs(f1 - f2);

                Console.WriteLine(f1 > f2 ? diff * 2 : diff);
                break;

            case 21:
                Console.Write("First integer: ");
                int t1 = int.Parse(Console.ReadLine());

                Console.Write("Second integer: ");
                int t2 = int.Parse(Console.ReadLine());

                Console.WriteLine(
                    t1 == 20 || t2 == 20 || (t1 + t2 == 20)
                );
                break;

            default:
                Console.WriteLine("Invalid choice!");
                break;
        }

        Console.ReadKey();
    }
}