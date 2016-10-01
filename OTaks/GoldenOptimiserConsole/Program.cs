#define ConsoleApp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptimisationTasks.DataStructures;
using OptimisationTasks.OptimisationMethods;

namespace GoldenOptimiserConsole
{
    class Program
    {
        static void Main ( string [ ] args )
        {
            Console.Write("Введите отрезок, на котором искать оптимум(В форме [a;b] или a;b: ");
            string interval = Console.ReadLine();
            Interval inter = new Interval(interval);
            OptKind kind = OptKind.NotSet;
            Console.WriteLine("Выберите вид оптимума:");
            Console.WriteLine("1.Максимум" + Environment.NewLine + "2.Минимум");
            int choice;
            do
            {
                Console.Write("Ваш выбор: ");
                choice = int.Parse(Console.ReadLine());
                switch ( choice )
                {
                    case 1: kind = OptKind.Maximum;
                            break;
                    case 2: kind = OptKind.Minimum;
                        break;
                    default:
                        Console.WriteLine("Неверное значение");
                        break;
                }
            } while (!( ( choice == 1 ) || ( choice == 2 ) )); 
            Console.Write("Введите имя переменной: ");
            string vName = Console.ReadLine();

            var optimiser = new GoldenPropOptimisator();
            Console.Write("Введите функцию, которую будем оптимизировать: ");
            var func = Console.ReadLine();
            var t = new Task1D(func, kind, vName, inter);
            Console.WriteLine(optimiser.Optimise(t));
            Console.ReadLine();
        }
        

    }
}
