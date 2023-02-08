using System;



public class Program2
{



    static void Main()
    {
        //exercise1();
        exercise2();



    }

    //Write a C# Sharp program that takes three letters as input and display them in reverse order.
    public static void exercise1()
    {


        Console.Write("Type a letter: ");
        string a = Console.ReadLine() ?? throw new ArgumentNullException();
        Console.Write("Type another  letter: ");
        string b = Console.ReadLine() ?? throw new ArgumentNullException();
        Console.Write("Type and a last letter: ");
        string c = Console.ReadLine() ?? throw new ArgumentNullException();

        List<string> stringList = new List<string>();

        stringList.Add(a);
        stringList.Add(b);
        stringList.Add(c);


        Console.WriteLine($"Letters {a} and {b} and {c} was in this order");

        stringList.Reverse();

        Console.WriteLine("They are now reversed!");
        Console.WriteLine(string.Join(", ", stringList));


    }



    //Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number.
    static void exercise2()
    {
        Console.Write("Type a number: ");
        string a = Console.ReadLine() ?? throw new ArgumentNullException();
        Console.Write("Type another number for the lenght: ");
        string b = Console.ReadLine() ?? throw new ArgumentNullException();

        int numberA = int.Parse(a);
        int numberB = int.Parse(b);


    }



}