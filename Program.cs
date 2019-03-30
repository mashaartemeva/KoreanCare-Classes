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
        /// Поск по названию статей
        /// </summary>
        public Article ArticleSearch { get; set; }

        /// <summary>
        /// Сохранение в закладки
        /// </summary>
        public bool Save { get; set; }

        /// <summary>
        /// Удаление статей
        /// </summary>
        public void Removal()
        {
        }
    }

    /// <summary>
    /// Статья
    /// </summary>
    public class Article
    {
        /// <summary>
        /// Все статьи
        /// </summary>
        public enum AllArticle
        {
            /// <summary>
            /// Список ссылок на статьи
            /// </summary>
        }

        /// <summary>
        /// Статьи для жирной кожи
        /// </summary>
        public enum OilySkinArticle
        {
            /// <summary>
            /// Список ссылок на статьи
            /// </summary>
        }

        /// <summary>
        /// Статьи для сухой кожи
        /// </summary>
        public enum DrySkinArticle
        {
            /// <summary>
            /// Список ссылок на статьи
            /// </summary>
        }

        /// <summary>
        /// Статьи для комбинированной кожи
        /// </summary>
        public enum CombinationSkinArticle
        {
            /// <summary>
            /// Список ссылок на статьи
            /// </summary>
        }

        /// <summary>
        /// Статьи для нормальной кожи
        /// </summary>
        public enum NormalSkinArticle
        {
            /// <summary>
            /// Список ссылок на статьи
            /// </summary>
        }
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
