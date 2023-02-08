//https://www.w3resource.com/csharp-exercises/basic/index.php

public class Program
{
    public static void Main()
    {

        // Console.WriteLine(sumAdd());
        // message();
        //Console.WriteLine(sumDivide());
        //result();
        //swap();
        //Console.WriteLine("The product is: " + total());
        // multipleSum();
        //multiplicationTable();
        //average();
        //exercise10();
        //exercise11();
        //exercise12();
        //exercise13();
        //exercise14();
        exercise15();
    }

    //Exercise 1
    public static void message()
    {
        Console.WriteLine("Hello, World!");
    }

    //Exercise 2
    public static int sumAdd()
    {
        int a = 1;
        int b = 2;
        return a + b;
    }

    //Exercise 3
    public static int sumDivide()
    {
        int a = 10;
        int b = 2;
        return a / b;
    }

    //Exercise 4
    public static void result()
    {
        Console.WriteLine(-1 + 4 * 6);
        Console.WriteLine((35 + 5) % 7);
        Console.WriteLine(14 + -4 * 6 / 11);
        Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
    }

    //Exercise 5
    public static void swap()
    {
        int a = 5;
        int b = 6;
        int temp = a;
        Console.WriteLine("Input the First Number : " + a);
        Console.WriteLine("Input the Second Number : " + b);
        a = b;
        b = temp;

        Console.WriteLine("After Swapping :");
        Console.WriteLine("First Number : " + a);
        Console.WriteLine("Second Number : " + b);
    }

    //Exercise 6
    public static int total()
    {
        int a;
        int b;
        int c;

        Console.Write("Input the First Number : ");
        string aString = Console.ReadLine() ?? throw new ArgumentNullException();
        Console.Write("Input the Second Number : ");
        string bString = Console.ReadLine() ?? throw new ArgumentNullException();
        Console.Write("Input the Third Number : ");
        string cString = Console.ReadLine() ?? throw new ArgumentNullException();

        a = int.Parse(aString);
        b = int.Parse(bString);
        c = int.Parse(cString);


        return a * b * c;
    }

    //Exercise 7
    public static void multipleSum()
    {
        //TODO: add console readability for input and output
        Console.Write("Input the First Number : ");
        string aString = Console.ReadLine() ?? throw new ArgumentNullException();
        Console.Write("Input the Second Number : ");
        string bString = Console.ReadLine() ?? throw new ArgumentNullException();

        int a = int.Parse(aString);
        int b = int.Parse(bString);

        int c = a + b;
        int d = a - b;
        int e = a * b;
        int f = a / b;
        int g = a % b;

        List<int> list = new List<int>();
        list.Add(c);
        list.Add(d);
        list.Add(e);
        list.Add(f);
        list.Add(g);

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine("Total is: " + list[i]);
        }

    }

    //Exercise 8
    //that takes a number as input and print its multiplication table
    public static void multiplicationTable()
    {
        Console.Write("Input the number (Table to be calculated) : ");
        string aString = Console.ReadLine() ?? throw new ArgumentNullException();
        int a = int.Parse(aString);

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(a + " x " + i + " = " + a * i);
        }
    }

    //Exercise 9
    //Write a C# Sharp program that takes four numbers as input to calculate and print the average
    public static void average()
    {
        Console.Write("Input the 1st number : ");
        string aString = Console.ReadLine() ?? throw new ArgumentNullException();
        Console.Write("Input the 2nd number : ");
        string bString = Console.ReadLine() ?? throw new ArgumentNullException();
        Console.Write("Input the 3rd number : ");
        string cString = Console.ReadLine() ?? throw new ArgumentNullException();
        Console.Write("Input the 4th number : ");
        string dString = Console.ReadLine() ?? throw new ArgumentNullException();

        int a = int.Parse(aString);
        int b = int.Parse(bString);
        int c = int.Parse(cString);
        int d = int.Parse(dString);

        int e = a + b + c + d;
        int f = e / 4;

        Console.WriteLine("The average of " + a + ", " + b + ", " + c + ", " + d + " is: " + f);
    }

    //Exercise 10
    //Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.
    public static void exercise10()
    {
        Console.Write("Input the 1st number : ");
        string aString = Console.ReadLine() ?? throw new ArgumentNullException();
        Console.Write("Input the 2nd number : ");
        string bString = Console.ReadLine() ?? throw new ArgumentNullException();
        Console.Write("Input the 3rd number : ");
        string cString = Console.ReadLine() ?? throw new ArgumentNullException();

        int a = int.Parse(aString);
        int b = int.Parse(bString);
        int c = int.Parse(cString);

        int d = (a + b) * c;
        int e = a * b + b * c;

        Console.WriteLine("The result of specified numbers " + a + ", " + b + ", " + c + " is: " + d + " and " + e);
    }

    //Exercise 11
    //Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20"
    public static void exercise11()
    {
        Console.Write("Input your age : ");
        string aString = Console.ReadLine() ?? throw new ArgumentNullException();
        int a = int.Parse(aString);

        Console.WriteLine("You look older than " + a);
    }

    //Exercise 12
    // Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), 
    //and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}
    public static void exercise12()
    {
        Console.Write("Input a number : ");
        string aString = Console.ReadLine() ?? throw new ArgumentNullException();
        int a = int.Parse(aString);

        Console.WriteLine(a + " " + a + " " + a + " " + a);
        Console.WriteLine(a + "" + a + "" + a + "" + a);
        Console.WriteLine("{0} {0} {0} {0}", a);
        Console.WriteLine("{0}{0}{0}{0}", a);
    }

    //Exercise 13
    //Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.
    public static void exercise13()
    {
        Console.Write("Input a number : ");
        string aString = Console.ReadLine() ?? throw new ArgumentNullException();
        int a = int.Parse(aString);

        Console.WriteLine("{0}{0}{0}", a);
        Console.WriteLine("{0} {0}", a);
        Console.WriteLine("{0} {0}", a);
        Console.WriteLine("{0} {0}", a);
        Console.WriteLine("{0}{0}{0}", a);
    }

    //Exercise 14
    //Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
    public static void exercise14()
    {
        Console.Write("Input the amount of celsius : ");
        string aString = Console.ReadLine() ?? throw new ArgumentNullException();
        int a = int.Parse(aString);

        int b = a + 273;
        double c = (a * 1.8) + 32;

        Console.WriteLine("Kelvin = " + b);
        Console.WriteLine("Fahrenheit = " + c);
    }

    //Exercise 15
    //Write a C# program remove specified a character from a non-empty string using index of a character.
    public static void exercise15()
    {
        Console.Write("Input a string : ");
        string aString = Console.ReadLine() ?? throw new ArgumentNullException();
        Console.Write("Input the character to be removed : ");
        string bString = Console.ReadLine() ?? throw new ArgumentNullException();

        int a = aString.IndexOf(bString);
        string c = aString.Remove(a, 1);

        Console.WriteLine(c);
    }

    //Exercise 16
    //Write a C# program to create a new string from a given string where the first and last characters will change their positions.
    public static void exercise16()
    {
        Console.Write("Input a string : ");
        string aString = Console.ReadLine() ?? throw new ArgumentNullException();

        int a = aString.Length;
        string b = aString.Substring(a - 1, 1);
        string c = aString.Substring(1, a - 2);
        string d = aString.Substring(0, 1);

        Console.WriteLine(b + c + d);
    }


}
