using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using OptimisationTasks.DataStructures;

namespace OptimisationTasks.FileOperations
{
    /// <summary>
    /// Читает описание задачи из некоторого источника (сейчас - файла)
    /// </summary>
    public static class TaskReader
    {
        public static Task1D ReadTaskFromFile(string pathToDataFile)
        {
         XDocument doc = XDocument.Load(pathToDataFile);
           
        IEnumerable<string> targetFunc = from task in doc.Descendants()
                                             select (string)task.Element("TargetFunction");
        IEnumerable<string> dir = from task in doc.Descendants() select 
                                  (string)task.Element("Direction");
            IEnumerable<string> varName = from task in doc.Descendants()
                                          select (string)task.Element("Variable"); 
        var direct = dir.First();
            OptKind dr = OptKind.NotSet;
            if (direct == "Maximum") dr = OptKind.Maximum;
            if (direct == "Minimum") dr = OptKind.Minimum;
        var target = targetFunc.First();
            var variable = varName.First();
            IEnumerable<string> OptInt = from task in doc.Descendants()
                                         select (string)task.Element("OptimumInterval");
            
            Task1D retTask = new Task1D(target, dr, variable, new Interval(OptInt.First()));
            return retTask;
        }
    }
}
