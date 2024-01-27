using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_3
{
    class Program
    {
        //Метод удаляет из заданной строки текст, заключенный в фигурные скобки
        //В строке может быть несколько таких фрагментов, могут быть вложенные фрагменты
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string s = Console.ReadLine();

            string rez = "";

            bool pausa = false;
            int kolvoSk = 0;    //кол-во открывающихся фигурных скобок

            //  string ch = s.Substring(i);

            for (int i = 0; i < s.Length; i++)      //проверяем совпадение по-символьно
            {
                if (s.Substring(i, 1) == "{")
                {
                    kolvoSk++;
                    if (kolvoSk == 1)               //если скобка первая - ставим запись на паузу
                    {
                        pausa = true;
                    }
                }
                else if (s.Substring(i, 1) == "}")
                {
                    kolvoSk--;
                    if (kolvoSk == 0)               //если все скобки закрылись - снимаем паузу
                    {
                        pausa = false;
                    }
                }
                else
                {
                    if (!pausa)
                    {
                        rez = rez + s.Substring(i, 1);
                    }

                }
            }



            Console.WriteLine(rez);
            Console.ReadKey();

        }
    }
}
