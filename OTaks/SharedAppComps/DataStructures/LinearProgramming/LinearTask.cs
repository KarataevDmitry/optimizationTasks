using System;
using System.Collections.Generic;
using System.Text;
using OptimisationTasks.DataStructures.LinearProgramming;
using OptimisationTasks.OptimisationMethods.Linear;

namespace OptimisationTasks.DataStructures.LinearProgramming
{
    public class LinearTask
    {
       private Matrix taskMatrix;
        public double [ ] Optimize ( ILinearOptimizer method ) => method.CalcSolution(taskMatrix.ToArray());
        public LinearTask (double[,] taskdata )
        {
            taskMatrix = new Matrix(taskdata);
        }
        public LinearTask (Matrix m )
        {
            taskMatrix = new Matrix(m.ToArray());        
        }
    }
}
