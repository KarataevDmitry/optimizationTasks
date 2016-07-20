using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELW.Library.Math;
using ELW.Library.Math.Tools;
using ELW.Library.Math.Expressions;
using OptimisationTasks.Utilites;
using System.Windows;
namespace OptimisationTasks.DataStructures
{
    
    /// <summary>
    /// Одномерная оптимизационная задача 
    /// </summary>
    sealed public class Task1D
    {
        /// <summary>
        /// Целевая функция
        /// </summary>
        public string TargetFunction { get; }
        /// <summary>
        /// Вид оптимума
        /// </summary>
        public OptKind OptimumType { get; }
        /// <summary>
        /// Переменная задачи
        /// </summary>
        public string VariableName { get; }
        /// <summary>
        /// Промежуток, на котором ищется оптимум
        /// </summary>
        public Interval OptimumInterval { get; }
        /// <summary>
        /// Вычисляет значение <code>TargetFunction</code>
        /// </summary>
        /// <param name="varValue">Точка, в которой вычисляется значение</param>
        /// <returns>Значение целевой функции</returns>
        public double GetFuncResult(double varValue)    
        {
            PreparedExpression prepared;
            CompiledExpression comp;
             prepared= ToolsHelper.Parser.Parse(TargetFunction);
            comp = ToolsHelper.Compiler.Compile(prepared);
                List < VariableValue > vars = new List<VariableValue>();
                vars.Add(new VariableValue(varValue, VariableName));
                return ToolsHelper.Calculator.Calculate(comp, vars);
        }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="func">Целевая функция</param>
    /// <param name="dir">Вид оптимума</param>
    /// <param name="varName">Имя переменной</param>
    /// <param name="interv">Отрезок поиска</param>
    public Task1D(string func, OptKind dir, string varName, Interval interv = new Interval())
        {
            TargetFunction = func.Replace(',','.');
            OptimumType = dir;
            VariableName = varName;
            OptimumInterval = interv;
        }
    }
}

