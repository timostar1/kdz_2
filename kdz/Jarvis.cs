using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kdz
{
    public delegate void JarvisSimpleEventHandler();
    //public class NewFileCreated
    public static class Jarvis
    {
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
        /// Вызывает событие Jarvis.CarAdded
        /// </summary>
        public static void OnCarAdded()
        {
            Cars.Add(new Model.Car());
            CarAdded();
        }

        /// <summary>
        /// Статический конструктор
        /// </summary>
        static Jarvis()
        {

        }
    }
}
