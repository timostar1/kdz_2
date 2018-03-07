using System;
using System.Collections.Generic;
using System.Globalization;
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
        /// класса-наследника значениями из списка строк
        /// </summary>
        /// <param name="values">Список строк для заполнения полей</param>
        /// <param name="cultureInfo">Информация о языке</param>
        void SetFromStringList(List<string> values, CultureInfo cultureInfo);
    }
}
