using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kdz.Model
{
    /// <summary>
    /// Обобщенный тип, представляющий свойства автомобилей
    /// </summary>
    /// <typeparam name="T">Тип значения свойства</typeparam>
    public class CarAttribute<T> : IFormattable, IComparable, IVerifiable<T>, IFromTextConvertable<T>
        where T : IFormattable, IComparable, new()
    {
        private RangeOfPermissibleValues<T> _permissibleValues;
        /// <summary>
        /// Свойство области допустимых значений
        /// </summary>
        public RangeOfPermissibleValues<T> PermissibleValues { get => this._permissibleValues; }

        private bool _correct;
        /// <summary>
        /// Свойство корректности значения
        /// </summary>
        public bool Correct { get => this._correct; }

        private bool _valid;
        /// <summary>
        /// Свойство валидности значения
        /// </summary>
        public bool Valid { get => this._valid; }

        private T _value;
        /// <summary>
        /// Значение атрибута машины
        /// </summary>
        public T Value { get => this._value; }

        /// <summary>
        /// Инициализирует новый экземпляр класса CarAttribute
        /// </summary>
        public CarAttribute()
        {
            this._correct = false;
            this._permissibleValues = null;
            this._valid = false;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса CarAttribute
        /// </summary>
        /// <param name="text">Данные в текстовой форме</param>
        /// <param name="permissibleValues">Объект RangeOfPermissibleValues - ОДЗ</param>
        public CarAttribute(string text, RangeOfPermissibleValues<T> permissibleValues=null)
        {
            this._permissibleValues = permissibleValues;
            T value = new T();
            ConvertFromText(text);
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса CarAttribute
        /// </summary>
        /// <param name="text">Данные в текстовой форме</param>
        /// <param name="minValue">Минимальное допустимое значение (будет включено)</param>
        /// <param name="maxValue">Максимальное допустимое значение (будет включено)</param>
        public CarAttribute(string text, T minValue, T maxValue)
        {
            this._permissibleValues = new RangeOfPermissibleValues<T>(minValue, maxValue);
            T value = new T();
            ConvertFromText(text);
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса CarAttribute
        /// </summary>
        /// <param name="text">Данные в текстовой форме</param>
        /// <param name="permissibleValues">Список допустимых значений</param>
        public CarAttribute(string text, List<T> permissibleValues)
        {
            this._permissibleValues = new RangeOfPermissibleValues<T>(permissibleValues);
            T value = new T();
            ConvertFromText(text);
        }

        /// <summary>
        /// Реализация интерфейса IComparable
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Реализация интерфейса IFormattable
        /// </summary>
        /// <param name="format"></param>
        /// <param name="formatProvider"></param>
        /// <returns></returns>
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (formatProvider == null)
            {
                formatProvider = CultureInfo.GetCultureInfo("en-US");
            }
            if (this.Valid)
            {
                if (this.Correct) return this.Value.ToString(format, formatProvider);
                else return "NA";
            }
            else return "Error";
        }

        public override string ToString()
        {
            return $"{this}";
        }

        /// <summary>
        /// Проверяет данные на корректность
        /// </summary>
        /// <param name="value">проверяемое значение</param>
        /// <returns>Статус проверки</returns>
        public bool IsCorrect(T value)
        {
            if (this.PermissibleValues == null) return true;
            else return this.PermissibleValues.In(value);
        }

        /// <summary>
        /// Преобразует текст к нужному значению,
        /// устанавливает свойства Valid, Correct, Value
        /// </summary>
        /// <param name="text">текстовые данные</param>
        public void ConvertFromText(string text)
        {
            text = text.Trim('"', ' ');
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
            try
            {
                this._value = (T)converter.ConvertFromString(text);
                this._valid = true;
                this._correct = Valid && IsCorrect(Value);
            }
            catch
            {
                this._value = new T();
                this._valid = false;
                this._correct = false;
            }
        }
    }
}
