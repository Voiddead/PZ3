using System;
using System.Collections.Generic;
using Практическа_Тима_Раков;

class Program
{
    static void Main(string[] args)
    {
        // Инициализация списка пользователей
        SocialNetwork.CreateUser("user1", UserCategory.RegularUser, new DateTime(2025, 1, 10));
        SocialNetwork.CreateUser("publisher1", UserCategory.PublishingAgency, new DateTime(2024, 5, 15));
        SocialNetwork.CreateUser("news1", UserCategory.NewsChannel, new DateTime(2024, 3, 20));

        // Добавление публикаций
        SocialNetwork.CreatePublication("user1", "Интересный факт", new DateTime(2025, 4, 10), "Елена Николаевна самый лучший учитель!");
        SocialNetwork.CreatePublication("publisher1", "Моя книга", new DateTime(2025, 4, 12), "Я хочу на второй курс");
        SocialNetwork.CreatePublication("news1", "Главные новости", new DateTime(2025, 4, 15), "ОКЭИ крутое место");
        SocialNetwork.CreatePublication("user1", "Мой отдых", new DateTime(2025, 4, 15), "Спорт - это жизнь");

        // Тестирование методов
        Console.WriteLine("Тестирование методов:");
        SocialNetwork.PrintUserPublications("user1");
        Console.WriteLine();
        SocialNetwork.RegularUsersPublications();
        Console.WriteLine();
        SocialNetwork.AgenciesPublications();
        Console.WriteLine();
        SocialNetwork.PrintNewsChannelsPublications();
        Console.WriteLine();
        SocialNetwork.PrintPublicationsByDate(new DateTime(2025, 4, 15));
    }
}
