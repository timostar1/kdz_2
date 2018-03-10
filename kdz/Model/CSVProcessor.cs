using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Globalization;

namespace kdz.Model
{
    public class CSVProcessor
    {
        private string _path;
        private string _headerParrern;
        public CSVProcessor(string filePath, string headerPattern=null, bool isNew=true)
        {
            if (File.Exists(filePath) & !isNew & headerPattern != null)
            {
                this._path = filePath;
                this._headerParrern = headerPattern;
            }
            else if (isNew)
            {
                this._path = filePath;
                this._headerParrern = headerPattern;
            }
            else
            {
                throw new FileNotFoundException("Не удалось открыть файл...");
            }
        }

        /// <summary>
        /// Итератор, возвращающий записи в CSV файле, преобразованные к типу T
        /// </summary>
        /// <typeparam name="T">Тип, в который будут записаны данные из файла</typeparam>
        /// <returns>Заполненный данными объект T</returns>
        public IEnumerable<T> GetRecords<T>() where T : IFromCSVReadable, new()
        {
            using (StreamReader reader = new StreamReader(this._path))
            {
                if (!reader.EndOfStream)
                {
                    string header = reader.ReadLine();
                    if (header != this._headerParrern)
                    {
                        throw new ArgumentException($"file {this._path} is invalid", "file");
                    }
                }

                T record;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    List<string> values = line.Split(',').ToList();
                    record = new T();
                    record.SetFromStringList(values, CultureInfo.GetCultureInfo("en-US"));
                    yield return record;
                }
            }
        }

        /// <summary>
        /// Записывает список объектов типа T в CSV файл
        /// </summary>
        /// <typeparam name="T">Тип записываемых объектов</typeparam>
        /// <param name="records">Список объектов для записи</param>
        /// <returns>Результат операции</returns>
        public bool TrySaveRecords<T>(List<T> records)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(this._path))
                {
                    if (this._headerParrern != null)
                    {
                        writer.WriteLine(this._headerParrern);
                    }
                    foreach (T item in records)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
