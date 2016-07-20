using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OptimisationTasks.DataStructures;
using Microsoft.VisualBasic;
using OptimisationTasks.FileOperations;
namespace OptimisationTasks.OptimisationMethods
{
    /// <summary>
    /// Отрезок
    /// </summary>
    
    /// <summary>
    /// Оптимизация улучшенным методом дихотомии (Метод золотого сечения)
    /// </summary>
    public class GoldenPropOptimisator : OptimizationMethod
    {
        /// <summary>
        /// Золотое сечение
        /// </summary>
        private double Phi = (1 + Math.Sqrt(5)) / 2;
        /// <see cref="OptimizationMethod.Optimise(Task1D, double)"/>
        public override double? Optimise(Task1D t, double eps=0.001)
        {
            Interval inter = t.OptimumInterval;
                double a = inter.Left;
                double b = inter.Right;
                double x1 = b - inter.Length / Phi;
                double x2 = a + inter.Length / Phi;
            double optval;
            switch (t.OptimumType)
            {
                case OptKind.Maximum:
                    {
                        do
                        {
                            double res1 = t.GetFuncResult(x1);
                            double res2 = t.GetFuncResult(x2);
                            if (res1 <= res2)
                            {
                                a = x1;
                                x1 = x2;
                                x2 = a + (b - a) / Phi;
                            }
                            else
                            {
                                b = x2;
                                x2 = x1;
                                x1 = b - (b - a) / Phi;
                            }
                        } while (Math.Abs(b - a) >= eps);
                        optval = (a + b) / 2;
                        if (IsOptimum(optval, OptKind.Maximum, t)) return optval;
                        else return null; 
                    }
            
                        
                
                    case OptKind.Minimum: 
                            do
                            {
                                double res1 = t.GetFuncResult(x1);
                                double res2 = t.GetFuncResult(x2);
                                if (res1 >= res2)
                                {
                                    a = x1;
                                    x1 = x2;
                                    x2 = a + (b - a) / Phi;
                                }
                                else
                                {
                                    b = x2;
                                    x2 = x1;
                                    x1 = b - (b - a) / Phi;
                                }
                            } while (Math.Abs(b - a) >= eps);
                    optval = (a + b) / 2;
                    if (IsOptimum(optval, OptKind.Minimum, t))  return optval;
                    else return null;
            }
           
            return null;
        }
        private bool IsOptimum(double val, OptKind optKind, Task1D t)
        {
            bool isOpt = false;
            if (optKind == OptKind.Maximum)
            {
                if (t.GetFuncResult(val) > t.GetFuncResult(val - 0.001) &&
                   t.GetFuncResult(val) > t.GetFuncResult(val + 0.001)) isOpt=true;
            }
            if (optKind==OptKind.Minimum)
            {
                if (t.GetFuncResult(val) < t.GetFuncResult(val - 0.001) &&
                       t.GetFuncResult(val) < t.GetFuncResult(val + 0.001)) isOpt=true;
            }
            return isOpt;
        }

       
                                
        private Interval[] SeparateRoots(Interval interval, Task1D t)
        {
            List<Interval> listInt = new List<Interval>();
            double step = (interval.Right - interval.Left)/1e+02;
            double x = interval.Left;
            double y_start = t.GetFuncResult(x);
            double y = 0.0;
            while (true)
            {
                if (x > interval.Right) break;
                x += step;
                y = t.GetFuncResult(x);
                if (y*y_start<=0)
                {
                    y_start = y;
                    listInt.Add(new Interval(x - step, x));
                    
                }
              
            }
            return listInt.ToArray(); 
        }
    }
}