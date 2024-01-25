using WorkWithAlgoritms.AlggoritmsConsole.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        User[] Users =
        {
           new User { Name = "Tom", Login = "Tom@gmail.com", IsPremium = true },
           new User { Name = "Bob", Login = "Bob@icloud.com", IsPremium = false },
           new User { Name = "Alice", Login = "Alice@gmail.com", IsPremium = true },
           new User { Name = "Sam", Login = "Sam@hh.com", IsPremium = false },
        };

        foreach (var user in Users)
            CheckPremium(user);
    }

    /// <summary>Метод для проверки на премиум аккаунт </summary>
    /// <param name="user"></param>
    static void CheckPremium(User user)
    {
        Console.WriteLine($"Здравствуйте {user.Name}! Мы рады видеть Вас.");
        if (user.IsPremium)
            Console.WriteLine("\tУ Вас премиум подписка\n");
        else
            ShowAds();
    }

   

    /// <summary>Наша реклама</summary>
    static void ShowAds()
    {
        Console.WriteLine("\tПосетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        // Остановка на 1 с
        Thread.Sleep(1000);

        Console.WriteLine("\tКупите подписку на МыКомбо и слушайте музыку везде и всегда.");
        // Остановка на 2 с
        Thread.Sleep(2000);

        Console.WriteLine("\tОформите премиум-подписку на наш сервис, чтобы не видеть рекламу.\n");
        // Остановка на 3 с
        Thread.Sleep(3000);
    }
}