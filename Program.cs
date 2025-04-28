using System;

class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Напишите число");
        var y = int.Parse(Console.ReadLine());
        Console.WriteLine(Factorial(y));
         

        Console.ReadKey();
    }

    static decimal Factorial(int x)
    {
        if (x == 0)
        {
            return 1;
        }
        else
        {
            return x * Factorial(x - 1);
        }
    }

}