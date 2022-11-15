using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //номер 1.4
            /* WriteLine("введите x =");
             int x = Convert.ToInt32(Console.ReadLine());
            /* double y = x >= 0 ? Math.Sqrt(Math.Pow(x, 2) - 1) : Math.Pow(x, 2) + 25;
             WriteLine($"y ={y}");*/

            //номер 2.4

            /*if (x < -5) 
             {
                 double y = 12 + Math.Sqrt(13 - 5 * x);
                 WriteLine($"y = {y}");
             }
             else if (x >= -5 && x <= 5)
             {
                 double y = Math.Cos(4 * x) + (x / 5);
                 WriteLine($"y = {y}");
             }
            else
             {
                 double y = Math.Sin(8 * x) - Math.Abs(x - 12);
                 WriteLine($"y = {y} ");
             }*/

            //задача 5

            /* Write("Введите номер месяца:");
             string month = ReadLine();
             switch (month)
             {
                 case "1":
                     WriteLine("Зима, январь, 2 семестр ");
                     break;

                 case "2":
                     WriteLine("Зима, февраль, 2 семестр");
                     break;
                 case "3":
                     WriteLine("Весна, март, 2 семестр");
                     break;
                 case"4":
                     WriteLine("Весна, апрель, 2 семестр");
                     break;
                 case "5":
                     WriteLine("Весна, май, 2 семестр");
                     break;
                 case "6":
                     WriteLine("Лето, июнь, СЕССИЯ!!!");
                     break;
                 case "7":
                     WriteLine("Лето, июль, каникулы");
                     break;
                 case "8":
                     WriteLine("Лето, август, еще каникулы))");
                     break;
                 case "9":
                     WriteLine("Осень, сентябрь, начало учебы, 1 семестр :(( ");
                     break;
                 case "10":
                     WriteLine("Осень, октябрь, 1 семестр");
                     break;
                 case "11":
                     WriteLine("Осень, ноябрь, 1 семестр");
                     break;
                 case "12":
                     WriteLine("Зима, декабрь, 1 семестр");
                     break;
             }*/

            //задача 6

            /*Write("Введите рост(в см):");
            int height = Convert.ToInt32(ReadLine());
            Write("Введите вес(в кг)");
            int weight = Convert.ToInt32(ReadLine());
            int normal = height - 100;
            int normal1 = normal + (height % 10);
            int normal2 = normal - (height % 10);
            if (weight > normal1)
            {
                WriteLine("Вам пора худеть");
            }
            else if (weight < normal1 && weight > normal2)
            {
                WriteLine("Ваш вес в пределах нормы");
            }
            else
            {
                WriteLine("Вам надо набирать массу");
            }*/
            //задача 7
           /* Write("введите первую букву предмета(ф,м,и,г,б):");
            char predmet = Convert.ToChar(Read());
            switch (predmet)
            {
                case 'ф':
                    WriteLine("физика");
                    break;
                case 'м':
                    WriteLine("математика");
                    break;
                case 'г':
                    WriteLine("география");
                    break;
                case 'и':
                    WriteLine("история");
                    break;
                case 'б':
                    WriteLine("биология");
                    break;
            }*/

            ReadKey();

        }
    }
}
