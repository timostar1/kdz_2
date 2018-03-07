using System;
using System.Collections.Generic;
using System.Globalization;
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
        private CarAttribute<int> _cyl;
        /// <summary>
        /// Свойство количества цилиндров
        /// </summary>
        public CarAttribute<int> Cyl { get => this._cyl; }

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

        /// <summary>
        ///  Инициализирунт объект класса Car
        /// </summary>
        public Car()
        {
            this._model = "";
            this._mpg = new CarAttribute<double>(0.1, 100.0);
            this._cyl = new CarAttribute<int>(1, 24);
            this._disp = new CarAttribute<double>(0.1, 1000.0);
            this._hp = new CarAttribute<double>(1.0, 2000.0);
            this._drat = new CarAttribute<double>(0.1, 10.0);
            this._wt = new CarAttribute<double>(0.1, 100.0);
            this._qsec = new CarAttribute<double>(5.0, 100.0);
            this._vs = new CarAttribute<int>(0, 1);
            this._am = new CarAttribute<int>(0, 1);
            this._gear = new CarAttribute<int>(1, 10);
            this._carb = new CarAttribute<int>(1, 24);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <param name="cultureInfo">Информация о языке</param>
        public void SetFromStringList(List<string> values, CultureInfo cultureInfo)
        {
            this._model = values[0];
            this._mpg.ConvertFromText(values[1]);
            this._cyl.ConvertFromText(values[2]);
            this._disp.ConvertFromText(values[3]);
            this._hp.ConvertFromText(values[4]);
            this._drat.ConvertFromText(values[5]);
            this._wt.ConvertFromText(values[6]);
            this._qsec.ConvertFromText(values[7]);
            this._vs.ConvertFromText(values[8]);
            this._am.ConvertFromText(values[9]);
            this._gear.ConvertFromText(values[10]);
            this._carb.ConvertFromText(values[11]);
        }

        public override string ToString()
        {
            string res = String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11}",
                Model, Mpg.ToString(), Cyl.ToString(), Disp.ToString(), Hp.ToString(), Drat.ToString(),
                Wt.ToString(), Qsec.ToString(), Vs.ToString(), Am.ToString(), Gear.ToString(), Carb.ToString());
            return res;
        }
    }
}
