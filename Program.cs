namespace Modul5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var someName = "Евгения";
            Console.WriteLine(someName);

            GetName(ref someName);

            Console.WriteLine(someName);

            Console.WriteLine("Введите возраст");
            int age = Convert.ToInt32(Console.ReadLine());  
            ChangeAge(age);
            Console.WriteLine(age);
           
            Console.ReadLine();
        }

        static void GetName (ref string name)
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
