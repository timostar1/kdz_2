using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kdz.Model
{
    /// <summary>
    /// Класс, позволяющий производить различные операции над моделью
    /// </summary>
    public class Autodiller
    {
        /// <summary>
        /// Список машин
        /// </summary>
        private List<Car> _cars;
        /// <summary>
        /// Свойство списка машин
        /// </summary>
        public List<Car> Cars { get => this._cars; set => this._cars = value; }

        public CSVProcessor Processor { get; }

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
            string header = "\"model\",\"mpg\",\"cyl\",\"disp\",\"hp\",\"drat\",\"wt\",\"qsec\",\"vs\",\"am\",\"gear\",\"carb\"";
            Processor = new CSVProcessor(filePath, header);
            this._cars = Processor.GetRecords<Car>().ToList();
        }

        public bool Save()
        {
            return Processor.TrySaveRecords(this._cars);
        }
    }
}
