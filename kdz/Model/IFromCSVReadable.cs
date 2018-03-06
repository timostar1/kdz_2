using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kdz.Model
{
    /// <summary>
    /// Интерфейс, позволяющий заполнить поля 
    /// класса при считывании CSV файла
    /// </summary>
    public interface IFromCSVReadable
    {
        /// <summary>
        /// Функция, позволяющая заполнить поля
        /// класса-наследника значениями из списка
        /// </summary>
        /// <typeparam name="T">Тип списка</typeparam>
        /// <param name="values">Список значений для заполнения полей</param>
        void SetFromList<T>(List<T> values);
    }
}
