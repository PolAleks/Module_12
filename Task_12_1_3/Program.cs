using System.Collections.Specialized;

namespace Task_12_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько элементов будет в массиве? ");
            int count;
            try
            {
                count = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                count = 3;
            }
            string[] array = new string[count];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите значения {i+1} элемента: ");
                array[i] = Console.ReadLine();
            }
            Console.Write("Все элементы записаны!");
        }
    }
}