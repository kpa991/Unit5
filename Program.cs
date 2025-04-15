namespace Modul5
{
    internal class Program
    {

        
        public static void Main(string[] args)
        {

            GetArrayFromConsole();

            Console.ReadKey();
        }
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            int temp = 0;


            return result;
        }
    }
}
