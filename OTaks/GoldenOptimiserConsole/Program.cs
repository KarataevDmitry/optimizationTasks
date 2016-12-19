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
            Console.Write("Введите отрезок, на котором искать оптимум (В форме [a;b] или a;b): ");
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
                    case (int) OptKind.Maximum: kind = OptKind.Maximum;
                            break;
                    case (int)OptKind.Minimum: kind = OptKind.Minimum;
                        break;
                    default:
                        Console.WriteLine("Неверное значение");
                        break;
                }
            } while (!( ( choice == 1 ) || ( choice == 2 ) ));
            var vName = "x";

            var optimiser = new GoldenPropOptimisator();
            Console.Write("Введите функцию от x, которую будем оптимизировать: ");
            var func = Console.ReadLine();
            var t = new Task1D(func, kind, vName, inter);
            string s="";
            switch ( t.OptimumType )
            {
                case OptKind.Maximum:
                    s = "Максимум";
                    break;
                case OptKind.Minimum:
                    s = "Минимум";
                    break;
                case OptKind.NotSet:
                  
                    break;
                default:
                    break;
            }
            double? v = null;
            try
            {
                 v = optimiser.Optimise(t);
                
            }
            catch ( Exception e)
            {

                Console.WriteLine($"Что-то пошло не так, а именно: {e.Message}");
            }
            if ( v.HasValue )
                Console.WriteLine($"{s} в точке {v.Value}");
            else
                Console.WriteLine("Нет экстремума на промежутке");
            Console.ReadLine();
        }
        

    }
}
