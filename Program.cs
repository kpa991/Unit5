namespace Modul5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var someName = "Евгения";
            Console.WriteLine(someName);

            GetName(someName);

            Console.WriteLine(someName);

            Console.WriteLine("Введите возраст");
            int age = Console.ReadLine();  
           
            Console.ReadLine();
        }

        static void GetName (string name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
        }

        static void ChangeAge(int age)
        {
            age = age + 1;
        }
       
    }
}
