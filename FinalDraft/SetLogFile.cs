using System;
using System.IO;
namespace LogFile
{
    class SetLogFile
    {

        string[] Top = new string[] { "Исходная функция", "Метод одномерной оптимизации", "Метод многомерной оптимизации", "Начальная точка", "Точность поиска", "Количество итераций", "Найденный минимум", "Истинный минимум"};

        /// <summary>
        /// Путь, где будет создан файл
        /// </summary>
        string myDocsPath;


        /// <summary>
        /// Создание файла с текщим именем
        /// </summary>
        string logFilePath;


        /// <summary>
        /// Создания файла в папке Мои документы
        /// </summary>
        public SetLogFile()
        {
            myDocsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            logFilePath = Path.Combine(myDocsPath, "Method.csv");
        }


        /// <summary>
        /// Запись текста в файл
        /// </summary>
        public void Write(string message)
        {
            File.AppendAllText(logFilePath, message);
        }


        /// <summary>
        /// Переход на новую строку при записи в файл
        /// </summary>
        public void WriteLine()
        {
            File.AppendAllText(logFilePath, "" + Environment.NewLine);
        }
    }
}
