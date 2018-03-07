using System;
using System.Collections.Generic;
using System.Globalization;
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
        /// Преобразует текст к нужному значению
        /// </summary>
        /// <param name="text">текстовые данные</param>
        /// <param name="cultureInfo">Информация о языке</param>
        void ConvertFromText(string text, CultureInfo cultureInfo);
    }
}
