
//https://www.w3resource.com/csharp-exercises/basic/index.php
public class Program
{
    public static void Main()
    {   

        Console.WriteLine(sumAdd());
        message();
        Console.WriteLine(sumDivide());
        result();
        swap();
        Console.WriteLine("The product is: " + total());
        multipleSum();
    }

    //Exercise 1
    public static void message(){
        Console.WriteLine("Hello, World!");
    }

    //Exercise 2
    public static int sumAdd(){
        int a = 1;
        int b = 2;
        return a + b;
    }

    //Exercise 3
    public static int sumDivide(){
        int a = 10;
        int b = 2;
        return a / b;
    }

    //Exercise 4
    public static void result(){
        Console.WriteLine(-1 + 4 * 6);
        Console.WriteLine(( 35+ 5 ) % 7);
        Console.WriteLine(14 + -4 * 6 / 11);
        Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
    }

    //Exercise 5
    public static void swap(){
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
    public static int total(){
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
    public static void multipleSum(){
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


}
