using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kdz
{
    /// <summary>
    /// Класс, представляющий аргументы событий ошибок класса Jarvis
    /// </summary>
    public class JarvisErrorEventArgs : EventArgs
    {
        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Инициализирует объект класса JarvisErrorEventArgs
        /// </summary>
        public JarvisErrorEventArgs()
        {
            ErrorMessage = null;
        }

        /// <summary>
        /// Инициализирует объект класса JarvisErrorEventArgs
        /// </summary>
        /// <param name="error">Сообщение об ошибке</param>
        public JarvisErrorEventArgs(string error)
        {
            ErrorMessage = error;
        }
    }

    /// <summary>
    /// Класс, представляющий аргументы событий класса Jarvis при работе с файлами
    /// </summary>
    public class JarvisFilesEventArgs : EventArgs
    {
        /// <summary>
        /// Путь к файлу
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Инициализирует объект класса JarvisFilesEventArgs
        /// </summary>
        public JarvisFilesEventArgs()
        {
            FilePath = null;
        }

        /// <summary>
        /// Инициализирует объект класса JarvisFilesEventArgs
        /// </summary>
        /// <param name="filePath">Путь к файлу</param>
        public JarvisFilesEventArgs(string filePath)
        {
            FilePath = filePath;
        }
    }

    /// <summary>
    /// Делегат-тип событий обибок класса Jarvis
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void JarvisErrorEventHandler(object sender, JarvisErrorEventArgs e);

    /// <summary>
    /// Делегат-тип событий обработки файлов класса Jarvis
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void JarvisFilesEventHandler(object sender, JarvisFilesEventArgs e);

    /// <summary>
    /// Делегат-тип простых событий класса Jarvis
    /// </summary>
    public delegate void JarvisSimpleEventHandler();

    public static class Jarvis
    {
        /// <summary>
        /// Автодиллер (для работы со списком машин)
        /// </summary>
        public static Model.Autodiller Autodiller;

        /// <summary>
        /// Список машин
        /// </summary>
        public static List<Model.Car> Cars;

        /// <summary>
        /// Событие создания нового файла
        /// </summary>
        public static event JarvisSimpleEventHandler NewFileCreated;

        /// <summary>
        /// Вызывает событие Jarvis.NewFileCreated
        /// </summary>
        public static void OnNewFileCreated()
        {
            Cars = new List<Model.Car>();
            Cars.Add(new Model.Car());
            NewFileCreated();
        }

        /// <summary>
        /// Событие добавления новой машины в список
        /// </summary>
        public static event JarvisSimpleEventHandler CarAdded;

        /// <summary>
        /// Событие загрузки данных из файла
        /// </summary>
        public static event JarvisFilesEventHandler FileUploaded;

        /// <summary>
        /// Событие ошибки
        /// </summary>
        public static event JarvisErrorEventHandler Error;

        /// <summary>
        /// событие сохранения файла
        /// </summary>
        public static event JarvisSimpleEventHandler FileSaved;

        /// <summary>
        /// Вызывает событие Jarvis.FileSaved
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void OnFileSaved()
        {
            Autodiller.Cars = Cars;
            bool result = Autodiller.Save();
            if (result) FileSaved();
            else Error(null, new JarvisErrorEventArgs("Не удалось сохранить файл"));
        }

        /// <summary>
        /// Вызывает событие Jarvis.Error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void OnError(object sender, JarvisErrorEventArgs e)
        {
            Error(sender, e);
        }

        /// <summary>
        /// Вызывает событие Jarvis.CarAdded
        /// </summary>
        public static void OnCarAdded()
        {
            Cars.Add(new Model.Car());
            CarAdded();
        }

        /// <summary>
        /// Вызывает событие Jarvis.FileUploaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void OnFileUploaded(object sender, JarvisFilesEventArgs e)
        {
            try
            {
                Autodiller = new Model.Autodiller(e.FilePath);
                Cars = Autodiller.Cars;
                FileUploaded(sender, e);
            }
            catch
            {
                Error(sender, new JarvisErrorEventArgs("Файл является некорректным"));
            }
        }

        /// <summary>
        /// Статический конструктор
        /// </summary>
        static Jarvis()
        {

        }
    }
}
