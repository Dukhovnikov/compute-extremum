using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDraft
{
    /// <summary>
    /// Набор многомерных методов минимизации
    /// </summary>
    internal class Methods
    {
        /// <summary>
        /// Тема метода многомерной оптимизации
        /// </summary>
        public string ThemeName { get; set; }
        /// <summary>
        /// Метод многомерной оптимизации
        /// </summary>
        public string MethodName { get; set; }

        public Methods(string ThemeName, string MethodName)
        {
            this.ThemeName = ThemeName;
            this.MethodName = MethodName;
        }

        /// <summary>
        /// Функция создает Методы и их классификацию
        /// </summary>
        public static List<Methods> GetMethods()
        {
            return new List<Methods>
            {
                new Methods("Модификаций Ньютоновских Оптимизационных Процессов","Обобщенный метод Ньютона"),
                new Methods("Модификаций Ньютоновских Оптимизационных Процессов","Метод Ньютона с регулировкой шага"),
                new Methods("Модификаций Ньютоновских Оптимизационных Процессов","Метод Ньютона с с постоянным гессианом"),

                new Methods("Методы Переменной Метрики","Дэвидона-Флетчера-Пауэлла"),
                new Methods("Методы Переменной Метрики","Бройдена-Флетчера-Шенно"),
                new Methods("Методы Переменной Метрики","Бройдена-Флетчера-Гольдфарба-Шенно"),
                new Methods("Методы Переменной Метрики","Мак-Кормика"),
                new Methods("Методы Переменной Метрики","Бройдена"),
                new Methods("Методы Переменной Метрики","Пирсона-2"),
                new Methods("Методы Переменной Метрики","Пирсона-3"),
                new Methods("Методы Переменной Метрики","Проекций Заутендийка"),

                new Methods("Методы Сопряженных Градиентов","Метод Даниела"),
                new Methods("Методы Сопряженных Градиентов","Метод Флетчера-Ривса"),
                new Methods("Методы Сопряженных Градиентов","Метод Полака-Рибьера"),
                new Methods("Методы Сопряженных Градиентов","Метод Диксона"),

            };
        }
    }
}
