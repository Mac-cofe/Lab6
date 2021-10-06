using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фразу. Проверим, является ли она палиндромом");
            StringBuilder startText = new StringBuilder(Console.ReadLine());
            StringBuilder itogText = new StringBuilder();
            startText = startText.Replace(" ", "");  // удаляем пробелы в исходной строке
            for (int i = startText.Length - 1; i > -1; i--)
            {
                itogText.Append(startText[i], 1);      //записывает перевернутую строку в переменную itogText
            }
            if (itogText.Equals(startText))                // сравниваем итоговую и перевернутую строки
                Console.WriteLine("Эта фраза палиндром");
            else
                Console.WriteLine("Эта фраза не палиндром");
            //Console.WriteLine(" - {0}", startText);    // вывод исходного текста
            //Console.WriteLine(" - {0}", itogText);     // вывод перевернутого текста
            Console.ReadKey();
        }

    }
}
