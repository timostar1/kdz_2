using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kdz.Model;

namespace kdz.Model
{
    public class Car: IFromCSVReadable
    {
        /// <summary>
        /// Модель автомобиля
        /// </summary>
        private string _model;
        /// <summary>
        /// Свойство модели
        /// </summary>
        public string Model { get => this._model; }

        /// <summary>
        /// Miles per (US) gallon
        /// </summary>
        private CarAttribute<double> _mpg;
        /// <summary>
        /// Miles per (US) gallon property
        /// </summary>
        public CarAttribute<double> Mpg { get => this._mpg; }

        /// <summary>
        /// Количество цилиндров
        /// </summary>
        private CarAttribute<double> _cyl;
        /// <summary>
        /// Свойство количества цилиндров
        /// </summary>
        public CarAttribute<double> Cyl { get => this._cyl; }

        /// <summary>
        /// Объем цилиндра (кубические дюймы)
        /// </summary>
        private CarAttribute<double> _disp;
        /// <summary>
        /// Свойство объема цилиндра
        /// </summary>
        public CarAttribute<double> Disp { get => this._disp; }

        /// <summary>
        /// Количество лошадиных сил
        /// </summary>
        private CarAttribute<double> _hp;
        /// <summary>
        /// Свойство количества лошадиных сил
        /// </summary>
        public CarAttribute<double> Hp { get => this._hp; }

        /// <summary>
        /// Rear axle ratio
        /// </summary>
        private CarAttribute<double> _drat;
        /// <summary>
        /// Rear axle ratio property
        /// </summary>
        public CarAttribute<double> Drat { get => this._drat; }

        /// <summary>
        /// Вес в тыс. фунтов
        /// </summary>
        private CarAttribute<double> _wt;
        /// <summary>
        /// Свойство веса
        /// </summary>
        public CarAttribute<double> Wt { get => this._wt; }

        /// <summary>
        /// Время прохождения 1/4 мили
        /// </summary>
        private CarAttribute<double> _qsec;
        /// <summary>
        /// Свойство времени прохождения 1/4 мили
        /// </summary>
        public CarAttribute<double> Qsec { get => this._qsec; }

        /// <summary>
        /// V/S (read https://stackoverflow.com/questions/18617174/r-mtcars-dataset-meaning-of-vs-variable)
        /// </summary>
        private CarAttribute<int> _vs;
        /// <summary>
        /// V/S property
        /// </summary>
        public CarAttribute<int> Vs { get => this._vs; }

        /// <summary>
        /// Трансмиссия
        /// </summary>
        private CarAttribute<int> _am;
        /// <summary>
        /// Свойство трансмиссии (0 = automatic, 1 = manual)
        /// </summary>
        public CarAttribute<int> Am { get => this._am; }

        /// <summary>
        /// Количество передних передач
        /// </summary>
        private CarAttribute<int> _gear;
        /// <summary>
        /// Свойство количества передних передач
        /// </summary>
        public CarAttribute<int> Gear { get => this._gear; }

        /// <summary>
        /// Количество карбюраторов
        /// </summary>
        private CarAttribute<int> _carb;
        /// <summary>
        /// Свойство количества карбюраторов
        /// </summary>
        public CarAttribute<int> Carb { get => this._carb; }

        public Car()
        {
        }

        public void SetFromList<T>(List<T> values)
        {
            throw new NotImplementedException();
        }
    }
}
