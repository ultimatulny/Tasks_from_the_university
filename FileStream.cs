using System;
using System.IO;
using System.Text;

namespace JustFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // Кодировка для вывода в консоли

            string path = @"E:\test\file.txt"; // Создание переменной, которая будет хранить путь к файлу

            using (var sw = new StreamWriter(path, true, Encoding.UTF8)) // Запись в файл строки "Hello" n раз, т.к. есть true
            {
                sw.Write("Hello!");
            }

            using (var sr = new StreamReader(path, Encoding.UTF8)) // Чтение файла
            {
                var text = sr.ReadToEnd();
                Console.WriteLine(text);
            }
        }
    }
}
