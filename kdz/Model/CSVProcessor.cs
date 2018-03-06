using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;

namespace kdz.Model
{
    public class CSVProcessor
    {
        private string _path;
        private string _headerParrern;
        public CSVProcessor(string filePath, string headerPattern)
        {
            if (File.Exists(filePath))
            {
                this._path = filePath;
                this._headerParrern = headerPattern;
            }
            else
            {
                throw new FileNotFoundException("Не удалось найти файл по данному пути");
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
                    record.SetFromList<string>(values);
                    yield return record;
                }
            }
        }
    }
}
