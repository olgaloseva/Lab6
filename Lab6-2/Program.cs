using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    class Program
    {
        //Метод определяет является ли введенная фраза палиндромом (без учета пробелов и регистра)
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите предложение: ");
            string dann = Console.ReadLine();
            dann = dann.ToLower();   //приводим к одному регистру и убираем пробелы
            dann = dann.Replace(" ", "");

            string invertDann = "";

            foreach (char c in dann)        //переворачиваем фразу
            {
                invertDann = c + invertDann;
            }

            bool palindr = true;
            string d, inv;

            for (int i = 0; i < dann.Length; i++)   //проверяем совпадение по-символьно
            {
                d = dann.Substring(i);
                inv = invertDann.Substring(i);
                if (d != inv)
                {
                    palindr = false;
                    break;
                }
            }

            if (palindr)
            {
                Console.Write("Фраза является палиндромом");
            }
            else
            {
                Console.Write("Фраза не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
