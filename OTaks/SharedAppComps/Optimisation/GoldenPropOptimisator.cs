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
        private double GoldenProportion = (1 + Math.Sqrt(5)) / 2;
        /// <see cref="OptimizationMethod.Optimise(Task1D, double)"/>
        public override double? Optimise(Task1D t, double eps=0.001)
        {
                Interval inter = t.OptimumInterval;
                double LeftEnd = inter.Left;
                double RightEnd = inter.Right;
                double firstPoint = RightEnd - inter.Length / GoldenProportion;
                double secondPoint = LeftEnd + inter.Length / GoldenProportion;
            double optval;
            switch (t.OptimumType)
            {
                case OptKind.Maximum:
                    {
                        do
                        {
                            double res1 = t.GetFuncResult(firstPoint);
                            double res2 = t.GetFuncResult(secondPoint);
                            if (res1 <= res2)
                            {
                                LeftEnd = firstPoint;
                                firstPoint = secondPoint;
                                secondPoint = LeftEnd + (RightEnd - LeftEnd) / GoldenProportion;
                            }
                            else
                            {
                                RightEnd = secondPoint;
                                secondPoint = firstPoint;
                                firstPoint = RightEnd - (RightEnd - LeftEnd) / GoldenProportion;
                            }
                        } while (Math.Abs(RightEnd - LeftEnd) >= eps);
                        optval = (LeftEnd + RightEnd) / 2;
                        if (IsOptimum(optval, OptKind.Maximum, t)) return optval;
                        else return null; 
                    }
            
                        
                
                    case OptKind.Minimum: 
                            do
                            {
                                double res1 = t.GetFuncResult(firstPoint);
                                double res2 = t.GetFuncResult(secondPoint);
                                if (res1 >= res2)
                                {
                                    LeftEnd = firstPoint;
                                    firstPoint = secondPoint;
                                    secondPoint = LeftEnd + (RightEnd - LeftEnd) / GoldenProportion;
                                }
                                else
                                {
                                    RightEnd = secondPoint;
                                    secondPoint = firstPoint;
                                    firstPoint = RightEnd - (RightEnd - LeftEnd) / GoldenProportion;
                                }
                            } while (Math.Abs(RightEnd - LeftEnd) >= eps);
                    optval = (LeftEnd + RightEnd) / 2;
                    if (IsOptimum(optval, OptKind.Minimum, t))  return optval;
                    else return null;
            }
           
            return null;
        }
        private bool IsOptimum(double val, OptKind optKind, Task1D t)
        {
            bool isOpt = false;
            switch ( optKind )
            {
                case OptKind.Maximum:
                    if ( t.GetFuncResult(val) > t.GetFuncResult(val - 0.001) &&
                    t.GetFuncResult(val) > t.GetFuncResult(val + 0.001) )
                    isOpt = true;
                    break;
                case OptKind.Minimum:
                    if ( t.GetFuncResult(val) < t.GetFuncResult(val - 0.001) &&
                      t.GetFuncResult(val) < t.GetFuncResult(val + 0.001) )
                        isOpt = true;
                    break;
                default:
                    break;
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