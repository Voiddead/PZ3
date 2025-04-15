using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическа_Тима_Раков
{
    internal class User
    {
        public string Username { get; set; }        // Имя
        public UserCategory Category { get; set; }  // Категория пользователя
        public List<Publication> Publications { get; set; } // Публикации
        public DateTime RegistrationDate { get; set; } // Дата регистрации

        public User(string username, UserCategory category, DateTime registrationDate)
        {
            Username = username;
            Category = category;
            RegistrationDate = registrationDate;
            Publications = new List<Publication>();
        }
    }
    }
    
    