using System.Xml.Linq;

namespace Task_12_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array =  { 0, 1, 2, 4, 5, 7, 9, 10, 11, 12, 13, 14, 15 };
            int searchIndex = FindIndexElement(array, 4);

            Console.WriteLine($"Индекс вставки элемента - {searchIndex}");
        }
        static int FindIndexElement(int[] array, int insertionValue)
        {
            int index;
            for (index = 0; index < array.Length; index++)
            {
                if (array[index] > insertionValue)
                    return index;
            }

            return index;
        }

        static void ShowArray(int[] array)
        {
            foreach(var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}