using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kdz.Model;
using CsvHelper;
using System.IO;
using System.ComponentModel;
using System.Globalization;

namespace kdz_2
{
    class En
    {
        private int[] ints = {1, 2, 3, 4, 6, 7, 8};
        private int index = -1;

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < ints.Length; i++)
            {
                if (i == 5) yield break;
                yield return ints[i];
            }
        }
    }
    class M : IEnumerable, IEnumerator
    {
        private List<int> ints = new List<int>();
        private int index = -1;

        public void Add(int x)
        {
            ints.Add(x);
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (index == ints.Count - 1)
            {
                Reset();
                return false;
            }

            index++;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }

        public object Current
        {
            get
            {
                return ints[index];
            }
        }
    }
    class Program
    {
        static IEnumerator<int> GetIntervalled(List<int> Collection)
        {
            for (int i = 0; i < Collection.Count; i++)
            {
                yield return Collection[i];
            }
        }
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Тимофей\\Documents\\!ТИМА\\УНИВЕР\\!ПРЕДМЕТЫ\\Программирование\\КДЗ_2\\mtcars.csv";
            int[] arr = { 1, 2, 3 };
            //CSVProcessor processor = new CSVProcessor(path);
            //foreach (string str in processor)
            //{
            //    Console.WriteLine(str);
            //}
            using (StreamReader reader = new StreamReader(path))
            {
                CsvReader r = new CsvReader(reader);
                //while (r.Read())
                //{
                //    //var record = r.GetRecord<Car>();
                //    Console.WriteLine(r.);
                //}
                //Console.WriteLine(r.GetRecords);
            }
            //TypeConverter converter = TypeDescriptor.GetConverter(typeof(int));
            CarAttribute<double> attr = new CarAttribute<double>(-1.0, 15.0, "1,9");
            Car car = new Car();
            string str = "\"Mazda RX4\",21,6,160,110,3.9,2.62,16.46,0,1,4,4";
            List<string> l = str.Split(',').ToList<string>();

            //Console.WriteLine("13".T)
            car.SetFromStringList(l, CultureInfo.GetCultureInfo("en-US"));
            Console.WriteLine(car);
            Console.WriteLine(attr);
        }
    }
}
