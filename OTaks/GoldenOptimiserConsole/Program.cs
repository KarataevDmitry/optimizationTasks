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
            var inter = new Interval(Console.ReadLine());

            Console.Write("Выберите вид оптимума " + "(+ - максимум(по умолчанию), - - минимум): ");
            char c = (char) Console.Read();
            OptKind kind = OptKind.NotSet;
            if ( c == '+' )
                kind = OptKind.Maximum;
            else
                kind = OptKind.Minimum;
            string vName = "";
            Console.Write("Введите имя переменной: ");
            vName = Console.ReadLine();

            var optimiser = new GoldenPropOptimisator();
            Console.Write("Введите функцию, которую будем оптимизировать: ");
            var func = Console.ReadLine();
            var t = new Task1D(func, kind, vName, inter);
            Console.WriteLine(optimiser.Optimise(t));
        }
        

    }
}
