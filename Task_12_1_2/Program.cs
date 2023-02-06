namespace Task_12_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как Вас зовут? ");
            string name = Console.ReadLine();

            string greetings = "Привет, " + name;
            Console.Write(greetings);
        }
    }
}