using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGA_Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fio = new string[30];
            string[] post = new string[30];
            int number;
            int i = 0;
        restart:
            Console.WriteLine("Отдел кадров");
            Console.WriteLine("1 - Добавить досье");
            Console.WriteLine("2 - Вывести все досье");
            Console.WriteLine("3 - Удалить досье");
            Console.WriteLine("4 - Поиск по фамилии");
            Console.WriteLine("5 - Выход\n");
            Console.Write("Выберите пункт меню: ");
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Вы ввели неправильное значение!");
                Restart();
                goto restart;
            }
            switch (number)
            {
                case 1:
                    AddDossier();
                    break;
                case 2:
                    ShowDossier();
                    break;
                case 3:
                    DeleteDossier();
                    break;
                case 4:
                    SearchSurname();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Таково пункта меню нет!");
                    break;
            }
            Restart();
            goto restart;
        }
        static void Restart()
        {
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
