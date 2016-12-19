using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using OptimisationTasks.DataStructures;
using Microsoft.Win32;

namespace OptimisationTasks.FileOperations
{  
    public static class TaskWriter
    {
        public static void WriteTaskToFile(Task1D t, string writeTo = "")
        {
            OptKind dir = t.OptimumType;
            XDocument doc = new XDocument(new XElement("Task",
                                                 new XElement("TargetFunction", t.TargetFunction),
                                                 new XElement("Direction", dir),
                                                 new XElement("Variable", t.VariableName),
                                                 new XElement("OptimumInterval", t.OptimumInterval.ToString())
                                                          )
                                              );
            if (writeTo == "")
            {   
                
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "XML Documents |*.xml";
               
                if (sd.ShowDialog() == true) writeTo = sd.FileName;



                Console.WriteLine("Введите имя файла для сохранения:");
                var writeto = Console.ReadLine();
               

            }
            doc.Save(writeTo);
        }
        
    }
}
