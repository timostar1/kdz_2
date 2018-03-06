using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kdz.Model
{
    /// <summary>
    /// Интерфейс, представляющий возможность конвертации данных из текта
    /// </summary>
    /// <typeparam name="T">Тип, к которому нужно преобразовать текст</typeparam>
    public interface IFromTextConvertable<T>
    {
        /// <summary>
        /// Статус валидности данных
        /// </summary>
        bool Valid { get; }

        /// <summary>
        /// Метод, преобразующий текстовые данные к типу T
        /// </summary>
        /// <param name="text">Текстовые данные</param>
        /// <param name="result">Данные в требуемом формате</param>
        /// <returns>Статус операции</returns>
        bool ConvertFromText(string text, out T result);
    }
}
