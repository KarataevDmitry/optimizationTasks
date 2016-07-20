using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using OptimisationTasksEditor;

namespace OptimisationTasksEditor.UICommands
{
    public class UICommands
    {
        public static RoutedUICommand SolveCommand { get; set; }

        static UICommands()
        {
         //   SolveCommand = new RoutedUICommand("Решить задачу оптимизации", "SolveCommand", typeof(OptimisationTasksEditor.OneDimesionalTaskDefinition));
        }
    }
}
