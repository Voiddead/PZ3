using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическа_Тима_Раков
{
    // Перечисление 
    public enum UserCategory
    {
        RegularUser,       // Обычный пользователь
        PublishingAgency,  // Издательское агентство
        NewsChannel        // Новостной канал
    }

    // Класс публикации
    public class Publication
    {
        public string Title { get; set; }       // Название 
        public DateTime CreationDate { get; set; } // Дата создания
        public string Content { get; set; }     // Текст 

        public Publication(string title, DateTime creationDate, string content)
        {
            Title = title;
            CreationDate = creationDate;
            Content = content;
        }
    }
}