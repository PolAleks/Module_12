namespace Task_12_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 8, 3, 6, 3, 1, 9 };
            int position = BinarySearch(3, array, 0, array.Length);
            Console.WriteLine(position);
        }

        static int BinarySearch(int value, int[] array, int start, int end)
        {
            Array.Sort(array);
            int middle = 0;

            while (array[middle] != value)
            {
                middle = (start + end) / 2;
                if (value < array[middle])
                    end = middle - 1;
                else if(value > array[middle])
                    start = middle + 1;                
            }
            return middle;
        }
    }
}