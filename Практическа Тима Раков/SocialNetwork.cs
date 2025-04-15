using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическа_Тима_Раков
{
    public static class SocialNetwork
    {
        private static List<User> users = new List<User>();

        // Создание пользователя
        public static void CreateUser(string username, UserCategory category, DateTime registrationDate)
        {
            users.Add(new User(username, category, registrationDate));
        }

        // Создание новой публикации 
        public static void CreatePublication(string username, string title, DateTime creationDate, string content)
        {
            foreach (var user in users)
            {
                if (user.Username == username)
                {
                    user.Publications.Add(new Publication(title, creationDate, content));
                    return;
                }
            }
        }

        // Вывод всех публикаций 
        public static void PrintUserPublications(string username)
        {
            foreach (var user in users)
            {
                if (user.Username == username)
                {
                    Console.WriteLine($"Публикации пользователя {username}:");
                    foreach (var pub in user.Publications)
                    {
                        Console.WriteLine($"- {pub.Title} ({pub.CreationDate.ToShortDateString()}): {pub.Content}");
                    }
                    return;
                }
            }
        }

        // Вывод всех публикаций пользователей
        public static void RegularUsersPublications()
        {
            Console.WriteLine("Публикации обычных пользователей:");
            foreach (var user in users)
            {
                if (user.Category == UserCategory.RegularUser)
                {
                    foreach (var pub in user.Publications)
                    {
                        Console.WriteLine($"- {user.Username}: {pub.Title} ({pub.CreationDate.ToShortDateString()})");
                    }
                }
            }
        }

        //  Вывод всех публикаций издательств
        public static void AgenciesPublications()
        {
            Console.WriteLine("Публикации издательских агентств:");
            foreach (var user in users)
            {
                if (user.Category == UserCategory.PublishingAgency)
                {
                    foreach (var pub in user.Publications)
                    {
                        Console.WriteLine($"- {user.Username}: {pub.Title} ({pub.CreationDate.ToShortDateString()})");
                    }
                }
            }
        }

        // Вывод всех публикаций новостных каналов
        public static void PrintNewsChannelsPublications()
        {
            Console.WriteLine("Публикации новостных каналов:");
            foreach (var user in users)
            {
                if (user.Category == UserCategory.NewsChannel)
                {
                    foreach (var pub in user.Publications)
                    {
                        Console.WriteLine($"- {user.Username}: {pub.Title} ({pub.CreationDate.ToShortDateString()})");
                    }
                }
            }
        }

        // Вывод публикаций на определённую дату
        public static void PrintPublicationsByDate(DateTime date)
        {
            Console.WriteLine($"Публикации за {date.ToShortDateString()}:");
            foreach (var user in users)
            {
                foreach (var pub in user.Publications)
                {
                    if (pub.CreationDate.Date == date.Date)
                    {
                        Console.WriteLine($"- {user.Username} ({user.Category}): {pub.Title}");
                    }
                }
            }
        }
    }
}
