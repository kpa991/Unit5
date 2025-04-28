using System;

class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Напишите число");
        var N = int.Parse(Console.ReadLine());
        Console.WriteLine("Напишите степень");
        var pow = byte.Parse(Console.ReadLine());

        Console.WriteLine(PowerUp(N, pow));      

        Console.ReadKey();
    }

    private static int PowerUp(int N, byte pow)
    {
        if (pow == 0)
        {
            return 1;
        }
        else
        {
            if (pow == 1)
            {
                return N;
            }
            else
            {
                return N * PowerUp(N, --pow);
            }
        }
    }

}