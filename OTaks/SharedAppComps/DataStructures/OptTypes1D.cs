using System;
using System.Collections.Generic;
using System.Text;

namespace OptimisationTasks.DataStructures
{
    /// <summary>
    /// Отрезок, на котором ищется решение
    /// </summary>
    public struct Interval
    {
        /// <summary>
        /// Начало отрезка
        /// </summary>
        public double Left;
        /// <summary>
        /// Конец отрезка
        /// </summary>
        public double Right;
        /// <summary>
        /// Длина отрезка
        /// </summary>
        public double Length => Math.Abs(Right - Left);
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="left"><see cref="Left"/></param>
        /// <param name="right"><see cref="Right"/></param>
        public Interval(double left, double right)
        {
            Left = left;
            Right = right;
        }
        /// <summary>
        /// Возвращает строку, представляющую отрезок
        /// </summary>
        /// <returns>Строковое представление</returns>
        public override string ToString() => $"[{Left};{Right}]";
        /// <summary>
        /// Конвертер из строки
        /// </summary>
        /// <param name="interv">Отрезок заданный в виде строки. Формат может быть 
        /// как "13.5;15.5", так и [13.5;15.5] а также 13,5;15,5</param>
        public Interval(string interv)
        {
            string tr_int = interv.Trim(new char[] { '[', ']' });
            tr_int = tr_int.Replace('.', ',');
            Left = double.Parse(tr_int.Split(';')[0]);
            Right = double.Parse(tr_int.Split(';')[1]);
        }
    }

    /// <summary>
    /// Вид оптимума
    /// </summary>
    public enum OptKind
    {
        Maximum = 1,
        Minimum = 2,
        NotSet = -1
    };
}
