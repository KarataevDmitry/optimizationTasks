using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using OptimisationTasks.DataStructures;
#if GUIApp
using Microsoft.Win32;
#endif

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
                #if GUIApp
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "XML Documents |*.xml";
               
                if (sd.ShowDialog() == true) writeTo = sd.FileName;
                #endif

                #if ConsoleApp
                Console.WriteLine("Введите имя файла для сохранения:")
                writeto = Console.ReadLine();
               #endif

            }
            doc.Save(writeTo);
        }
        
    }
}
