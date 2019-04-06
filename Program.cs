using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanCare
{
    /// <summary>
    /// Базовые функции
    /// </summary>
    public class BaseFunctions
    {
        /// <summary>
        /// Авторизация
        /// </summary>
        public UserType Authorization { get; set; }

        /// <summary>
        /// Сортировка статей по типу кожи
        /// </summary>
        public Article SortArticles { get; set; }

        /// <summary>
        /// Сохранение статей на диск
        /// </summary>
        public bool Save { get; set; }

        /// <summary>
        /// Добавление статей
        /// </summary>
        public bool Add { get; set; }

        /// <summary>
        /// Удаление статей
        /// </summary>
        public bool Removal { get; set; }
        
    }

    /// <summary>
    /// Статья
    /// </summary>
    public class Article
    {
        /// <summary>
        /// Все статьи
        /// </summary>
        public List<string> AllArticle {get; set;}

        /// <summary>
        /// Статьи для жирной кожи
        /// </summary>
        public List<string> OilySkinArticle {get; set;}

        /// <summary>
        /// Статьи для сухой кожи
        /// </summary>
        public List<string> DrySkinArticle {get; set;}

        /// <summary>
        /// Статьи для комбинированной кожи
        /// </summary>
        public List<string> CombinationSkinArticle { get; set; }

        /// <summary>
        /// Статьи для нормальной кожи
        /// </summary>
        public List<string> NormalSkinArticle { get; set; }

        /// <summary>
        /// Дата публикации статьи
        /// </summary>
        public DateTime PublicationDate { get; set; }
    }

    /// <summary>
    /// Тест
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Тест для определения типа кожи
        /// </summary>
        public SkinType SkinTypeTest { get; set; }
    }

    /// <summary>
    /// Тип пользователя
    /// </summary>
    public enum UserType
    {
        /// <summary>
        /// Обычный пользователь
        /// </summary>
        UsualUser,

        /// <summary>
        /// Админ
        /// </summary>
        Admin
    }

    /// <summary>
    /// Тип кожи
    /// </summary>
    public enum SkinType
    {
        /// <summary>
        /// Жирная
        /// </summary>
        Oily,

        /// <summary>
        /// Сухая
        /// </summary>
        Dry,

        /// <summary>
        /// Комбинированная
        /// </summary>
        Combination,

        /// <summary>
        /// Нормальная
        /// </summary>
        Normal
    }
}
