using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        //Метод находит самое длинное слово во введенном предложении, в котором
        //слова разделены пробелом, знаки препинания не используются
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите предложение: ");
            string dann = Console.ReadLine();
            string[] strArr = dann.Split();
            string max = strArr[0];

            foreach (string s in strArr)
            {
                if (s.Length > max.Length)
                {
                    max = s;
                }
            }
            Console.WriteLine("Самое длинное слово в предложении: {0}", max);
            Console.ReadKey();
        }
    }
}
