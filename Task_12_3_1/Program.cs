namespace Task_12_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 4, 5, 7, 9, 10, 11, 12, 13, 14, 15 };
            int position = BinarySearch(3, array, 0, array.Length);
            Console.WriteLine(position);
        }
        /// <summary>
        /// Метод бинарного поиска в массиве
        /// </summary>
        /// <param name="value">Искомое значение</param>
        /// <param name="array">Массив в котором необходимо найти искомое значение</param>
        /// <param name="left">Стартовый индекс поиска</param>
        /// <param name="right">Конечный индекс поиска</param>
        /// <returns>Возвращает индекс искомого элемента</returns>
        static int BinarySearch(int value, int[] array, int left, int right)
        {
            while (left <= right)
            {
                var middle = (left + right) / 2;

                var midElement = array[middle];

                if (midElement == value)
                    return middle;
                else if (value < midElement)
                    right = middle - 1;
                else
                    left = middle + 1;
            }

            return -1;
        }
    }
}