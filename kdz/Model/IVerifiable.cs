using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kdz.Model
{
    /// <summary>
    /// Интерфейс, представляющий верифицируемые данные
    /// </summary>
    /// <typeparam name="T">Верифицируемый тип</typeparam>
    public interface IVerifiable<T> where T : IComparable
    {
        /// <summary>
        /// Область допустимых значений
        /// </summary>
        RangeOfPermissibleValues<T> PermissibleValues { get; }

        /// <summary>
        /// Статус корректности данных
        /// </summary>
        bool Correct { get; }

        /// <summary>
        /// Метода, проверяющий корректность данных
        /// </summary>
        /// <param name="value">Проверяемое значение</param>
        /// <returns>Статус проверки</returns>
        bool IsCorrect(T value);
    }
}
