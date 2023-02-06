namespace Task_12_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>()
            {
                new User() { Login = "Ivan", Name = "Иван", IsPremium = true },
                new User() { Login = "Aleks", Name = "Александр", IsPremium = false },
                new User() { Login = "Fedor", Name = "Фёдор", IsPremium = true },
                new User() { Login = "Anastasija", Name = "Анастасия", IsPremium = false },
            };

            Console.WriteLine("Список доступных пользователей:");

            foreach (var user in users)
            {
                Console.WriteLine(user.Login);
            }

            Console.Write("Введите логин пользователя из вышеперечисленных списка: ");

            string selectUser = Console.ReadLine();

            int index = users.FindIndex(x => x.Login == selectUser);

            if (index > -1)
            {
                users[index].Greetings();
                if (!users[index].IsPremium)
                    ShowAds();
            }
        }
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}