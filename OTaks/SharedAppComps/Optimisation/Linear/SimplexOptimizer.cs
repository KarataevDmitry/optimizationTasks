using System;
using System.Collections.Generic;
using System.Text;
using OptimisationTasks.OptimisationMethods.Linear;

namespace OptimisationTasks.Optimisation.Linear
{
   public class SimplexOptimizer : ILinearOptimizer
    {
        private int varCount;
        private static Simplex simplexM;

        public double[] CalcSolution(double[,] table)
        {
            int varCount = table.GetLength(1) - 1;
            simplexM = new Simplex(table);
            double [ ] res = new double[varCount];
            double[,] restable;
            restable = simplexM.Calculate(res);
            return res;
        }
    }
  
}
