using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение из нескольких слов, знаки препинания не использовать ");
            string startText = Console.ReadLine();
            string[] textArray = startText.Split();

            string maxWord = "";
            string minWord = "";
            int k = 0;
            int m = startText.Length;

            foreach (string s in textArray)
            {
                if (s.Length > k)
                {
                    if (s.Length > k)
                    {
                        k = s.Length;
                        maxWord = s;
                    }
                    if (s.Length < m)
                    {
                        m = s.Length;
                        minWord = s;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Максимальное по длине слово в этой фразе - {0}, его длина {1} символа(ов) ",maxWord, k);
            Console.WriteLine("Самое короткое по длине слово в этой фразе - {0}, его длина {1} символа(ов) ", minWord, m);
            Console.ReadKey();


        }
    }
}
