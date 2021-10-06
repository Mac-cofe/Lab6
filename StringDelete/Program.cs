using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку символов, кроме букв или цифр используйте { и }");
            String startText = Console.ReadLine();
            String itogText = "";
            int kol_a = 0;   //количество {
            int kol_b = 0;   //количество }
            int first = 0;   // позиция первой {
            int last = 0;    // позиция первой }
            int count = 0;   // количество символов между { }
            foreach (char c in startText) // проверяем есть ли { } и сколько их
            {
                if (c == '{')
                    kol_a++;
                if (c == '}')
                    kol_b++;
            }
            if (kol_a == 0 && kol_b == 0)
            {
                Console.WriteLine("В данной строке нет фигурных скобок");
            }
            else
            {
                Console.WriteLine("В данной строке {{ - {0} , а }} - {1}", kol_a, kol_b);
                first = startText.IndexOf("{");
                last = startText.IndexOf("}");
                if (last > 0)
                {
                    count = last - first;
                    itogText = startText.Remove(first, count + 1);
                }
                else
                    itogText = startText;
                Console.WriteLine("Исходная строка - {0}", startText);
                Console.WriteLine("Итоговая строка - {0}", itogText);
            }
            Console.ReadKey();
        }
    }
}
