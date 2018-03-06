using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kdz.Model
{
    /// <summary>
    /// Обобщенный класс Области Допустимых Значений
    /// </summary>
    /// <typeparam name="T">Тип объектов области</typeparam>
    public class RangeOfPermissibleValues<T> where T : IComparable
    {
        /// <summary>
        /// Конструктор без параметров (вызовет исключение)
        /// </summary>
        public RangeOfPermissibleValues()
        {
            throw new ArgumentException("Не обнаружено аргументов для задания ОДЗ");
        }

        /// <summary>
        /// Конструктор, задающий список допустимых значений
        /// </summary>
        /// <param name="permissibleValues">
        /// Список допустимых значений
        /// </param>
        public RangeOfPermissibleValues(List<T> permissibleValues)
        {
            this.valuesList = permissibleValues;
        }

        /// <summary>
        /// Конструктор, задающий ограничения ОДЗ
        /// </summary>
        /// <param name="minValue">Минимальное значение (будет включено)</param>
        /// <param name="maxValue">Максимальное значение (будет включено)</param>
        public RangeOfPermissibleValues(T minValue, T maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        /// <summary>
        /// Список допустимых значений
        /// </summary>
        private List<T> valuesList = null;

        /// <summary>
        /// Минимальное возможное значение
        /// </summary>
        private T minValue;

        /// <summary>
        /// Максимальное возможное значение
        /// </summary>
        private T maxValue;

        /// <summary>
        /// Определяет, находится ли элемент в области допустимых значений
        /// </summary>
        /// <param name="element">Элемент, проверяемый на вхождение в ОДЗ</param>
        /// <returns>Статус проверки</returns>
        public bool In(T element)
        {
            if (valuesList != null)
            {
                return valuesList.Contains(element);
            }
            else
            {
                return element.CompareTo(minValue) != -1 && element.CompareTo(maxValue) != 1;
            }
        }
    }
}
