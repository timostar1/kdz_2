using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kdz.Model
{
    class Autodiller
    {
        /// <summary>
        /// Список машин
        /// </summary>
        private List<Car> _cars;
        /// <summary>
        /// Свойство списка машин
        /// </summary>
        public List<Car> Cars { get => this._cars; }

        /// <summary>
        /// Инициализирует объект класса Autodiller
        /// </summary>
        public Autodiller()
        {
            this._cars = new List<Car>();
        }

        /// <summary>
        /// Инициализирует объект класса Autodiller
        /// </summary>
        /// <param name="filePath">путь к CSV файлу</param>
        public Autodiller(string filePath)
        {
            string header = "";
            CSVProcessor processor;
            try
            {
                processor = new CSVProcessor(filePath, header);
                try
                {
                    this._cars = processor.GetRecords<Car>().ToList();
                }
                catch (ArgumentException e)
                {
                    // TODO
                }
            }
            catch
            {
                // TODO
            }
        }
    }
}
