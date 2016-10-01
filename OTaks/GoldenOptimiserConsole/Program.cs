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
            Console.Write("Ваш выбор");
            var choice = int.Parse(Console.ReadLine());
            if ( choice == 1 ) kind = OptKind.Maximum;
            if ( choice == 2 ) kind = OptKind.Minimum;
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
