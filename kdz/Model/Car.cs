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
        /// Информация о языке
        /// </summary>
        private CultureInfo cultureInfo;

        /// <summary>
        /// Марка
        /// </summary>
        private string _mark;
        /// <summary>
        /// Свойство марки
        /// </summary>
        public string Mark { get => this._mark; set => this._mark = value; }

        /// <summary>
        /// Модель автомобиля
        /// </summary>
        private string _model;
        /// <summary>
        /// Свойство модели
        /// </summary>
        public string Model { get => this._model; set => _model = value; }

        /// <summary>
        /// Miles per (US) gallon
        /// </summary>
        private CarAttribute<double> _mpg;
        /// <summary>
        /// Miles per (US) gallon property
        /// </summary>
        //public CarAttribute<double> Mpg { get => this._mpg; }
        public string Mpg
        {
            get { return this._mpg.ToString(); }
            set { this._mpg.ConvertFromText(value, this.cultureInfo); }
        }

        /// <summary>
        /// Количество цилиндров
        /// </summary>
        private CarAttribute<int> _cyl;
        /// <summary>
        /// Свойство количества цилиндров
        /// </summary>
        public string Cyl
        {
            get { return this._cyl.ToString(); }
            set { this._cyl.ConvertFromText(value, this.cultureInfo); }
        }

        /// <summary>
        /// Объем цилиндра (кубические дюймы)
        /// </summary>
        private CarAttribute<double> _disp;
        /// <summary>
        /// Свойство объема цилиндра
        /// </summary>
        public string Disp
        {
            get { return this._disp.ToString(); }
            set { this._disp.ConvertFromText(value, this.cultureInfo); }
        }

        /// <summary>
        /// Количество лошадиных сил
        /// </summary>
        private CarAttribute<double> _hp;
        /// <summary>
        /// Свойство количества лошадиных сил
        /// </summary>
        public string Hp
        {
            get { return this._hp.ToString(); }
            set { this._hp.ConvertFromText(value, this.cultureInfo); }
        }

        /// <summary>
        /// Rear axle ratio
        /// </summary>
        private CarAttribute<double> _drat;
        /// <summary>
        /// Rear axle ratio property
        /// </summary>
        public string Drat
        {
            get { return this._drat.ToString(); }
            set { this._drat.ConvertFromText(value, this.cultureInfo); }
        }

        /// <summary>
        /// Вес в тыс. фунтов
        /// </summary>
        private CarAttribute<double> _wt;
        /// <summary>
        /// Свойство веса
        /// </summary>
        public string Wt
        {
            get { return this._wt.ToString(); }
            set { this._wt.ConvertFromText(value, this.cultureInfo); }
        }

        /// <summary>
        /// Время прохождения 1/4 мили
        /// </summary>
        private CarAttribute<double> _qsec;
        /// <summary>
        /// Свойство времени прохождения 1/4 мили
        /// </summary>
        public string Qsec
        {
            get { return this._qsec.ToString(); }
            set { this._qsec.ConvertFromText(value, this.cultureInfo); }
        }

        /// <summary>
        /// V/S (read https://stackoverflow.com/questions/18617174/r-mtcars-dataset-meaning-of-vs-variable)
        /// </summary>
        private CarAttribute<int> _vs;
        /// <summary>
        /// V/S property
        /// </summary>
        public string Vs
        {
            get { return this._vs.ToString(); }
            set { this._vs.ConvertFromText(value, this.cultureInfo); }
        }

        /// <summary>
        /// Трансмиссия
        /// </summary>
        private CarAttribute<int> _am;
        /// <summary>
        /// Свойство трансмиссии (0 = automatic, 1 = manual)
        /// </summary>
        public string Am
        {
            get { return this._am.ToString(); }
            set { this._am.ConvertFromText(value, this.cultureInfo); }
        }

        /// <summary>
        /// Количество передних передач
        /// </summary>
        private CarAttribute<int> _gear;
        /// <summary>
        /// Свойство количества передних передач
        /// </summary>
        public string Gear
        {
            get { return this._gear.ToString(); }
            set { this._gear.ConvertFromText(value, this.cultureInfo); }
        }

        /// <summary>
        /// Количество карбюраторов
        /// </summary>
        private CarAttribute<int> _carb;
        /// <summary>
        /// Свойство количества карбюраторов
        /// </summary>
        public string Carb
        {
            get { return this._carb.ToString(); }
            set { this._carb.ConvertFromText(value, this.cultureInfo); }
        }

        /// <summary>
        ///  Инициализирунт объект класса Car
        /// </summary>
        public Car()
        {
            this._mark = "mark";
            this._model = "model";
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
            this.cultureInfo = cultureInfo;
            string[] markModel = values[0].Trim('"').Split(' ');
            this._mark = markModel[0];
            this._model = markModel.Length > 1 ? markModel[1] : "model";
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

        /// <summary>
        /// Сздает текстовое представление объекта класса Car
        /// </summary>
        /// <returns>Стрка - представление объекта класса Car</returns>
        public override string ToString()
        {
            string res = String.Format("\"{12} {0}\", {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}",
                Model, Mpg.ToString(), Cyl.ToString(), Disp.ToString(), Hp.ToString(), Drat.ToString(),
                Wt.ToString(), Qsec.ToString(), Vs.ToString(), Am.ToString(), Gear.ToString(), Carb.ToString(), Mark);
            return res;
        }
    }
}
