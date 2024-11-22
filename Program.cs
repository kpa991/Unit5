namespace Modul5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name,string[] LoveEat ) User;

            Console.Write("Введите ваше имя:");
            User.Name = Console.ReadLine();

            User.LoveEat = new string[5];
            for (int i = 0; i<User.LoveEat.Length; i++)
            {
                int n = i + 1;
                Console.WriteLine("Напишите ваше " + n + " любимое блюдо?");
                User.LoveEat[i] = Console.ReadLine();
            }


        }
    }
}
